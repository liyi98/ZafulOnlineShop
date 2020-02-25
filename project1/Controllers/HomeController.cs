using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Owin.Security.OAuth;
using project1.Data;
using project1.Models;

namespace project1.Controllers
{
    public class HomeController : Controller
    {
        private readonly FashionShopDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public static OAuthBearerAuthenticationOptions OAuthBearerOptions { get; private set; }
        public HomeController(FashionShopDbContext context, IHttpContextAccessor httpContextAccessor) {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }
        public int GetCookie(string variable) {
            return int.Parse(Request.Cookies[variable]);
        }
        public IActionResult Index()
        {
            string cookieValueFromContext = _httpContextAccessor.HttpContext.Request.Cookies["UserId"];
            //read cookie from Request object  
            
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            List<User> users = _context.User.ToList();
            int num = users.Count();
            return View(users);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
         public IActionResult Login()
        {

            return View("Login");
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            string a = user.Email;
            string b = user.Password;
     
            try {
                var user_info = _context.User.Where(u => u.Email == user.Email).Where(u=>u.role == 0).FirstOrDefault();
                string pass = user_info.Password;
                if (Crypto.VerifyHashedPassword(user_info.Password, user.Password) == true)
                {
                    TempData["Message"] = "Login Sucess";
                    Set("UserId", user_info.UserId.ToString(), 12345678);
                    Set("Email", user_info.Email, 12345678);
                    return RedirectToAction("Index", "Home");
                }
            } catch (Exception e) {

                return RedirectToAction("Login", "Home"); ;
            }

            return RedirectToAction("Index", "Home");

        }

        public void Set(string key, string value, int? expireTime)
        {
            CookieOptions option = new CookieOptions();

            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
            else
                option.Expires = DateTime.Now.AddMilliseconds(10);

            Response.Cookies.Append(key, value, option);
        }
        [HttpGet]
        public IActionResult SignUp()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(Register register)
        {
        

            User user = new User();
            user.Email = register.Email;
            user.Password = Crypto.HashPassword(register.Password);
            user.CreationDate = DateTime.UtcNow;
            user.role = 0;
            _context.User.Add(user);
            int success = _context.SaveChanges();

            if (success == 0)
            {
                ViewBag.Message = "Failed to Register";
            }
            else
            {
                ViewBag.Message = "Register Sucessful!";
            }
            return View();
        }
     
        public IActionResult Product(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            var products = _context.Product.ToList(); 
            if (!String.IsNullOrEmpty(searchString))
            {
                products = _context.Product.Where(s => s.ProductName.Contains(searchString)).ToList();
            }
            else {
            }
      
            ViewData["Products"] = products;
            return View();

        }
        [HttpGet]
        [Route("/Product/{id}")]
        public IActionResult ProductDetails([FromRoute]int id)
        {
  
            if (id != 0)
            {
                Product product = _context.Product.Where(m => m.ProductId == id).FirstOrDefault();
                ViewData["Product"] = product;
                ViewData["Id"] = id;
            }
            return View();
        }
        [HttpPost]
        public IActionResult AddCart(CartProduct cartproduct)
        {
            try {
                cartproduct.UserId = GetCookie("UserId");
                CartProduct product = _context.CartProduct.Where(c => c.ProductId == cartproduct.ProductId).FirstOrDefault();
                if (product != null)
                {
                    product.Quantity += cartproduct.Quantity;
                    _context.CartProduct.Update(product);
                }
                else {
                    _context.CartProduct.Add(cartproduct);
                }
             
                int success = _context.SaveChanges();
                if (success == 0)
                {
                    ViewBag.Message = "Failed to Add Cart";
                }else{
                    ViewBag.Message = "Add to Cart";
                }

            }catch (Exception e) {
                ViewBag.Message = "Login To Add Item";
                return RedirectToAction("Login", "Home");
            }
            return RedirectToAction("ProductDetails", "Home", new { id = cartproduct.ProductId });
        }

      
        public IActionResult Cart()
        {
            try { 
                int id = GetCookie("UserId");
                List<CartProduct> cartProducts = _context.CartProduct.Where(c => c.UserId == id).ToList();
                    foreach (var item in cartProducts){
                    Product product = _context.Product.Where(m => m.ProductId == item.ProductId).FirstOrDefault();
                    item.Product = product;
                    }ViewData["CartProducts"] = cartProducts;

            } catch (Exception e) {

            }
       
            return View();

        }

        [HttpPost]
        public IActionResult DeleteCart(int CartProductId)
        {
            _context.CartProduct.Remove(_context.CartProduct.Find(CartProductId));
            _context.SaveChanges();
            return RedirectToAction("Cart","Home");
        }
        public IActionResult Logout()
        {
            Response.Cookies.Delete("UserId");
            Response.Cookies.Delete("Email");
            return RedirectToAction("Index", "Home");
        }


    }
}

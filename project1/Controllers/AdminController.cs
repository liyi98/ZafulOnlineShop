using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.File;
using project1.Data;
using project1.Models;

namespace project1.Controllers
{
    public class AdminController : Controller
    {
        private readonly FashionShopDbContext _context;

        public AdminController(FashionShopDbContext context)
        {
            _context = context;
        }

        public IActionResult EmptySpace() {
            return View();
        }
        public IActionResult Index()
        {
    
            return View();
        }

        public string GetCookie(string variable)
        {
            return Request.Cookies[variable];
        }

        [HttpPost]
        public IActionResult Index(User user)
        {

            try
            {
                var user_info = _context.User.Where(u => u.Email == user.Email).Where(u => u.role == 1).FirstOrDefault();
                string pass = user_info.Password;
                if (Crypto.VerifyHashedPassword(user_info.Password, user.Password) == true)
                {
                    Set("Admin", user_info.Email, 12345678);
                    return RedirectToAction("Dashboard");
                }
            }
            catch (Exception e)
            {
                return View();
            }

            return View();

        }
        public IActionResult Dashboard()
        {
            try
            {
                GetCookie("Admin");
                List<User> users = _context.User.ToList();
                ViewData["Users"] = users;
            }
            catch(Exception e) {
                return View("EmptySpace");
            }
            return View();

        }
        [HttpPost]
        public IActionResult DeleteUser(int UserId)
        {
            _context.User.Remove(_context.User.Find(UserId));
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        public IActionResult ManageCategory()
        {
            try {
                GetCookie("Admin");
                List<Category> categories = _context.Category.ToList();
                ViewData["Categories"] = categories;
            }
            catch (Exception e)
            {
                return View("EmptySpace");
            }

            return View();
        }
        [HttpPost]
        public IActionResult ManageCategory(Category _category)
        {
         
            Category category = new Category();
            category.CategoryName = _category.CategoryName;
            _context.Category.Add(category);
            int success = _context.SaveChanges();

            if (success == 0)
            {
                ViewBag.Message = "Failed to Add New Category";
            }
            else {
                ViewBag.Message = "Add Category Sucessful!";
            }

            List<Category> categories = _context.Category.ToList();
            ViewData["Categories"] = categories;
            return View();
        }
    
        [HttpPost]
        public IActionResult DeleteCategory(int CategoryId)
        {
            _context.Category.Remove(_context.Category.Find(CategoryId));
            _context.SaveChanges();
            return RedirectToAction("ManageCategory");
        }
 
        public IActionResult ManageProduct([FromRoute]int id)
        {
            try
            {
                GetCookie("Admin");
                List<Product> products = _context.Product.ToList();
                ViewData["Products"] = products;
                List<Category> categories = _context.Category.ToList();
                ViewData["Categories"] = categories;
                if (id != 0)
                {
                    Product product = _context.Product.Where(m => m.ProductId == id).FirstOrDefault();
                    ViewData["Product"] = product;
                    ViewData["Id"] = id;
                }

            } catch (Exception e)
            {
                return View("EmptySpace");
            }

            return View();
        }
       
        public IActionResult EditProduct(Product _product)
        {
            int success = 0;
            //string filetype = _product.Image.ContentType;

            //if (filetype == "image/jpeg")
            //{
            //    _context.Product.Update(_product);
            //    _product.ImagePath = _product.category.CategoryName + "-" + _product.ProductId + ".jpg";
            //    success = _context.SaveChanges();
            //    using (var stream = _product.Image.OpenReadStream())
            //    {
            //        var uploadSuccess = UploadBlob(_product.ImagePath, stream);
            //    }
            //}
            try
            {
                string filetype = _product.Image.ContentType;

                if (filetype == "image/jpeg")
                {
                    _context.Product.Update(_product);
                    var category = _context.Category.Where(m => m.CategoryId == _product.CategoryId).FirstOrDefault();
                    _product.ImagePath = category.CategoryName + "-" + _product.ProductId + ".jpg";
                    success = _context.SaveChanges();
                    using (var stream = _product.Image.OpenReadStream())
                    {
                        var uploadSuccess = UploadBlob(_product.ImagePath, stream);
                    }
                }
                else if (filetype == "image/png")
                {
                    _context.Product.Update(_product);
                    var category = _context.Category.Where(m => m.CategoryId == _product.CategoryId).FirstOrDefault();
                    _product.ImagePath = category.CategoryName + "-" + _product.ProductId + ".jpg";
                    success = _context.SaveChanges();
                    using (var stream = _product.Image.OpenReadStream())
                    {
                        var uploadSuccess = UploadBlob(_product.ImagePath, stream);
                    }
                }
                else
                {
                    TempData["message"] = "Only JPG OR PNG";
                    return RedirectToAction("ManageProduct");
                }
            }catch (Exception e) {
                _context.Product.Update(_product);
                success = _context.SaveChanges();
            }
     
            if (success == 0){
                  TempData["message"] = "Fail to  Modify";
            }else {
                TempData["message"] = "Success";
            }
          
            return RedirectToAction("ManageProduct");
        }
        [HttpPost]
        public IActionResult ManageProduct(Product _product)
        {

            string filetype = _product.Image.ContentType;
            int success = 0;
            if (filetype == "image/jpeg") {
                _product.CreationDate = DateTime.UtcNow;
                var category = _context.Category.Where(m => m.CategoryId == _product.CategoryId).FirstOrDefault();
                var last_item = _context.Product.OrderByDescending(c => c.ProductId).FirstOrDefault();
                int id = 1;
                if (last_item != null)
                {
                    id = last_item.ProductId + 1;
                }
                var info = _context.Product.Add(_product);
                _product.ImagePath = category.CategoryName + "-"+ id  + ".jpg";
                success = _context.SaveChanges();
                using (var stream = _product.Image.OpenReadStream())
                {
                    var uploadSuccess = UploadBlob(_product.ImagePath, stream);
                }
            } else if (filetype == "image/png")
            {
                _product.CreationDate = DateTime.UtcNow;
                var category = _context.Category.Where(m => m.CategoryId == _product.CategoryId).FirstOrDefault();
                var info = _context.Product.Add(_product);
                _product.ImagePath = category.CategoryName + info.Entity.ProductId + ".png";
                success = _context.SaveChanges();
                using (var stream = _product.Image.OpenReadStream())
                {
                    var uploadSuccess = UploadBlob(_product.ImagePath , stream);
                }
            }
            else {
                ViewBag.Message = "Picture JPG or PNG Only!";
                return RedirectToAction("ManageProduct");
            }
            if (success == 0)
            {
                ViewBag.Message = "Failed to Add New Product";
            }
            else
            {
                ViewBag.Message = "Add Product Sucessful!";
            }

            List<Product> products = _context.Product.ToList();
            ViewData["Products"] = products;
            List<Category> categories = _context.Category.ToList();
            ViewData["Categories"] = categories;
            return View();
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
            user.role = 1;
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
        [HttpPost]
        public IActionResult DeleteProduct(int ProductId)
        {
            _context.Product.Remove(_context.Product.Find(ProductId));
            _context.SaveChanges();
            return RedirectToAction("ManageProduct");
        }

        public IActionResult ViewOrder()
        {
            List<Order> orders = _context.Order.ToList();
            ViewData["Orders"] = orders;
            return View();
        }

     
        
        //BlobStorage
        private CloudBlobContainer GetCloudBlobContainer()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            IConfiguration Configuration = builder.Build();
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Configuration["ConnectionStrings:Zafulappstorage"]);
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudFileClient blob = storageAccount.CreateCloudFileClient();
            CloudBlobContainer container = blobClient.GetContainerReference("zaful-pictures");
            return container;

        }
        public Boolean CreateBlobContainer()
        {
            CloudBlobContainer container = GetCloudBlobContainer();
            Boolean result= container.CreateIfNotExistsAsync().Result;
            return result;

        }

        public Boolean UploadBlob(string filename, Stream filestream)
        {
            var blobcreate = CreateBlobContainer();
            CloudBlobContainer container = GetCloudBlobContainer();
            CloudBlockBlob blob = container.GetBlockBlobReference(filename);
       
            if (filestream != null){
                 blob.UploadFromStreamAsync(filestream).Wait(); ;
            } else{
            return false;
            }
            return true;
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
        public IActionResult Logout()
        {
            Response.Cookies.Delete("Admin");
            return RedirectToAction("Index", "Admin");
        }
    }
}
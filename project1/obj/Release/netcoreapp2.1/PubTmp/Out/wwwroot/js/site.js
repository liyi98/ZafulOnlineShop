//$(document).ready(function () {
//    const userid = getCookie("UserId");
//    if (userid != '' || userid != '0') {
//        $('#username').html(getCookie("UserId"));
//        $('#login-validator').html('<li class="nav-item active"><a class="nav-link" href="#" id="username"></a></li><li class="nav-item active"><a onclick="logout">Logout</a></li>');
//    } else {
//        $('#login-validator').html('<li class="nav-item active"><a href="/Home/Login">Login</a></li>');
//    }
//    $('#login-validator').html($('#login-validator').html() + '<li class="nav-item active"><a asp-area="" href="/Home/Cart"> <i class="fa fa-shopping-basket" aria-hidden="true"></i></a></li >');

//});


function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#blah')
                .attr('src', e.target.result)
                .css('width', '200px')
                .css('object-fit','cover')
                .height(250);
        };

        reader.readAsDataURL(input.files[0]);
    }
}
function readURL1(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#blah1')
                .attr('src', e.target.result)
                .css('width', '200px')
                .css('object-fit', 'cover')
                .height(250);
        };

        reader.readAsDataURL(input.files[0]);
    }

}
function getCookie(cname) {
    var name = cname + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}

function setCookie(cname, cvalue, exdays) {
    var d = new Date();
    d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000));
    var expires = "expires=" + d.toUTCString();
    document.cookie = cname + "=" + cvalue + ";" + expires + ";path=/";
}

function logout() {
    document.cookie = '';
}
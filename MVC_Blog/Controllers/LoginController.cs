using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_Blog.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        [HttpGet]
        public ActionResult AuthorLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AuthorLogin(Author p)
        {
            var authorInfo = c.Authors.FirstOrDefault(x => x.Mail == p.Mail && x.Password == p.Password);
            if(authorInfo != null)
            {
                FormsAuthentication.SetAuthCookie(authorInfo.Mail, false);
                Session["Mail"] = authorInfo.Mail.ToString();
                return RedirectToAction("AuthorBlogList", "AuthorPanel");
            }
            else
            {
                return RedirectToAction("AuthorLogin", "Login");
            }
        }
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(Admin p)
        {
            var adminInfo = c.Admins.FirstOrDefault(x => x.Username == p.Username && x.Password == p.Password);
            if (adminInfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminInfo.Username, false);
                Session["Username"] = adminInfo.Username.ToString();
                return RedirectToAction("BlogListAdmin", "Blog");
            }
            else
            {
                return RedirectToAction("AdminLogin", "Login");
            }
        }
    }
}
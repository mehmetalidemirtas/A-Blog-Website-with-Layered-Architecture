using BusinessLogicLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Blog.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager cm = new ContactManager();
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Index(Contact p)
        {
            cm.BLLContactAdd(p);
            return View();
        }
        public ActionResult Inbox()
        {
            var MessageList = cm.ContactByStatusTrue();
            return View(MessageList);
        }
        public ActionResult MessageDetails(int id)
        {
            Contact contact = cm.GetContactDetails(id);
            return View(contact);
        }
        public ActionResult StatusChangeToFalse(int id)
        {
            cm.StatusChangeToFalseBLL(id);
            return RedirectToAction("Inbox");
        }
        public ActionResult Trash()
        {
            var commentList = cm.ContactByStatusFalse();
            return View(commentList);
        }
        public ActionResult DeleteMessage(int id)
        {
            cm.DeleteMessageBLL(id);
            return RedirectToAction("Trash");
        }
        [AllowAnonymous]
        public PartialViewResult Address()
        {
            var recentPost = cm.GetAddress();
            return PartialView(recentPost);
        }
    }
}
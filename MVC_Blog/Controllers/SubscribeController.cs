using BusinessLogicLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Blog.Controllers
{
    [AllowAnonymous]
    public class SubscribeController : Controller
    {
        // GET: Subscribe
        SubscribeManager sm = new SubscribeManager();
        [HttpGet]
        public PartialViewResult AddMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult AddMail(SubscribeMail p)
        {
            sm.BLAdd(p);
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult AddMailAbout()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult AddMailAbout(SubscribeMail p)
        {
            sm.BLAdd(p);
            return PartialView();
        }
        public ActionResult SubscribeList()
        {
            var subscribeLists = sm.GetAll();
            return View(subscribeLists);
        }
        public ActionResult DeleteSubscriber(int id)
        {
            sm.DeleteSubscriberBLL(id);
            return RedirectToAction("SubscribeList");
        }
    }
}
using Entities;
using Interfaces;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WepApp.Models;

namespace WepApp.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository _userRepository = new UserRepository();
        // GET: User
        public ActionResult Index() 
        {
            List<ApplicationUser> users = _userRepository.GetAll();

            return View(users);
        }

        public ActionResult Create()
        {
            return View(new RegisterViewModel());
        }

        //[HttpPost]
        //public ActionResult Create(ApplicationUser user)
        //{
        //    if(_userRepository.Create(user))
        //        return RedirectToAction("Index");
        //    else
        //        return View(user);

        //}
        public ActionResult Edit(string id)
        {
            ApplicationUser user = _userRepository.GetByID(id);

           return View(user);
        }

        [HttpPost]
        public ActionResult Edit(ApplicationUser user)
        {
             //return _userRepository.Edit(user) ? RedirectToAction("Index") : View(user);
            if(_userRepository.Edit(user))
                return RedirectToAction("Index");
            else
                return View(user);
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            if(_userRepository.Delete(id))
                return RedirectToAction("Index");
            else
                return HttpNotFound();
        }
    }
}
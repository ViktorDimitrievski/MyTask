using Entities;
using Interfaces;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WepApp.Controllers
{
    public class ProjectController : Controller
    {
        private IProjectRepository _projectRepository = new ProjectRepository();
        private ICustomerRepository _custoemrRepository = new CustomerRepository();

        public ActionResult Index()
        {
            List<Project> projects = _projectRepository.GetAll();
            return View(projects);
        }


        public ActionResult Create()
        {
            ViewBag.Customers = new SelectList(_custoemrRepository.GetAll().ToList() , "ID" , "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Project project)
        {
            _projectRepository.Create(project);
            return RedirectToAction("Index");
        }


        public ActionResult Edit(int id)
        {
            var project = _projectRepository.GetByID(id);
            ViewBag.Customers = new SelectList(_custoemrRepository.GetAll().ToList() , "ID" , "Name");
            return View(project);
        }
        [HttpPost]
        public ActionResult Edit(Project project)
        {
            _projectRepository.Edit(project);
            return RedirectToAction("Index");
        }


        public ActionResult Details(int id)
        {
            var project = _projectRepository.GetByID(id);
            return View(project);
        }

       

        //[HttpPost]
        //public ActionResult Delete(int id)
        //{
        //    var project = _projectRepository.GetByID(id);
        //    return View(project);
        //}
    }
}
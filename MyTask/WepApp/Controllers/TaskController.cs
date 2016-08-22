using Entities;
using Interfaces;
using Repositories;
using System.Web.Mvc;

namespace WepApp.Controllers
{
    public class TaskController : Controller
    {
        private ITaskRepository _taskRepository = new TaskRepository();
        private IProjectRepository _projectRepository = new ProjectRepository();
        // GET: Task
        public ActionResult Index(int id)
        {
            return View(_taskRepository.GetAllByProject(id));
        }

        // GET: Task/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Task/Create
        public ActionResult Create()
        {
            ViewBag.Project = new SelectList(_projectRepository.GetAll() , "ID" , "Name");
            return View();
        }

        // POST: Task/Create
        [HttpPost]
        public ActionResult Create(Task task)
        {
            _taskRepository.Create(task);
            return RedirectToAction("Index/" + task.ProjectID);
        }

        // GET: Task/Edit/5
        public ActionResult Edit(int id)
        {
            var task = _taskRepository.GetByID(id);
            return View(task);
        }

        // POST: Task/Edit/5
        [HttpPost]
        public ActionResult Edit(Task task)
        {
            _taskRepository.Edit(task);
            return RedirectToAction("Index");
        }

        // GET: Task/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Task/Delete/5
        [HttpPost]
        public ActionResult Delete(int id , FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

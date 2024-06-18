using CRUD_application_2.Models;
using System.Linq;
using System.Web.Mvc;

// ou will be creating an application named Contact Database Application, a C# application, with the help of Github Copilot, which will let the users save the contact details of people as per requirements and also carry out the basic functions like editing their details, deleting their profiles, and so on. You will be provided with the skeleton of the application already, but you will need to build the functionalities inside the UserController.cs file by yourself. Your task is to complete these methods by utilizing GitHub Copilot to generate the necessary code, guided by the comments provided in the file.

namespace CRUD_application_2.Controllers
{
    public class UserController : Controller
    {
        public static System.Collections.Generic.List<User> userlist = new System.Collections.Generic.List<User>();
        // GET: User
        public ActionResult Index()
        {
            return View(userlist);
        }
 
        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            var user = userlist.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }
 
        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }
 
        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            userlist.Add(user);
            return RedirectToAction("Index");
        }
 
        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            var user = userlist.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }
 
        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User user)
        {
            var existingUser = userlist.FirstOrDefault(u => u.Id == id);
            if (existingUser == null)
            {
                return HttpNotFound();
            }
            // Update properties here
            existingUser.Name = user.Name;
            existingUser.Email = user.Email;
            // Add other properties as needed
            return RedirectToAction("Index");
        }
 
        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            var user = userlist.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }
 
        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var user = userlist.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                userlist.Remove(user);
            }
            return RedirectToAction("Index");
        }
    }
}

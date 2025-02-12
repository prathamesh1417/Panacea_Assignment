using Panacea_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Panacea_Assignment.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public UserDBContext ub = new UserDBContext();

        public ActionResult Index()
        {
            return View();
        }

  
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            var p = ub.Users.Where(h => h.Username.Equals(model.Username) && h.Password.Equals(model.Password));
            var user = ub.Users.FirstOrDefault(u => u.Username == model.Username);
   
                
                if (user != null)
                {
                    
                    Session["Username"] = user.Username;
                    FormsAuthentication.SetAuthCookie(user.Username, true);
                    return RedirectToAction("Dashboard");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login credentials");
                }
            
            return View();
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
        [Authorize]
        public ActionResult Dashboard()
        {
            if (Session["Username"] == null)
            {
                return RedirectToAction("login");
            }

            var total = ub.Users.Count();
            ViewBag.total = total;

            var active = ub.Users.Count(x => x.Status == "Active");
            ViewBag.active = active;

            var Inactive = ub.Users.Count(x => x.Status == "Inactive");
            ViewBag.Inactive = Inactive;
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User_List user)
        {
            if (ModelState.IsValid)
            {
                ub.Users.Add(user);
                ub.SaveChanges();

                return RedirectToAction("Login");
            }
            return View();
        }
        [Authorize]

        public ActionResult Display_User()
        {
            var users = ub.Users.ToList();
            return View(users);
        }
        [HttpPost]
        public ActionResult Display_User(String searchQuery)
        {
            List<User_List> users;
            if (searchQuery.Equals(""))
            {
                users = ub.Users.ToList();
            }
            else
            {
                users = ub.Users.Where(u => u.Username.Contains(searchQuery) || u.Email.Contains(searchQuery) || u.PhoneNumber.Contains(searchQuery) || u.FirstName.Contains(searchQuery) || u.Email.Contains(searchQuery) || u.MiddleName.Contains(searchQuery) || u.LastName.Contains(searchQuery) || u.City.Contains(searchQuery) || u.State.Contains(searchQuery) || u.PinCode.Contains(searchQuery)).ToList();
            }
            return View(users);

        }
        [Authorize]
        public ActionResult Edit(int id)
        {
            var user = ub.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

   
        [HttpPost]
        
        public ActionResult Edit(User_List user)
        {
            if (ModelState.IsValid)
            {
                ub.Entry(user).State = EntityState.Modified;
                ub.SaveChanges();
                return RedirectToAction("Display_User");
            }
            return View(user);
        }
        [Authorize]
        public ActionResult Details(int id)
        {
            var user = ub.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }
        [Authorize]
        public ActionResult Delete(int id)
        {
            var user = ub.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

       
        [HttpPost, ActionName("Delete")]
     
        public ActionResult DeleteConfirmed(int id)
        {
            var user = ub.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            ub.Users.Remove(user);
            ub.SaveChanges();
            return RedirectToAction("Display_User");
        }



    }
}
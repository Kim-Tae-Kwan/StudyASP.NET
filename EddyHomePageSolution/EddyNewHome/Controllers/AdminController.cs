using EddyNewHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EddyNewHome.Controllers
{
    public class AdminController : Controller
    {
        EddyNewHomeEntities db = new EddyNewHomeEntities();
        // GET: Admin
        public ActionResult Index()
        {
            if (Session["user_id"] != null && Session["user_id"].ToString() == "Admin" && 
                Session["levels"] != null && Session["levels"].ToString() == "1")
                return View("Index","_AdminLayout");
            else
                return RedirectToAction("../Home/Index");
        }

        [HttpGet]
        public ActionResult Members()
        {
            IEnumerable<Members> list = db.Members.ToList();
            return View("Members","_AdminLayout",list);
        }

        [HttpGet]
        public ActionResult MemberEdit(string memberid)
        {
            Members member = db.Members.Find(memberid);
            return View("MemberEdit","_AdminLayout",member);
        }

        [HttpPost]
        public ActionResult MemberEdit(Members member)
        {
            //Members dbMember = db.Members.Where(m => m.MemberID == member.MemberID).FirstOrDefault();
            Members dbMember = db.Members.Find(member.MemberID);
            try
            {
                dbMember.MemberName = member.MemberName;
                dbMember.MemberPWD = member.MemberPWD;
                dbMember.Email = member.Email;
                dbMember.Telephone = member.Telephone;

                db.Entry(dbMember).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                ViewBag.Result = "OK";
                return RedirectToAction("Members");
            }
            catch (Exception)
            {
                ViewBag.Result = "FAUL";
            }

            return View(dbMember);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Login(Members member)
        {
            Members admin = db.Members.Where(m => m.MemberID == member.MemberID)
                .Where(m => m.MemberPWD == member.MemberPWD)
                .Where(m => m.Levels == "1").FirstOrDefault();

            if(admin == null) // 아이디 없음.
            {
                ViewBag.Result = "FAIL";
                return View(member);
            }
            else //관리자 로그인
            {
                Session["user_id"] = admin.MemberID;
                Session["levels"] = admin.Levels;
                return RedirectToAction("Index");
            }
        }

        public ActionResult Logout()
        {
            Session["user_id"] = string.Empty;
            Session["levels"] = string.Empty;

            return RedirectToAction("../Home/Index");
        }
           
    }
}
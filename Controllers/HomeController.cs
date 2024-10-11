using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_VnR.Models;

namespace Test_VnR.Controllers
{
    public class HomeController : Controller
    {
        VNR_InternShipEntities db = new VNR_InternShipEntities();
        public ActionResult Index()
        {
            var courseList = db.KhoaHocs.ToList();
            return View(courseList);
        }

        public ActionResult choose_Frontend_Option(int id)
        {
            ViewBag.KhoaHoc = db.KhoaHocs.FirstOrDefault(c => c.ID == id).TenKhoaHoc;
            var subjectList = db.MonHocs.Where(p => p.KhoaHocID == id).ToList();
            return View(subjectList);
        }

        public ActionResult choose_BackEnd_Option(int id)
        {
            ViewBag.KhoaHoc = db.KhoaHocs.FirstOrDefault(c => c.ID == id).TenKhoaHoc;
            var subjectList = db.MonHocs.Where(p => p.KhoaHocID == id).ToList();
            return View(subjectList);
        }

        public ActionResult choose_DotnetCore_Option(int id)
        {
            ViewBag.KhoaHoc = db.KhoaHocs.FirstOrDefault(c => c.ID == id).TenKhoaHoc;
            var subjectList = db.MonHocs.Where(p => p.KhoaHocID == id).ToList();
            return View(subjectList);
        }

    }
}
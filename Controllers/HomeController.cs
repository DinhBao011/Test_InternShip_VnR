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
            var dsKhoaHoc = db.KhoaHocs.ToList();
            return View(dsKhoaHoc);
        }

        public ActionResult chon_Khoa_Hoc_Chi_Tiet(int id, string viewName)
        {
            var khoaHoc = db.KhoaHocs.FirstOrDefault(c => c.ID == id);
            if (khoaHoc == null)
            {
                return HttpNotFound();
            }
            ViewBag.KhoaHoc = khoaHoc.TenKhoaHoc;
            var dsMonHoc = db.MonHocs.Where(p => p.KhoaHocID == id).ToList();
            return View(viewName, dsMonHoc);
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wedding_management_project.Models;

namespace Wedding_management_project.Controllers
{
    public class PhieuTheoDoiTiecsController : Controller
    {
        // GET: PhieuTheoDoiTiecs
        public ActionResult Index()
        {
            ListPhieuTheoDoiTiec strPTDT = new ListPhieuTheoDoiTiec();
            List<QLPhieuTheoDoiTiec> obj = strPTDT.getPhieuTheoDoiTiec(string.Empty);
            return View(obj);
        }
        //Thêm phiếu đặt tiệc
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(QLPhieuTheoDoiTiec strPTDT)
        {
            if (ModelState.IsValid)
            {
                ListPhieuTheoDoiTiec PTDT = new ListPhieuTheoDoiTiec();
                PTDT.AddPhieuTheoDoiTiec(strPTDT);
                return RedirectToAction("Index");
            }
            return View();
        }
        //Sửa phiếu đặt tiệc
        public ActionResult Edit(string maptdt = "")
        {
            ListPhieuTheoDoiTiec PTDT = new ListPhieuTheoDoiTiec();
            List<QLPhieuTheoDoiTiec> obj = PTDT.getPhieuTheoDoiTiec(maptdt);
            return View(obj.FirstOrDefault());
        }

        [HttpPost]

        public ActionResult Edit(QLPhieuTheoDoiTiec strPTDT)
        {
            ListPhieuTheoDoiTiec PTDT = new ListPhieuTheoDoiTiec();
            PTDT.EditPhieuTheoDoiTiec(strPTDT);
            return RedirectToAction("Index");
        }

        //Xóa phiếu đặt tiệc
        public ActionResult Delete(string maptdt = "")
        {
            ListPhieuTheoDoiTiec PTDT = new ListPhieuTheoDoiTiec();
            List<QLPhieuTheoDoiTiec> obj = PTDT.getPhieuTheoDoiTiec(maptdt);
            return View(obj.FirstOrDefault());
        }

        [HttpPost]

        public ActionResult Delete(QLPhieuTheoDoiTiec strPTDT)
        {
            ListPhieuTheoDoiTiec PTDT = new ListPhieuTheoDoiTiec();
            PTDT.DeletePhieuTheoDoiTiec(strPTDT);
            return RedirectToAction("Index");
        }
    }
}

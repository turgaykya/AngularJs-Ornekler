using Business;
using Entities2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UILayer.Models;

namespace UILayer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        UrunBLL _urunBll = new UrunBLL();
        public ActionResult Index()
        {

            return View();
        }

        public JsonResult Gonder()
        {
            List<Ürünler> ürünler = _urunBll.GetAll();
            List<UrunModal> model = new List<UrunModal>();
            foreach (var item in ürünler)
            {
                model.Add(new UrunModal()
                {
                    Id = item.Id,
                    Ad = item.Ad,
                    KategoriId = item.KategoriId,
                    sehirId = item.ŞehirId
                });
            }

            List<Şehir> şehir = _urunBll.ŞehirGetAll();
            List<ŞehirModal> model2 = new List<ŞehirModal>();
            foreach (var item in şehir)
            {
                model2.Add(new ŞehirModal()
                {
                    Id = item.Id,
                    Ad = item.Ad
                });
            }

            List<Kategori> Kategori = _urunBll.KategoriGetAll();
            List<KategoriModal> model3 = new List<KategoriModal>();
            foreach (var item in Kategori)
            {
                model3.Add(new KategoriModal()
                {
                    Id = item.Id,
                    Ad = item.Ad
                });
            }

            return Json(new { Ürünler = model, Şehir = model2, Kategori = model3 }, JsonRequestBehavior.AllowGet);
        }
    }
}
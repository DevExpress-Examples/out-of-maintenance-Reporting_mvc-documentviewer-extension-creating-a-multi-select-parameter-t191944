using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using T191944.Reports;

namespace T191944.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }        

        public ActionResult DocumentViewerPartial() {
            ProductsReport report = new ProductsReport();
            return PartialView("_DocumentViewerPartial", report);
        }

        public ActionResult DocumentViewerPartialExport() {
            ProductsReport report = new ProductsReport();
            return DocumentViewerExtension.ExportTo(report, Request);
        }
    }
}
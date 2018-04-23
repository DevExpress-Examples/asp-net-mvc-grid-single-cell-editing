using DevExpress.Web.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E430_MVC.Controllers
{
    public class HomeController : Controller {
        // GET: Home
        public ActionResult Index() {
            return View();
        }

        public ActionResult GridViewPartial() {
            return PartialView(BatchEditRepository.GridData);
        }

       public JsonResult UpdateData(string data) {
            try {
                BatchEditRepository.UpdateData(JsonConvert.DeserializeObject<GridDataItem>(data));
                return Json("OK");
            }
            catch (Exception ex) {
                return Json(ex.Message);
            }
        }
    }
}
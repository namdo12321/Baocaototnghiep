using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class OrderDetailController : BaseController
    {
        // GET: Admin/OrderDetail
        public ActionResult Index( int page = 1, int pageSize = 5)
        {
            var dao = new OrderDetailDao ();
            var model = dao.ListAllPaging( page, pageSize);
            return View(model);
        }    
    }
}
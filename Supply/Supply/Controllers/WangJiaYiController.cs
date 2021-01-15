using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL.WangJiaYi;

namespace Supply.Controllers
{
    public class WangJiaYiController : Controller
    {
        //视图
        public ActionResult Index()
        {
            return View();
        }
        //展示数据进行分页操作
        public ActionResult GeRenDisplay(int PageIndex, int PageSize)
        {
            return Json(GeRenZiLiaosManager.GeRenDisplay(PageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }
        
        //修改状态
        public ActionResult EditCondition(int zlid, string Condit)
        {
            return Json(GeRenZiLiaosManager.EditCondition(zlid, Condit), JsonRequestBehavior.AllowGet);
        }
        //带条件查询数据
        public ActionResult GeRenDisplays(int PageIndex, int PageSize, string name)
        {
            return Json(GeRenZiLiaosManager.GeRenDisplays(PageIndex, PageSize, name), JsonRequestBehavior.AllowGet);
        }
        //总条数
        public ActionResult Rows(string name)
        {
            return Json(GeRenZiLiaosManager.Rows(name), JsonRequestBehavior.AllowGet);
        }

        public ActionResult newPage()
        {
            return View();
        }

        //新增个人资料用户
        public ActionResult GeRenAdd(GeRenZiLiao ziLiao)
        {
            return Json(GeRenZiLiaosManager.GeRenAdd(ziLiao), JsonRequestBehavior.AllowGet);
        }
        public ActionResult ModifyPage()
        {
            return View();
        }
        //根基ID查询数据
        public ActionResult IDGeRenSelect(int id) {
            return Json(GeRenZiLiaosManager.IDGeRenSelect(id), JsonRequestBehavior.AllowGet);
        }
        //修改个人资料数据
        public ActionResult GeRenEdit(GeRenZiLiao ziLiao)
        {
            return Json(GeRenZiLiaosManager.GeRenEdit(ziLiao), JsonRequestBehavior.AllowGet);
        }

        public ActionResult QianTai()
        {
            return View();
        }

        //查询前台
        public ActionResult Getqiantai(int PageIndex,int PageSize)
        {
            return Json(QianTaiYongHuManager.Getqiantai(PageIndex,PageSize),JsonRequestBehavior.AllowGet);
        }

        //总条数
        public ActionResult Rowes()
        {
            return Json(QianTaiYongHuManager.Rows(),JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddQianTai()
        {
            return View();
        }

        //新增
        public ActionResult QtAdd(QianTaiYongHu qt)
        {
            return Json(QianTaiYongHuManager.QtAdd(qt),JsonRequestBehavior.AllowGet);
        }

        //绑定数据
        public ActionResult Getzt()
        {
            return Json(ZHTypeManager.Getzt(),JsonRequestBehavior.AllowGet);
        }

        public ActionResult Updateqt()
        {
            return View();
        }

        //修改-根据id查询
        public ActionResult getByIdqt(int id)
        {
            return Json(QianTaiYongHuManager.getByIdqt(id),JsonRequestBehavior.AllowGet);
        }

        //修改
        public ActionResult Editqt(QianTaiYongHu q)
        {
            return Json(QianTaiYongHuManager.Editqt(q),JsonRequestBehavior.AllowGet);
        }
        //删除
        public ActionResult delqt(int id)
        {
            return Json(QianTaiYongHuManager.Del(id),JsonRequestBehavior.AllowGet);
        }
    }
}
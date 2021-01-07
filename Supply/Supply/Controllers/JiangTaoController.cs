using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.JiangTao;
using Models;

namespace Supply.Controllers
{
    public class JiangTaoController : Controller
    {
        // GET: ShoYe
        public ActionResult index()
        {
            string dd = Request.QueryString["miaoShu"];
            TempData["name"] = dd;
            Logion user=new Logion();
            if(dd!= null) {
                user = new LogionBll().QueryLogionById(int.Parse(TempData["UserId"].ToString()));
            }
            return View(user);
        }
        public ActionResult Logion() {
            return View();
        }

        /// <summary>
        /// 判断登录返回结果
        /// </summary>
        /// <returns></returns>
        public string IFLogion(string name,string pwd) {
            string jiegGUO = "";
            int ID = new LogionBll().IFLogion(name, pwd);
            if (ID > 0) {
                TempData["UserId"] = ID;
                jiegGUO = "登录成功!";
            }
            else {
                jiegGUO="账号或密码错误!";
            }
            return jiegGUO;
        }

        public ActionResult DiTu() {
            return View();
        }

    }
}
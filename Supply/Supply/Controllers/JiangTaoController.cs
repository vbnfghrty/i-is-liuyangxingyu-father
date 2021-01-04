using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.JiangTao;

namespace Supply.Controllers
{
    public class JiangTaoController : Controller
    {
        string UserId = "";
        // GET: ShoYe
        public ActionResult index()
        {
            string d = "1,2,3,4";
            string ddd = string.Join(",", d);
            return View(ddd);
        }
        public ActionResult Logion() {
            return View();
        }

        public ActionResult DiTu() {
            
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
                UserId = ID.ToString() ;
                Session["UserId"] = UserId;
                jiegGUO = "登录成功!";
            }
            else {
                jiegGUO="账号或密码错误!";
            }
            return jiegGUO;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.JiangTao;
using Models;

namespace BLL.JiangTao
{
    public class LogionBll
    {
        /// <summary>
        /// 验证登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public int IFLogion(string name, string pwd) {
            return new LogionDal().IFLogion(name, pwd); ;
        }

        /// <summary>
        /// 根据id查询账户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Logion QueryLogionById(int id)
        {
            return new LogionDal().QueryLogionById(id);
        }
    }
}

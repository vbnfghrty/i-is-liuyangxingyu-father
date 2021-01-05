using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.JiangTao
{
     public class LogionDal
    {

        /// <summary>
        /// 验证登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public int IFLogion(string name,string pwd) {
            List<int> dd = (from p in new SupplyEntities().Logion where p.ZhName == name && p.ZHPwd == pwd select p.ZHId).ToList();
            int ddd = 0;
            ddd = dd[0];
            return ddd;
        }

        /// <summary>
        /// 根据id查询账户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Logion QueryLogionById(int id) {
            SupplyEntities en = new SupplyEntities();
            var logion = from p in en.Logion
                                  where p.ZHId == id
                                  orderby p.ZHId
                                  select p ;
            Logion lgg = new Logion();
            foreach (Logion lg in logion)
            {
                lgg = lg;
            }
            return lgg;
        }
    }
}

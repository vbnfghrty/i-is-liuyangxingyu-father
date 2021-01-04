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
        public int IFLogion(string name,string pwd) {
            var dd = (from p in new SupplyEntities().Logion where p.ZhName == name && p.ZHPwd == pwd select p.ZHId);
            int UserId = 0;
            foreach (int it in dd)
            {
                UserId = it;
            }
            return UserId;
        }
    }
}

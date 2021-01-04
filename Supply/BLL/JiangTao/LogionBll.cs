using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.JiangTao;

namespace BLL.JiangTao
{
     public class LogionBll
    {
        public int IFLogion(string name, string pwd) {
            return new LogionDal().IFLogion(name,pwd); ;
        }
    }
}

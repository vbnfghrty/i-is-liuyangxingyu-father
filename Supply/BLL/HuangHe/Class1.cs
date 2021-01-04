using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.HuangHe
{
    class Class1
    {
        public int GroupLight(string name, string pwd)
        {
            return new LogionDal().IFLogion(name, pwd); ;
        }
 
    }
}
                 
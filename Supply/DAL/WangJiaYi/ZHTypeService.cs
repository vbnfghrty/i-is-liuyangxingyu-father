using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.WangJiaYi
{
  public  class ZHTypeService
    {
        public static IQueryable Getzt()
        {
            SupplyEntities s = new SupplyEntities();
            var obj = from p in s.ZHType
                      select new {
                          ZTId=p.ZTId,
                          ZTName=p.ZTName
                      };
            return obj;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.WangJiaYi;
using Models;

namespace BLL.WangJiaYi
{
  public  class ZHTypeManager
    {
        public static IQueryable Getzt()
        {
            return ZHTypeService.Getzt();
        }
        }
}

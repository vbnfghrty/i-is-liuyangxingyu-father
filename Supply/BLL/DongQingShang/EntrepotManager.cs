using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.DongQingShang;

namespace BLL.DongQingShang
{
   public class EntrepotManager
    {
        public static int GetRows()
        {
            return EntrepotService.GetRows();
        }
        public static PageList PageListDemo(int PageIndex, int PageSize)
        {
            return EntrepotService.PageListDemo(PageIndex,PageSize);
        
        }
        public static IQueryable IDSelect(string name, string CKDiZhi)
        {
            return EntrepotService.IDSelect(name,CKDiZhi);
        }


        public static int EntrepotAdds(CangKu c)
        {
            return EntrepotService.EntrepotAdds(c);
        }

        //根据ID查询数据
        public static IQueryable GoCount(int Id)
        {
            return EntrepotService.GoCount(Id);
        }
        //进行修改操作
        public static int CKUpdate(CangKu ck)
        {
            return EntrepotService.CKUpdate(ck);
        }
        }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.WangJiaYi
{
   public class QianTaiYongHuService
    {
        //查询
        public static PageList Getqiantai(int PageIndex,int PageSize)
        {
            SupplyEntities s = new SupplyEntities();
            PageList li = new PageList();
            var obj = from p in s.QianTaiYongHu
                      orderby p.QTId
                      select new {
                          QTId=p.QTId,
                          QTName=p.QTName,
                          QTPwd=p.QTPwd,
                          QTDiZhi=p.QTDiZhi,
                          ZTId=p.ZTId
                      };
            li.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = s.QianTaiYongHu.Count();
            li.PageCount = rows % PageSize == 0 ? rows / rows : PageSize / PageSize + 1;
            return li;
        }

        //总条数
        public static int Rows()
        {
            SupplyEntities su = new SupplyEntities();
            return su.QianTaiYongHu.Count();
        }

        //新增
        public static int QtAdd(QianTaiYongHu qt)
        {
            SupplyEntities s = new SupplyEntities();
            s.QianTaiYongHu.Add(qt);
            return s.SaveChanges();
        }

        //修改-根据id查询
        public static IQueryable getByIdqt(int id)
        {
            SupplyEntities s = new SupplyEntities();
            var obj = from p in s.QianTaiYongHu
                      where p.QTId == id
                      select new {
                          QTId=p.QTId,
                          QTName=p.QTName,
                          QTPwd=p.QTPwd,
                          QTDiZhi=p.QTDiZhi,
                          ZTId=p.ZTId
                      };
            return obj;
        }

        //修改
        public static int Editqt(QianTaiYongHu q)
        {
            SupplyEntities s = new SupplyEntities();
            var obj = (from p in s.QianTaiYongHu where p.QTId==q.QTId select p).FirstOrDefault();
            obj.QTName = q.QTName;
            obj.QTPwd = q.QTPwd;
            obj.QTDiZhi = q.QTDiZhi;
            obj.ZTId = q.ZTId;
            return s.SaveChanges();
        }

        //删除
        public static int Del(int id)
        {
            SupplyEntities su = new SupplyEntities();
            var obj = (from p in su.QianTaiYongHu where p.QTId==id select p).First();
            su.QianTaiYongHu.Remove(obj);
            return su.SaveChanges();
        }
    }
}

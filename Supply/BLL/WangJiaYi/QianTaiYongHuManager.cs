using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.WangJiaYi;

namespace BLL.WangJiaYi
{
   public class QianTaiYongHuManager
    {
        //查询
        public static PageList Getqiantai(int PageIndex, int PageSize)
        {
            return QianTaiYongHuService.Getqiantai(PageIndex,PageSize);
        }
        //总条数
        public static int Rows()
        {
            return QianTaiYongHuService.Rows();
        }
        //新增
        public static int QtAdd(QianTaiYongHu qt)
        {
            return QianTaiYongHuService.QtAdd(qt);
        }
        //修改-根据id查询
        public static IQueryable getByIdqt(int id)
        {
            return QianTaiYongHuService.getByIdqt(id);
        }
        //修改
        public static int Editqt(QianTaiYongHu q)
        {
            return QianTaiYongHuService.Editqt(q);
        }
        //删除
        public static int Del(int id)
        {
            return QianTaiYongHuService.Del(id);
        }
        }
}

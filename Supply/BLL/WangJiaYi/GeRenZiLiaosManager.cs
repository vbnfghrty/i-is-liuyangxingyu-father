using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.WangJiaYi;
namespace BLL.WangJiaYi
{
   public  class GeRenZiLiaosManager
    {
        //展示数据进行分页操作
        public static PageList GeRenDisplay(int PageIndex, int PageSize)
        {
            return GeRenZiLiaosService.GeRenDisplay(PageIndex, PageSize);
        }
        //根据ID查询个人数据
        public static IQueryable IDGeRenSelect(int id)
        {
            return GeRenZiLiaosService.IDGeRenSelect(id);
        }
            //修改个人资料数据
            public static int GeRenEdit(GeRenZiLiao ziLiao)
        {
            return GeRenZiLiaosService.GeRenEdit(ziLiao);
        }
        //修改状态
        public static int EditCondition(int zlid, string Condit)
        {
            return GeRenZiLiaosService.EditCondition(zlid,Condit);
        }
        //新增个人资料用户
        public static int GeRenAdd(GeRenZiLiao ziLiao)
        {
            return GeRenZiLiaosService.GeRenAdd(ziLiao);
        }
        //带条件查询数据
        public static PageList GeRenDisplays(int PageIndex, int PageSize, string name)
        {
            return GeRenZiLiaosService.GeRenDisplays(PageIndex, PageSize, name);
        }
        //获取GeRenZiLiao总条数
        public static int Rows(string name)
        {
            return GeRenZiLiaosService.Rows(name);
        }
        }
}

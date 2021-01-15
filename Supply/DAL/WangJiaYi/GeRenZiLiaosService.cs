using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.WangJiaYi
{
    public class GeRenZiLiaosService
    {
        //展示数据进行分页操作
        public static PageList GeRenDisplay(int PageIndex, int PageSize)
        {
            SupplyEntities entities = new SupplyEntities();
            PageList list = new PageList();
            var obj = from p in entities.GeRenZiLiao
                      where p.Condition != "公司离职"
                      orderby p.ZLId
                      select new
                      {
                          ZLId = p.ZLId,
                          ZhName = p.Logion.ZhName,
                          Name = p.Name,
                          Birthday = p.Birthday,
                          EntryDate = p.EntryDate,
                          Email = p.Email,
                          Condition = p.Condition
                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = entities.GeRenZiLiao.Count();
            list.PageCount = rows % PageSize == 0 ? rows / rows : PageSize / PageSize + 1;
            return list;
        }
        //根据ID查询个人数据
        public static IQueryable IDGeRenSelect(int id)
        {
            SupplyEntities entities = new SupplyEntities();
            var obj = from p in entities.GeRenZiLiao
                      where p.ZLId == id
                      select new
                      {
                          ZhName = p.Logion.ZhName,
                          Name = p.Name,
                          Birthday = p.Birthday,
                          EntryDate = p.EntryDate,
                          Email = p.Email,
                          Condition = p.Condition
                      };
            return obj;
        }

        //修改个人资料数据
        public static int GeRenEdit(GeRenZiLiao ziLiao)
        {
            SupplyEntities entities = new SupplyEntities();
            var obj = (from p in entities.GeRenZiLiao where p.ZLId == p.ZLId select p).FirstOrDefault();
            obj.Name = ziLiao.Name;
            obj.Birthday = ziLiao.Birthday;
            obj.EntryDate = ziLiao.EntryDate;
            obj.Email = ziLiao.Email;
            obj.Condition = ziLiao.Condition;
            return entities.SaveChanges();
        }
        //修改状态
        public static int EditCondition(int zlid ,string Condit)
        {
            SupplyEntities entities = new SupplyEntities();
            var obj = (from p in entities.GeRenZiLiao where p.ZLId == zlid select p).FirstOrDefault();
            obj.Condition = Condit;
            return entities.SaveChanges();
        }
        //新增个人资料用户
        public static int GeRenAdd(GeRenZiLiao ziLiao)
        {
            SupplyEntities entities = new SupplyEntities();
            entities.GeRenZiLiao.Add(ziLiao);
            return entities.SaveChanges();
        }
        //带条件查询数据
        public static PageList GeRenDisplays(int PageIndex, int PageSize, string name)
        {
            SupplyEntities entities = new SupplyEntities();
            PageList list = new PageList();
            var obj = from p in entities.GeRenZiLiao
                      where p.Name.Contains(name) && p.Condition!="公司离职"
                      orderby p.ZLId
                      select new
                      {
                          ZLId = p.ZLId,
                          ZhName = p.Logion.ZhName,
                          Name = p.Name,
                          Birthday = p.Birthday,
                          EntryDate = p.EntryDate,
                          Email = p.Email,
                          Condition = p.Condition
                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = entities.GeRenZiLiao.Count();
            list.PageCount = rows % PageSize == 0 ? rows / rows : PageSize / PageSize + 1;
            return list;
        }
        //获取GeRenZiLiao总条数
        public static int Rows(string name)
        {
            SupplyEntities entities = new SupplyEntities();
            var obj = (from p in entities.GeRenZiLiao
                       where p.Condition != "公司离职" && p.Name.Contains(name)
                       select p).Count();
            return obj;
        }
    }
}

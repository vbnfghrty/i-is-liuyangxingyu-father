using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.LiuYangXingYu
{
    public class InventoryService
    {
        //获取CPClass表总条数
        public static int CPPaginate()
        {
            SupplyEntities entities = new SupplyEntities();
            return entities.CPClass.Count();
        }
        //获取DanWei表总条数
        public static int DWPaginate()
        {
            SupplyEntities entities = new SupplyEntities();
            return entities.DanWei.Count();
        }
        //查询CPClass表数据
        public static PageList CPClass(int PageIndex,int PageSize)
        {
            SupplyEntities entities = new SupplyEntities();
            PageList list = new PageList();
            var obj = from p in entities.CPClass
                      orderby p.CId
                      select new
                      {
                          CId = p.CId,
                          CName = p.CName,
                          CBeiZhu = p.CBeiZhu
                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = entities.CPClass.Count();
            list.PageCount = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }
        //新增CPClass数据
        public static int CpAdd(CPClass cP)
        {
            SupplyEntities entities = new SupplyEntities();
            entities.CPClass.Add(cP);
            return entities.SaveChanges();
        }
        //根据Cid查询出CPClass表数据显示在页面上
        public static IQueryable CpidSel(int Cid)
        {
            SupplyEntities entities = new SupplyEntities();
            var obj = from p in entities.CPClass
                      where p.CId == Cid
                      select new
                      {
                          CId = p.CId,
                          CName = p.CName,
                          CBeiZhu = p.CBeiZhu
                      };
            return obj;
        }
        //修改CPClass数据
        public static int CpUpdate(CPClass cP)
        {
            SupplyEntities entities = new SupplyEntities();
            var obj = (from p in entities.CPClass
                       where p.CId == cP.CId
                       select p).FirstOrDefault();
            obj.CName = cP.CName;
            obj.CBeiZhu = cP.CBeiZhu;
            return entities.SaveChanges();
        }





        //查询DanWei表数据
        public static PageList DanWei(int PageIndex,int PageSize)
        {
            SupplyEntities entities = new SupplyEntities();
            PageList list = new PageList();
            var obj = from p in entities.DanWei
                      orderby p.DWId
                      select new
                      {
                          DWId = p.DWId,
                          DWJiLiangName = p.DWJiLiangName
                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = entities.DanWei.Count();
            list.PageCount = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }
        //新增DanWei数据
        public static int DwAdd(DanWei wei)
        {
            SupplyEntities entities = new SupplyEntities();
            entities.DanWei.Add(wei);
            return entities.SaveChanges();
        }
        //根据DWid查询出DanWei表数据显示在页面上
        public static IQueryable DwidSel(int Dwid)
        {
            SupplyEntities entities = new SupplyEntities();
            var obj = from p in entities.DanWei
                      where p.DWId == Dwid
                      select new
                      {
                          DWId = p.DWId,
                          DWJiLiangName = p.DWJiLiangName
                      };
            return obj;
        }
        //修改DanWei表数据
        public static int DwUpdate(DanWei wei)
        {
            SupplyEntities entities = new SupplyEntities();
            var obj = (from p in entities.DanWei
                       where p.DWId == wei.DWId
                       select p).FirstOrDefault();
            obj.DWJiLiangName = wei.DWJiLiangName;
            return entities.SaveChanges();
        }
        //计算条数
        public static int CPCount(string CPName)
        {
            SupplyEntities entities = new SupplyEntities();
            var obj = (from p in entities.CPClass where p.CName == CPName select p).Count();
            return obj;
        }
        //计算条数
        public static int DWCount(string DWName)
        {
            SupplyEntities entities = new SupplyEntities();
            var obj = (from p in entities.DanWei where p.DWJiLiangName == DWName select p).Count();
            return obj;
        }
    }
}

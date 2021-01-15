using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.LiuYangXingYu;

namespace BLL.LiuYangXingYu
{
    public class InventoryManager
    {
        //获取CPClass表总条数
        public static int CPPaginate()
        {
            return InventoryService.CPPaginate();
        }
        //获取DanWei表总条数
        public static int DWPaginate()
        {
            return InventoryService.DWPaginate();
        }
        //查询CPClass表数据
        public static PageList CPClass(int PageIndex, int PageSize)
        {
            return InventoryService.CPClass(PageIndex, PageSize);
        }
        //新增CPClass数据
        public static int CpAdd(CPClass cP)
        {
            return InventoryService.CpAdd(cP);
        }
        //根据Cid查询出CPClass表数据显示在页面上
        public static IQueryable CpidSel(int Cid)
        {
            return InventoryService.CpidSel(Cid);
        }
        //修改CPClass数据
        public static int CpUpdate(CPClass cP)
        {
            return InventoryService.CpUpdate(cP);
        }



        //查询DanWei表数据
        public static PageList DanWei(int PageIndex, int PageSize)
        {
            return InventoryService.DanWei(PageIndex,PageSize);
        }
        //新增DanWei数据
        public static int DwAdd(DanWei wei)
        {
            return InventoryService.DwAdd(wei);
        }
        //根据DWid查询出DanWei表数据显示在页面上
        public static IQueryable DwidSel(int Dwid)
        {
            return InventoryService.DwidSel(Dwid);
        }
        //修改DanWei表数据
        public static int DwUpdate(DanWei wei)
        {
            return InventoryService.DwUpdate(wei);
        }

        //计算条数
        public static int CPCount(string CPName)
        {
            return InventoryService.CPCount(CPName);
        }
        //计算条数
        public static int DWCount(string DWName)
        {
            return InventoryService.DWCount(DWName);
        }
    }
}

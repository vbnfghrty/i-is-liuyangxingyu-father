using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.DongQingShang
{
    public class EntrepotService
    {
        //仓库信息查询

        //总条数
        public static int GetRows()
        {
            SupplyEntities entities = new SupplyEntities();
            return entities.CangKu.Count();
        }
        public static PageList PageListDemo(int PageIndex, int PageSize)
        {
            SupplyEntities entities = new SupplyEntities();
            PageList list = new PageList();
            var obj = from p in entities.CangKu
                      orderby p.CKId
                      select new
                      {
                          CKId = p.CKId,
                          CKName = p.CKName,
                          CKDiZhi = p.CKDiZhi,
                          CKChuanJianTime = p.CKChuanJianTime,
                          CKType = p.CKType

                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = entities.CangKu.Count();
            list.PageCount = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }
        public static IQueryable IDSelect(string name, string CKDiZhi)
        {
            SupplyEntities entities = new SupplyEntities();
            var obj = from p in entities.CangKu
                      where p.CKDiZhi == CKDiZhi
                      || p.CKName.Contains(name)
                      orderby p.CKId
                      select new
                      {
                          CKId = p.CKId,
                          CKName = p.CKName,
                          CKDiZhi = p.CKDiZhi,
                          CKChuanJianTime = p.CKChuanJianTime,
                          CKType = p.CKType

                      };
            return obj;
        }


        //仓库新增
        public static int EntrepotAdds(CangKu c)
        {
            SupplyEntities entities = new SupplyEntities();
            entities.CangKu.Add(c);

            return entities.SaveChanges();
        }
        //根据ID查询数据
        public static IQueryable GoCount(int Id)
        {
            SupplyEntities entities = new SupplyEntities();
            var obj = from p in entities.CangKu
                      where p.CKId == Id
                      select new
                      {
                          CKId = p.CKId,
                          CKName = p.CKName,
                          CKDiZhi = p.CKDiZhi,
                          CKChuanJianTime = p.CKChuanJianTime,
                          CKType = p.CKType
                      };
            return obj;
        }
        //进行修改操作
        public static int CKUpdate(CangKu ck)
        {
            SupplyEntities entities = new SupplyEntities();
            var obj = (from p in entities.CangKu
                       where p.CKId == ck.CKId
                       select p).FirstOrDefault();
            obj.CKName = ck.CKName;
            obj.CKDiZhi = ck.CKDiZhi;
            obj.CKChuanJianTime = ck.CKChuanJianTime;
            obj.CKType = ck.CKType;
            return entities.SaveChanges();
        }
    }
}

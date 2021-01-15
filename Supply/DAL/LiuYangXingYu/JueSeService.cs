using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.LiuYangXingYu
{
    public class JueSeService
    {
        //查询JueSe表数据
        public static IQueryable JsSelect()
        {
            SupplyEntities entities = new SupplyEntities();
            var obj = from p in entities.JueSe
                      orderby p.JueSeId
                      select new
                      {
                          JueSeId = p.JueSeId,
                          JueSeName = p.JueSeName,
                          JSTime = p.JSTime,
                          JSBeiZhu = p.JSBeiZhu
                      };
            return obj;
        }
        //新增JueSe表数据
        public static int JsAdd(JueSe js)
        {
            SupplyEntities entities = new SupplyEntities();
            entities.JueSe.Add(js);
            return entities.SaveChanges();
        }
        //根据ID查询数据在显示修改页面
        public static IQueryable JsIdSelect(int jsId)
        {
            SupplyEntities entities = new SupplyEntities();
            var obj = from p in entities.JueSe
                      where p.JueSeId == jsId
                      select new
                      {
                          JueSeId = p.JueSeId,
                          JueSeName = p.JueSeName,
                          JSTime = p.JSTime,
                          JSBeiZhu = p.JSBeiZhu
                      };
            return obj;
        }
        //获取传过来的ID进行修改操作
        public static int JsUpdate(JueSe js)
        {
            SupplyEntities entities = new SupplyEntities();
            var obj = (from p in entities.JueSe where p.JueSeId == js.JueSeId select p).FirstOrDefault();
            obj.JueSeName = js.JueSeName;
            obj.JSTime = js.JSTime;
            obj.JSBeiZhu = js.JSBeiZhu;
            return entities.SaveChanges();
        }
        //判断数据库有没有这个值
        public static int Count(string Name)
        {
            SupplyEntities entities = new SupplyEntities();
            var obj = (from p in entities.JueSe where p.JueSeName == Name select p.JueSeId).Count();
            return obj;
        }
    }
}

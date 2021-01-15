using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.LiuYangXingYu;
namespace BLL.LiuYangXingYu
{
    public class JueSeManager
    {
        //查询JueSe表数据
        public static IQueryable JsSelect()
        {
            return JueSeService.JsSelect();
        }
        //新增JueSe表数据
        public static int JsAdd(JueSe js)
        {
            return JueSeService.JsAdd(js);
        }
        //根据ID查询数据在显示修改页面
        public static IQueryable JsIdSelect(int jsId)
        {
            return JueSeService.JsIdSelect(jsId);
        }
        //获取传过来的ID进行修改操作
        public static int JsUpdate(JueSe js)
        {
            return JueSeService.JsUpdate(js);
        }
        //判断数据库有没有这个值
        public static int Count(string Name)
        {
            return JueSeService.Count(Name);
        }
        }
}

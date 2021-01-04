using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.HuangHe
{
    class Class1
    {
        public int GroupLight(int ddid)
        {
            var S = (from DD in new SupplyEntities().DingDan from DX in new SupplyEntities().DingDangXX from CP in new SupplyEntities().ChanPingJiBen where DX.DDId == ddid && DX.JBId == CP.JBId select DD.DDType );
            int UserId = 0;
            foreach (int it in S)
            {
                UserId = it;
            }
            return UserId;
        }
    }
}

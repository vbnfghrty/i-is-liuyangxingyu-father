//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CangKu
    {
        public CangKu()
        {
            this.ChanPing = new HashSet<ChanPing>();
        }
    
        public int CKId { get; set; }
        public string CKName { get; set; }
        public string CKDiZhi { get; set; }
        public Nullable<System.DateTime> CKChuanJianTime { get; set; }
        public Nullable<int> CKType { get; set; }
        public string CKValue1 { get; set; }
        public string CKValue2 { get; set; }
    
        public virtual ICollection<ChanPing> ChanPing { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLQuanAn
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public Nullable<int> TaiKhoanID { get; set; }
    
        public virtual Account Account { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace doan
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietHDBan
    {
        public string MaHD { get; set; }
        public string MaSP { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<int> GiaBan { get; set; }
        public Nullable<bool> TrangThai { get; set; }
    
        public virtual HDBanHang HDBanHang { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DTO
{
    class NhaCungCapDTO
    {
		private string _MaNCC;
		public string MaNCC
		{
			get { return _MaNCC; }
			set { _MaNCC = value; }
		}

		private string _TenNCC;
		public string TenNCC
		{
			get { return _TenNCC; }
			set { _TenNCC = value; }
		}

		private string _SDT;
		public string SDT
		{
			get { return _SDT; }
			set { _SDT = value; }
		}

		private bool _TrangThai;
		public bool TrangThai
		{
			get { return _TrangThai; }
			set { _TrangThai = value; }
		}

		public NhaCungCapDTO()
		{
			this.MaNCC = "";
			this.TenNCC = "";
			this.SDT = "";
			this.TrangThai = true;
		}

		public NhaCungCapDTO(string MaNCC_, string TenNCC_, string SDT_, bool TrangThai_)
		{
			this.MaNCC = MaNCC_;
			this.TenNCC = TenNCC_;
			this.SDT = SDT_;
			this.TrangThai = TrangThai_;
		}
	}
}

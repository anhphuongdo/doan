using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DTO
{
    class LoaiSanPhamDTO
    {
			private string _MaLoai;
			public string MaLoai
			{
				get { return _MaLoai; }
				set { _MaLoai = value; }
			}

			private string _TenLoai;
			public string TenLoai
			{
				get { return _TenLoai; }
				set { _TenLoai = value; }
			}

			private bool _TrangThai;
			public bool TrangThai
			{
				get { return _TrangThai; }
				set { _TrangThai = value; }
			}
		public LoaiSanPhamDTO()
		{
			this.MaLoai = "";
			this.TenLoai ="";
			this.TrangThai = true;
		}

		public LoaiSanPhamDTO(string MaLoai_, string TenLoai_, bool TrangThai_)
			{
				this.MaLoai = MaLoai_;
				this.TenLoai = TenLoai_;
				this.TrangThai = TrangThai_;
			}
		}
	}

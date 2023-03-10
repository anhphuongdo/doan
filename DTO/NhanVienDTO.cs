using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DTO
{
    class NhanVienDTO
    {
			private string _MaNV;
			public string MaNV
			{
				get { return _MaNV; }
				set { _MaNV = value; }
			}

			private string _TenNV;
			public string TenNV
			{
				get { return _TenNV; }
				set { _TenNV = value; }
			}

			private string _Username;
			public string Username
			{
				get { return _Username; }
				set { _Username = value; }
			}

			private string _MatKhau;
			public string MatKhau
			{
				get { return _MatKhau; }
				set { _MatKhau = value; }
			}

			private string _ChucVu;
			public string ChucVu
			{
				get { return _ChucVu; }
				set { _ChucVu = value; }
			}

			private string _SDT;
			public string SDT
			{
				get { return _SDT; }
				set { _SDT = value; }
			}

			private string _Email;
			public string Email
			{
				get { return _Email; }
				set { _Email = value; }
			}

			private string _DiaChi;
			public string DiaChi
			{
				get { return _DiaChi; }
				set { _DiaChi = value; }
			}

			private string _GioiTinh;
			public string GioiTinh
			{
				get { return _GioiTinh; }
				set { _GioiTinh = value; }
			}

			private string _NgaySinh;
			public string NgaySinh
			{
				get { return _NgaySinh; }
				set { _NgaySinh = value; }
			}

			private string _CaLam;
			public string CaLam
			{
				get { return _CaLam; }
				set { _CaLam = value; }
			}

			private int _SoCong;
			public int SoCong
			{
				get { return _SoCong; }
				set { _SoCong = value; }
			}

			private Single _MucLuong;
			public Single MucLuong
			{
				get { return _MucLuong; }
				set { _MucLuong = value; }
			}

			private bool _TrangThai;
			public bool TrangThai
			{
				get { return _TrangThai; }
				set { _TrangThai = value; }
			}
		public NhanVienDTO()
		{
			this.MaNV = "";
			this.TenNV = "";
			this.Username = "";
			this.MatKhau = "";
			this.ChucVu = "";
			this.SDT = "";
			this.Email = "";
			this.DiaChi = "";
			this.GioiTinh = "";
			this.NgaySinh = "";
			this.CaLam = "";
			this.SoCong = 0;
			this.MucLuong = 0;
			this.TrangThai = true;
		}

		public NhanVienDTO(string MaNV_, string TenNV_, string Username_, string MatKhau_, string ChucVu_, string SDT_, string Email_, string DiaChi_, string GioiTinh_, string NgaySinh_, string CaLam_, int SoCong_, Single MucLuong_, bool TrangThai_)
			{
				this.MaNV = MaNV_;
				this.TenNV = TenNV_;
				this.Username = Username_;
				this.MatKhau = MatKhau_;
				this.ChucVu = ChucVu_;
				this.SDT = SDT_;
				this.Email = Email_;
				this.DiaChi = DiaChi_;
				this.GioiTinh = GioiTinh_;
				this.NgaySinh = NgaySinh_;
				this.CaLam = CaLam_;
				this.SoCong = SoCong_;
				this.MucLuong = MucLuong_;
				this.TrangThai = TrangThai_;
			}
		}
	}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DTO
{
    class ChiTietHDBanDTO
    {
			private string _MaHD;
			public string MaHD
			{
				get { return _MaHD; }
				set { _MaHD = value; }
			}

			private string _MaSP;
			public string MaSP
			{
				get { return _MaSP; }
				set { _MaSP = value; }
			}

			private int _SoLuong;
			public int SoLuong
			{
				get { return _SoLuong; }
				set { _SoLuong = value; }
			}

			private int _GiaBan;
			public int GiaBan
			{
				get { return _GiaBan; }
				set { _GiaBan = value; }
			}

			private bool _TrangThai;
			public bool TrangThai
			{
				get { return _TrangThai; }
				set { _TrangThai = value; }
			}

			public ChiTietHDBanDTO()
			{
				this.MaHD = "";
				this.MaSP = "";
				this.SoLuong = 0;
				this.GiaBan = 0;
				this.TrangThai = true;
			}
			public ChiTietHDBanDTO(string MaHD_, string MaSP_, int SoLuong_, int GiaBan_, bool TrangThai_)
			{
				this.MaHD = MaHD_;
				this.MaSP = MaSP_;
				this.SoLuong = SoLuong_;
				this.GiaBan = GiaBan_;
				this.TrangThai = TrangThai_;
			}
		}
	}

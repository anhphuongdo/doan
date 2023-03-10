using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DTO
{
    class KhachHangDTO
    {
			private string _MaKH;
			public string MaKH
			{
				get { return _MaKH; }
				set { _MaKH = value; }
			}

			private string _TenKH;
			public string TenKH
			{
				get { return _TenKH; }
				set { _TenKH = value; }
			}

			private string _Email;
			public string Email
			{
				get { return _Email; }
				set { _Email = value; }
			}

			private string _SDT;
			public string SDT
			{
				get { return _SDT; }
				set { _SDT = value; }
			}

			private bool _VIP;
			public bool VIP
			{
				get { return _VIP; }
				set { _VIP = value; }
			}

			private bool _TrangThai;
			public bool TrangThai
			{
				get { return _TrangThai; }
				set { _TrangThai = value; }
			}

			public KhachHangDTO()
			{
				this.MaKH = "";
				this.TenKH = "";
				this.Email = "";
				this.SDT = "";
				this.VIP = false;
				this.TrangThai = true;
			}

			public KhachHangDTO(string MaKH_, string TenKH_, string Email_, string SDT_, bool VIP_, bool TrangThai_)
			{
				this.MaKH = MaKH_;
				this.TenKH = TenKH_;
				this.Email = Email_;
				this.SDT = SDT_;
				this.VIP = VIP_;
				this.TrangThai = TrangThai_;
		}
	}
}

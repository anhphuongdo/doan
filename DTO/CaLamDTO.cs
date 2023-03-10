using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DTO
{
    class CaLamDTO
    {
			private string _MaCa;
			public string MaCa
			{
				get { return _MaCa; }
				set { _MaCa = value; }
			}

			private string _NgayLam;
			public string NgayLam
			{
				get { return _NgayLam; }
				set { _NgayLam = value; }
			}

			private string _BatDau;
			public string BatDau
			{
				get { return _BatDau; }
				set { _BatDau = value; }
			}

			private string _KetThuc;
			public string KetThuc
			{
				get { return _KetThuc; }
				set { _KetThuc = value; }
			}

			private bool _TrangThai;
			public bool TrangThai
			{
				get { return _TrangThai; }
				set { _TrangThai = value; }
			}

			public CaLamDTO()
            {
				this.MaCa = "";
				this.NgayLam = "";
				this.BatDau = "";
				this.KetThuc = "";
				this.TrangThai = true;
			}
			public CaLamDTO(string MaCa_, string NgayLam_, string BatDau_, string KetThuc_, bool TrangThai_)
			{
				this.MaCa = MaCa_;
				this.NgayLam = NgayLam_;
				this.BatDau = BatDau_;
				this.KetThuc = KetThuc_;
				this.TrangThai = TrangThai_;
			}
		}
	}

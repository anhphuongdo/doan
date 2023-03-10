using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DTO
{
    class PhanCongDTO
    {
		private string _MaNV;
		public string MaNV
		{
			get { return _MaNV; }
			set { _MaNV = value; }
		}

		private string _MaCa;
		public string MaCa
		{
			get { return _MaCa; }
			set { _MaCa = value; }
		}

		private bool _TrangThai;
		public bool TrangThai
		{
			get { return _TrangThai; }
			set { _TrangThai = value; }
		}

		public PhanCongDTO()
		{
			this.MaNV = "";
			this.MaCa = "";
			this.TrangThai = true;
		}

		public PhanCongDTO(string MaNV_, string MaCa_, bool TrangThai_)
		{
			this.MaNV = MaNV_;
			this.MaCa = MaCa_;
			this.TrangThai = TrangThai_;
		}
	}
}

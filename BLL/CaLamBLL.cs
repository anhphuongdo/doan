using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using doan.DAL;
using doan.DTO;

namespace doan.BLL
{
    class CaLamBLL
    {
        public static List<CaLamDTO> EF_GetAll()
        {
            return CaLamDAL.EF_GetAll();
        }
        public static List<CaLamDTO> EF_GetShift(NhanVienDTO nv)
        {
            return CaLamDAL.EF_GetShift(nv);
        }
    }
}

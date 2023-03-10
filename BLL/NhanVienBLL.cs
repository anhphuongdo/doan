using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using doan.DAL;
using doan.DTO;

namespace doan.BLL
{
    class NhanVienBLL
    {
        public static List<NhanVienDTO> EF_GetAll()
        {
            return NhanVienDAL.EF_GetAll();
        }
    }
}

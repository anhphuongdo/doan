using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using doan.DAL;
using doan.DTO;

namespace doan.BLL
{
    class LoaiSanPhamBLL
    {
        public static List<LoaiSanPhamDTO> EF_GetAll()
        {
            return LoaiSanPhamDAL.EF_GetAll();
        }
    }
}

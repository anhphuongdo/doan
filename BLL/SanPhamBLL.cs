using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using doan.DAL;
using doan.DTO;

namespace doan.BLL
{
    class SanPhamBLL
    {
        public static List<SanPhamDTO> EF_GetAll()
        {
            return SanPhamDAL.EF_GetAll();
        }
        public static List<SanPhamDTO> EF_Price(int a, int b)
        {
            return SanPhamDAL.EF_Price(a, b);
        }
        public static List<SanPhamDTO> EF_FindSP(SanPhamDTO sp)
        {
            return SanPhamDAL.EF_FindSP(sp);
        }
        public static List<SanPhamDTO> EF_FindLSP(SanPhamDTO sp)
        {
            return SanPhamDAL.EF_FindLSP(sp);
        }
        public static List<SanPhamDTO> EF_FindMSP(SanPhamDTO sp)
        {
            return SanPhamDAL.EF_FindMSP(sp);
        }
        public static List<SanPhamDTO> EF_GetLsPWithPrice(int a, int b, SanPhamDTO sp)
        {
            return SanPhamDAL.EF_GetLsPWithPrice(a, b, sp);
        }
    }
}

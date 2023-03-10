using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using doan.DAL;
using doan.DTO;

namespace doan.BLL
{
    class KhachHangBLL
    {
        public static List<KhachHangDTO> EF_GetAll()
        {
            return KhachHangDAL.EF_GetAll();
        }
        public static List<KhachHangDTO> EF_GetReallyAll()
        {
            return KhachHangDAL.EF_GetReallyAll();
        }
        public static void EF_Delete(KhachHangDTO dto)
        {
            KhachHangDAL.EF_Delete(dto);
        }
        public static void EF_AddNew(KhachHangDTO dto)
        {
            KhachHangDAL.EF_AddNew(dto);
        }
        public static void EF_Edit(KhachHangDTO dto)
        {
            KhachHangDAL.EF_Edit(dto);
        }
    }
}

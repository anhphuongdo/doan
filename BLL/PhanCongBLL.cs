using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using doan.DAL;
using doan.DTO;

namespace doan.BLL
{
    class PhanCongBLL
    {
        public static List<PhanCongDTO> EF_GetAll()
        {
            return PhanCongDAL.EF_GetAll();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using doan.DAL;
using doan.DTO;

namespace doan.BLL
{
    class NhaCungCapBLL
    {
        public static List<NhaCungCapDTO> EF_GetAll()
        {
            return NhaCungCapDAL.EF_GetAll();
        }
    }
}

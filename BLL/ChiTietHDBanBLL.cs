﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using doan.DAL;
using doan.DTO;

namespace doan.BLL
{
    class ChiTietHDBanBLL
    {
        public static List<ChiTietHDBanDTO> EF_GetAll()
        {
            return ChiTietHDBanDAL.EF_GetAll();
        }
    }
}

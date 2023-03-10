using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using doan.DTO;
using AutoMapper;

namespace doan.DAL
{
    class ChiTietHDBanDAL
    {
        public static List<ChiTietHDBanDTO> EF_GetAll()
        {
            QLNSEntities data = new QLNSEntities();
            var truyvan = from ct in data.ChiTietHDBans
                          where ct.TrangThai == true
                          select ct;
            List<ChiTietHDBanDTO> listKQ = new List<ChiTietHDBanDTO>();
            foreach (ChiTietHDBan ct in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<ChiTietHDBan, ChiTietHDBanDTO>());
                var mapper = new Mapper(config);
                ChiTietHDBanDTO dto = mapper.Map<ChiTietHDBanDTO>(ct);

                listKQ.Add(dto);
            }
            return listKQ;
        }
    }
}

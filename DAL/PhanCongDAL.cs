using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using doan.DTO;
using AutoMapper;

namespace doan.DAL
{
    class PhanCongDAL
    {
        public static List<PhanCongDTO> EF_GetAll()
        {
            QLNSEntities data = new QLNSEntities();
            var truyvan = from pc in data.PhanCongs
                          where pc.TrangThai == true
                          select pc;
            List<PhanCongDTO> listKQ = new List<PhanCongDTO>();
            foreach (PhanCong pc in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<PhanCong, PhanCongDTO>());
                var mapper = new Mapper(config);
                PhanCongDTO dto = mapper.Map<PhanCongDTO>(pc);

                listKQ.Add(dto);
            }
            return listKQ;
        }
    }
}

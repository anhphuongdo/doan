using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using doan.DTO;
using AutoMapper;

namespace doan.DAL
{
    class NhaCungCapDAL
    {
        public static List<NhaCungCapDTO> EF_GetAll()
        {
            QLNSEntities data = new QLNSEntities();
            var truyvan = from ncc in data.NhaCungCaps
                          where ncc.TrangThai == true
                          select ncc;
            List<NhaCungCapDTO> listKQ = new List<NhaCungCapDTO>();
            foreach (NhaCungCap ncc in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<NhaCungCap, NhaCungCapDTO>());
                var mapper = new Mapper(config);
                NhaCungCapDTO dto = mapper.Map<NhaCungCapDTO>(ncc);

                listKQ.Add(dto);
            }
            return listKQ;
        }
    }
}

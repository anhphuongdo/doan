using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using doan.DTO;
using AutoMapper;

namespace doan.DAL
{
    class NhanVienDAL
    {
        public static List<NhanVienDTO> EF_GetAll()
        {
            QLNSEntities data = new QLNSEntities();
            var truyvan = from nv in data.NhanViens
                          where nv.TrangThai == true
                          select nv;
            List<NhanVienDTO> listKQ = new List<NhanVienDTO>();
            foreach (NhanVien nv in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<NhanVien, NhanVienDTO>());
                var mapper = new Mapper(config);
                NhanVienDTO dto = mapper.Map<NhanVienDTO>(nv);

                listKQ.Add(dto);
            }
            return listKQ;
        }
    }
}

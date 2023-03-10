using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using doan.DTO;
using AutoMapper;

namespace doan.DAL
{
    class CaLamDAL
    {
        public static List<CaLamDTO> EF_GetAll()
        {
            QLNSEntities data = new QLNSEntities();
            var truyvan = from ca in data.CaLams
                          where ca.TrangThai == true
                          select ca;
            List<CaLamDTO> listKQ = new List<CaLamDTO>();
            foreach (CaLam ca in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<CaLam, CaLamDTO>());
                var mapper = new Mapper(config);
                CaLamDTO dto = mapper.Map<CaLamDTO>(ca);

                listKQ.Add(dto);
            }
            return listKQ;
        }
        public static List<CaLamDTO> EF_GetShift(NhanVienDTO nv)
        {
            QLNSEntities data = new QLNSEntities();
            var truyvan = from ca in data.CaLams
                          where nv.CaLam == ca.MaCa
                          select ca;
            List<CaLamDTO> listKQ = new List<CaLamDTO>();
            foreach(CaLam ca in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<CaLam, CaLamDTO>());
                var mapper = new Mapper(config);
                CaLamDTO dto = mapper.Map<CaLamDTO>(ca);

                listKQ.Add(dto);
            }
            return listKQ;
        }
    }
}

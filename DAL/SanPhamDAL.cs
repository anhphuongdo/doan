using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using doan.DTO;
using AutoMapper;

namespace doan.DAL
{
    class SanPhamDAL
    {
        public static List<SanPhamDTO> EF_GetAll()
        {
            QLNSEntities data = new QLNSEntities();
            var truyvan = from sp in data.SanPhams
                          where sp.TrangThai == true
                          select sp;
            List<SanPhamDTO> listKQ = new List<SanPhamDTO>();
            foreach (SanPham sp in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
                var mapper = new Mapper(config);
                SanPhamDTO dto = mapper.Map<SanPhamDTO>(sp);

                listKQ.Add(dto);
            }
            return listKQ;
        }
        public static List<SanPhamDTO> EF_Price(int a, int b)
        {
            QLNSEntities data = new QLNSEntities();
            var truyvan = from sp in data.SanPhams
                          where sp.DonGia >= a
                          where sp.DonGia <= b
                          where sp.TrangThai == true
                          select sp;
            List<SanPhamDTO> listKQ = new List<SanPhamDTO>();
            foreach (SanPham sp in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
                var mapper = new Mapper(config);
                SanPhamDTO dto = mapper.Map<SanPhamDTO>(sp);

                listKQ.Add(dto);
            }
            return listKQ;
        }
        public static List<SanPhamDTO> EF_GetLsPWithPrice(int a, int b, SanPhamDTO sanpham)
        {
            QLNSEntities data = new QLNSEntities();
            var truyvan = from sp in data.SanPhams
                          where sp.DonGia >= a
                          where sp.DonGia <= b
                          where sp.MaLoai == sanpham.MaLoai
                          where sp.TrangThai == true
                          select sp;
            List<SanPhamDTO> listKQ = new List<SanPhamDTO>();
            foreach (SanPham sp in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
                var mapper = new Mapper(config);
                SanPhamDTO dto = mapper.Map<SanPhamDTO>(sp);

                listKQ.Add(dto);
            }
            return listKQ;

        }
        public static List<SanPhamDTO> EF_FindSP(SanPhamDTO sanpham)
        {
            QLNSEntities data = new QLNSEntities();
            var truyvan = from sp in data.SanPhams
                          where sp.TenSP == sanpham.TenSP
                          where sp.TrangThai == true
                          select sp;
            List<SanPhamDTO> listKQ = new List<SanPhamDTO>();
            foreach (SanPham sp in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
                var mapper = new Mapper(config);
                SanPhamDTO dto = mapper.Map<SanPhamDTO>(sp);

                listKQ.Add(dto);
            }
            return listKQ;
        }
        public static List<SanPhamDTO> EF_FindMSP(SanPhamDTO sanpham)
        {
            QLNSEntities data = new QLNSEntities();
            var truyvan = from sp in data.SanPhams
                          where sp.MaSP == sanpham.MaSP
                          where sp.TrangThai == true
                          select sp;
            List<SanPhamDTO> listKQ = new List<SanPhamDTO>();
            foreach (SanPham sp in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
                var mapper = new Mapper(config);
                SanPhamDTO dto = mapper.Map<SanPhamDTO>(sp);

                listKQ.Add(dto);
            }
            return listKQ;
        }
        public static List<SanPhamDTO> EF_FindLSP(SanPhamDTO sanpham)
        {
            QLNSEntities data = new QLNSEntities();
            var truyvan = from sp in data.SanPhams
                          where sp.MaLoai == sanpham.MaLoai
                          where sp.TrangThai == true
                          select sp;
            List<SanPhamDTO> listKQ = new List<SanPhamDTO>();
            foreach (SanPham sp in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
                var mapper = new Mapper(config);
                SanPhamDTO dto = mapper.Map<SanPhamDTO>(sp);

                listKQ.Add(dto);
            }
            return listKQ;
        }
    }
}

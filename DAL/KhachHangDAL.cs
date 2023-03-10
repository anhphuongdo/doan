using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using doan.DTO;
using AutoMapper;

namespace doan.DAL
{
    class KhachHangDAL
    {
        public static List<KhachHangDTO> EF_GetAll()
        {
            QLNSEntities data = new QLNSEntities();
            var truyvan = from kh in data.KhachHangs
                          where kh.TrangThai == true
                          select kh;
            List<KhachHangDTO> listKQ = new List<KhachHangDTO>();
            foreach(KhachHang kh in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<KhachHang, KhachHangDTO>());
                var mapper = new Mapper(config);
                KhachHangDTO dto = mapper.Map<KhachHangDTO>(kh);

                listKQ.Add(dto);
            }
            return listKQ;
        }
        public static List<KhachHangDTO> EF_GetReallyAll()
        {
            QLNSEntities data = new QLNSEntities();
            var truyvan = from kh in data.KhachHangs
                          select kh;
            List<KhachHangDTO> listKQ = new List<KhachHangDTO>();
            foreach (KhachHang kh in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<KhachHang, KhachHangDTO>());
                var mapper = new Mapper(config);
                KhachHangDTO dto = mapper.Map<KhachHangDTO>(kh);

                listKQ.Add(dto);
            }
            return listKQ;
        }
        public static void EF_Delete(KhachHangDTO dto)
        {
            QLNSEntities data = new QLNSEntities();
            KhachHang kh = (from khachhang in data.KhachHangs
                               where khachhang.MaKH == dto.MaKH.Trim()
                               select khachhang).FirstOrDefault<KhachHang>();
            kh.MaKH = dto.MaKH;
            kh.Email = dto.Email;
            kh.TenKH = dto.TenKH;
            kh.SDT = dto.SDT;
            kh.VIP = dto.VIP;
            kh.TrangThai = dto.TrangThai;
            data.SaveChanges();
        }
        public static void EF_AddNew(KhachHangDTO dto)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<KhachHangDTO, KhachHang>());
            var mapper = new Mapper(config);
            KhachHang kh = mapper.Map<KhachHang>(dto);

            QLNSEntities data = new QLNSEntities();
            data.KhachHangs.Add(kh);
            data.SaveChanges();
        }
        public static void EF_Edit(KhachHangDTO dto)
        {
            QLNSEntities data = new QLNSEntities();
            KhachHang kh = (from khachhang in data.KhachHangs
                            where khachhang.MaKH == dto.MaKH.Trim()
                            select khachhang).SingleOrDefault<KhachHang>();
            kh.MaKH = dto.MaKH;
            kh.Email = dto.Email;
            kh.TenKH = dto.TenKH;
            kh.SDT = dto.SDT;
            kh.VIP = dto.VIP;
            kh.TrangThai = dto.TrangThai;
            data.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using doan.DTO;
using AutoMapper;

namespace doan.DAL
{
    class LoaiSanPhamDAL
    {
        public static List<LoaiSanPhamDTO> EF_GetAll()
        {
            QLNSEntities data = new QLNSEntities();
            var truyvan = from lsp in data.LoaiSanPhams
                          where lsp.TrangThai == true
                          select lsp;
            List<LoaiSanPhamDTO> listKQ = new List<LoaiSanPhamDTO>();
            foreach (LoaiSanPham lsp in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<LoaiSanPham, LoaiSanPhamDTO>());
                var mapper = new Mapper(config);
                LoaiSanPhamDTO dto = mapper.Map<LoaiSanPhamDTO>(lsp);

                listKQ.Add(dto);
            }
            return listKQ;
        }
    }
}

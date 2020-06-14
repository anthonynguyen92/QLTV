using Application.PhieuThuTiens;
using AutoMapper;
using BUS.DTO;
using EntityDb.Entities;
using System.Data;

namespace BUS.PhieuThuTienService
{
    public class BUS_PhieuThuTien :IBUS_PhieuThuTien
    {
        private readonly IApplicationPhieuThuTien _application;

        public BUS_PhieuThuTien(IApplicationPhieuThuTien application)
        {
            _application = application;
        }
        
        public int Them(PhieuThuTienDTO pPhieuThuTien)
        {
            var config = new MapperConfiguration(cfg =>
                   cfg.CreateMap<PhieuThuTienDTO, PhieuThuTien>()
               );
            var mapper = new Mapper(config);
            var empDTO = mapper.Map<PhieuThuTien>(pPhieuThuTien);

            return _application.Them(empDTO);
        }
        
        public int Xoa(string pMa)
        {
            return _application.Xoa(pMa);
        }
        
        public int Sua(PhieuThuTienDTO pPhieuThuTien, string idx)
        {
            var config = new MapperConfiguration(cfg =>
                  cfg.CreateMap<PhieuThuTienDTO, PhieuThuTien>()
              );
            var mapper = new Mapper(config);
            var empDTO = mapper.Map<PhieuThuTien>(pPhieuThuTien);

            return _application.Sua(empDTO, idx);
        }
        
        public DataTable Get_PhieuThuTien()
        {
            return _application.Get_PhieuThuTien();
        }
    }
}

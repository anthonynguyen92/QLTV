using Application.NhanViens;
using AutoMapper;
using BUS.DTO;
using EntityDb.Entities;
using System.Data;

namespace BUS.NhanVienService
{
    public class BUS_NhanVien : IBUS_NhanVien
    {
        private readonly IApplicationNhanviens _application;
       
        public BUS_NhanVien(IApplicationNhanviens application)
        {
            _application = application;
        }

        
        public int Them(NhanVienDTO pNhanVien)
        {
            var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<NhanVienDTO, NhanVien>()
                );
            var mapper = new Mapper(config);
            var empDTO = mapper.Map<NhanVien>(pNhanVien);

            return _application.Them(empDTO);
        }
        
        public int Xoa(string pMa)
        {
            return _application.Xoa(pMa);
        }
        
        public int Sua(NhanVienDTO pNhanVien, string idx)
        {
            var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<NhanVienDTO, NhanVien>()
                );
            var mapper = new Mapper(config);
            var empDTO = mapper.Map<NhanVien>(pNhanVien);
            return _application.Sua(empDTO, idx);
        }
        
        public DataTable Get_NhanVien()
        {
            return _application.Get_NhanVien();
        }
    }
}

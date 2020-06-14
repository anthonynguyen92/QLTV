using Application.PhieuMuonSachs;
using AutoMapper;
using BUS.DTO;
using EntityDb.Entities;
using System.Data;

namespace BUS.PhieuMuonSachService
{
    public class BUS_PhieuMuonSach : IBUS_PhieuMuonSach
    {
        private readonly IApplicationPhieuMuonSachs _application;
        
        public BUS_PhieuMuonSach(IApplicationPhieuMuonSachs application)
        {
            _application = application;
        }
        
        public int Them(PhieuMuonSachDTO pPhieuMuonSach)
        {
            var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<PhieuMuonSachDTO, PhieuMuonSach>()
                );
            var mapper = new Mapper(config);
            var empDTO = mapper.Map<PhieuMuonSach>(pPhieuMuonSach);

            return _application.Them(empDTO);
        }
        
        public int ThemNgayTra(string pMa, string pNgayTra)
        {
            return _application.ThemNgayTra(pMa, pNgayTra);
        }
        
        public int Xoa(string pMa)
        {
            return _application.Xoa(pMa);
        }
        
        public int Sua(PhieuMuonSachDTO pPhieuMuonSach, string idx)
        {
            var config = new MapperConfiguration(cfg =>
                   cfg.CreateMap<PhieuMuonSachDTO, PhieuMuonSach>()
               );
            var mapper = new Mapper(config);
            var empDTO = mapper.Map<PhieuMuonSach>(pPhieuMuonSach);

            return _application.Sua(empDTO, idx);
        }
        
        public DataTable Get_PhieuMuonSach()
        {
            return _application.Get_PhieuMuonSach();
        }
        
        public int Get_MaCuoi()
        {
            return _application.Get_MaCuoi();
        }
    }
}

using Application.ChiTietPhieuMuons;
using AutoMapper;
using BUS.DTO;
using EntityDb.Entities;
using System.Data;

namespace BUS.ChiTietPhieuMuonService
{
    public class BUS_ChiTietPhieuMuon:IBUS_ChiTietPhieuMuon
    {
        private readonly IApplicationChiTietPhieuMuon _application;
       
        public BUS_ChiTietPhieuMuon(IApplicationChiTietPhieuMuon application)
        {
            _application = application;
        }

        public int Them(ChiTietPhieuMuonDTO pChiTietPhieuMuon)
        {
            var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<ChiTietPhieuMuonDTO, ChiTietPhieuMuon>()
                );
            var mapper = new Mapper(config);
            var empDTO = mapper.Map<ChiTietPhieuMuon>(pChiTietPhieuMuon);

            return _application.Them(empDTO);
        }
        
        public DataTable Get_NhanVien()
        {
            return _application.Get_ChiTietPhieuMuon();
        }
    }
}

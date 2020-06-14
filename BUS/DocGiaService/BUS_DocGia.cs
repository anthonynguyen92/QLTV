using Application.DocGias;
using AutoMapper;
using BUS.DTO;
using EntityDb.Entities;
using System.Data;

namespace BUS.DocGiaService
{
    public class BUS_DocGia : IBUS_DocGia
    {
        private readonly IApplicationDocGia _application;
        
        public BUS_DocGia(IApplicationDocGia application)
        {
            _application = application;
        }
        
        public int Them(DocGiaDTO pDocGia)
        {
            var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<DocGiaDTO, DocGia>()
                );
            var mapper = new Mapper(config);
            var empDTO = mapper.Map<DocGia>(pDocGia);

            return _application.Them(empDTO);
        }
        
        public int Xoa(string pMa)
        {
            return _application.Xoa(pMa);
        }
        
        public int Sua(DocGiaDTO pDocGia, string idx)
        {
            var config = new MapperConfiguration(cfg =>
                   cfg.CreateMap<DocGiaDTO, DocGia>()
               );
            var mapper = new Mapper(config);
            var empDTO = mapper.Map<DocGia>(pDocGia);
            return _application.Sua(empDTO, idx);
        }
        
        public DataTable Get_DocGia()
        {
            return _application.Get_DocGia();
        }
        
        public int Get_MaDocGia(string pHoTenDocGia)
        {
            return _application.Get_MaDocGia(pHoTenDocGia);
        }
        
        public string Get_TenDocGia(string pMa)
        {
            return _application.Get_TenDocGia(pMa);
        }
    }
}

using Application.Sachs;
using AutoMapper;
using BUS.DTO;
using EntityDb.Entities;
using System.Data;

namespace BUS.SachService
{
    public class BUS_Sach : IBUS_Sach
    {
        private readonly IApplicastionSach _application;
        
        public BUS_Sach(IApplicastionSach application)
        {
            _application = application;

        }
        
        public int Them(SachDTO pSach)
        {
            var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<SachDTO, Sach>()
                );
            var mapper = new Mapper(config);
            var empDTO = mapper.Map<Sach>(pSach);

            return _application.Them(empDTO);
        }
        
        public int Xoa(string pMa)
        {
            return _application.Xoa(pMa);
        }
        
        public int Sua(SachDTO pSach, string idx)
        {
            var config = new MapperConfiguration(cfg =>
                  cfg.CreateMap<SachDTO, Sach>()
              );
            var mapper = new Mapper(config);
            var empDTO = mapper.Map<Sach>(pSach);
            return _application.Sua(empDTO, idx);
        }
        
        public DataTable Get_Sach()
        {
            return _application.Get_Sach();
        }
    }
}

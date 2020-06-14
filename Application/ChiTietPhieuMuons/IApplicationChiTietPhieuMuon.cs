using EntityDb.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Application.ChiTietPhieuMuons
{
    public interface IApplicationChiTietPhieuMuon
    {
        DataTable Get_ChiTietPhieuMuon();
        int Them(ChiTietPhieuMuon pChiTietPhieuMuon);
    }
}

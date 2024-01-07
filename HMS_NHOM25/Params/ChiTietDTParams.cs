using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_NHOM25.Params
{
    internal class ChiTietDTParams
    {
        private object _maThuoc;
        private string _soLuong;
        private string _lieuDung;
        private string _moTa;

        public ChiTietDTParams(object maThuoc, string soLuong, string lieuDung, string moTa)
        {
            MaThuoc = maThuoc;
            SoLuong = soLuong;
            LieuDung = lieuDung;
            MoTa = moTa;
        }

        public object MaThuoc { get => _maThuoc; set => _maThuoc = value; }
        public string SoLuong { get => _soLuong; set => _soLuong = value; }
        public string LieuDung { get => _lieuDung; set => _lieuDung = value; }
        public string MoTa { get => _moTa; set => _moTa = value; }
    }
}

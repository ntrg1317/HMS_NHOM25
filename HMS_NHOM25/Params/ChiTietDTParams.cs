using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_NHOM25.Params
{
    internal class ChiTietDTParams
    {
        private string _maBn;
        private object _maThuoc;
        private string _soLuong;
        private string _lieuDung;
        private string _loiDan;

        public ChiTietDTParams(string maBN, object maThuoc, string soLuong, string lieuDung, string loiDan = null)
        {
            MaBN = maBN;
            MaThuoc = maThuoc;
            SoLuong = soLuong;
            LieuDung = lieuDung;
            LoiDan = loiDan;
        }

        public string MaBN { get => _maBn; set => _maBn = value; }
        public object MaThuoc { get => _maThuoc; set => _maThuoc = value; }
        public string SoLuong { get => _soLuong; set => _soLuong = value; }
        public string LieuDung { get => _lieuDung; set => _lieuDung = value; }
        public string LoiDan { get => _loiDan; set => _loiDan = value; }
    }
}

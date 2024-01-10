using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_NHOM25.Params
{
    internal class BenhNhan_LichSuParams
    {
        private string _maBN;
        private string _maPhong;
        private string _ngayVao;
        private string _benhTrang;

        public BenhNhan_LichSuParams(string maBN, string maPhong, string ngayVao, string benhTrang)
        {
            _maBN = maBN;
            _maPhong = maPhong;
            _ngayVao = ngayVao;
            _benhTrang = benhTrang;
        }

        public string MaBN { get => _maBN; set => _maBN = value; }
        public string MaPhong { get => _maPhong; set => _maPhong = value; }
        public string NgayVao { get => _ngayVao; set => _ngayVao = value; }
        public string BenhTrang { get => _benhTrang; set => _benhTrang = value; }
    }
}

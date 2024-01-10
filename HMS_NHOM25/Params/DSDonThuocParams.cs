using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_NHOM25.Params
{
    internal class DSDonThuocParams
    {
        private string _maDT;
        private string _maBN;
        private string _ngayKeDon;

        public DSDonThuocParams(string maDT, string maBN, string ngayKeDon)
        {
            MaDT = maDT;
            MaBN = maBN;
            NgayKeDon = ngayKeDon;
        }

        public string MaDT { get => _maDT; set => _maDT = value; }
        public string MaBN { get => _maBN; set => _maBN = value; }
        public string NgayKeDon { get => _ngayKeDon; set => _ngayKeDon = value; }
    }
}

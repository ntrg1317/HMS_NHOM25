using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_NHOM25.Params
{
    internal class TaiKhoanParams
    {
        private string _tenDN;
        private string _matKhau;

        public TaiKhoanParams(string tenDN, string matKhau)
        {
            TenDN = tenDN;
            MatKhau = matKhau;
        }
        public string TenDN { get => _tenDN; set => _tenDN = value; }
        public string MatKhau { get => _matKhau; set => _matKhau = value; }
    }
}

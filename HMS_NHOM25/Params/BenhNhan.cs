using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_NHOM25.Params
{
    class BenhNhan
    {
        private string _tenBN;
        private object _maPhong;
        private string _ngaySinh;
        private string _ngayVao;
        private string _gioiTinh;
        private string _benhTrang;
        private string _sdt;
        private string _diaChi;
        private string _sdtNguoiThan;
        private string _trangThai;

        private string _tenDN;
        private string _matKhau;

        public BenhNhan()
        {
        }

        public BenhNhan(string tenBN, object maPhong, string ngaySinh, string ngayVao, string gioiTinh, string benhTrang, string sdt, string diaChi, string sdtNguoiThan, string trangThai = null, string tenDN = null, string matKhau = null)
        {
            _tenBN = tenBN;
            _maPhong = maPhong;
            _ngaySinh = ngaySinh;
            _ngayVao = ngayVao;
            _gioiTinh = gioiTinh;
            _benhTrang = benhTrang;
            _sdt = sdt;
            _diaChi = diaChi;
            _sdtNguoiThan = sdtNguoiThan;
            _trangThai = trangThai;

            _tenDN = tenDN;
            _matKhau = matKhau;
        }

        public string TenBN { get => _tenBN; set => _tenBN = value; }
        public string NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string NgayVao { get => _ngayVao; set => _ngayVao = value; }
        public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public string BenhTrang { get => _benhTrang; set => _benhTrang = value; }
        public string Sdt { get => _sdt; set => _sdt = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string SdtNguoiThan { get => _sdtNguoiThan; set => _sdtNguoiThan = value; }
        public string TenDN { get => _tenDN; set => _tenDN = value; }
        public string MatKhau { get => _matKhau; set => _matKhau = value; }
        public object MaPhong { get => _maPhong; set => _maPhong = value; }
        public string TrangThai { get => (_trangThai == "Hoạt động") ? "1" : "0"; set => _trangThai = value; }
    }
}

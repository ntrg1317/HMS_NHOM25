namespace HMS_NHOM25.Params
{
    class BenhNhan
    {
        private string _tenBN;
        private string _ngaySinh;
        private string _gioiTinh;
        private string _sdt;
        private string _diaChi;
        private string _sdtNguoiThan;
        private string _trangThai;

        private string _tenDN;
        private string _matKhau;

        public BenhNhan()
        {
        }

        public BenhNhan(string tenBN, string ngaySinh, string gioiTinh, string sdt, string diaChi, string sdtNguoiThan = null, string trangThai = null, string tenDN = null, string matKhau = null)
        {
            _tenBN = tenBN;
            _ngaySinh = ngaySinh;
            _gioiTinh = gioiTinh;
            _sdt = sdt;
            _diaChi = diaChi;
            _sdtNguoiThan = sdtNguoiThan;
            _trangThai = trangThai;

            _tenDN = tenDN;
            _matKhau = matKhau;
        }

        public string TenBN { get => _tenBN; set => _tenBN = value; }
        public string NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public string Sdt { get => _sdt; set => _sdt = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string SdtNguoiThan { get => _sdtNguoiThan; set => _sdtNguoiThan = value; }
        public string TenDN { get => _tenDN; set => _tenDN = value; }
        public string MatKhau { get => _matKhau; set => _matKhau = value; }
        public string TrangThai { get => (_trangThai == "Hoạt động") ? "1" : "0"; set => _trangThai = value; }
    }
}

namespace HMS_NHOM25.Params
{
    internal class BacSi
    {
        private string _tenBS;
        private string _ngaySinh;
        private string _gioiTinh;
        private string _sdt;
        private string _diaChi;
        private string _chuyenMon;
        private string _bangCap;
        private string _tenDNBS;
        private string _matKhauBS;
        private string _trangThai;

        public BacSi(string tenBS, string ngaySinh, string gioiTinh, string sdt, string diaChi, string chuyenMon, string bangCap, string tenDNBS = null, string matKhauBS = null, string trangThai = null)
        {
            _tenBS = tenBS;
            _ngaySinh = ngaySinh;
            _gioiTinh = gioiTinh;
            _sdt = sdt;
            _diaChi = diaChi;
            _chuyenMon = chuyenMon;
            _bangCap = bangCap;
            _tenDNBS = tenDNBS;
            _matKhauBS = matKhauBS;
            _trangThai = trangThai;
        }

        public string TenBS { get => _tenBS; set => _tenBS = value; }
        public string NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public string Sdt { get => _sdt; set => _sdt = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string ChuyenMon { get => _chuyenMon; set => _chuyenMon = value; }
        public string BangCap { get => _bangCap; set => _bangCap = value; }
        public string TenDNBS { get => _tenDNBS; set => _tenDNBS = value; }
        public string MatKhauBS { get => _matKhauBS; set => _matKhauBS = value; }
        public string TrangThai { get => (_trangThai == "Hoạt động") ? "1" : "0"; set => _trangThai = value; }
    }
}

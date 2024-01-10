namespace HMS_NHOM25.Params
{
    internal class DuocSiParams
    {
        private string _tenNV;
        private string _ngaySinh;
        private string _gioiTinh;
        private string _sdt;
        private string _diaChi;
        private string _tenDN;
        private string _matKhau;
        private string _trangThai;

        public DuocSiParams(string tenNV, string ngaySinh, string gioiTinh, string sdt, string diaChi, string tenDN = null, string matKhau = null, string trangThai = null)
        {
            _tenNV = tenNV;
            _ngaySinh = ngaySinh;
            _gioiTinh = gioiTinh;
            _sdt = sdt;
            _diaChi = diaChi;
            _tenDN = tenDN;
            _matKhau = matKhau;
            _trangThai = trangThai;
        }

        public string TenNV { get => _tenNV; set => _tenNV = value; }
        public string NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public string Sdt { get => _sdt; set => _sdt = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string TenDN { get => _tenDN; set => _tenDN = value; }
        public string MatKhau { get => _matKhau; set => _matKhau = value; }
        public string TrangThai { get => _trangThai; set => _trangThai = value; }
    }
}

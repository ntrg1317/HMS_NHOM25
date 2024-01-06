namespace HMS_NHOM25.Params
{
    internal class NVThuNganParams
    {
        private string _tenNV;
        private string _ngaySinh;
        private string _gioiTinh;
        private string _sdt;
        private string _diaChi;
        private string _trangThai;

        private string _tenDN;
        private string _matKhau;

        public NVThuNganParams(string tenNV, string ngaySinh, string gioiTinh, string sdt, string diaChi, string trangThai, string tenDN = null, string matKhau = null)
        {
            TenNV = tenNV;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            Sdt = sdt;
            DiaChi = diaChi;
            TrangThai = trangThai;

            TenDN = tenDN;
            MatKhau = matKhau;
        }

        public string TenNV { get => _tenNV; set => _tenNV = value; }
        public string NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public string Sdt { get => _sdt; set => _sdt = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string TrangThai { get => (_trangThai == "Hoạt động") ? "1" : "0"; set => _trangThai = value; }
        public string TenDN { get => _tenDN; set => _tenDN = value; }
        public string MatKhau { get => _matKhau; set => _matKhau = value; }
    }
}

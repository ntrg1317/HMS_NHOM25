namespace HMS_NHOM25.Params
{
    internal class PhongParams
    {
        private string _tenPhong;
        private string _soLuong;
        private string _tienPhong;

        public PhongParams(string tenPhong, string soLuong, string tienPhong)
        {
            TenPhong = tenPhong;
            SoLuong = soLuong;
            TienPhong = tienPhong;
        }

        public string TenPhong { get => _tenPhong; set => _tenPhong = value; }
        public string SoLuong { get => _soLuong; set => _soLuong = value; }
        public string TienPhong { get => _tienPhong; set => _tienPhong = value; }
    }
}

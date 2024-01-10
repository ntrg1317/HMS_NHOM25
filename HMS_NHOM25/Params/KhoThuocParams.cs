namespace HMS_NHOM25.Params
{
    internal class KhoThuocParams
    {
        private string _tenThuoc;
        private string _soLuong;
        private string _nsx;
        private string _hsd;
        private string _tienThuoc;

        public KhoThuocParams(string tenThuoc, string soLuong, string nsx, string hsd, string tienThuoc)
        {
            TenThuoc = tenThuoc;
            SoLuong = soLuong;
            NSX = nsx;
            HSD = hsd;
            TienThuoc = tienThuoc;
        }

        public string TenThuoc { get => _tenThuoc; set => _tenThuoc = value; }
        public string SoLuong { get => _soLuong; set => _soLuong = value; }
        public string NSX { get => _nsx; set => _nsx = value; }
        public string HSD { get => _hsd; set => _hsd = value; }
        public string TienThuoc { get => _tienThuoc; set => _tienThuoc = value; }
    }
}

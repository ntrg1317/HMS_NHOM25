namespace HMS_NHOM25.Params
{
    internal class DichVuParams
    {
        private string _tenDV;
        private string _tienDV;
        private string _ngayDung;

        public DichVuParams(string tenDV, string tienDV, string ngayDung = null)
        {
            TenDV = tenDV;
            TienDV = tienDV;
            NgayDung = ngayDung;
        }
        public string TenDV { get => _tenDV; set => _tenDV = value; }
        public string TienDV { get => _tienDV; set => _tienDV = value; }
        public string NgayDung { get => _ngayDung; set => _ngayDung = value; }
    }
}

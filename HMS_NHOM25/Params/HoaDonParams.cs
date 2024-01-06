namespace HMS_NHOM25.Params
{
    internal class HoaDonParams
    {
        private string _maBS;
        private string _ngayTT;
        private string _tongTien;

        public HoaDonParams(string maBS, string ngayTT, string tongTien)
        {
            MaBS = maBS;
            NgayTT = ngayTT;
            TongTien = tongTien;
        }

        public string MaBS { get => _maBS; set => _maBS = value; }
        public string NgayTT { get => _ngayTT; set => _ngayTT = value; }
        public string TongTien { get => _tongTien; set => _tongTien = value; }
    }
}

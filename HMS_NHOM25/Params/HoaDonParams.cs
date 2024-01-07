namespace HMS_NHOM25.Params
{
    internal class HoaDonParams
    {
        private string _maBN;
        private string _ngayTT;
        private string _tongTien;

        public HoaDonParams(string maBN, string ngayTT, string tongTien)
        {
            MaBN = maBN;
            NgayTT = ngayTT;
            TongTien = tongTien;
        }

        public string MaBN { get => _maBN; set => _maBN = value; }
        public string NgayTT { get => _ngayTT; set => _ngayTT = value; }
        public string TongTien { get => _tongTien; set => _tongTien = value; }
    }
}

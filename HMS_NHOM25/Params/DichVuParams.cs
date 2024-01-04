using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_NHOM25.Params
{
    internal class DichVuParams
    {
        private string _tenDV;
        private string _tienDV;

        public DichVuParams(string tenDV, string tienDV)
        {
            TenDV = tenDV;
            TienDV = tienDV;
        }
        public string TenDV { get => _tenDV; set => _tenDV = value; }
        public string TienDV { get => _tienDV; set => _tienDV = value; }
    }
}

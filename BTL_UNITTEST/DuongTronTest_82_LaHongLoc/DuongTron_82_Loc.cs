using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongTronTest_82_Loc
{
   public  class DuongTron_82_Loc
    {
        public Diem_82_Loc TrungDiem_82_Loc { get; set; }
        public double BanKinh_82_Loc { get; set; }

        public DuongTron_82_Loc(Diem_82_Loc O, double R)
        {
            if (R >= 0)
            {
                this.TrungDiem_82_Loc = O;
                this.BanKinh_82_Loc = R;
            }
            else throw new KhongPhaiDuongTron_Exception_82_Loc();
        }
    }
}

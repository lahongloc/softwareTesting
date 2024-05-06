using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongTronTest_82_Loc
{
    public class KiemTra_82_Loc
    {
        public DuongTron_82_Loc DuongTron_82_Loc;
        public Diem_82_Loc Diem_82_Loc;

        public KiemTra_82_Loc() { }
        public KiemTra_82_Loc(double Ox, double Oy, double R, double Mx, double My)
        {
            this.DuongTron_82_Loc = new DuongTron_82_Loc(new Diem_82_Loc(Ox, Oy), R);
            this.Diem_82_Loc = new Diem_82_Loc(Mx, My);
        }

        public static double TinhKhoangCach_82_Loc(Diem_82_Loc d1_82_Loc, Diem_82_Loc d2_82_Loc)
        {
            double KhoangCach_82_Loc = Math.Round(
                Math.Sqrt(Math.Pow(d1_82_Loc.x_82_Loc - d2_82_Loc.x_82_Loc, 2) + 
                Math.Pow(d1_82_Loc.y_82_Loc - d2_82_Loc.y_82_Loc, 2)), 2);

            return KhoangCach_82_Loc;
        }


        public ViTri_Enum_82_Loc KiemTraViTri_82_Loc()
        { 
            double KhoangCach_82_LaHongLoc = 
                KiemTra_82_Loc.TinhKhoangCach_82_Loc(this.Diem_82_Loc, this.DuongTron_82_Loc.TrungDiem_82_Loc);

            if (KhoangCach_82_LaHongLoc < this.DuongTron_82_Loc.BanKinh_82_Loc)
                return ViTri_Enum_82_Loc.Trong_82_Loc;
            else if (KhoangCach_82_LaHongLoc > this.DuongTron_82_Loc.BanKinh_82_Loc)
                return ViTri_Enum_82_Loc.Ngoai_82_Loc;
            else return ViTri_Enum_82_Loc.Tren_82_Loc;
        }

    }
}

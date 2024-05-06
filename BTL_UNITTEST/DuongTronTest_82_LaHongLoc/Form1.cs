using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuongTronTest_82_Loc
{
    public partial class _82_Loc : Form
    {
        public _82_Loc()
        {
            InitializeComponent();
        }

        private void btn_kiemTra_82_Loc_Click(object sender, EventArgs e)
        {
            try
            {
                double Ox_82_Loc = double.Parse(txt_Ox_82_Loc.Text);
                double Oy_82_Loc = double.Parse(txt_Oy_82_Loc.Text);

                double R_82_Loc = double.Parse(txt_R_82_Loc.Text);

                double Mx_82_Loc = double.Parse(txt_Mx_82_Loc.Text);
                double My_82_Loc = double.Parse(txt_My_82_Loc.Text);

                KiemTra_82_Loc KiemTra =
                    new KiemTra_82_Loc(Ox_82_Loc, Oy_82_Loc,
                    R_82_Loc, Mx_82_Loc, My_82_Loc);


                txt_Kq_82_Loc.Text = KiemTra.KiemTraViTri_82_Loc().ToString();
            }
            catch (Exception ex)
            {
                txt_Kq_82_Loc.Text = ex.Message.ToString();
            }
        }

        private void btn_tinhKC_82_Loc_Click(object sender, EventArgs e)
        {
            try
            {
                double Ox_82_Loc = double.Parse(txt_Ox_82_Loc.Text);
                double Oy_82_Loc = double.Parse(txt_Oy_82_Loc.Text);
                Diem_82_Loc O_82_Loc = new Diem_82_Loc(Ox_82_Loc, Oy_82_Loc);

                double Mx_82_Loc = double.Parse(txt_Mx_82_Loc.Text);
                double My_82_Loc = double.Parse(txt_My_82_Loc.Text);
                Diem_82_Loc M_82_Loc = new Diem_82_Loc(Mx_82_Loc, My_82_Loc);

                txt_PT_82_Loc.Text = 
                    KiemTra_82_Loc.TinhKhoangCach_82_Loc(M_82_Loc, O_82_Loc).ToString();
            }
            catch (Exception ex)
            {
                txt_PT_82_Loc.Text = ex.Message.ToString();
            }
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DuongTronTest_82_Loc;

namespace KiemTraViTri_UnitTest_82_Loc
{
    [TestClass]
    public class UnitTest1
    {
        private KiemTra_82_Loc KiemTra_82_Loc;
        public TestContext TestContext { get; set; }
        [TestInitialize]
        public void SetUp()
        {
            KiemTra_82_Loc = new KiemTra_82_Loc();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\TinhKhoangCachData.csv", "TinhKhoangCachData#csv", DataAccessMethod.Sequential)]
        public void TinhKhoangCach_82_Loc_Test()
        {
            double Ox_82_Loc, Oy_82_Loc, Mx_82_Loc, My_82_Loc;
            double expected, actual;

            Ox_82_Loc = double.Parse(TestContext.DataRow[0].ToString());
            Oy_82_Loc = double.Parse(TestContext.DataRow[1].ToString());
            Diem_82_Loc O_82_Loc = new Diem_82_Loc(Ox_82_Loc, Oy_82_Loc);

            Mx_82_Loc = double.Parse(TestContext.DataRow[2].ToString());
            My_82_Loc = double.Parse(TestContext.DataRow[3].ToString());
            Diem_82_Loc M_82_Loc = new Diem_82_Loc(Mx_82_Loc, My_82_Loc);

            expected = double.Parse(TestContext.DataRow[4].ToString());

            actual = KiemTra_82_Loc.TinhKhoangCach_82_Loc(M_82_Loc, O_82_Loc);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\KiemTraVTData.csv", "KiemTraVTData#csv", DataAccessMethod.Sequential)]
        public void KiemTraViTri_Test_82_Loc()
        {
            double Ox_82_Loc, Oy_82_Loc, R_82_Loc, Mx_82_Loc, My_82_Loc;
            ViTri_Enum_82_Loc expected, actual;

            Ox_82_Loc = double.Parse(TestContext.DataRow[0].ToString());
            Oy_82_Loc = double.Parse(TestContext.DataRow[1].ToString());
            R_82_Loc = double.Parse(TestContext.DataRow[2].ToString());
            Mx_82_Loc = double.Parse(TestContext.DataRow[3].ToString());
            My_82_Loc = double.Parse(TestContext.DataRow[4].ToString());

            expected = (ViTri_Enum_82_Loc)Enum.Parse(typeof(ViTri_Enum_82_Loc), TestContext.DataRow[5].ToString());

            KiemTra_82_Loc =
                new KiemTra_82_Loc(Ox_82_Loc, Oy_82_Loc, R_82_Loc, Mx_82_Loc, My_82_Loc);

            actual = KiemTra_82_Loc.KiemTraViTri_82_Loc();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(KhongPhaiDuongTron_Exception_82_Loc))]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\KhongPhaiDuongTronExData.csv", "KhongPhaiDuongTronExData#csv", DataAccessMethod.Sequential)]
        public void KiemTraViTriException_Test_82_Loc()
        {
            double Ox_82_Loc, Oy_82_Loc, R_82_Loc, Mx_82_Loc, My_82_Loc;
            Ox_82_Loc = double.Parse(TestContext.DataRow[0].ToString());
            Oy_82_Loc = double.Parse(TestContext.DataRow[1].ToString());
            R_82_Loc = double.Parse(TestContext.DataRow[2].ToString());
            Mx_82_Loc = double.Parse(TestContext.DataRow[3].ToString());
            My_82_Loc = double.Parse(TestContext.DataRow[4].ToString());

            KiemTra_82_Loc  =
                new KiemTra_82_Loc(Ox_82_Loc, Oy_82_Loc, R_82_Loc, Mx_82_Loc, My_82_Loc);
            ViTri_Enum_82_Loc VT_82_Loc = KiemTra_82_Loc.KiemTraViTri_82_Loc();
        }
    }
}

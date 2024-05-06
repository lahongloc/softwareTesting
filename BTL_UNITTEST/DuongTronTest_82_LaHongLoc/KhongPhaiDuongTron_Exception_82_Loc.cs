using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongTronTest_82_Loc
{
    public class KhongPhaiDuongTron_Exception_82_Loc : Exception
    {
        public KhongPhaiDuongTron_Exception_82_Loc() : base("Đây không phải đường tròn(R < 0)!") { }
        public KhongPhaiDuongTron_Exception_82_Loc(string message) : base(message) { }
    }
}

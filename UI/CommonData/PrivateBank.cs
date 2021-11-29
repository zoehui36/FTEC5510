using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.CommonData
{
    public class PrivateBank
    {
    }
    public class ConversionRecord
    {
        public int ConversionID { get; set; }
        public string AccountNumber { get; set; }
        public DateTime ConvertTime { get; set; }
        public float ConvertAmount { get; set; }
        public bool ConvertECNY { get; set; }
        public string Remark { get; set; }

    }

    public class AccountInfo
    {
        public string AccountNumber { get; set; }
        public string CustomerID { get; set; }
        public int Balance { get; set; }
    }
}

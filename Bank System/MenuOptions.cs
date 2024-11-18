using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public class MenuOptions
    {
        public static Dictionary<int, string> Options = new Dictionary<int, string>
        {
            {1, "Balance Iquiry" },
            {2, "Cash Deposit" },
            {3, "Withdrawal" },
            {4, "Third Party Transfer" },
            {5, "Transactions" },
            {6, "Logout" }
        };
    }
}

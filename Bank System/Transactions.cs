using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace System{

    public class Transactions{

        public string Type  {get; set;}
        public double Amount { get; set;}
        public DateTime Date { get; set;}
        public double BalanceAfter {get;set;}

    }
}
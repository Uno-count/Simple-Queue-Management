using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;

namespace Queue_Management_Ortega
{
    class CashierClass
    {
        private int x;
        public static string getNumberInQueue = "";
        public static Queue<string> CashierQueue;
        public CashierClass()
        {
            x = 1000;
            CashierQueue = new Queue<string>();
        }

        public string CashierGenerateNumber(string CashierNumber)
        {
            x++;
            CashierNumber = CashierNumber + x.ToString();
            return CashierNumber;
        }
    }
}

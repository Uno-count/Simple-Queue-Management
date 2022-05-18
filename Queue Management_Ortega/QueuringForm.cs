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
    public partial class QueuringForm : Form
    {
        CashierClass cashier = new CashierClass();
     
        public QueuringForm()
        {
            InitializeComponent();
        }

        private void QueuringForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGenerateNumber("R - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            CashierWindowQueueForm cashierWindow = new CashierWindowQueueForm();
            cashierWindow.OpenCashier();
        }

        private void lblQueue_Click(object sender, EventArgs e)
        {

        }
    }
}

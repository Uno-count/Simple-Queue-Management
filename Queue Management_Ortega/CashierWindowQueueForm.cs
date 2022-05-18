using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Queue_Management_Ortega
{
    public partial class CashierWindowQueueForm : Form
    {
        
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = (1 * 100);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        Boolean openForm = false;
        VIewForm view = new VIewForm();
        FormCollection Allforms = Application.OpenForms;
        Form OpenedForm = new Form();
        

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);

        }

       

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());

            }
        }

        public delegate void PassControl(object sender);
        public PassControl passControl;

        public void OpenCashier()
        {
            if (openForm == false)
            {
                CashierWindowQueueForm cashierWindow = new CashierWindowQueueForm();
                cashierWindow.Visible = true;
                openForm = true;
            }
        }
        private void btnxt_Click(object sender, EventArgs e)
        {
            NextServing();
            
        }


        public void NextServing()
        {
            foreach (Form form in Allforms)

            {
                if (form.Name == "CustomerView")
                {
                    OpenedForm = form;
                    openForm = true;

                }


            }
            if (openForm == true)
            {
                if (passControl != null)
                {
                    view.lblNowServing.Text = CashierClass.CashierQueue.Peek();
                    CashierClass.CashierQueue.Dequeue();
                    passControl(view.lblNowServing);
                }

            }
            else
            {
                view.ShowDialog();
                view.lblNowServing.Text = CashierClass.CashierQueue.Peek().ToString();
                CashierClass.CashierQueue.Dequeue();
            } 


            
        }

       
    }
}

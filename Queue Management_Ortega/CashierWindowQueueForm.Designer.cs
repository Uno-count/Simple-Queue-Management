namespace Queue_Management_Ortega
{
    partial class CashierWindowQueueForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierWindowQueueForm));
            this.listCashierQueue = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnxt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listCashierQueue
            // 
            this.listCashierQueue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listCashierQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCashierQueue.FormattingEnabled = true;
            this.listCashierQueue.ItemHeight = 42;
            this.listCashierQueue.Location = new System.Drawing.Point(337, 13);
            this.listCashierQueue.Margin = new System.Windows.Forms.Padding(4);
            this.listCashierQueue.Name = "listCashierQueue";
            this.listCashierQueue.Size = new System.Drawing.Size(301, 336);
            this.listCashierQueue.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(451, 227);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(141, 63);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Visible = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnxt
            // 
            this.btnxt.BackColor = System.Drawing.Color.Tomato;
            this.btnxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxt.ForeColor = System.Drawing.Color.White;
            this.btnxt.Location = new System.Drawing.Point(60, 236);
            this.btnxt.Margin = new System.Windows.Forms.Padding(4);
            this.btnxt.Name = "btnxt";
            this.btnxt.Size = new System.Drawing.Size(162, 85);
            this.btnxt.TabIndex = 2;
            this.btnxt.Text = "NEXT";
            this.btnxt.UseVisualStyleBackColor = false;
            this.btnxt.Click += new System.EventHandler(this.btnxt_Click);
            // 
            // CashierWindowQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 453);
            this.Controls.Add(this.btnxt);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.listCashierQueue);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CashierWindowQueueForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierWindowQueueForm";
            this.Load += new System.EventHandler(this.CashierWindowQueueForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listCashierQueue;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnxt;
    }
}
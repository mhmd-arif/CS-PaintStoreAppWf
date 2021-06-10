
namespace PaintStoreManagerCatMan.Forms
{
    partial class FmMainCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMainCashier));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Logout = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Btn_History = new System.Windows.Forms.Button();
            this.Btn_Cart = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.Btn_Logout);
            this.panel1.Controls.Add(this.Btn_History);
            this.panel1.Controls.Add(this.Btn_Cart);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 681);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Logout
            // 
            this.Btn_Logout.ActiveBorderThickness = 1;
            this.Btn_Logout.ActiveCornerRadius = 20;
            this.Btn_Logout.ActiveFillColor = System.Drawing.Color.DarkOrange;
            this.Btn_Logout.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_Logout.ActiveLineColor = System.Drawing.Color.DarkOrange;
            this.Btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            this.Btn_Logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Logout.BackgroundImage")));
            this.Btn_Logout.ButtonText = "Logout";
            this.Btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Logout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Logout.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_Logout.IdleBorderThickness = 1;
            this.Btn_Logout.IdleCornerRadius = 20;
            this.Btn_Logout.IdleFillColor = System.Drawing.Color.Red;
            this.Btn_Logout.IdleForecolor = System.Drawing.Color.White;
            this.Btn_Logout.IdleLineColor = System.Drawing.Color.Red;
            this.Btn_Logout.Location = new System.Drawing.Point(5, 622);
            this.Btn_Logout.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Logout.Name = "Btn_Logout";
            this.Btn_Logout.Size = new System.Drawing.Size(187, 45);
            this.Btn_Logout.TabIndex = 7;
            this.Btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Logout.Click += new System.EventHandler(this.Btn_Logout_Click);
            // 
            // Btn_History
            // 
            this.Btn_History.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_History.FlatAppearance.BorderSize = 0;
            this.Btn_History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_History.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_History.ForeColor = System.Drawing.Color.White;
            this.Btn_History.Location = new System.Drawing.Point(0, 165);
            this.Btn_History.Name = "Btn_History";
            this.Btn_History.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_History.Size = new System.Drawing.Size(200, 65);
            this.Btn_History.TabIndex = 1;
            this.Btn_History.Text = "Reports";
            this.Btn_History.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_History.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_History.UseVisualStyleBackColor = true;
            this.Btn_History.Click += new System.EventHandler(this.Btn_History_Click);
            // 
            // Btn_Cart
            // 
            this.Btn_Cart.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Cart.FlatAppearance.BorderSize = 0;
            this.Btn_Cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cart.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cart.ForeColor = System.Drawing.Color.White;
            this.Btn_Cart.Location = new System.Drawing.Point(0, 100);
            this.Btn_Cart.Name = "Btn_Cart";
            this.Btn_Cart.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_Cart.Size = new System.Drawing.Size(200, 65);
            this.Btn_Cart.TabIndex = 0;
            this.Btn_Cart.Text = "Cart";
            this.Btn_Cart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cart.UseVisualStyleBackColor = true;
            this.Btn_Cart.Click += new System.EventHandler(this.Btn_Cart_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.Lbl_Title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 100);
            this.panel2.TabIndex = 1;
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Location = new System.Drawing.Point(465, 38);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(152, 23);
            this.Lbl_Title.TabIndex = 1;
            this.Lbl_Title.Text = "Cashier Control";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1084, 581);
            this.panelDesktop.TabIndex = 2;
            // 
            // FmMainCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 681);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FmMainCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page Cashier";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button Btn_Cart;
        private System.Windows.Forms.Button Btn_History;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Logout;
        private System.Windows.Forms.Label Lbl_Title;
    }
}
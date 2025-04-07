namespace InventryManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.customerButton1 = new InventryManagementSystem.CustomerButton();
            this.customerButton2 = new InventryManagementSystem.CustomerButton();
            this.customerButton3 = new InventryManagementSystem.CustomerButton();
            this.customerButton4 = new InventryManagementSystem.CustomerButton();
            this.customerButton5 = new InventryManagementSystem.CustomerButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.customerButton5);
            this.panel1.Controls.Add(this.customerButton4);
            this.panel1.Controls.Add(this.customerButton3);
            this.panel1.Controls.Add(this.customerButton2);
            this.panel1.Controls.Add(this.customerButton1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 115);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "pack";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 63);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 595);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 16);
            this.panel2.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 115);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(984, 480);
            this.panelMain.TabIndex = 2;
            // 
            // customerButton1
            // 
            this.customerButton1.Image = ((System.Drawing.Image)(resources.GetObject("customerButton1.Image")));
            this.customerButton1.ImageHover = ((System.Drawing.Image)(resources.GetObject("customerButton1.ImageHover")));
            this.customerButton1.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customerButton1.ImageNormal")));
            this.customerButton1.Location = new System.Drawing.Point(449, 56);
            this.customerButton1.Name = "customerButton1";
            this.customerButton1.Size = new System.Drawing.Size(31, 29);
            this.customerButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerButton1.TabIndex = 0;
            this.customerButton1.TabStop = false;
            this.customerButton1.Click += new System.EventHandler(this.customerButton1_Click);
            // 
            // customerButton2
            // 
            this.customerButton2.Image = ((System.Drawing.Image)(resources.GetObject("customerButton2.Image")));
            this.customerButton2.ImageHover = ((System.Drawing.Image)(resources.GetObject("customerButton2.ImageHover")));
            this.customerButton2.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customerButton2.ImageNormal")));
            this.customerButton2.Location = new System.Drawing.Point(528, 56);
            this.customerButton2.Name = "customerButton2";
            this.customerButton2.Size = new System.Drawing.Size(31, 29);
            this.customerButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerButton2.TabIndex = 11;
            this.customerButton2.TabStop = false;
            // 
            // customerButton3
            // 
            this.customerButton3.Image = ((System.Drawing.Image)(resources.GetObject("customerButton3.Image")));
            this.customerButton3.ImageHover = ((System.Drawing.Image)(resources.GetObject("customerButton3.ImageHover")));
            this.customerButton3.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customerButton3.ImageNormal")));
            this.customerButton3.Location = new System.Drawing.Point(607, 56);
            this.customerButton3.Name = "customerButton3";
            this.customerButton3.Size = new System.Drawing.Size(31, 29);
            this.customerButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerButton3.TabIndex = 12;
            this.customerButton3.TabStop = false;
            // 
            // customerButton4
            // 
            this.customerButton4.Image = ((System.Drawing.Image)(resources.GetObject("customerButton4.Image")));
            this.customerButton4.ImageHover = ((System.Drawing.Image)(resources.GetObject("customerButton4.ImageHover")));
            this.customerButton4.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customerButton4.ImageNormal")));
            this.customerButton4.Location = new System.Drawing.Point(686, 56);
            this.customerButton4.Name = "customerButton4";
            this.customerButton4.Size = new System.Drawing.Size(31, 29);
            this.customerButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerButton4.TabIndex = 13;
            this.customerButton4.TabStop = false;
            // 
            // customerButton5
            // 
            this.customerButton5.Image = ((System.Drawing.Image)(resources.GetObject("customerButton5.Image")));
            this.customerButton5.ImageHover = ((System.Drawing.Image)(resources.GetObject("customerButton5.ImageHover")));
            this.customerButton5.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customerButton5.ImageNormal")));
            this.customerButton5.Location = new System.Drawing.Point(765, 56);
            this.customerButton5.Name = "customerButton5";
            this.customerButton5.Size = new System.Drawing.Size(31, 29);
            this.customerButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerButton5.TabIndex = 14;
            this.customerButton5.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomerButton customerButton1;
        private CustomerButton customerButton5;
        private CustomerButton customerButton4;
        private CustomerButton customerButton3;
        private CustomerButton customerButton2;
    }
}
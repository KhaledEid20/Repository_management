namespace WH_management
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.sarf = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddformPnl = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.addItem = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.AddformPnl.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.sarf);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(903, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 757);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(221, 49);
            this.button4.TabIndex = 5;
            this.button4.Text = "إذن إهلاك";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "إذن إرجاع";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sarf
            // 
            this.sarf.BackColor = System.Drawing.Color.Gray;
            this.sarf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sarf.Location = new System.Drawing.Point(0, 136);
            this.sarf.Name = "sarf";
            this.sarf.Size = new System.Drawing.Size(221, 49);
            this.sarf.TabIndex = 3;
            this.sarf.Text = "إذن صرف";
            this.sarf.UseVisualStyleBackColor = false;
            this.sarf.Click += new System.EventHandler(this.sarf_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Gray;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(0, 87);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(221, 49);
            this.Add.TabIndex = 2;
            this.Add.Text = "إذن إضافة";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 87);
            this.panel2.TabIndex = 1;
            // 
            // AddformPnl
            // 
            this.AddformPnl.Controls.Add(this.toolStrip1);
            this.AddformPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddformPnl.Location = new System.Drawing.Point(0, 0);
            this.AddformPnl.Name = "AddformPnl";
            this.AddformPnl.Size = new System.Drawing.Size(903, 757);
            this.AddformPnl.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit,
            this.addItem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(903, 37);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // exit
            // 
            this.exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(34, 34);
            this.exit.Text = "toolStripButton4";
            this.exit.ToolTipText = "خروج";
            this.exit.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // addItem
            // 
            this.addItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addItem.Image = ((System.Drawing.Image)(resources.GetObject("addItem.Image")));
            this.addItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(34, 34);
            this.addItem.Text = "toolStripButton4";
            this.addItem.ToolTipText = "إضافة صنف";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 757);
            this.Controls.Add(this.AddformPnl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "mainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel1.ResumeLayout(false);
            this.AddformPnl.ResumeLayout(false);
            this.AddformPnl.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button sarf;
        private System.Windows.Forms.Panel AddformPnl;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addItem;
        private System.Windows.Forms.ToolStripButton exit;
    }
}


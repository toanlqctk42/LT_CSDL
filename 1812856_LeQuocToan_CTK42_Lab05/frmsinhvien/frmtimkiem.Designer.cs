namespace frmsinhvien
{
    partial class frmtimkiem
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
            this.button1 = new System.Windows.Forms.Button();
            this.rdmssv = new System.Windows.Forms.RadioButton();
            this.rdten = new System.Windows.Forms.RadioButton();
            this.rdlop = new System.Windows.Forms.RadioButton();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdmssv
            // 
            this.rdmssv.AutoSize = true;
            this.rdmssv.Location = new System.Drawing.Point(128, 32);
            this.rdmssv.Name = "rdmssv";
            this.rdmssv.Size = new System.Drawing.Size(55, 17);
            this.rdmssv.TabIndex = 5;
            this.rdmssv.TabStop = true;
            this.rdmssv.Text = "MSSV";
            this.rdmssv.UseVisualStyleBackColor = true;
            this.rdmssv.CheckedChanged += new System.EventHandler(this.rdmssv_CheckedChanged);
            // 
            // rdten
            // 
            this.rdten.AutoSize = true;
            this.rdten.Location = new System.Drawing.Point(207, 32);
            this.rdten.Name = "rdten";
            this.rdten.Size = new System.Drawing.Size(44, 17);
            this.rdten.TabIndex = 5;
            this.rdten.TabStop = true;
            this.rdten.Text = "Tên";
            this.rdten.UseVisualStyleBackColor = true;
            this.rdten.CheckedChanged += new System.EventHandler(this.rdten_CheckedChanged);
            // 
            // rdlop
            // 
            this.rdlop.AutoSize = true;
            this.rdlop.Location = new System.Drawing.Point(271, 32);
            this.rdlop.Name = "rdlop";
            this.rdlop.Size = new System.Drawing.Size(43, 17);
            this.rdlop.TabIndex = 5;
            this.rdlop.TabStop = true;
            this.rdlop.Text = "Lớp";
            this.rdlop.UseVisualStyleBackColor = true;
            this.rdlop.CheckedChanged += new System.EventHandler(this.rdlop_CheckedChanged);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(80, 75);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(234, 20);
            this.txttimkiem.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Loại tìm kiếm :";
            // 
            // frmtimkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 156);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.rdlop);
            this.Controls.Add(this.rdten);
            this.Controls.Add(this.rdmssv);
            this.Controls.Add(this.button1);
            this.Name = "frmtimkiem";
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.frmtimkiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdmssv;
        private System.Windows.Forms.RadioButton rdten;
        private System.Windows.Forms.RadioButton rdlop;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
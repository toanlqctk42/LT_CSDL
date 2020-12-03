namespace RestaurantManagementProject
{
    partial class formfood
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpleft = new System.Windows.Forms.GroupBox();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmddelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpright = new System.Windows.Forms.GroupBox();
            this.cmdexit = new System.Windows.Forms.Button();
            this.lvfood = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenThucPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DVT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoaiThucPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GhiChu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblstatistic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpleft.SuspendLayout();
            this.grpright.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpleft);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpright);
            this.splitContainer1.Size = new System.Drawing.Size(839, 450);
            this.splitContainer1.SplitterDistance = 337;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpleft
            // 
            this.grpleft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpleft.Controls.Add(this.cmdUpdate);
            this.grpleft.Controls.Add(this.cmddelete);
            this.grpleft.Controls.Add(this.label6);
            this.grpleft.Controls.Add(this.cmdAdd);
            this.grpleft.Controls.Add(this.cmdClear);
            this.grpleft.Controls.Add(this.cbCategory);
            this.grpleft.Controls.Add(this.txtNotes);
            this.grpleft.Controls.Add(this.txtPrice);
            this.grpleft.Controls.Add(this.txtUnit);
            this.grpleft.Controls.Add(this.txtName);
            this.grpleft.Controls.Add(this.label4);
            this.grpleft.Controls.Add(this.label3);
            this.grpleft.Controls.Add(this.label2);
            this.grpleft.Controls.Add(this.label1);
            this.grpleft.Location = new System.Drawing.Point(3, 3);
            this.grpleft.Name = "grpleft";
            this.grpleft.Size = new System.Drawing.Size(331, 444);
            this.grpleft.TabIndex = 0;
            this.grpleft.TabStop = false;
            this.grpleft.Text = "Chức năng";
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(164, 412);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(71, 23);
            this.cmdUpdate.TabIndex = 3;
            this.cmdUpdate.Text = "Sửa";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmddelete
            // 
            this.cmddelete.Location = new System.Drawing.Point(241, 412);
            this.cmddelete.Name = "cmddelete";
            this.cmddelete.Size = new System.Drawing.Size(75, 23);
            this.cmddelete.TabIndex = 3;
            this.cmddelete.Text = "Xóa";
            this.cmddelete.UseVisualStyleBackColor = true;
            this.cmddelete.Click += new System.EventHandler(this.cmddelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ghi chú";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(91, 412);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(67, 23);
            this.cmdAdd.TabIndex = 3;
            this.cmdAdd.Text = "Thêm";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(28, 412);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(57, 23);
            this.cmdClear.TabIndex = 3;
            this.cmdClear.Text = "Nhập lại";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(98, 121);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(164, 21);
            this.cbCategory.TabIndex = 2;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(98, 154);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(164, 152);
            this.txtNotes.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(98, 91);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(164, 20);
            this.txtPrice.TabIndex = 1;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(98, 57);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(164, 20);
            this.txtUnit.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 20);
            this.txtName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại thực phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đơn vị tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên thực phẩm";
            // 
            // grpright
            // 
            this.grpright.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpright.Controls.Add(this.cmdexit);
            this.grpright.Controls.Add(this.lvfood);
            this.grpright.Controls.Add(this.lblstatistic);
            this.grpright.Location = new System.Drawing.Point(3, 3);
            this.grpright.Name = "grpright";
            this.grpright.Size = new System.Drawing.Size(483, 444);
            this.grpright.TabIndex = 0;
            this.grpright.TabStop = false;
            this.grpright.Text = "Danh mục thức ăn";
            // 
            // cmdexit
            // 
            this.cmdexit.Location = new System.Drawing.Point(380, 415);
            this.cmdexit.Name = "cmdexit";
            this.cmdexit.Size = new System.Drawing.Size(54, 23);
            this.cmdexit.TabIndex = 3;
            this.cmdexit.Text = "Thoát";
            this.cmdexit.UseVisualStyleBackColor = true;
            this.cmdexit.Click += new System.EventHandler(this.cmdexit_Click);
            // 
            // lvfood
            // 
            this.lvfood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvfood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.TenThucPham,
            this.DVT,
            this.Gia,
            this.LoaiThucPham,
            this.GhiChu});
            this.lvfood.FullRowSelect = true;
            this.lvfood.GridLines = true;
            this.lvfood.HideSelection = false;
            this.lvfood.Location = new System.Drawing.Point(0, 19);
            this.lvfood.MultiSelect = false;
            this.lvfood.Name = "lvfood";
            this.lvfood.Size = new System.Drawing.Size(477, 388);
            this.lvfood.TabIndex = 0;
            this.lvfood.UseCompatibleStateImageBehavior = false;
            this.lvfood.View = System.Windows.Forms.View.Details;
            this.lvfood.Click += new System.EventHandler(this.lvfood_Click);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            // 
            // TenThucPham
            // 
            this.TenThucPham.Text = "Tên thực phẩm";
            // 
            // DVT
            // 
            this.DVT.Text = "ĐVT";
            // 
            // Gia
            // 
            this.Gia.Text = "Giá";
            // 
            // LoaiThucPham
            // 
            this.LoaiThucPham.Text = "Loại thực phẩm";
            // 
            // GhiChu
            // 
            this.GhiChu.Text = "Ghi chú";
            // 
            // lblstatistic
            // 
            this.lblstatistic.AutoSize = true;
            this.lblstatistic.Location = new System.Drawing.Point(23, 417);
            this.lblstatistic.Name = "lblstatistic";
            this.lblstatistic.Size = new System.Drawing.Size(53, 13);
            this.lblstatistic.TabIndex = 0;
            this.lblstatistic.Text = "Thống kê";
            // 
            // formfood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "formfood";
            this.Text = "Thêm-Xóa-Sửa Bảng FOOD";
            this.Load += new System.EventHandler(this.formfood_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpleft.ResumeLayout(false);
            this.grpleft.PerformLayout();
            this.grpright.ResumeLayout(false);
            this.grpright.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpleft;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmddelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpright;
        private System.Windows.Forms.Button cmdexit;
        private System.Windows.Forms.ListView lvfood;
        private System.Windows.Forms.Label lblstatistic;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader TenThucPham;
        private System.Windows.Forms.ColumnHeader DVT;
        private System.Windows.Forms.ColumnHeader Gia;
        private System.Windows.Forms.ColumnHeader LoaiThucPham;
        private System.Windows.Forms.ColumnHeader GhiChu;
    }
}


namespace Lab06_Basic_Command
{
    partial class frmFood
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
            this.dgrfood = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodCategoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantManagenmentDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantManagenmentDataSet1 = new Lab06_Basic_Command.RestaurantManagenmentDataSet1();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFoodCategoryID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.categoryTableAdapter = new Lab06_Basic_Command.RestaurantManagenmentDataSetTableAdapters.CategoryTableAdapter();
            this.btnThem = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.restaurantManagenmentDataSet = new Lab06_Basic_Command.RestaurantManagenmentDataSet();
            this.restaurantManagenmentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodTableAdapter = new Lab06_Basic_Command.RestaurantManagenmentDataSet1TableAdapters.FoodTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgrfood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagenmentDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagenmentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagenmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagenmentDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrfood
            // 
            this.dgrfood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrfood.AutoGenerateColumns = false;
            this.dgrfood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrfood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrfood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.foodCategoryIDDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dgrfood.DataSource = this.foodBindingSource;
            this.dgrfood.Location = new System.Drawing.Point(1, 135);
            this.dgrfood.Name = "dgrfood";
            this.dgrfood.ReadOnly = true;
            this.dgrfood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrfood.Size = new System.Drawing.Size(637, 312);
            this.dgrfood.TabIndex = 0;
            this.dgrfood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrfood_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // foodCategoryIDDataGridViewTextBoxColumn
            // 
            this.foodCategoryIDDataGridViewTextBoxColumn.DataPropertyName = "FoodCategoryID";
            this.foodCategoryIDDataGridViewTextBoxColumn.HeaderText = "FoodCategoryID";
            this.foodCategoryIDDataGridViewTextBoxColumn.Name = "foodCategoryIDDataGridViewTextBoxColumn";
            this.foodCategoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // foodBindingSource
            // 
            this.foodBindingSource.DataMember = "Food";
            this.foodBindingSource.DataSource = this.restaurantManagenmentDataSet1BindingSource;
            // 
            // restaurantManagenmentDataSet1BindingSource
            // 
            this.restaurantManagenmentDataSet1BindingSource.DataSource = this.restaurantManagenmentDataSet1;
            this.restaurantManagenmentDataSet1BindingSource.Position = 0;
            // 
            // restaurantManagenmentDataSet1
            // 
            this.restaurantManagenmentDataSet1.DataSetName = "RestaurantManagenmentDataSet1";
            this.restaurantManagenmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(81, 12);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(119, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(119, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtFoodCategoryID
            // 
            this.txtFoodCategoryID.Location = new System.Drawing.Point(321, 12);
            this.txtFoodCategoryID.Name = "txtFoodCategoryID";
            this.txtFoodCategoryID.ReadOnly = true;
            this.txtFoodCategoryID.Size = new System.Drawing.Size(119, 20);
            this.txtFoodCategoryID.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(321, 35);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(119, 20);
            this.txtPrice.TabIndex = 1;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(321, 61);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(119, 20);
            this.txtNotes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã món ăn :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên món ăn :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn vị :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giá Tiền : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mã nhóm thức ăn :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Notes :";
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(403, 106);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 3;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(502, 106);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // cboUnit
            // 
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Items.AddRange(new object[] {
            "đĩa",
            "tô",
            "lon",
            "gói",
            "cái",
            "chai",
            "tộ",
            "con"});
            this.cboUnit.Location = new System.Drawing.Point(81, 61);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(119, 21);
            this.cboUnit.TabIndex = 4;
            this.cboUnit.Text = "đĩa";
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(211, 106);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(307, 106);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(75, 23);
            this.btncapnhat.TabIndex = 6;
            this.btncapnhat.Text = "Cập Nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // restaurantManagenmentDataSet
            // 
            this.restaurantManagenmentDataSet.DataSetName = "RestaurantManagenmentDataSet";
            this.restaurantManagenmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restaurantManagenmentDataSetBindingSource
            // 
            this.restaurantManagenmentDataSetBindingSource.DataSource = this.restaurantManagenmentDataSet;
            this.restaurantManagenmentDataSetBindingSource.Position = 0;
            // 
            // foodTableAdapter
            // 
            this.foodTableAdapter.ClearBeforeFill = true;
            // 
            // frmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboUnit);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtFoodCategoryID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgrfood);
            this.Name = "frmFood";
            this.Text = "Foodform";
            this.Load += new System.EventHandler(this.frmFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrfood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagenmentDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagenmentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagenmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagenmentDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrfood;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFoodCategoryID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.ComboBox cboUnit;
        private RestaurantManagenmentDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btncapnhat;
        private RestaurantManagenmentDataSet restaurantManagenmentDataSet;
        private System.Windows.Forms.BindingSource restaurantManagenmentDataSet1BindingSource;
        private RestaurantManagenmentDataSet1 restaurantManagenmentDataSet1;
        private System.Windows.Forms.BindingSource restaurantManagenmentDataSetBindingSource;
        private System.Windows.Forms.BindingSource foodBindingSource;
        private RestaurantManagenmentDataSet1TableAdapters.FoodTableAdapter foodTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodCategoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
    }
}
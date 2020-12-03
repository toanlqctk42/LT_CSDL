namespace Lab06_Basic_Command
{
    partial class AccountManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.dtpdatecreate = new System.Windows.Forms.DateTimePicker();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restaurantManagenmentDataSet3 = new Lab06_Basic_Command.RestaurantManagenmentDataSet3();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTableAdapter = new Lab06_Basic_Command.RestaurantManagenmentDataSet3TableAdapters.AccountTableAdapter();
            this.accountNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsmxoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmxemds = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagenmentDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ và Tên :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày khởi tạo : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số điện thoại :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Password :";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(106, 10);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(278, 20);
            this.txtAccount.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(106, 39);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(197, 20);
            this.txtpassword.TabIndex = 1;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(106, 64);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(278, 20);
            this.txthoten.TabIndex = 1;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(106, 92);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(278, 20);
            this.txtemail.TabIndex = 1;
            // 
            // dtpdatecreate
            // 
            this.dtpdatecreate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdatecreate.Location = new System.Drawing.Point(106, 146);
            this.dtpdatecreate.Name = "dtpdatecreate";
            this.dtpdatecreate.Size = new System.Drawing.Size(278, 20);
            this.dtpdatecreate.TabIndex = 2;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(106, 121);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(278, 20);
            this.txtsdt.TabIndex = 1;
            // 
            // dgvAccount
            // 
            this.dgvAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccount.AutoGenerateColumns = false;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.tellDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn});
            this.dgvAccount.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAccount.DataSource = this.accountBindingSource;
            this.dgvAccount.Location = new System.Drawing.Point(2, 182);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(642, 263);
            this.dgvAccount.TabIndex = 3;
            this.dgvAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellContentClick);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(518, 23);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 4;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(309, 37);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 4;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(518, 57);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 4;
            this.btnsua.Text = "Cập Nhật";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmxoa,
            this.tsmxemds});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(192, 70);
            // 
            // restaurantManagenmentDataSet3
            // 
            this.restaurantManagenmentDataSet3.DataSetName = "RestaurantManagenmentDataSet3";
            this.restaurantManagenmentDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.restaurantManagenmentDataSet3;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // accountNameDataGridViewTextBoxColumn
            // 
            this.accountNameDataGridViewTextBoxColumn.DataPropertyName = "AccountName";
            this.accountNameDataGridViewTextBoxColumn.HeaderText = "AccountName";
            this.accountNameDataGridViewTextBoxColumn.Name = "accountNameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // tellDataGridViewTextBoxColumn
            // 
            this.tellDataGridViewTextBoxColumn.DataPropertyName = "Tell";
            this.tellDataGridViewTextBoxColumn.HeaderText = "Tell";
            this.tellDataGridViewTextBoxColumn.Name = "tellDataGridViewTextBoxColumn";
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            // 
            // tsmxoa
            // 
            this.tsmxoa.Name = "tsmxoa";
            this.tsmxoa.Size = new System.Drawing.Size(191, 22);
            this.tsmxoa.Text = "Xóa";
            this.tsmxoa.Click += new System.EventHandler(this.tsmxoa_Click);
            // 
            // tsmxemds
            // 
            this.tsmxemds.Name = "tsmxemds";
            this.tsmxemds.Size = new System.Drawing.Size(191, 22);
            this.tsmxemds.Text = "Xem danh sách vai trò";
            // 
            // AccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.dtpdatecreate);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "AccountManager";
            this.Text = "AccountManager";
            this.Load += new System.EventHandler(this.AccountManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagenmentDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.DateTimePicker dtpdatecreate;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private RestaurantManagenmentDataSet3 restaurantManagenmentDataSet3;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private RestaurantManagenmentDataSet3TableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem tsmxoa;
        private System.Windows.Forms.ToolStripMenuItem tsmxemds;
    }
}
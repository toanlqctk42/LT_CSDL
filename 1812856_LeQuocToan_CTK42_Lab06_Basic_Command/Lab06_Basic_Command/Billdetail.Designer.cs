namespace Lab06_Basic_Command
{
    partial class Billdetail
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
            this.dgrbiildetail = new System.Windows.Forms.DataGridView();
            this.restaurantManagenmentDataSet3 = new Lab06_Basic_Command.RestaurantManagenmentDataSet3();
            this.billDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billDetailsTableAdapter = new Lab06_Basic_Command.RestaurantManagenmentDataSet3TableAdapters.BillDetailsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrbiildetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagenmentDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrbiildetail
            // 
            this.dgrbiildetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrbiildetail.AutoGenerateColumns = false;
            this.dgrbiildetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrbiildetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.invoiceIDDataGridViewTextBoxColumn,
            this.foodIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dgrbiildetail.DataSource = this.billDetailsBindingSource;
            this.dgrbiildetail.Location = new System.Drawing.Point(0, 0);
            this.dgrbiildetail.Name = "dgrbiildetail";
            this.dgrbiildetail.Size = new System.Drawing.Size(442, 372);
            this.dgrbiildetail.TabIndex = 0;
            // 
            // restaurantManagenmentDataSet3
            // 
            this.restaurantManagenmentDataSet3.DataSetName = "RestaurantManagenmentDataSet3";
            this.restaurantManagenmentDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billDetailsBindingSource
            // 
            this.billDetailsBindingSource.DataMember = "BillDetails";
            this.billDetailsBindingSource.DataSource = this.restaurantManagenmentDataSet3;
            // 
            // billDetailsTableAdapter
            // 
            this.billDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceIDDataGridViewTextBoxColumn
            // 
            this.invoiceIDDataGridViewTextBoxColumn.DataPropertyName = "InvoiceID";
            this.invoiceIDDataGridViewTextBoxColumn.HeaderText = "Mã Bills";
            this.invoiceIDDataGridViewTextBoxColumn.Name = "invoiceIDDataGridViewTextBoxColumn";
            // 
            // foodIDDataGridViewTextBoxColumn
            // 
            this.foodIDDataGridViewTextBoxColumn.DataPropertyName = "FoodID";
            this.foodIDDataGridViewTextBoxColumn.HeaderText = "Mã món ăn";
            this.foodIDDataGridViewTextBoxColumn.Name = "foodIDDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // Billdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 371);
            this.Controls.Add(this.dgrbiildetail);
            this.Name = "Billdetail";
            this.Text = "Billdetail";
            this.Load += new System.EventHandler(this.Billdetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrbiildetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagenmentDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrbiildetail;
        private RestaurantManagenmentDataSet3 restaurantManagenmentDataSet3;
        private System.Windows.Forms.BindingSource billDetailsBindingSource;
        private RestaurantManagenmentDataSet3TableAdapters.BillDetailsTableAdapter billDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}
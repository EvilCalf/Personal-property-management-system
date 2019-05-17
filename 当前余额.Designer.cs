namespace 个人财产管理系统
{
    partial class 当前余额
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && ( components != null ))
            {
                components.Dispose ( );
            }
            base.Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.账户余额表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.个人资产数据库DataSet = new 个人财产管理系统.当前余额数据绑定();
            this.账户余额表TableAdapter = new 个人财产管理系统.个人资产数据库DataSetTableAdapters.账户余额表TableAdapter();
            this.银行卡DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.现金DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.支付宝DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.交通卡DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.理财产品DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总余额DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.账户余额表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.个人资产数据库DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.银行卡DataGridViewTextBoxColumn,
            this.现金DataGridViewTextBoxColumn,
            this.支付宝DataGridViewTextBoxColumn,
            this.交通卡DataGridViewTextBoxColumn,
            this.理财产品DataGridViewTextBoxColumn,
            this.总余额DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.账户余额表BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(805, 76);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // 账户余额表BindingSource
            // 
            this.账户余额表BindingSource.DataMember = "账户余额表";
            this.账户余额表BindingSource.DataSource = this.个人资产数据库DataSet;
            // 
            // 个人资产数据库DataSet
            // 
            this.个人资产数据库DataSet.DataSetName = "个人资产数据库DataSet";
            this.个人资产数据库DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 账户余额表TableAdapter
            // 
            this.账户余额表TableAdapter.ClearBeforeFill = true;
            // 
            // 银行卡DataGridViewTextBoxColumn
            // 
            this.银行卡DataGridViewTextBoxColumn.DataPropertyName = "银行卡";
            this.银行卡DataGridViewTextBoxColumn.HeaderText = "银行卡";
            this.银行卡DataGridViewTextBoxColumn.Name = "银行卡DataGridViewTextBoxColumn";
            // 
            // 现金DataGridViewTextBoxColumn
            // 
            this.现金DataGridViewTextBoxColumn.DataPropertyName = "现金";
            this.现金DataGridViewTextBoxColumn.HeaderText = "现金";
            this.现金DataGridViewTextBoxColumn.Name = "现金DataGridViewTextBoxColumn";
            // 
            // 支付宝DataGridViewTextBoxColumn
            // 
            this.支付宝DataGridViewTextBoxColumn.DataPropertyName = "支付宝";
            this.支付宝DataGridViewTextBoxColumn.HeaderText = "支付宝";
            this.支付宝DataGridViewTextBoxColumn.Name = "支付宝DataGridViewTextBoxColumn";
            // 
            // 交通卡DataGridViewTextBoxColumn
            // 
            this.交通卡DataGridViewTextBoxColumn.DataPropertyName = "交通卡";
            this.交通卡DataGridViewTextBoxColumn.HeaderText = "交通卡";
            this.交通卡DataGridViewTextBoxColumn.Name = "交通卡DataGridViewTextBoxColumn";
            // 
            // 理财产品DataGridViewTextBoxColumn
            // 
            this.理财产品DataGridViewTextBoxColumn.DataPropertyName = "理财产品";
            this.理财产品DataGridViewTextBoxColumn.HeaderText = "理财产品";
            this.理财产品DataGridViewTextBoxColumn.Name = "理财产品DataGridViewTextBoxColumn";
            // 
            // 总余额DataGridViewTextBoxColumn
            // 
            this.总余额DataGridViewTextBoxColumn.DataPropertyName = "总余额";
            this.总余额DataGridViewTextBoxColumn.HeaderText = "总余额";
            this.总余额DataGridViewTextBoxColumn.Name = "总余额DataGridViewTextBoxColumn";
            // 
            // 当前余额
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 76);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "当前余额";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "当前余额";
            this.Load += new System.EventHandler(this.当前余额_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.账户余额表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.个人资产数据库DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;


        private 当前余额数据绑定 个人资产数据库DataSet;
        private System.Windows.Forms.BindingSource 账户余额表BindingSource;
        private 个人资产数据库DataSetTableAdapters.账户余额表TableAdapter 账户余额表TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 银行卡DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 现金DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 支付宝DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 交通卡DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 理财产品DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总余额DataGridViewTextBoxColumn;
    }
}
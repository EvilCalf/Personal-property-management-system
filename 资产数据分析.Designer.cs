namespace 个人财产管理系统
{
    partial class 资产数据分析
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(资产数据分析));
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.资产表TableAdapter = new 个人财产管理系统.个人资产数据库DataSet6TableAdapters.资产表TableAdapter();
            this.资产表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.个人资产数据库DataSet6 = new 个人财产管理系统.资产数据绑定();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.资产表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.个人资产数据库DataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.AppearanceNameSerializable = "Nature Colors";
            this.chartControl1.BackImage.Image = ((System.Drawing.Image)(resources.GetObject("chartControl1.BackImage.Image")));
            this.chartControl1.DataAdapter = this.资产表TableAdapter;
            this.chartControl1.DataBindings = null;
            this.chartControl1.DataSource = this.资产表BindingSource;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PaletteName = "Green Yellow";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(782, 553);
            this.chartControl1.TabIndex = 0;
            // 
            // 资产表TableAdapter
            // 
            this.资产表TableAdapter.ClearBeforeFill = true;
            // 
            // 资产表BindingSource
            // 
            this.资产表BindingSource.DataMember = "资产表";
            this.资产表BindingSource.DataSource = this.个人资产数据库DataSet6;
            // 
            // 个人资产数据库DataSet6
            // 
            this.个人资产数据库DataSet6.DataSetName = "个人资产数据库DataSet6";
            this.个人资产数据库DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // 资产数据分析
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.chartControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "资产数据分析";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "资产数据分析";
            this.Load += new System.EventHandler(this.资产数据分析_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.资产表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.个人资产数据库DataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private 个人资产数据库DataSet6TableAdapters.资产表TableAdapter 资产表TableAdapter;
        private 资产数据绑定 个人资产数据库DataSet6;
        private System.Windows.Forms.BindingSource 资产表BindingSource;
    }
}
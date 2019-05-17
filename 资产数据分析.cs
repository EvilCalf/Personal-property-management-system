using DevExpress.XtraCharts;
using System;
using System.Windows.Forms;

namespace 个人财产管理系统
{
    public partial class 资产数据分析 : Form
    {
        public 资产数据分析 ( )
        {
            InitializeComponent ( );
        }

        private void 资产数据分析_Load ( object sender , EventArgs e )
        {
            // TODO: 这行代码将数据加载到表“个人资产数据库DataSet6.资产表”中。您可以根据需要移动或删除它。
            this.资产表TableAdapter.Fill(this.个人资产数据库DataSet6.资产表);
            chartControl1.Series.Clear ( );
            Series series1 = new Series("价值", ViewType.RadarArea);
            chartControl1.Series.Add ( series1 );
            Database db = new Database ( );
            string sql1 = "select sum(money) from 资产表 where 资产类型=N'固定资产' and 用户名=N'" + 登陆界面.username + "'";
            string sql2 = "select sum(money) from 资产表 where 资产类型=N'流动资产' and 用户名=N'" + 登陆界面.username + "'";
            string sql3 = "select sum(money) from 资产表 where 资产类型=N'长期投资' and 用户名=N'" + 登陆界面.username + "'";
            string sql4 = "select sum(money) from 资产表 where 资产类型=N'无形资产' and 用户名=N'" + 登陆界面.username + "'";
            string sql5 = "select sum(money) from 资产表 where 资产类型=N'递延资产' and 用户名=N'" + 登陆界面.username + "'";
            string sql6 = "select sum(money) from 资产表 where 资产类型=N'长期负债' and 用户名=N'" + 登陆界面.username + "'";
            double money1 = db.RunSqlDouble ( sql1 );
            double money2 = db.RunSqlDouble ( sql2 );
            double money3 = db.RunSqlDouble ( sql3 );
            double money4 = db.RunSqlDouble ( sql4 );
            double money5 = db.RunSqlDouble ( sql5 );
            double money6 = db.RunSqlDouble ( sql6 );
            series1.Points.Add ( new SeriesPoint ( "固定资产" , money1 ) );
            series1.Points.Add ( new SeriesPoint ( "流动资产" , money2 ) );
            series1.Points.Add ( new SeriesPoint ( "长期投资" , money3 ) );
            series1.Points.Add ( new SeriesPoint ( "无形资产" , money4 ) );
            series1.Points.Add ( new SeriesPoint ( "递延资产" , money5 ) );
            series1.Points.Add ( new SeriesPoint ( "长期负债" , money6 ) );
        }
    }
}

using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace 个人财产管理系统
{
    public partial class 分类支出 : Form
    {
        public 分类支出()
        {
            InitializeComponent();
        }
        private void 分类支出_Load(object sender, EventArgs e)
        {
            chartControl1.Series.Clear();
            Series series1 = new Series("金额", ViewType.Pie3D);
            chartControl1.Series.Add(series1);
#pragma warning disable CS0618 // 类型或成员已过时
            series1.LegendPointOptions.PointView = PointView.Argument;//右边的图例  
#pragma warning restore CS0618 // 类型或成员已过时
            Database db = new Database();
            string sql1 = "select sum(金额) from 流水表 where 分类=N'早午晚饭' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            string sql2 = "select sum(金额) from 流水表 where 分类=N'水果饮料零食' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            string sql3 = "select sum(金额) from 流水表 where 分类=N'日常用品' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            string sql4 = "select sum(金额) from 流水表 where 分类=N'公共交通' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            string sql5 = "select sum(金额) from 流水表 where 分类=N'手机费' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            string sql6 = "select sum(金额) from 流水表 where 分类=N'上网费' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            string sql7 = "select sum(金额) from 流水表 where 分类=N'腐败聚会' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            string sql8 = "select sum(金额) from 流水表 where 分类=N'休闲玩乐' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            string sql9 = "select sum(金额) from 流水表 where 分类=N'书报杂志' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            string sql10 = "select sum(金额) from 流水表 where 分类=N'培训进修' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            string sql11 = "select sum(金额) from 流水表 where 分类=N'药品费' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            string sql12 = "select sum(金额) from 流水表 where 分类=N'治疗费' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            string sql13 = "select sum(金额) from 流水表 where 分类=N'复印打印' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            double money1 = db.RunSqlDouble(sql1);
            double money2 = db.RunSqlDouble(sql2);
            double money3 = db.RunSqlDouble(sql3);
            double money4 = db.RunSqlDouble(sql4);
            double money5 = db.RunSqlDouble(sql5);
            double money6 = db.RunSqlDouble(sql6);
            double money7 = db.RunSqlDouble(sql7);
            double money8 = db.RunSqlDouble(sql8);
            double money9 = db.RunSqlDouble(sql9);
            double money10 = db.RunSqlDouble(sql10);
            double money11 = db.RunSqlDouble(sql11);
            double money12 = db.RunSqlDouble(sql12);
            double money13 = db.RunSqlDouble(sql13);
            series1.Points.Add(new SeriesPoint("早午晚饭", money1));
            series1.Points.Add(new SeriesPoint("水果饮料零食", money2));
            series1.Points.Add(new SeriesPoint("日常用品", money3));
            series1.Points.Add(new SeriesPoint("公共交通", money4));
            series1.Points.Add(new SeriesPoint("手机费", money5));
            series1.Points.Add(new SeriesPoint("上网费", money6));
            series1.Points.Add(new SeriesPoint("腐败聚会", money7));
            series1.Points.Add(new SeriesPoint("休闲玩乐", money8));
            series1.Points.Add(new SeriesPoint("书报杂志", money9));
            series1.Points.Add(new SeriesPoint("培训进修", money10));
            series1.Points.Add(new SeriesPoint("药品费", money11));
            series1.Points.Add(new SeriesPoint("治疗费", money12));
            series1.Points.Add(new SeriesPoint("复印打印", money13));
            chartControl2.Series.Clear();
            Series series2 = new Series("金额", ViewType.Pie3D);
            chartControl2.Series.Add(series2);
#pragma warning disable CS0618 // 类型或成员已过时
            series2.LegendPointOptions.PointView = PointView.Argument;//右边的图例  
#pragma warning restore CS0618 // 类型或成员已过时
            string sqlstr1 = "select sum(金额) from 流水表 where 分类=N'早午晚饭' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + DateTime.Now.ToString("yyyy-MM") + "%'";
            string sqlstr2 = "select sum(金额) from 流水表 where 分类=N'水果饮料零食' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + DateTime.Now.ToString("yyyy-MM") + "%'";
            string sqlstr3 = "select sum(金额) from 流水表 where 分类=N'日常用品' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + DateTime.Now.ToString("yyyy-MM") + "%'";
            string sqlstr4 = "select sum(金额) from 流水表 where 分类=N'公共交通' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + DateTime.Now.ToString("yyyy-MM") + "%'";
            string sqlstr5= "select sum(金额) from 流水表 where 分类=N'手机费' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + DateTime.Now.ToString("yyyy-MM") + "%'";
            string sqlstr6 = "select sum(金额) from 流水表 where 分类=N'上网费' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + DateTime.Now.ToString("yyyy-MM") + "%'";
            string sqlstr7 = "select sum(金额) from 流水表 where 分类=N'腐败聚会' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + DateTime.Now.ToString("yyyy-MM") + "%'";
            string sqlstr8 = "select sum(金额) from 流水表 where 分类=N'休闲玩乐' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + DateTime.Now.ToString("yyyy-MM") + "%'";
            string sqlstr9 = "select sum(金额) from 流水表 where 分类=N'书报杂志' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + DateTime.Now.ToString("yyyy-MM") + "%'";
            string sqlstr10 = "select sum(金额) from 流水表 where 分类=N'培训进修' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + DateTime.Now.ToString("yyyy-MM") + "%'";
            string sqlstr11 = "select sum(金额) from 流水表 where 分类=N'药品费' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + DateTime.Now.ToString("yyyy-MM") + "%'";
            string sqlstr12 = "select sum(金额) from 流水表 where 分类=N'治疗费' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + DateTime.Now.ToString("yyyy-MM") + "%'";
            string sqlstr13 = "select sum(金额) from 流水表 where 分类=N'复印打印' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + DateTime.Now.ToString("yyyy-MM") + "%'";
            double mone1 = db.RunSqlDouble(sql1);
            double mone2 = db.RunSqlDouble(sql2);
            double mone3 = db.RunSqlDouble(sql3);
            double mone4 = db.RunSqlDouble(sql4);
            double mone5 = db.RunSqlDouble(sql5);
            double mone6 = db.RunSqlDouble(sql6);
            double mone7 = db.RunSqlDouble(sql7);
            double mone8 = db.RunSqlDouble(sql8);
            double mone9 = db.RunSqlDouble(sql9);
            double mone10 = db.RunSqlDouble(sql10);
            double mone11 = db.RunSqlDouble(sql11);
            double mone12 = db.RunSqlDouble(sql12);
            double mone13 = db.RunSqlDouble(sql13);
            series2.Points.Add(new SeriesPoint("早午晚饭", mone1));
            series2.Points.Add(new SeriesPoint("水果饮料零食", mone2));
            series2.Points.Add(new SeriesPoint("日常用品", mone3));
            series2.Points.Add(new SeriesPoint("公共交通", mone4));
            series2.Points.Add(new SeriesPoint("手机费", mone5));
            series2.Points.Add(new SeriesPoint("上网费", mone6));
            series2.Points.Add(new SeriesPoint("腐败聚会", mone7));
            series2.Points.Add(new SeriesPoint("休闲玩乐", mone8));
            series2.Points.Add(new SeriesPoint("书报杂志", mone9));
            series2.Points.Add(new SeriesPoint("培训进修", mone10));
            series2.Points.Add(new SeriesPoint("药品费", mone11));
            series2.Points.Add(new SeriesPoint("治疗费", mone12));
            series2.Points.Add(new SeriesPoint("复印打印", mone13));
        }


        private void NumericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            chartControl2.Series.Clear();
            Series series2 = new Series("金额", ViewType.Pie3D);
            chartControl2.Series.Add(series2);
#pragma warning disable CS0618 // 类型或成员已过时
            series2.LegendPointOptions.PointView = PointView.Argument;//右边的图例  
#pragma warning restore CS0618 // 类型或成员已过时
            Database db = new Database();
            string sql1 = "select sum(金额) from 流水表 where 分类=N'早午晚饭' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            string sql2 = "select sum(金额) from 流水表 where 分类=N'水果饮料零食' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            string sql3 = "select sum(金额) from 流水表 where 分类=N'日常用品' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            string sql4 = "select sum(金额) from 流水表 where 分类=N'公共交通' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            string sql5 = "select sum(金额) from 流水表 where 分类=N'手机费' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            string sql6 = "select sum(金额) from 流水表 where 分类=N'上网费' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            string sql7 = "select sum(金额) from 流水表 where 分类=N'腐败聚会' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            string sql8 = "select sum(金额) from 流水表 where 分类=N'休闲玩乐' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            string sql9 = "select sum(金额) from 流水表 where 分类=N'书报杂志' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            string sql10 = "select sum(金额) from 流水表 where 分类=N'培训进修' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            string sql11 = "select sum(金额) from 流水表 where 分类=N'药品费' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            string sql12 = "select sum(金额) from 流水表 where 分类=N'治疗费' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            string sql13 = "select sum(金额) from 流水表 where 分类=N'复印打印' and 用户名=N'" + 登陆界面.username + "' and 时间 like '" + numericUpDown1.Text.ToString() + "%'";
            double mone1 = db.RunSqlDouble(sql1);
            double mone2 = db.RunSqlDouble(sql2);
            double mone3 = db.RunSqlDouble(sql3);
            double mone4 = db.RunSqlDouble(sql4);
            double mone5 = db.RunSqlDouble(sql5);
            double mone6 = db.RunSqlDouble(sql6);
            double mone7 = db.RunSqlDouble(sql7);
            double mone8 = db.RunSqlDouble(sql8);
            double mone9 = db.RunSqlDouble(sql9);
            double mone10 = db.RunSqlDouble(sql10);
            double mone11 = db.RunSqlDouble(sql11);
            double mone12 = db.RunSqlDouble(sql12);
            double mone13 = db.RunSqlDouble(sql13);
            series2.Points.Add(new SeriesPoint("早午晚饭", mone1));
            series2.Points.Add(new SeriesPoint("水果饮料零食", mone2));
            series2.Points.Add(new SeriesPoint("日常用品", mone3));
            series2.Points.Add(new SeriesPoint("公共交通", mone4));
            series2.Points.Add(new SeriesPoint("手机费", mone5));
            series2.Points.Add(new SeriesPoint("上网费", mone6));
            series2.Points.Add(new SeriesPoint("腐败聚会", mone7));
            series2.Points.Add(new SeriesPoint("休闲玩乐", mone8));
            series2.Points.Add(new SeriesPoint("书报杂志", mone9));
            series2.Points.Add(new SeriesPoint("培训进修", mone10));
            series2.Points.Add(new SeriesPoint("药品费", mone11));
            series2.Points.Add(new SeriesPoint("治疗费", mone12));
            series2.Points.Add(new SeriesPoint("复印打印", mone13));
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;

namespace 个人财产管理系统
{
    public partial class 当前余额 : Form
    {
        public 当前余额 ( )
        {
            InitializeComponent ( );
        }

        private void 当前余额_Load ( object sender , EventArgs e )
        {

            string name = 登陆界面.username;
            string sql;
            Database db = new Database();
            DataSet ds = new DataSet();
            sql = "select 银行卡,现金,支付宝,交通卡,理财产品,总余额 from 账户余额表 where 用户名=N'" + name + "'";
            ds = db.RunSqlDS(sql);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void dataGridView1_CellValueChanged ( object sender , DataGridViewCellEventArgs e )
        {
            if (dataGridView1.CurrentCell != null)
            {
                if (dataGridView1.CurrentCell.ColumnIndex == 0)
                {
                    string strcolumn = dataGridView1.Columns [e.ColumnIndex].HeaderText;//获取列标题
                    string value = dataGridView1.CurrentCell.Value.ToString ( );//获取当前点击的活动单元格的值
                    string name = 登陆界面.username;
                    Database db = new Database ( );
                    string sql = "update 账户余额表 set " + strcolumn + "=N'" + value + "'where 用户名 = N'" + name + "'";
                    db.RunSql ( sql );
                    DataSet ds = new DataSet ( );
                    sql = "select * from 账户余额表 where 用户名=N'" + name + "'";
                    ds = db.RunSqlDS ( sql );
                    dataGridView1.DataSource = ds.Tables [0];
                }
            }

        }
    }
}

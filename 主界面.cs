using System;
using System.Data;
using System.Windows.Forms;


namespace 个人财产管理系统
{

    public partial class 主界面 : Form
    {
        string username;
        string pswd;
        public 主界面 ( string name,string password )
        {
            InitializeComponent ( );
            username = name;
            pswd = password;
        }

        private void 主界面_FormClosed ( object sender , FormClosedEventArgs e )
        {
            Application.Exit ( );
        }

        private void Button1_Click ( object sender , EventArgs e )
        {
            this.tabPage1.Show ( );
            tabControl1.SelectedIndex = 0;
        }

        private void Button2_Click ( object sender , EventArgs e )
        {
            this.tabPage2.Show ( );
            tabControl1.SelectedIndex = 1;
        }

        private void Button3_Click ( object sender , EventArgs e )
        {
            this.tabPage3.Show ( );
            tabControl1.SelectedIndex = 2;
        }


        private void Button5_Click ( object sender , EventArgs e )
        {
            this.tabPage7.Show ( );
            tabControl1.SelectedIndex = 3;
        }

        private void 主界面_Load ( object sender , EventArgs e )
        {
            gridView1.OptionsCustomization.AllowColumnMoving = false;
            gridView1.OptionsCustomization.AllowSort = false;
            gridView1.OptionsCustomization.AllowColumnResizing = false;
            Database db = new Database ( );
            double budget = 0;
            string sql = "select 预算 from 账户余额表 where 用户名=N'" + username + "'";
            budget=db.RunSqlDouble ( sql );
            progressBar1.Maximum = (int)budget;
            label1.Text = "这个月的预算为："+Convert.ToString ( budget );
            System.DateTime currentTime = new System.DateTime();
            if (currentTime.Day==1)
            {
                string flag= "select 标志 from 账户余额表 where 用户名=N'" + username + "'";
                int flag2 = db.RunSqlint(flag);
                if (flag2 == 0)
                {
                    flag = "update 账户余额表 set 标志=1 where 用户名=N'" + username + "'";
                    db.RunSql(flag);
                    flag = "update 账户余额表 set 当前预算=预算 where 用户名=N'" + username + "'";
                    db.RunSql(flag);
                }
                else
                {
                    string sql2 = "select 当前预算 from 账户余额表 where 用户名=N'" + username + "'";
                    budget = db.RunSqlDouble(sql2);
                }
            }
            else
            {
                string sql2 = "select 当前预算 from 账户余额表 where 用户名=N'" + username + "'";
                budget = db.RunSqlDouble(sql2);
            }
            progressBar1.Value = (int)budget;
            label2.Text = "这个月的余额为：" + Convert.ToString ( budget );
            sql = "select sum(money) from 资产表 where 用户名=N'" + username + "'";
            double t = db.RunSqlDouble ( sql );
            label6.Text = t.ToString();
            sql = "select * from 资产表 where 用户名=N'" + username + "'";
            DataSet ds = new DataSet ( );
            ds = db.RunSqlDS ( sql );
            gridControl1.DataSource = ds.Tables [0];
            sql = "select * from 流水表 where 用户名=N'" + username + "'";
            DataSet ds2 = new DataSet ( );
            ds2 = db.RunSqlDS ( sql );
            gridControl2.DataSource = ds2.Tables [0];
            textBox3.Text = pswd;
            textBox6.Text = pswd;
            sql= "select 性别 from 用户信息表 where 用户名=N'" + username + "'";
            comboBox4.Text = db.RunSqlstring(sql);
            sql = "select 出生日期 from 用户信息表 where 用户名=N'" + username + "'";
            dateTimePicker1.Text = db.RunSqlstring(sql);
        }

        private void Button9_Click ( object sender , EventArgs e )
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show ( "请输入金额！" );
            }
            else
            {
                double money = (double)numericUpDown1.Value;
                string classification = comboBox1.Text.Trim ( );
                string account = comboBox2.Text.Trim ( );
                Database db = new Database ( );
                string sql = "insert 流水表(用户名,金额,分类,账户类型) values(N'" + username + "'," + money + ",N'" + classification + "',N'" + account + "')";
                db.RunSql ( sql );
                sql = "update 账户余额表 set " + account + "=" + account + "-" + money;
                db.RunSql ( sql );
                string sql2 = "select 当前预算 from 账户余额表 where 用户名=N'" + username + "'";
                double budget = db.RunSqlDouble ( sql2 );
                progressBar1.Value = (int)budget;
                label2.Text = "这个月的余额为：" + Convert.ToString ( budget );
                sql = "select * from 流水表";
                DataSet ds = new DataSet ( );
                ds = db.RunSqlDS ( sql );
                gridControl2.DataSource = ds.Tables [0];
                MessageBox.Show ( "记录成功！" );
                numericUpDown1.Value = 0;
                comboBox1.Text = "";
                comboBox2.Text = "";
            }
           
        }

        private void Button6_Click ( object sender , EventArgs e )
        {
            Database db = new Database ( );
            string sql = "select count(*) from 流水表 where 分类 like N'" + textBox1.Text.Trim ( ) + "%' or 账户类型 like N'" + textBox1.Text.Trim ( ) +"%'";
            int t = 0;
            t = db.RunSqlint ( sql );
            if (t > 0)
            {
                DataSet ds = new DataSet ( );
                sql = "select * from 流水表 where 分类 like N'" +textBox1.Text.Trim ( ) + "%' or 账户类型 like N'" + textBox1.Text.Trim ( ) + "%'";
                ds = db.RunSqlDS ( sql );
                gridControl2.DataSource = ds.Tables [0];
            }
            else
            {
                MessageBox.Show ( "你查找的数据不存在！");
            }
        }

        private void Button10_Click ( object sender , EventArgs e )
        {
            当前余额 form = new 当前余额 ( );
            form.Show ( );
        }

        private void Button11_Click ( object sender , EventArgs e )
        {
            if (numericUpDown2.Value == 0)
            {
                MessageBox.Show ( "请输入价值！" );
            }
            else
            {
                double money = (double)numericUpDown2.Value;
                string classification = comboBox3.Text.Trim ( );
                string classification2 = textBox4.Text.Trim ( );
                Database db = new Database ( );
                string sql = "insert 资产表(用户名,money,资产名,资产类型) values(N'" + username + "'," + money + ",N'" + classification2 + "',N'" + classification + "')";
                db.RunSql ( sql );
                sql = "select sum(money) from 资产表 where 用户名=N'" + username + "'";
                double t = db.RunSqlDouble ( sql );
                label6.Text = t.ToString ( );
                sql = "select * from 资产表 where 用户名=N'" + username + "'";
                DataSet ds = new DataSet ( );
                ds = db.RunSqlDS ( sql );
                gridControl1.DataSource = ds.Tables [0];
                MessageBox.Show ( "更新成功!" );
                numericUpDown2.Value = 0;
                comboBox3.Text = "";
                textBox4.Text = "";
            }
        }

        private void Button7_Click ( object sender , EventArgs e )
        {
            Database db = new Database ( );
            string sql = "select count(*) from 资产表 where 资产名 like N'%" + textBox2.Text.Trim ( ) + "%' or 资产类型 like N'%" + textBox2.Text.Trim ( ) + "%' or 时间 like N'%" + textBox2.Text.Trim ( ) + "%' ";
            int t = 0;
            t = db.RunSqlint ( sql );
            if (t > 0)
            {
                DataSet ds = new DataSet ( );
                sql = "select * from 资产表 where 资产名 like N'%" + textBox2.Text.Trim() + "%' or 资产类型 like N'%" + textBox2.Text.Trim() + "%' or 时间 like N'%" + textBox2.Text.Trim() + "%' ";
                ds = db.RunSqlDS ( sql );
                gridControl1.DataSource = ds.Tables [0];
            }
            else
            {
                MessageBox.Show ( "你查找的数据不存在！" );
            }
        }

        private void GridView1_CellValueChanged ( object sender , DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e )
        {

            string strcolumn = gridView1.FocusedColumn.ToString ( );//获取列标题
            if (strcolumn == "价值")
            {
                strcolumn = "money";
            }
            string value = gridView1.FocusedValue.ToString ( );//获取当前点击的活动单元格的值
            string name = 登陆界面.username;
            Database db = new Database ( );
            string sql = "update 资产表 set " + strcolumn + "=N'" + value + "'where 用户名 = N'" + name + "'";
            db.RunSql ( sql );
            DataSet ds = new DataSet ( );
            sql = "select * from 资产表 where 用户名=N'" + name + "'";
            ds = db.RunSqlDS ( sql );
            gridControl1.DataSource = ds.Tables [0];

        }

        private void Button12_Click ( object sender , EventArgs e )
        {
            资产数据分析 form = new 资产数据分析 ( );
            form.Show ( );
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string strcolumn = gridView2.FocusedColumn.ToString();//获取列标题
            string value = gridView2.FocusedValue.ToString();//获取当前点击的活动单元格的值
            string name = 登陆界面.username;
            Database db = new Database();
            string sql = "update 流水表 set " + strcolumn + "=N'" + value + "'where 用户名 = N'" + name + "'";
            db.RunSql(sql);
            DataSet ds = new DataSet();
            sql = "select * from 流水表 where 用户名=N'" + name + "'";
            ds = db.RunSqlDS(sql);
            gridControl2.DataSource = ds.Tables[0];
          
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            分类支出 form = new 分类支出();
            form.Show();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            Common com = new Common();
            Database db = new Database();
            string sql;
            if(textBox6.Text==textBox3.Text)
            {
                sql = "update 用户信息表 set 密码=N'" + com.Md5(textBox6.Text.Trim()) + "' where 用户名=N'" + username + "' 性别=N'"+ comboBox4.Text.Trim()+"' 出生日期=N'"+ dateTimePicker1.Value.ToShortDateString()+"'";
                db.RunSql(sql);
                MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("两次密码不一致请重新输入！");
            }
        }
    }
    
}

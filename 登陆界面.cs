using System;
using System.Windows.Forms;

namespace 个人财产管理系统
{
    public partial class 登陆界面 : Form
    {
        public 登陆界面 ( )
        {
            InitializeComponent ( );
        }
        private void Button1_Click ( object sender , EventArgs e )
        {
            if (textBox1.Text.Trim ( ).Length == 0)
            {
                MessageBox.Show ( "请输入用户名!" );
                textBox1.Focus ( );
                return;
            }
            if (textBox2.Text.Trim ( ).Length == 0)
            {
                MessageBox.Show ( "请输入密码!" );
                textBox2.Focus ( );
                return;
            }
            Common com=new Common ( );
            Database db = new Database ( );
            int t = 0;
            string sql = "select count(*) from 用户信息表 where 用户名=N'" + textBox1.Text.Trim ( ) + "'and 密码='" + com.Md5 ( textBox2.Text.Trim ( ) ) + "'";
            t = db.RunSqlint ( sql );
            if (t > 0)
            {
                MessageBox.Show ( textBox1.Text.Trim ( )+"欢迎你" );
                username = textBox1.Text.Trim ( );
                this.Hide ( );
                Database db2 = new Database();
                double budget = 0;
                string sql2 = "select 预算 from 账户余额表 where 用户名=N'" + username + "'";
                budget = db2.RunSqlDouble(sql2);
                if (budget == 0)
                {
                    预算设置 from = new 预算设置(username, textBox2.Text.Trim());
                    from.Show();
                    this.Hide();
                }
                else
                {
                    主界面 form = new 主界面(username, textBox2.Text.Trim());
                    form.Show();
                }
            }
            else
            {
                MessageBox.Show ( "用户名或密码错误!" );
            }
        }
        public static string username;
        private void Button2_Click ( object sender , EventArgs e )
        {
            this.Hide ( );
            注册界面 form = new 个人财产管理系统.注册界面 ( );
            form.Show ( );
        }

        private void Button3_Click ( object sender , EventArgs e )
        {
            Application.Exit ( );
        }

        private void 登陆界面_Load(object sender, EventArgs e)
        {

        }
    }
}

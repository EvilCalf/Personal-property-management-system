using System;
using System.Windows.Forms;

namespace 个人财产管理系统
{
    public partial class 注册界面 : Form
    {
        public 注册界面 ( )
        {
            InitializeComponent ( );
        }

        private void Button1_Click ( object sender , EventArgs e )
        {
            this.Close ( );
        }

        private void Button2_Click ( object sender , EventArgs e )
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
            if (comboBox1.Text.Trim ( ).Length == 0)
            {
                MessageBox.Show ( "请选择性别" );
                comboBox1.Focus ( );
                return;
            }
            if (dateTimePicker1.Text.Trim ( ).Length == 0)
            {
                MessageBox.Show ( "请选择出生日期！" );
                dateTimePicker1.Focus ( );
                return;
            }
            Database db = new Database ( );
            Common com = new Common ( );
            int t = 0;
            string sql = "select count(*) from 用户信息表 where 用户名='" + textBox1.Text.Trim ( ) + "'";
            t = db.RunSqlint ( sql );
            if (t ==0)
            {
                sql = "insert 用户信息表 (用户名,性别,出生日期,密码) values(N'" + textBox1.Text.Trim ( ) + "',N'" + comboBox1.Text.Trim ( ) + "',N'" + dateTimePicker1.Value.ToShortDateString() + "','"+ com.Md5 ( textBox2.Text.Trim ( ) )+"')";
                db.RunSql ( sql );
                sql = "select count(*) from 用户信息表 where 用户名=N'" + textBox1.Text.Trim ( ) + "'";
                t = db.RunSqlint ( sql );
                if (t > 0)
                {

                    MessageBox.Show ( "注册成功！" );
                    this.Close ( );

                }
                else
                {
                    MessageBox.Show ( "注册失败！" );
                }
            }
            else
            {
                MessageBox.Show ( "用户名已存在!" );
            }

        }

        private void 注册界面_FormClosed ( object sender , FormClosedEventArgs e )
        {
            登陆界面 form = new 登陆界面 ( );
            form.Show ( );
        }
    }
}

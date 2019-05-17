using System;
using System.Windows.Forms;

namespace 个人财产管理系统
{
    public partial class 预算设置 : DevExpress.XtraEditors.XtraForm
    {
        public string username;
        string mima;
        public 预算设置(string name,string mima)
        {
            InitializeComponent();
            username = name;
            this.mima = mima;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            string sql = "insert 账户余额表(用户名,预算,当前预算) values(N'"+ username +"',"+ numericUpDown1.Value.ToString() + ","+numericUpDown1.Value.ToString()+") ";
            db.RunSql(sql);
            MessageBox.Show("设置成功！");
            this.Close();
            主界面 f = new 主界面(username,mima);
                f.Show();
            当前余额 form = new 当前余额();
            form.Show();
            MessageBox.Show("请设置你的账户金额!");
        }

        private void 预算设置_Load(object sender, EventArgs e)
        {

        }
    }
}

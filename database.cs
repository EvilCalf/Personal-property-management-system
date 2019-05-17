using System;
using System.Data;
using System.Data.SqlClient;

namespace 个人财产管理系统
{
    class Database
    {
        SqlConnection con;
 
        //打开数据库
        private void Open ( )
        {
            if (con == null)
            {
                string str = System.Environment.CurrentDirectory;
                string souce = @"server = 112.74.25.95; database =个人资产数据库; uid = xujiading; pwd = propressntc811";
                con = new SqlConnection ( souce );
            }
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open ( );
            }
        }
        //关闭数据库
        private void Close ( )
        {
            if (con != null)
            {
                con.Close ( );
            }
        }
        //创建SQL命令
        private SqlCommand Createcommand ( string sqlStr )
        {
            Open ( );
            SqlCommand com = new SqlCommand ( sqlStr , con );
            return com;
        }
        //执行语句无返回值
        public void RunSql ( string sqlStr )
        {
            SqlCommand cmd = Createcommand ( sqlStr );
            cmd.ExecuteNonQuery ( );
            Close ( );
        }
        //执行语句返回整数类型
        public int RunSqlint ( string sqlStr )
        {
            try
            {
                SqlCommand cmd = Createcommand(sqlStr);

                int t = (int)cmd.ExecuteScalar();
                Close();
                return t;
            }
            catch
            {
                return 0;
            }


        }
        public string RunSqlstring(string sqlStr)
        {
            try
            {
                SqlCommand cmd = Createcommand(sqlStr);

                string t = (string)cmd.ExecuteScalar();
                Close();
                return t;
            }
            catch
            {
                return null;
            }

        }
        public double RunSqlDouble ( string sqlStr )
        {
            try
            {
                SqlCommand cmd = Createcommand ( sqlStr );
                double t = Convert.ToDouble ( cmd.ExecuteScalar ( ) );
                Close ( );
                return t;
            }
            catch
            {
                Close();
                return 0;
            }
        }
        //执行SQL查询语句
        public SqlDataReader RunSql ( string sqlStr , out SqlDataReader dr )
        {
            SqlCommand cmd = Createcommand(sqlStr);
            dr = cmd.ExecuteReader ( CommandBehavior.CloseConnection );
            Close();
            return dr;
        }
        public DataSet RunSqlDS ( string sqlStr  )
        {

            SqlCommand cmd = Createcommand(sqlStr);
            SqlDataAdapter sda = new SqlDataAdapter ( cmd );
            DataSet ds = new DataSet ( );
            sda.Fill ( ds,"表" );
            Close();
            return ds;
        }
        //把datareader转换为datatable
        public DataTable ConcertDataReaderToDataTable ( SqlDataReader dataReader )
        {
            DataTable datatable = new DataTable ( );
            DataTable schemaTable = dataReader.GetSchemaTable ( );
            try
            {
                foreach (DataRow myRow in schemaTable.Rows)
                {
                    DataColumn myDataColunm = new DataColumn()
                    {
                        DataType = System.Type.GetType("system.string"),
                        ColumnName = myRow[0].ToString()
                    };
                    datatable.Columns.Add ( myDataColunm );
                }
                while (dataReader.Read ( ))
                {
                    DataRow myDataRow = datatable.NewRow ( );
                    for (int i = 0 ; i < schemaTable.Rows.Count ; i++)
                    {
                        myDataRow [i] = dataReader [i].ToString ( );
                    }
                    datatable.Rows.Add ( myDataRow );
                    myDataRow = null;
                }
                schemaTable = null;
                dataReader.Close ( );
                return datatable;
            }
            catch(Exception ex)
            {
                throw new Exception ( "转换出错！" , ex );
            }
        }
    }
}

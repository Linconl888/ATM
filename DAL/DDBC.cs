using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    internal class DDBC
    {
        private string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
        private SqlConnection connection;

        /// <summary>
        /// 重写无参构造器
        /// 调用时自动连接数据库
        /// </summary>
        public DDBC() {
            //创建与服务器连接
            SqlConnection conn = new SqlConnection(ConnectionString);
            this.connection = conn;
        }

        /// <summary>
        /// 查询语句
        /// 返回读取器
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public SqlDataReader select(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql,connection);

            //设置读取到的数据类型
            cmd.CommandType = System.Data.CommandType.Text;

            //打开数据库
            connection.Open();

            //返回读取器
            return cmd.ExecuteReader();
        }

        /// <summary>
        /// 插入语句
        /// 返回影响的行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int Insert(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql,connection);
            cmd.CommandType = System.Data.CommandType.Text;
            connection.Open();

            return cmd.ExecuteNonQuery();
        }




        public void Close()
        {
            connection.Close();
        }
    }
}

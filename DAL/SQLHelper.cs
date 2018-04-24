using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class SQLHelper
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        private static string connStr = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;

        /// <summary>
        /// 数据连接对象
        /// </summary>
        private static SqlConnection connection = new SqlConnection(connStr);

        #region 数据库的打开与关闭

        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public static void Open()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public static void Close()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        #endregion 数据库的打开与关闭

        /// <summary>
        /// 执行Insert,Delete,Update更新语句
        /// </summary>
        /// <param name="sql">sql语句或存储过程</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlParameter">sql语句或存储过程中的参数</param>
        /// <returns>返回受影响的记录数据</returns>
        public static int ExecuteNonQurery(string sql, CommandType commandType, params SqlParameter[] sqlParameter)
        {
            int count = 0;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.CommandType = commandType;
                if (sqlParameter != null)
                {
                    command.Parameters.AddRange(sqlParameter);
                }
                count = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            Close();
            return count;
        }

        /// <summary>
        /// 执行Select查询语句
        /// </summary>
        /// <param name="sql">sql语句或存储过程</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlParameter">sql语句或存储过程中的参数</param>
        /// <returns>返回数据集</returns>
        public static SqlDataReader GetSqlDataReader(string sql, CommandType commandType, params SqlParameter[] sqlParameter)
        {
            SqlDataReader sqlDataReader = null;
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                sqlCommand.CommandType = commandType;
                if (sqlParameter != null)
                {
                    sqlCommand.Parameters.AddRange(sqlParameter);
                }
                sqlDataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception)
            {
                throw;
            }
            return sqlDataReader;
        }

        /// <summary>
        /// 执行Select查询语句
        /// </summary>
        /// <param name="sql">sql语句或存储过程</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlParameter">sql语句或存储过程中的参数</param>
        /// <returns>返回数据集</returns>
        public static DataSet GetDataSet(string sql, CommandType commandType, params SqlParameter[] sqlParameter)
        {
            DataSet dataSet = new DataSet();
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.SelectCommand.CommandType = commandType;
                if (sqlParameter != null)
                {
                    dataAdapter.SelectCommand.Parameters.AddRange(sqlParameter);
                }
                dataAdapter.Fill(dataSet);
            }
            catch (Exception)
            {
                throw;
            }
            return dataSet;
        }

        /// <summary>
        /// 执行Select查询语句
        /// </summary>
        /// <param name="sql">sql语句或存储过程</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlParameter">sql语句或存储过程中的参数</param>
        /// <returns>返回查询结果中的数量</returns>
        public static int ExecuteScalar(string sql, CommandType commandType, params SqlParameter[] sqlParameter)
        {
            int count = 0;
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                sqlCommand.CommandType = commandType;
                if (sqlParameter != null)
                {
                    sqlCommand.Parameters.AddRange(sqlParameter);
                }
                count = (int)sqlCommand.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
            Close();
            return count;
        }
    }
}
using AllShowMVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllShowMVC.Dao.sql
{
    public class EmployeeDao : BaseSqlDao
    {
        public int Create(Employee Item)
        {
            string sql = @"
                    INSERT INTO [dbo].[Employee]
                               ([EmpName]
                               ,[EmpAccount]
                               ,[EmpPwd]
                               ,[EmpEmail]
                               ,[EmpSex]
                               ,[EmpBirth]
                               ,[EmpTel]
                               ,[HireDate]
                               ,[LeaveDate]
                               ,[EmpAccountState])
                         VALUES
                               (@EmpName
                               ,@EmpAccount
                               ,@EmpPwd
                               ,@EmpEmail
                               ,@EmpSex
                               ,@EmpBirth
                               ,@EmpTel
                               ,@HireDate
                               ,@LeaveDate
                               ,@EmpAccountState)
            ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@EmpName", Item.EmpName);
                cmd.Parameters.AddWithValue("@EmpAccount", Item.EmpAccount);
                cmd.Parameters.AddWithValue("@EmpPwd", Item.EmpPwd);
                cmd.Parameters.AddWithValue("@EmpEmail", Item.EmpEmail);
                cmd.Parameters.AddWithValue("@EmpSex", Item.EmpSex);
                cmd.Parameters.AddWithValue("@EmpBirth", Item.EmpBirth);
                cmd.Parameters.AddWithValue("@EmpTel", Item.EmpTel);
                cmd.Parameters.AddWithValue("@HireDate", Item.HireDate);
                cmd.Parameters.AddWithValue("@LeaveDate", (object)Item.LeaveDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@EmpAccountState", Item.EmpAccountState ?? "0");

                try
                {
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public int Update(Employee Item)
        {
            string sql = @"
                    UPDATE [dbo].[Employee]
                       SET [EmpName] = @EmpName
                          ,[EmpAccount] = @EmpAccount
                          ,[EmpPwd] = @EmpPwd
                          ,[EmpEmail] = @EmpEmail
                          ,[EmpSex] = @EmpSex
                          ,[EmpBirth] = @EmpBirth
                          ,[EmpTel] = @EmpTel
                          ,[HireDate] = @HireDate
                          ,[LeaveDate] = @LeaveDate
                          ,[EmpAccountState] = @EmpAccountState
                     WHERE 
                          EmpNo=@EmpNo
            ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@EmpNo", Item.EmpNo);
                cmd.Parameters.AddWithValue("@EmpName", Item.EmpName);
                cmd.Parameters.AddWithValue("@EmpAccount", Item.EmpAccount);
                cmd.Parameters.AddWithValue("@EmpPwd", Item.EmpPwd);
                cmd.Parameters.AddWithValue("@EmpEmail", Item.EmpEmail);
                cmd.Parameters.AddWithValue("@EmpSex", Item.EmpSex);
                cmd.Parameters.AddWithValue("@EmpBirth", Item.EmpBirth);
                cmd.Parameters.AddWithValue("@EmpTel", Item.EmpTel);
                cmd.Parameters.AddWithValue("@HireDate", Item.HireDate);
                cmd.Parameters.AddWithValue("@LeaveDate", (object)Item.LeaveDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@EmpAccountState", Item.EmpAccountState ?? "0");

                try
                {
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public int Delete(int empNo)
        {
            string sql = @"
            DELETE FROM [dbo].[Employee]
            WHERE EmpNo=@EmpNo
            ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@EmpNo", empNo);

                try
                {
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}

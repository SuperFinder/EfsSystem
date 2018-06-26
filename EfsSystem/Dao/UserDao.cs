using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EfsSystem.common;
using EfsSystem.Entity;
using MySql.Data.MySqlClient;
using MySqlHelper = EfsSystem.common.MySqlHelper;

namespace EfsSystem.Dao
{
    public class UserDao
    {
        public void addOrUpdateUser(string userId,string userName,string department,string postion,string tel)
        {
            try
            {
                MySqlParameter paraUserName = new MySqlParameter("@paraUserName", userName);
                MySqlParameter paraDepartment = new MySqlParameter("@paraDepartment", department);
                MySqlParameter paraPostion = new MySqlParameter("@paraPosition", postion);
                MySqlParameter paraTel = new MySqlParameter("@paraTel", tel);
                string sql;
                if (userId != string.Empty)
                {
                    MySqlParameter paraId = new MySqlParameter("@paraId", userId);
                    sql = "update user set user_name = @paraUserName, department = @paraDepartment, position = @paraPosition, tel = @paratel where id = @paraId";
                    MySqlHelper.ExecuteNonQuery(common.MySqlHelper.conn, CommandType.Text, sql, paraUserName, paraDepartment, paraPostion, paraTel, paraId);
                }
                else
                {
                    sql = "insert into user(user_name,department,position,tel) values(@paraUserName,@paraDepartment,@paraPosition,@paraTel)";
                    MySqlHelper.ExecuteNonQuery(MySqlHelper.conn, CommandType.Text, sql, paraUserName, paraDepartment, paraPostion, paraTel);
                }
            }
            catch (Exception exception)
            {
                LogHelper.WriteLog(typeof(FormAddUser), exception.ToString());
            }
        }

        public UserInfo getUserInfo(string userId)
        {
            UserInfo userInfo = new UserInfo();
            try
            {
                if (userId != string.Empty)
                {
                    MySqlParameter paraUserId = new MySqlParameter("paraUserId", userId);
                    string sql = "select user_name,department,position,tel from user where id = @paraUserId";
                    MySqlDataReader mySqlDataReader = MySqlHelper.ExecuteReader(MySqlHelper.conn, CommandType.Text, sql, paraUserId);
                    if (mySqlDataReader.Read())
                    {
                        userInfo.userName = (string)mySqlDataReader["user_name"];
                        userInfo.department = (string)mySqlDataReader["department"];
                        userInfo.position = (string)mySqlDataReader["position"];
                        userInfo.tel = (string)mySqlDataReader["tel"];
                    }
                    mySqlDataReader.Close();
                }
            }
            catch (Exception exception)
            {
                LogHelper.WriteLog(typeof(FormAddUser), exception.ToString());
            }
            return userInfo;
        }

        public List<UserInfo> getAllUserInfo()
        {
            List<UserInfo> userInfos = new List<UserInfo>();
            try
            {
                
                    string sql = "select user_name,department,position,tel from user";
                    MySqlDataReader mySqlDataReader = MySqlHelper.ExecuteReader(MySqlHelper.conn, CommandType.Text, sql, null);
                    while (mySqlDataReader.Read())
                    {
                        UserInfo userInfo = new UserInfo
                        {
                            userName = (string) mySqlDataReader["user_name"],
                            department = (string) mySqlDataReader["department"],
                            position = (string) mySqlDataReader["position"],
                            tel = (string) mySqlDataReader["tel"]
                        };
                        userInfos.Add(userInfo);
                    }
                    mySqlDataReader.Close();
            }
            catch (Exception exception)
            {
                LogHelper.WriteLog(typeof(FormAddUser), exception.ToString());
            }
            return userInfos;
        }
    }
}

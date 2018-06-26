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
    public class CustomerInfoDao
    {
        public void addOrUpdateCustomer(string customerId,string unitName,string address,string responsibleUserName,string tel,string fax,string email)
        {
            try
            {
                MySqlParameter paraUnitName = new MySqlParameter("@paraUnitName", unitName);
                MySqlParameter paraAddress = new MySqlParameter("@paraAddress", address);
                MySqlParameter paraResponsibleUserName = new MySqlParameter("@paraResponsibleUserName", responsibleUserName);
                MySqlParameter paraTel = new MySqlParameter("@paraTel", tel);
                MySqlParameter paraFax = new MySqlParameter("@paraFax", fax);
                MySqlParameter paraEmail = new MySqlParameter("@paraEmail", email);
                if (customerId != string.Empty)
                {
                    MySqlParameter paraId = new MySqlParameter("@paraId", customerId);
                    string sql = "update customer set unit_name = @paraUnitName,address = @paraAddress,responsible_user_name = @paraResponsibleUserName,tel = @paraTel,fax = @paraFax, email = @paraEmail where id = @paraId";
                    common.MySqlHelper.ExecuteNonQuery(common.MySqlHelper.conn, CommandType.Text, sql, paraUnitName, paraAddress, paraResponsibleUserName, paraTel, paraFax, paraEmail, paraId);
                    MessageBox.Show(@"修改客户成功!", "提示", MessageBoxButtons.OK);
                }
                else
                {
                    string sql = "insert into customer(unit_name,address,responsible_user_name,tel,fax,email) values(@paraUnitName,@paraAddress,@paraResponsibleUserName,@paraTel,@paraFax,@paraEmail)";
                    common.MySqlHelper.ExecuteNonQuery(MySqlHelper.conn, CommandType.Text, sql, paraUnitName, paraAddress, paraResponsibleUserName, paraTel, paraFax, paraEmail);
                }
            }
            catch (Exception exception)
            {
                LogHelper.WriteLog(typeof(FormAddCustomer), exception.ToString());
            }
        }

        public CustomerInfo getCustomerInfo(string customerId)
        {
            CustomerInfo customerInfo = new CustomerInfo();
            if (customerId != string.Empty)
            {
                MySqlParameter paraId = new MySqlParameter("@paraId", customerId);
                string sql = "select unit_name,address,responsible_user_name,tel,fax,email from customer where id = @paraId";
                MySqlDataReader mySqlDataReader = MySqlHelper.ExecuteReader(MySqlHelper.conn, CommandType.Text, sql, paraId);
                if (mySqlDataReader.Read())
                {
                    customerInfo.unitName = (string)mySqlDataReader["unit_name"];
                    customerInfo.address = (string)mySqlDataReader["address"];
                    customerInfo.responsibleUserName = (string)mySqlDataReader["responsible_user_name"];
                    customerInfo.tel = (string)mySqlDataReader["tel"];
                    customerInfo.fax = (string)mySqlDataReader["fax"];
                    customerInfo.email = (string)mySqlDataReader["email"];
                }
                mySqlDataReader.Close();
            }
            return customerInfo;
        }
        public List<CustomerInfo> getAllCustomerInfo()
        {
            List<CustomerInfo> customerInfos = new List<CustomerInfo>();
            {
                string sql = "select unit_name,address,responsible_user_name,tel,fax,email from customer";
                MySqlDataReader mySqlDataReader = MySqlHelper.ExecuteReader(MySqlHelper.conn, CommandType.Text, sql, null);
                while (mySqlDataReader.Read())
                {
                    CustomerInfo customerInfo = new CustomerInfo
                    {
                        unitName = (string) mySqlDataReader["unit_name"],
                        address = (string) mySqlDataReader["address"],
                        responsibleUserName = (string) mySqlDataReader["responsible_user_name"],
                        tel = (string) mySqlDataReader["tel"],
                        fax = (string) mySqlDataReader["fax"],
                        email = (string) mySqlDataReader["email"]
                    };
                    customerInfos.Add(customerInfo);
                }
                mySqlDataReader.Close();
            }
            return customerInfos;
        }
    }
}

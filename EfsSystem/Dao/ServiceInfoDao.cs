using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using EfsSystem.common;
using EfsSystem.Entity;
using MySql.Data.MySqlClient;
using MySqlHelper = EfsSystem.common.MySqlHelper;

namespace EfsSystem.Dao
{
    public class ServiceInfoDao
    {
        public void addServiceInfo(ServiceInfo serviceInfo)
        {
            try
            {
                MySqlParameter paraInfoName = new MySqlParameter("@paraInfoName", serviceInfo.infoName);
                MySqlParameter paraReceiverName = new MySqlParameter("@paraReceiverName", serviceInfo.receiverName);
                MySqlParameter paraBrief = new MySqlParameter("@paraBrief", serviceInfo.brief);
                MySqlParameter paraBasicInfo = new MySqlParameter("@paraBasicInfo", serviceInfo.basicInfo);
                MySqlParameter paraWorkOrderNumber = new MySqlParameter("@paraWorkOrderNumber", serviceInfo.workOderNumber);
                MySqlParameter paraUnitName = new MySqlParameter("@paraUnitName", serviceInfo.unitName);
                MySqlParameter paraAddress = new MySqlParameter("@paraAddress", serviceInfo.address);
                MySqlParameter paraResponsibleCustomerName = new MySqlParameter("@paraResponsibleCustomerName", serviceInfo.responsibleCustomerName);
                MySqlParameter paraResponsibleCustomerTel = new MySqlParameter("@paraResponsibleCustomerTel", serviceInfo.responsibleCustomerTel);
                MySqlParameter paraResponsibleCustomerFax = new MySqlParameter("@paraResponsibleCustomerFax", serviceInfo.responsibleCustomerFax);
                MySqlParameter paraResponsibleUserName = new MySqlParameter("@paraResponsibleUserName", serviceInfo.responsibleUserName);
                MySqlParameter paraResponsibleUserTel = new MySqlParameter("@paraResponsibleUserTel", serviceInfo.responsibleUserTel);
                MySqlParameter paraStartDate = new MySqlParameter("@paraStartDate", serviceInfo.startDate);
                MySqlParameter paraEndDate = new MySqlParameter("@paraEndDate", serviceInfo.endDate);
                MySqlParameter paraUserNames = new MySqlParameter("@paraUserNames", serviceInfo.userNames);
                MySqlParameter paraUserCount = new MySqlParameter("@paraUserCount", serviceInfo.userCount);
                MySqlParameter paraServiceStyle = new MySqlParameter("@paraServiceStyle",serviceInfo.serviceStyle);
                MySqlParameter paraEquipsCount = new MySqlParameter("@paraEquipsCount", serviceInfo.equipsCount);
                MySqlParameter paraFalutInfo = new MySqlParameter("@paraFalutInfo", serviceInfo.faultInfo);
                MySqlParameter paraReturnMoney = new MySqlParameter("@paraReturnMoney", serviceInfo.returnMoney);
                MySqlParameter paraExplain = new MySqlParameter("@paraExplain", serviceInfo.explain);
                MySqlParameter paraSatisfiedQuality = new MySqlParameter("@paraSatisfiedQuality", serviceInfo.satisfiedQuality);
                MySqlParameter paraSatisfiedService = new MySqlParameter("@paraSatisfiedService", serviceInfo.satisfiedService);
                MySqlParameter paraSatisfiedDeliver = new MySqlParameter("@paraSatisfiedDeliver", serviceInfo.satisfiedDeliver);
                MySqlParameter paraSatisfiedPrice = new MySqlParameter("@paraSatisfiedPrice", serviceInfo.satisfiedPrice);
                MySqlParameter paraSuggestAppearance = new MySqlParameter("@paraSuggestAppearance", serviceInfo.suggestAppearance);
                MySqlParameter paraSuggestAttitude = new MySqlParameter("@paraSuggestAttitude", serviceInfo.suggestAttitude);
                MySqlParameter paraSuggestPrice = new MySqlParameter("@paraSuggestPrice", serviceInfo.suggestPrice);
                string sql =
                    "insert into services(info_name,receiver_name,brief,basic_info,work_order_number,unit_name,address,responsible_customer_name,responsible_customer_tel,responsible_customer_fax,responsible_user_name,start_date,end_date,user_names,user_count,service_style,equips_count,falut_info,return_money,`explain`,satisfied_quality,satisfied_service,satisfied_deliver,satisfied_price,suggest_appearance,suggest_attitude,suggest_price) values(@paraInfoName,@paraReceiverName,@paraBrief,@paraBasicInfo,@paraWorkOrderNumber,@paraUnitName,@paraAddress,@paraResponsibleCustomerName,@paraResponsibleCustomerTel,@paraResponsibleCustomerFax,@paraResponsibleUserName,@paraStartDate,@paraEndDate,@paraUserNames,@paraUserCount,@paraServiceStyle,@paraEquipsCount,@paraFalutInfo,@paraReturnMoney,@paraExplain,@paraSatisfiedQuality,@paraSatisfiedService,@paraSatisfiedDeliver,@paraSatisfiedPrice,@paraSuggestAppearance,@paraSuggestAttitude,@paraSuggestPrice)";
                MySqlHelper.ExecuteNonQuery(MySqlHelper.conn, CommandType.Text, sql, paraInfoName, paraReceiverName, paraBrief, paraBasicInfo, paraWorkOrderNumber, paraUnitName, paraAddress,
                    paraResponsibleCustomerName, paraResponsibleCustomerTel, paraResponsibleCustomerFax, paraResponsibleUserName, paraResponsibleUserTel, paraStartDate, paraEndDate, paraUserNames,
                    paraUserCount, paraServiceStyle,paraEquipsCount, paraFalutInfo, paraReturnMoney, paraExplain, paraSatisfiedQuality, paraSatisfiedService, paraSatisfiedDeliver, paraSatisfiedPrice,
                    paraSuggestAppearance, paraSuggestAttitude, paraSuggestPrice);
            }
            catch (Exception e)
            {
                LogHelper.WriteLog(typeof(ServiceInfoDao), e.ToString());
                throw;
            }
        }

        public int getMaxId()
        {
            int maxId = 0;
            try
            {
                string sql = "select max(id) from services";
                MySqlDataReader mySqlDataReader = MySqlHelper.ExecuteReader(MySqlHelper.conn, CommandType.Text, sql, null);
                if (mySqlDataReader.Read())
                {
                    maxId = (int) mySqlDataReader["max(id)"];
                }
                mySqlDataReader.Close();
            }
            catch (Exception e)
            {
                LogHelper.WriteLog(typeof(ServiceInfo), e.ToString());
                throw;
            }
            return maxId;
        }

        public ServiceInfo getServiceInfoByOrderNumber(string orderNumber)
        {
            ServiceInfo serviceInfo = null;
            MySqlParameter paraOrderNumber = new MySqlParameter("@paraOrderNumber",orderNumber);
            string sql =
                "select info_name,receiver_name,brief,basic_info,work_order_number,unit_name,address,responsible_customer_name,responsible_customer_tel,responsible_customer_fax,responsible_user_name,start_date,end_date,user_names,user_count,service_style,equips_count,falut_info,return_money,`explain`,satisfied_quality,satisfied_service,satisfied_deliver,satisfied_price,suggest_appearance,suggest_attitude,suggest_price from services where work_order_number = @paraOrderNumber";
            MySqlDataReader mySqlDataReader = MySqlHelper.ExecuteReader(MySqlHelper.conn, CommandType.Text, sql, paraOrderNumber);
            while (mySqlDataReader.Read())
            {
                ServiceInfo newServiceInfo = new ServiceInfo()
                {
                    infoName = mySqlDataReader.GetString("info_name"),
                    receiverName = mySqlDataReader.GetString("receiver_name"),
                    brief = mySqlDataReader.GetString("brief"),
                    basicInfo = mySqlDataReader.GetString("basic_info"),
                    workOderNumber = mySqlDataReader.GetString("work_order_number"),
                    unitName = mySqlDataReader.GetString("unit_name"),
                    address = mySqlDataReader.GetString("address"),
                    responsibleCustomerName = mySqlDataReader.GetString("responsible_customer_name"),
                    responsibleCustomerTel = mySqlDataReader.GetString("responsible_customer_tel"),
                    responsibleCustomerFax = mySqlDataReader.GetString("responsible_customer_fax"),
                    responsibleUserName = mySqlDataReader.GetString("responsible_user_name"),
//                    responsibleUserTel = mySqlDataReader.GetString("responsible_user_tel"),
                    startDate = mySqlDataReader.GetDateTime("start_date"),
                    endDate = mySqlDataReader.GetDateTime("end_date"),
                    userNames = mySqlDataReader.GetString("user_names"),
                    userCount = mySqlDataReader.GetString("user_count"),
                    serviceStyle = mySqlDataReader.GetString("service_style"),
                    equipsCount = mySqlDataReader.GetString("equips_count"),
                    faultInfo = "",
                    returnMoney = mySqlDataReader.GetString("return_money"),
                    explain = mySqlDataReader.GetString("explain"),
                    satisfiedQuality = mySqlDataReader.GetString("satisfied_quality"),
                    satisfiedService = mySqlDataReader.GetString("satisfied_service"),
                    satisfiedDeliver = mySqlDataReader.GetString("satisfied_deliver"),
                    satisfiedPrice = mySqlDataReader.GetString("satisfied_price"),
                    suggestAppearance = mySqlDataReader.GetString("suggest_appearance"),
                    suggestAttitude = mySqlDataReader.GetString("suggest_attitude"),
                    suggestPrice = mySqlDataReader.GetString("suggest_price")
                };
                serviceInfo = newServiceInfo;
            }
            return serviceInfo;
        }

        public DataSet getServiceInfos(DateTime starDateTime, DateTime endDateTime, string unitName, string responsibleUserName, string serviceStyle)
        {
            ArrayList paraList = new ArrayList();
            MySqlParameter paraStartTime = new MySqlParameter("@paraStartTime",starDateTime);
            MySqlParameter paraEndTime = new MySqlParameter("@paraEndTime",endDateTime);
            MySqlParameter paraUnitName = new MySqlParameter("@paraUnitName",unitName);
            MySqlParameter paraResponsibleUserName = new MySqlParameter("@paraResponsibleUserName",responsibleUserName);
            MySqlParameter paraServiceStyle = new MySqlParameter("@paraServiceStyle",serviceStyle);
            paraList.Add(paraStartTime);
            paraList.Add(paraEndTime);
            string sql =
                "SELECT `info_name`,`receiver_name`,`work_order_number`,`unit_name`,`responsible_customer_name`,`responsible_customer_tel`,`responsible_user_name`,`start_date`,`end_date`,`user_names`,`service_style`,`return_money` FROM services where start_date > @paraStartTime and end_date < @paraEndTime ";
            if (unitName != "全部" && unitName != "请选择单位")
            {
                sql += "and unit_name = @paraUnitName ";
                paraList.Add(paraUnitName);
            }
            if (responsibleUserName != "全部" && responsibleUserName != "请选择带队人")
            {
                sql += "and responsible_user_name = @paraResponsibleUserName ";
                paraList.Add(paraResponsibleUserName);
            }
            if (serviceStyle != "全部" && serviceStyle != "请选择服务类型")
            {
                sql += "and service_style = @paraServiceStyle";
                paraList.Add(paraServiceStyle);
            }
            return MySqlHelper.GetDataSet(MySqlHelper.conn, CommandType.Text, sql, (MySqlParameter[]) paraList.ToArray(typeof(MySqlParameter)));
        }
    }
}

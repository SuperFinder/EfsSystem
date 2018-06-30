using System;
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
                    "insert into services(info_name,receiver_name,brief,basic_info,work_order_number,unit_name,address,responsible_customer_name,responsible_customer_tel,responsible_customer_fax,responsible_user_name,start_date,end_date,user_names,user_count,equips_count,falut_info,return_money,`explain`,satisfied_quality,satisfied_service,satisfied_deliver,satisfied_price,suggest_appearance,suggest_attitude,suggest_price) values(@paraInfoName,@paraReceiverName,@paraBrief,@paraBasicInfo,@paraWorkOrderNumber,@paraUnitName,@paraAddress,@paraResponsibleCustomerName,@paraResponsibleCustomerTel,@paraResponsibleCustomerFax,@paraResponsibleUserName,@paraStartDate,@paraEndDate,@paraUserNames,@paraUserCount,@paraEquipsCount,@paraFalutInfo,@paraReturnMoney,@paraExplain,@paraSatisfiedQuality,@paraSatisfiedService,@paraSatisfiedDeliver,@paraSatisfiedPrice,@paraSuggestAppearance,@paraSuggestAttitude,@paraSuggestPrice)";
                MySqlHelper.ExecuteNonQuery(MySqlHelper.conn, CommandType.Text, sql, paraInfoName, paraReceiverName, paraBrief, paraBasicInfo, paraWorkOrderNumber, paraUnitName, paraAddress,
                    paraResponsibleCustomerName, paraResponsibleCustomerTel, paraResponsibleCustomerFax, paraResponsibleUserName, paraResponsibleUserTel, paraStartDate, paraEndDate, paraUserNames,
                    paraUserCount, paraEquipsCount, paraFalutInfo, paraReturnMoney, paraExplain, paraSatisfiedQuality, paraSatisfiedService, paraSatisfiedDeliver, paraSatisfiedPrice,
                    paraSuggestAppearance, paraSuggestAttitude, paraSuggestPrice);
            }
            catch (Exception e)
            {
                LogHelper.WriteLog(typeof(ServiceInfoDao), e.ToString());
                throw;
            }
        }
    }
}

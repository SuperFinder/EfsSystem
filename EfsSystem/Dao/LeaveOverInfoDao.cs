﻿using System;
using System.Collections;
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
    public class LeaveOverInfoDao
    {
        ServiceInfoDao serviceInfoDao = new ServiceInfoDao();
        public void addLeaveOverInfo(List<LeaveOverInfo> leaveOverInfos)
        {
            int serviceId = serviceInfoDao.getMaxId();
            try
            {
                foreach (LeaveOverInfo leaveOverInfo in leaveOverInfos)
                {
                    MySqlParameter paraEquipName = new MySqlParameter("@paraEquipName", leaveOverInfo.equipName);
                    MySqlParameter paraEquipVersion = new MySqlParameter("@paraEquipVersion", leaveOverInfo.equipVersion);
                    MySqlParameter paraFalutInfo = new MySqlParameter("@paraFalutInfo", leaveOverInfo.falutInfo);
                    MySqlParameter paraMaintenanceMode = new MySqlParameter("@paraMaintenanceMode", leaveOverInfo.maintenance);
                    MySqlParameter paraSparePartName = new MySqlParameter("@paraSparePartName", leaveOverInfo.sparePartName);
                    MySqlParameter paraSparePartVersion = new MySqlParameter("@paraSparePartVersion", leaveOverInfo.sparePartVersion);
                    MySqlParameter paraSparePartSpecification = new MySqlParameter("@paraSparePartSpecification", leaveOverInfo.sparePartSpecification);
                    MySqlParameter paraSparePartPartCount = new MySqlParameter("@paraSparePartPartCount", leaveOverInfo.sparePartCount);
                    MySqlParameter ParaServiceId = new MySqlParameter("@ParaServiceId", serviceId);
                    string sql =
                        "INSERT INTO `leave_over_infos`(`equip_name`,`equip_version`,`falut_info`,`maintenance mode`,`spare_part_name`,`spare_part_version`,`spare_part_specification`,`spare_part_count`,`service_id`) values(@paraEquipName,@paraEquipVersion,@paraFalutInfo,@paraMaintenanceMode,@paraSparePartName,@paraSparePartVersion,@paraSparePartSpecification,@paraSparePartPartCount,@ParaServiceId)";
                    MySqlHelper.ExecuteNonQuery(MySqlHelper.conn, CommandType.Text, sql, paraEquipName, paraEquipVersion, paraFalutInfo, paraMaintenanceMode, paraSparePartName, paraSparePartVersion,
                        paraSparePartSpecification, paraSparePartPartCount, ParaServiceId);
                }
            }
            catch (Exception e)
            {
                LogHelper.WriteLog(typeof(LeaveOverInfoDao), e.ToString());
                throw;
            }
        }

        public DataSet getLeaveOverInfos(DateTime starDateTime, DateTime endDateTime, string unitName, string responsibleUserName, string serviceStyle)
        {
            ArrayList paraList = new ArrayList();
            MySqlParameter paraStartTime = new MySqlParameter("@paraStartTime", starDateTime);
            MySqlParameter paraEndTime = new MySqlParameter("@paraEndTime", endDateTime);
            MySqlParameter paraUnitName = new MySqlParameter("@paraUnitName", unitName);
            MySqlParameter paraResponsibleUserName = new MySqlParameter("@paraResponsibleUserName", responsibleUserName);
            MySqlParameter paraServiceStyle = new MySqlParameter("@paraServiceStyle", serviceStyle);
            paraList.Add(paraStartTime);
            paraList.Add(paraEndTime);
            string sql = "SELECT a.`equip_name`,a.`equip_version`,a.`falut_info`,a.`maintenance_mode`,a.`spare_part_name`,a.`spare_part_version`,a.`spare_part_specification`,a.`spare_part_count`,a.`service_id`,b.`start_date`,b.`end_date` FROM `leave_over_infos` a,`services` b WHERE b.`start_date` > @paraStartTime and b.`end_date` < @paraEndTime and a.service_id = b.id";
            if (unitName != "全部" && unitName != "请选择单位")
            {
                sql += "and b.unit_name = @paraUnitName ";
                paraList.Add(paraUnitName);
            }
            if (responsibleUserName != "全部" && responsibleUserName != "请选择带队人")
            {
                sql += "and b.responsible_user_name = @paraResponsibleUserName ";
                paraList.Add(paraResponsibleUserName);
            }
            if (serviceStyle != "全部" && serviceStyle != "请选择服务类型")
            {
                sql += "and b.service_style = @paraServiceStyle";
                paraList.Add(paraServiceStyle);
            }
            return MySqlHelper.GetDataSet(MySqlHelper.conn, CommandType.Text, sql, (MySqlParameter[])paraList.ToArray(typeof(MySqlParameter)));
        }
    }
}

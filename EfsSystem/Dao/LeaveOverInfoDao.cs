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
    }
}

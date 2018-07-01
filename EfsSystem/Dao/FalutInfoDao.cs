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
    public class FalutInfoDao
    {
        ServiceInfoDao serviceInfoDao = new ServiceInfoDao();
        public void addFaultInfo(List<FalutInfo> falutInfos)
        {
            int serviceId = serviceInfoDao.getMaxId();
            try
            {
                foreach (FalutInfo falutInfo in falutInfos)
                {
                    MySqlParameter paraEquipName = new MySqlParameter("@paraEquipName", falutInfo.equipName);
                    MySqlParameter paraEquipVersion = new MySqlParameter("@paraEquipVersion", falutInfo.equipVersion);
                    MySqlParameter paraFalutInfo = new MySqlParameter("@paraFalutInfo", falutInfo.falutInfo);
                    MySqlParameter paraMaintenanceMode = new MySqlParameter("@paraMaintenanceMode", falutInfo.maintenance);
                    MySqlParameter paraSparePartName = new MySqlParameter("@paraSparePartName", falutInfo.sparePartName);
                    MySqlParameter paraSparePartVersion = new MySqlParameter("@paraSparePartVersion", falutInfo.sparePartVersion);
                    MySqlParameter paraSparePartSpecification = new MySqlParameter("@paraSparePartSpecification", falutInfo.sparePartSpecification);
                    MySqlParameter paraSparePartPartCount = new MySqlParameter("@paraSparePartPartCount", falutInfo.sparePartCount);
                    MySqlParameter ParaServiceId = new MySqlParameter("@ParaServiceId", serviceId);
                    string sql =
                        "INSERT INTO `falut_infos`(`equip_name`,`equip_version`,`falut_info`,`maintenance mode`,`spare_part_name`,`spare_part_version`,`spare_part_specification`,`spare_part_count`,`service_id`) values(@paraEquipName,@paraEquipVersion,@paraFalutInfo,@paraMaintenanceMode,@paraSparePartName,@paraSparePartVersion,@paraSparePartSpecification,@paraSparePartPartCount,@ParaServiceId)";
                    MySqlHelper.ExecuteNonQuery(MySqlHelper.conn, CommandType.Text,sql, paraEquipName, paraEquipVersion, paraFalutInfo, paraMaintenanceMode, paraSparePartName, paraSparePartVersion,
                        paraSparePartSpecification, paraSparePartPartCount, ParaServiceId);
                }
            }
            catch (Exception e)
            {
                LogHelper.WriteLog(typeof(FalutInfoDao),e.ToString());
                throw;
            }
        }
    }
}

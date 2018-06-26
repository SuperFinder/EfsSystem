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
    public class SparePartDao
    {
        public void addOrUpdateSparePart(string sparePartId,string SparePartName,string SparePartVersion,string SparePartSpecification)
        {
            try
            {
                MySqlParameter paraPartName = new MySqlParameter("@paraPartName", SparePartName);
                MySqlParameter paraPartVersion = new MySqlParameter("@paraPartVesion", SparePartVersion);
                MySqlParameter paraPartSpecification = new MySqlParameter("@paraPartSpecification", SparePartSpecification);
                if (sparePartId != string.Empty)
                {
                    MySqlParameter paraId = new MySqlParameter("@paraId", sparePartId);
                    string sql = "update spare_parts set spare_part_name = @paraPartName, spare_part_version = @paraPartVesion, spare_part_specification = @paraPartSpecification where id = @paraId";
                    MySqlHelper.ExecuteNonQuery(common.MySqlHelper.conn, CommandType.Text, sql, paraPartName, paraPartVersion, paraPartSpecification, paraId);
                }
                else
                {
                    string sql = "insert into spare_parts(spare_part_name,spare_part_version,spare_part_specification) values(@paraPartName,@paraPartVesion,@paraPartSpecification)";
                    MySqlHelper.ExecuteNonQuery(MySqlHelper.conn, CommandType.Text, sql, paraPartName, paraPartVersion, paraPartSpecification);
                }

            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(typeof(FormAddSparePart), ex.ToString());
            }
        }

        public SparePart getSparePart(string sparePartId)
        {
            SparePart sparePart = new SparePart();
            try
            {
                if (sparePartId != String.Empty)
                {
                    MySqlParameter paraId = new MySqlParameter("@paraId", sparePartId);
                    string sql = "select spare_part_name,spare_part_version,spare_part_specification from spare_parts where id = @paraId";
                    MySqlDataReader mySqlDataReader = MySqlHelper.ExecuteReader(MySqlHelper.conn, CommandType.Text, sql, paraId);
                    if (mySqlDataReader.Read())
                    {
                        sparePart.sparePartName = (string)mySqlDataReader["spare_part_name"];
                        sparePart.sparePartVersion = (string)mySqlDataReader["spare_part_version"];
                        sparePart.sparePartSpecification = (string)mySqlDataReader["spare_part_specification"];
                    }
                    mySqlDataReader.Close();
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(typeof(FormAddSparePart), ex.ToString());
            }
            return sparePart;
        }

        public List<SparePart> getAllSparePart()
        {
            List<SparePart> spareParts = new List<SparePart>();
            try
            {
                string sql = "select spare_part_name,spare_part_version,spare_part_specification from spare_parts";
                MySqlDataReader mySqlDataReader = MySqlHelper.ExecuteReader(MySqlHelper.conn, CommandType.Text, sql, null);
                while (mySqlDataReader.Read())
                {
                    SparePart sparePart = new SparePart
                    {
                        sparePartName = (string) mySqlDataReader["spare_part_name"],
                        sparePartVersion = (string) mySqlDataReader["spare_part_version"],
                        sparePartSpecification = (string) mySqlDataReader["spare_part_specification"]
                    };
                    spareParts.Add(sparePart);
                }
                mySqlDataReader.Close();
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(typeof(FormAddSparePart), ex.ToString());
            }
            return spareParts;
        }
    }
}

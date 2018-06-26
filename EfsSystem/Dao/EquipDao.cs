using System;
using System.Collections.Generic;
using System.Data;
using EfsSystem.common;
using EfsSystem.Entity;
using MySql.Data.MySqlClient;
using MySqlHelper = EfsSystem.common.MySqlHelper;

namespace EfsSystem.Dao
{
    public class EquipDao
    {
        public void addOrUpdateEquip(string equipId, string name, string number, string version, string specification)
        {
            try
            {
                var paraName = new MySqlParameter("@paraName", name);
                var paraNumber = new MySqlParameter("@paraNumber", number);
                var paraVersion = new MySqlParameter("@paraVersion", version);
                var paraSpecification = new MySqlParameter("@paraSpecification", specification);
                if (equipId != string.Empty)
                {
                    var paraId = new MySqlParameter("@paraId", equipId);
                    var sql = "update equips set name = @paraName, number = @paraNumber, version = @paraVersion, specification = @paraSpecification where id = @paraId";
                    MySqlHelper.ExecuteNonQuery(MySqlHelper.conn, CommandType.Text, sql, paraName, paraNumber, paraVersion, paraSpecification, paraId);
                }
                else
                {
                    var sql = "insert into equips(name,number,version,specification) values(@paraName,@paraNumber,@paraVersion,@paraSpecification)";
                    MySqlHelper.ExecuteNonQuery(MySqlHelper.conn, CommandType.Text, sql, paraName, paraNumber, paraVersion, paraSpecification);
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(typeof(FormAddEquip), ex.ToString());
            }
        }

        public Equip getEquip(string equipId)
        {
            var equip = new Equip();
            if (equipId != string.Empty)
            {
                var paraId = new MySqlParameter("@paraId", equipId);
                var sql = "select name,number,version,specification from equips where id = @paraId";
                var mySqlDataReader = MySqlHelper.ExecuteReader(MySqlHelper.conn, CommandType.Text, sql, paraId);
                if (mySqlDataReader.Read())
                {
                    equip.name = (string) mySqlDataReader["name"];
                    equip.number = (string) mySqlDataReader["number"];
                    equip.version = (string) mySqlDataReader["version"];
                    equip.specification = (string) mySqlDataReader["specification"];
                }
                mySqlDataReader.Close();
            }
            return equip;
        }

        public List<Equip> getAllEquip()
        {
            var equips = new List<Equip>();
            var sql = "select name,number,version,specification from equips";
            var mySqlDataReader = MySqlHelper.ExecuteReader(MySqlHelper.conn, CommandType.Text, sql, null);
            while (mySqlDataReader.Read())
            {
                var equip = new Equip();
                equip.name = (string) mySqlDataReader["name"];
                equip.number = (string) mySqlDataReader["number"];
                equip.version = (string) mySqlDataReader["version"];
                equip.specification = (string) mySqlDataReader["specification"];
                equips.Add(equip);
            }
            mySqlDataReader.Close();
            return equips;
        }
    }
}
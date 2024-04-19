﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ISA_BANK.DB_CLASS
{
    internal class Koneksi
    {
        private MySqlConnection koneksiDB;

        #region Properties
        public MySqlConnection KoneksiDB { get => koneksiDB; private set => koneksiDB = value; }
        #endregion

        #region Constructors
        public Koneksi(string pServer, string pDatabase, string pUsername, string pPassword)
        {
            string strCon = "server=" + pServer + ";database=" + pDatabase +
                ";uid=" + pUsername + ";password=" + pPassword;

            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = strCon;

            //panggil method connect ke database
            Connect();
        }

        public Koneksi()
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            ConfigurationSectionGroup userSettings = myConf.SectionGroups["userSettings"];

            var settingsSection = userSettings.Sections["ISA_BANK.Properties.dbsetting"] as ClientSettingsSection;

            string DbServer = settingsSection.Settings.Get("DbServer").Value.ValueXml.InnerText;
            string DbName = settingsSection.Settings.Get("DbName").Value.ValueXml.InnerText;
            string DbUsername = settingsSection.Settings.Get("DbUsername").Value.ValueXml.InnerText;
            string DbPassword = settingsSection.Settings.Get("DbPassword").Value.ValueXml.InnerText;

            string strCon = "server=" + DbServer + ";database=" + DbName +
                ";uid=" + DbUsername + ";password=" + DbPassword;
            KoneksiDB = new MySqlConnection();

            KoneksiDB.ConnectionString = strCon;

            Connect();
        }
        #endregion

        #region Methods
        public void Connect()
        {
            if (KoneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }
            KoneksiDB.Open();
        }

        public static MySqlDataReader JalankanPerintahQuery(string sql)
        {
            Koneksi k = new Koneksi();
            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);

            MySqlDataReader hasil = c.ExecuteReader();

            return hasil;
        }

        public static int JalankanPerintahDML(string sql)
        {
            Koneksi k = new Koneksi();
            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);

            int hasil = c.ExecuteNonQuery();

            return hasil;
        }
        #endregion
    }
}


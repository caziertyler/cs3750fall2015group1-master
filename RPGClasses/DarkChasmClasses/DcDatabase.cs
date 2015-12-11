using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using DarkChasmDatabase.DcDatabaseClasses;

namespace DarkChasmDatabase
{
    public static class DcDatabase
    {
        private static SQLiteConnection dbConnection;
        public static string SerializeGame(object game)
        {
            XmlSerializer x = new XmlSerializer(game.GetType());
            //Console.WriteLine(game.GetType());
            TextWriter textWriter = new StringWriter();
            x.Serialize(textWriter, game);
            //Console.WriteLine(textWriter);
            return textWriter.ToString();
        }
        public static object DeserializeGame(string game, Type type)
        {
            XmlSerializer x = new XmlSerializer(type);
            TextReader textReader = new StringReader(game);
            XmlReader xmlReader = new XmlTextReader(textReader);
            return Convert.ChangeType(x.Deserialize(xmlReader),type);
        }
        public static bool SaveGame(int id, object game)
        {
            string sql;
            string modifiedDateTime = DateTime.Now.ToString("yyyyMMdd HH:mm:ss");
            sql = "UPDATE gamesave SET `data`=@parameter, `type`='"+game.GetType()+"', `modifiedDate`='" + modifiedDateTime + "' WHERE `id` = " + id + ";";
            SQLiteCommand command = dbConnection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Parameters.Add(new SQLiteParameter("parameter", SerializeGame(game)));
            return (command.ExecuteNonQuery()==1);
        }
        public static object LoadGame(int id)
        {
            string sql;
            SQLiteCommand command;
            sql = "SELECT `type`,`data` FROM `gamesave` WHERE `id` = " + id + ";";
            command = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                var type = Type.GetType(reader["type"] as string);
                var data = reader["data"] as string;
                return DeserializeGame(data,type);
            }
            return false;
        }
        public static bool InitializeDatabase()
        {
            string sql;
            SQLiteCommand command;
            if (!File.Exists("DarkChasm.sqlite"))
            {
                SQLiteConnection.CreateFile("DarkChasm.sqlite");
            }
            dbConnection = new SQLiteConnection("Data Source=DarkChasm.sqlite;Version=3;");
            dbConnection.Open();
            sql = @"CREATE TABLE IF NOT EXISTS `setting` (
                `id` INTEGER PRIMARY KEY ASC,
                `gamesaveId` INTEGER,
                `settingName` TEXT,
                `settingValue` INTEGER
                );";
            command = new SQLiteCommand(sql, dbConnection);
            command.ExecuteNonQuery();
            sql = @"CREATE TABLE IF NOT EXISTS `gamesave` ( 
                `id` INTEGER PRIMARY KEY ASC,
                `name` TEXT,
                `chapter` INTEGER,
                `createdDate` TEXT,
                `modifiedDate` TEXT,
                `type` TEXT,
                `data` TEXT
                )";
            command = new SQLiteCommand(sql, dbConnection);
            command.ExecuteNonQuery();
            return true;
        }
        public static bool RenameGame(int id, string name)
        {
            SQLiteCommand command;
            string sql = "UPDATE `gamesave` SET `name` = '" + name + "' where `id` = " + id+";";
            command = new SQLiteCommand(sql, dbConnection);
            return (command.ExecuteNonQuery() != 0);
        }
        public static bool DeleteGame(int id)
        {
            SQLiteCommand command;
            string sql = "delete from gamesave where `id` = " + id;
            command = new SQLiteCommand(sql, dbConnection);
            return (command.ExecuteNonQuery() != 0);
        }
        public static int NewGame()
        {
            string sql;
            SQLiteCommand command;
            string currentDateTime = DateTime.Now.ToString("yyyyMMdd HH:mm:ss");
            sql = "insert into gamesave (`name`,`createdDate`, `modifiedDate`) values ('','" + currentDateTime + "', '" + currentDateTime + "')";
            command = new SQLiteCommand(sql, dbConnection);
            command.ExecuteNonQuery();
            sql = "select last_insert_rowid()";
            command = new SQLiteCommand(sql, dbConnection);
            int lastId = Convert.ToInt32(command.ExecuteScalar());
            return lastId;
        }
        public static List<DcDatabaseSavedGame> GetSavedGames()
        {
            string sql;
            SQLiteCommand command;
            var list = new List<DcDatabaseSavedGame>();
            sql = "select * from gamesave order by modifiedDate desc";
            command = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DcDatabaseSavedGame game = new DcDatabaseSavedGame
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Name = reader["name"] as string,
                    Chapter = reader["chapter"] as string,
                    CreatedDate = reader["createdDate"] as string,
                    ModifiedDate = reader["modifiedDate"] as string,
                    Data = reader["data"] as string,
                    Type = reader["type"] as string
                };
                list.Add(game);
            }
            return list;
        }
        public static List<DcDatabaseSetting> GetSettings(int id)
        {
            SQLiteCommand command;
            string sql;
            List<DcDatabaseSetting> list = new List<DcDatabaseSetting>();
            sql = "select * from settings where gamesaveId = " + id;
            command = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DcDatabaseSetting databaseSetting = new DcDatabaseSetting
                {
                    GamesaveId = Convert.ToInt32(reader["gamesaveId"]),
                    Id = Convert.ToInt32(reader["Id"]),
                    SettingName = Convert.ToString(reader["settingName"]),
                    SettingValue = Convert.ToInt32(reader["settingValue"])
                };
                list.Add(databaseSetting);
            }
            return list;
        }
        public static bool SaveSetting(int id, string settingName, string settingValue) //NOT YET IMPLEMENTED
        {
            return true;
        }

        //For testing:
        public static void DeleteDb()
        {
            if (File.Exists("DarkChasm.sqlite"))
            {
                File.Delete("DarkChasm.sqlite");
            }
        }
    }
}

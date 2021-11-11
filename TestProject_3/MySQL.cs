using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MDM
{
    public static class MySQL
    {
        public static MySqlConnection myConnection;
        public static bool Try_Connect_to_mysql()
        {
            MySqlDataAdapter adapter = null;
            
            MySqlConnectionStringBuilder mysqlCSB = new MySqlConnectionStringBuilder();
            //доменное имя
            mysqlCSB.Server = "mysql.hosting.nic.ru";
            //логин от сервера mySql
            mysqlCSB.UserID = "alex683275_bazau";
            //пароль
            mysqlCSB.Password = "Auesila_1488";
            //кодировка символов
            mysqlCSB.CharacterSet = "utf8";
            //порт
            mysqlCSB.Port = 3306;
            //имя базы данных
            mysqlCSB.Database = "alex683275_baza";
            //создание подключения
             MySQL.myConnection = new MySqlConnection(mysqlCSB.ConnectionString);
            try
            {
                //открытие подключения
                MySQL.myConnection.Open();
               // MySQL.myConnection.Close();
                return true;
                //adapter = new MySqlDataAdapter(command, myConnection);
               // table = new DataTable();
                //adapter.Fill(table);

                //eturn table;

            }
            //при наличии ошибки выводим ее
            catch (Exception ex)
            {
                return false;
            }
          
        }
        public static bool ExMysqlCommandAuth(string command) {

            MySqlDataAdapter adapter = null;

            MySqlConnectionStringBuilder mysqlCSB = new MySqlConnectionStringBuilder();
            //доменное имя
    
            //создание подключения
            MySqlConnection myConnection = new MySqlConnection(mysqlCSB.ConnectionString);
           
                //открытие подключения
               // myConnection.Open();
                MySqlCommand myCommand = new MySqlCommand(command, MySQL.myConnection);
                myCommand.ExecuteNonQuery();

                var result = Int32.Parse(myCommand.ExecuteScalar().ToString());
            //если вход выполнен
            if (result > 0)
            {
               // myConnection.Close();
                return true;
                //adapter = new MySqlDataAdapter(command, myConnection);
                // table = new DataTable();
                //adapter.Fill(table);

                //eturn table;
            }

            else
            {
                //при наличии ошибки выводим ее

                return false;
            }
        }

        public static DataTable FillDataTable(string command)
        {
            MySqlDataAdapter adapter = null;
            DataTable table = null;
            MySqlConnectionStringBuilder mysqlCSB = new MySqlConnectionStringBuilder();
            //доменное имя
       
            //создание подключения
            MySqlConnection myConnection = new MySqlConnection(mysqlCSB.ConnectionString);
            try
            {
                //открытие подключения
              //  myConnection.Open();
                adapter = new MySqlDataAdapter(command, MySQL.myConnection);
                table = new DataTable();
                adapter.Fill(table);
                //myConnection.Close();
                return table;

            }
            //при наличии ошибки выводим ее
            catch (Exception ex)
            {
               
            }
            return null;
        }
        public static bool ExMysqlCommand(string command)
        {

            MySqlDataAdapter adapter = null;

            MySqlConnectionStringBuilder mysqlCSB = new MySqlConnectionStringBuilder();
            //доменное имя
      
            //создание подключения
            MySqlConnection myConnection = new MySqlConnection(mysqlCSB.ConnectionString);

            //открытие подключения
           // myConnection.Open();
            MySqlCommand myCommand = new MySqlCommand(command, MySQL.myConnection);
            myCommand.ExecuteNonQuery();
            //myConnection.Close();
            return true;
            //var result = Int32.Parse(myCommand.ExecuteScalar().ToString());
            //если вход выполнен
           
        }
    }
}

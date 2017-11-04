using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema_de_Nomina
{
    class DbConnection
    {
        
            private MySqlConnection connection;
            private string server;
            private string database;
            private string uid;
            private string password;

            //Constructor
            public DbConnection()
            {
                Initialize();
            }

            //Initialize values
            private void Initialize()
            {
                server = "localhost";
                database = "connectcsharptomysql";
                uid = "username";
                password = "password";
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

                connection = new MySqlConnection(connectionString);
            }

            //open connection to database
            private void OpenConnection()
            {
            }

            //Close connection
            private void  CloseConnection()
            {
            }

            //Insert statement
            public void Insert()
            {
            }

            //Update statement
            public void Update()
            {
            }

            //Delete statement
            public void Delete()
            {
            }

            //Select statement
            public List<string>[] Select()
            {
            }

            //Count statement
            public int Count()
            {
            }

            //Backup
            public void Backup()
            {
            }

            //Restore
            public void Restore()
            {
            }
        }
    }


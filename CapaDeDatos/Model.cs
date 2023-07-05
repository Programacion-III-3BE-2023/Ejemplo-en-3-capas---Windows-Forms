using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace CapaDeDatos
{
    public abstract class Model
    {
        public string DatabaseIp;
        public string DatabaseUser;
        public string DatabasePassword;
        public string DatabaseName;

        public MySqlConnection Connection;
        public MySqlCommand Command;
        public MySqlDataReader Reader;

        public Model()
        {
            this.DatabaseIp = "192.168.241.1";
            this.DatabaseUser = "root";
            this.DatabasePassword = "root";
            this.DatabaseName = "modelos";

            this.Connection = new MySqlConnection(            
                $"server={this.DatabaseIp};" +
                $"user={this.DatabaseUser};" +
                $"password={this.DatabasePassword};" +
                $"database={this.DatabaseName};"
            );

            this.Connection.Open();

            this.Command = new MySqlCommand();
            this.Command.Connection = this.Connection;
        }
    }
}

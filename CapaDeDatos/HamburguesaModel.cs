using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace CapaDeDatos
{
    public class HamburguesaModel : Model
    {
        public int Id;
        public string Nombre;
        public int Precio;

        public void Save()
        {
            this.Command.CommandText = $"INSERT INTO hamburguesas(nombre,precio) VALUES ('{this.Nombre}',{this.Precio})";
            this.Command.ExecuteNonQuery();

        }

        public List<HamburguesaModel> Todos()
        {
            this.Command.CommandText = "SELECT * FROM hamburguesas";
            this.Reader = this.Command.ExecuteReader();

            List<HamburguesaModel> resultado = new List<HamburguesaModel>();

            while(this.Reader.Read())
            {
                HamburguesaModel elemento = new HamburguesaModel();
                elemento.Id = Int32.Parse(this.Reader["Id"].ToString());
                elemento.Nombre = this.Reader["Nombre"].ToString();
                elemento.Precio = Int32.Parse(this.Reader["Precio"].ToString());
                resultado.Add(elemento);

            }

            return resultado;
        }

    }
}

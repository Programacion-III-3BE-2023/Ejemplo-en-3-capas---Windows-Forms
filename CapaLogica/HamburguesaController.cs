﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using System.Data;

namespace CapaLogica
{
    public static class HamburguesaController
    {
        public static void Crear(string nombre, int precio)
        {
            HamburguesaModel hamburguesa = new HamburguesaModel();

            hamburguesa.Nombre = nombre;
            hamburguesa.Precio = precio;

            hamburguesa.Save();

        }

        public static DataTable Obtener()
        {
            HamburguesaModel h = new HamburguesaModel();
            List<HamburguesaModel> hamburguesas = h.Todos();

            DataTable tabla = new DataTable();

            tabla.Columns.Add("Id", typeof(int));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Precio", typeof(int));

            foreach (HamburguesaModel hamburguesa in hamburguesas)
            {
                DataRow fila = tabla.NewRow();
                fila["Id"] = hamburguesa.Id;
                fila["Nombre"] = hamburguesa.Nombre;
                fila["Precio"] = hamburguesa.Precio;
                tabla.Rows.Add(fila);
                
            }

            return tabla;
            

        } 

    }
}

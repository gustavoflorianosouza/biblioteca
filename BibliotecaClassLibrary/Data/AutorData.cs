using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BibliotecaClassLibrary.Entity;

namespace BibliotecaClassLibrary.Data
{
    internal class AutorData : DBConnection
    {
        internal AutorData(string strConn) : base(strConn) { }

        internal void Create(Autor e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Autor values (@nome)";
            cmd.Parameters.AddWithValue("@nome", e.Nome);
            cmd.ExecuteNonQuery();
        }

        internal void Update(Autor e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update Autor set nome=@nome where=@id";
            cmd.Parameters.AddWithValue("@nome", e.Nome);
            cmd.ExecuteNonQuery();
        }
    }

}

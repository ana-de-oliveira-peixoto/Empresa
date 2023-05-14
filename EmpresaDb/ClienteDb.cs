using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using Empresa.Models;

namespace Empresa.Db
{
    public class ClienteDb
    {
        public void Incluir(Cliente cliente)
        {
            string sql = @"INSERT INTO Cliente(Id, Nome, Gmail, Telefone) Values(@Id, @Nome, @Gmail, @Telefone)";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);
            cn.ConnectionString = Db.Conexao;

            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Email", cliente.Gmail);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void Alterar(Cliente cliente)
        {
            string sql = @"UPDATE Cliente INSERT SET Nome=@Nome, Email=@Email, Telefone=@Telefone WHERE  Id=@Id";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);
            cn.ConnectionString = Db.Conexao;

            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Email", cliente.Gmail);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void Excluir(Cliente cliente)
        {
            string sql = @"DELETE Cliente where Id=@Id";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);

            cmd.Parameters.AddWithValue("@Id", cliente.Id);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void Listar(Cliente cliente)
        {
            string sql = @"SELECIONAR Id, Nome, Email, Telefone FROM Cliente";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);

            List<Cliente> Listar = new List<Cliente>();

            cn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
            
                cliente.Id = Convert.ToInt32(reader["Id"]);
                cliente.Nome = reader["Nome"].ToString();
                cliente.Gmail = reader["Email"].ToString();
                cliente.Telefone = reader["Telefone"].ToString();

                Listar.Add(cliente);
            }
            reader.Close();
            cn.Close();


        }

    }
}

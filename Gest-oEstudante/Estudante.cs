using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Gest_oEstudante
{
    internal class estudantes
    {
        Meu_BD bancoDeDados = new Meu_BD();

        public object Comando { get; private set; }

        // private object nascimento;

        public bool inserirEstudantes(string Nome, string Sobrenome,
            DateTime Nacimento, string Telefone, string Genero, 
            string Endereco, MemoryStream Foto)
        {
            MySqlCommand comando = new MySqlCommand("INSERT INTO `estudantes`(`Nome`, `Sobrenome`, `Nascimento`, `Genero`, `Telefone`, `Endereco`, `Foto`) VALUES (@nm,@sbn,@nsc,@gen,@tel,@end,@fot)",
                bancoDeDados.getConexao);

            comando.Parameters.Add("@nm", MySqlDbType.VarChar).Value = Nome;
            comando.Parameters.Add("@sbn", MySqlDbType.VarChar).Value = Sobrenome;
            comando.Parameters.Add("@nsc", MySqlDbType.Date). Value= Nacimento;
            comando.Parameters.Add("@gen", MySqlDbType.VarChar).Value = Genero;
            comando.Parameters.Add("@tel", MySqlDbType.VarChar).Value = Telefone;
            comando.Parameters.Add("@end", MySqlDbType.VarChar).Value = Endereco;
            comando.Parameters.Add("@fot", MySqlDbType.LongBlob).Value = Foto.ToArray();

            bancoDeDados.abrirConexao();
            if (comando.ExecuteNonQuery() == 1)
            {
                bancoDeDados.fecharConexao();
                return true;
            }
            else
            {
                bancoDeDados.fecharConexao();
                return false;
            }
        }
        public bool atualizarEstudante (int id, string Nome, string Sobrenome,
           DateTime Nacimento, string Telefone, string Genero,
           string Endereco, MemoryStream Foto)
        {
            MySqlCommand comando = new MySqlCommand("UPDATE `estudantes` SET `Nome`=@nm,`Sobrenome`=@sbn,`Nascimento`=@nsc,`Genero`=@gen,`Telefone`=@tel,`Endereco`=@end,`Foto`=@fot WHERE `id` = @id",bancoDeDados.getConexao);

            comando.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            comando.Parameters.Add("@nm", MySqlDbType.VarChar).Value = Nome;
            comando.Parameters.Add("@sbn", MySqlDbType.VarChar).Value = Sobrenome;
            comando.Parameters.Add("@nsc", MySqlDbType.Date).Value = Nacimento;
            comando.Parameters.Add("@gen", MySqlDbType.VarChar).Value = Genero;
            comando.Parameters.Add("@tel", MySqlDbType.VarChar).Value = Telefone;
            comando.Parameters.Add("@end", MySqlDbType.VarChar).Value = Endereco;
            comando.Parameters.Add("@fot", MySqlDbType.LongBlob).Value = Foto.ToArray();

            bancoDeDados.abrirConexao();
            if (comando.ExecuteNonQuery() == 1)
            {
                bancoDeDados.fecharConexao();
                return true;
            }
            else
            {
                bancoDeDados.fecharConexao();
                return false;
            }
        }
        public bool deletarEstudante(int id) 
        {
            MySqlCommand comando = new MySqlCommand("DELETE FROM `estudantes` WHERE `id` = estudantes");
            comando.Parameters.Add("estudantes", MySqlDbType.Int32).Value = id;

            bancoDeDados.abrirConexao();

            if(comando.ExecuteNonQuery() == 1)
            {
                bancoDeDados.fecharConexao();
                return true;
            }
            else
            {
                bancoDeDados.fecharConexao();
                return false;
            }
        }

        public DataTable getEstudantes(MySqlCommand comando)
        {
            comando.Connection = bancoDeDados.getConexao;
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabela= new DataTable();
            adaptador.Fill(tabela);

            return tabela;

        }
    }
}

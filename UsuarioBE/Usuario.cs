using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using FuncoesAuxiliares;
namespace UsuarioBE
{
    public class Usuario
    {

        #region PROPRIEDADES
        public int Id { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public string UserName { get; set; }
        public string Senha { get; set; }
        public int Perfil { get; set; }
        public string IsSupervisor { get; set; }
        #endregion

        public int Insert()
        {
            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO u_usuario_tb (nome, rg, cpf, endereco, complemento, num_celular, num_telefone, usuario, senha, perfil) VALUES (@nome, @rg, @cpf, @endereco, @complemento, @num_celular, @num_telefone, @usuario, @senha, @perfil); RETURNING id;");
            cmd.Parameters.AddWithValue(@"nome", Nome);
            cmd.Parameters.AddWithValue(@"rg", RG);
            cmd.Parameters.AddWithValue(@"cpf", CPF);
            cmd.Parameters.AddWithValue(@"endereco", Endereco);
            cmd.Parameters.AddWithValue(@"complemento", Complemento);
            cmd.Parameters.AddWithValue(@"num_celular", Celular);
            cmd.Parameters.AddWithValue(@"num_telefone", Telefone);
            cmd.Parameters.AddWithValue(@"usuario", UserName);
            cmd.Parameters.AddWithValue(@"senha", Access.Encrypt(UserName, Senha));
            cmd.Parameters.AddWithValue(@"perfil", Perfil);

            return Access.ExecuteScalar(cmd);
        }


        public bool Update()
        {
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE u_usuario_tb SET nome = @nome, rg = @rg, cpf = @cpf, endereco = @endereco, complemento = @complemento, num_celular = @num_celular, num_telefone = @num_telefone, usuario = @usuario, senha = @senha, perfil = @perfil");
            cmd.Parameters.AddWithValue(@"id_usuario", Id);
            cmd.Parameters.AddWithValue(@"nome", Nome);
            cmd.Parameters.AddWithValue(@"rg", RG);
            cmd.Parameters.AddWithValue(@"cpf", CPF);
            cmd.Parameters.AddWithValue(@"endereco", Endereco);
            cmd.Parameters.AddWithValue(@"complemento", Complemento);
            cmd.Parameters.AddWithValue(@"num_celular", Celular);
            cmd.Parameters.AddWithValue(@"num_telefone", Telefone);
            cmd.Parameters.AddWithValue(@"usuario", UserName);
            cmd.Parameters.AddWithValue(@"senha", Access.Encrypt(UserName, Senha));
            cmd.Parameters.AddWithValue(@"perfil", Perfil);

            return Access.ExecuteNonQuery(cmd);
        }


        public static bool Delete(int id)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM u_usuario_tb WHERE id_usuario = " + id);
            return Access.ExecuteNonQuery(cmd);
        }

        public static bool Logar(string usuario, string senha)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT usuario, senha WHERE usuario  = '" + usuario + "' ;");
            DataSet ds = Access.ExecuteReader(cmd);
            string password = "";
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                password = dr["senha"].ToString();
                break;
            }
            return senha == Access.Decrypt(usuario, password);
        }
    }
}

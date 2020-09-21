using FuncoesAuxiliares;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaBE
{
    public class Cliente
    {
        #region        VARIAVEIS



        #endregion




        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Tipo_Cliente { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Numero_celular { get; set; }
        public string Numero_telefone { get; set; }
        public string Observacao { get; set; }
        /// <summary>
        /// Retorna um vetor do endereço. Dicionário de posições: 0 Nome da rua, 1 Numero, 2 Bairro, 3 Cidade, 4 UF 
        /// </summary>
        public string[] EnderecoArray
        {
            get
            {
                return Endereco.Split(',');
            }
        }

        #endregion


        #region Construtores
        public Cliente()
        {
            Id = -1;
            Nome = string.Empty;
            Rg = string.Empty;
            Cpf = string.Empty;
            Endereco = string.Empty;
            Complemento = string.Empty;
            Numero_celular = string.Empty;
            Numero_telefone = string.Empty;
            Tipo_Cliente = string.Empty;
            Observacao = string.Empty;
        }

        public Cliente(DataRow dr)
        {
            Id = Convert.ToInt32(dr["id"]);
            Nome = dr["nome"].ToString();
            Rg = dr["rg"].ToString();
            Cpf = dr["cpf"].ToString();
            Endereco = dr["endereco"].ToString();
            Complemento = dr["complemento"].ToString();
            Numero_celular = dr["numero_celular"].ToString();
            Numero_telefone = dr["numero_telefone"].ToString();
            Tipo_Cliente = dr["tipo_cliente"].ToString();
            Observacao = dr["observacao"].ToString();
        }
        #endregion


        public bool Insert()
        {
            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO a_agenda_tb (nome, rg, cpf, endereco, complemento, numero_celular, numero_telefone, tipo_cliente, observacao) VALUES (@nome, @rg, @cpf, @endereco, @complemento, @numero_celular, @numero_telefone, @tipo_cliente, @observacao) RETURNING id;");
            cmd.Parameters.AddWithValue(@"nome", Nome);
            cmd.Parameters.AddWithValue(@"rg", Rg);
            cmd.Parameters.AddWithValue(@"cpf", Cpf);
            cmd.Parameters.AddWithValue(@"endereco", Endereco);
            cmd.Parameters.AddWithValue(@"complemento", Complemento);
            cmd.Parameters.AddWithValue(@"numero_celular", Numero_celular);
            cmd.Parameters.AddWithValue(@"numero_telefone", Numero_telefone);
            cmd.Parameters.AddWithValue(@"tipo_cliente", Tipo_Cliente);
            cmd.Parameters.AddWithValue(@"observacao", Observacao);

            Id = Convert.ToInt32(Access.ExecuteScalar(cmd));
            return Id > 0;
        }

        public bool Update()
        {
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE a_agenda_tb SET nome = @nome, rg = @rg, cpf = @cpf, endereco = @endereco, complemento = @complemento, numero_celular = @numero_celular, numero_telefone = @numero_telefone, tipo_cliente =  @tipo_cliente, observacao = @observacao WHERE id = @id");
            cmd.Parameters.AddWithValue(@"id", Id);
            cmd.Parameters.AddWithValue(@"nome", Nome);
            cmd.Parameters.AddWithValue(@"rg", Rg);
            cmd.Parameters.AddWithValue(@"cpf", Cpf);
            cmd.Parameters.AddWithValue(@"endereco", Endereco);
            cmd.Parameters.AddWithValue(@"complemento", Complemento);
            cmd.Parameters.AddWithValue(@"numero_celular", Numero_celular);
            cmd.Parameters.AddWithValue(@"numero_telefone", Numero_telefone);
            cmd.Parameters.AddWithValue(@"tipo_cliente", Tipo_Cliente);
            cmd.Parameters.AddWithValue(@"observacao", Observacao);

            return Access.ExecuteNonQuery(cmd);
        }

        public static bool Delete(int id)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM a_agenda_tb WHERE id = " + id);
            return Access.ExecuteNonQuery(cmd);
        }

        public static List<Cliente> GetAllClientes()
        {
            List<Cliente> result = new List<Cliente>();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM a_agenda_tb ORDER BY nome;");

            foreach (DataRow cliente in Access.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new Cliente(cliente));
            return result;
        }

        public static List<Cliente> GetByNome(string nome)
        {
            List<Cliente> result = new List<Cliente>();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM a_agenda_tb WHERE nome LIKE @nome ORDER BY nome;");
            cmd.Parameters.AddWithValue(@"nome", nome + "%");

            foreach (DataRow cliente in Access.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new Cliente(cliente));
            return result;
        }

        public static Cliente GetById(int id)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM a_agenda_tb WHERE id = @id;");
            cmd.Parameters.AddWithValue(@"id", id);
            DataTable dt = Access.ExecuteReader(cmd).Tables[0];

            if (dt != null && dt.Rows.Count > 0)
                return new Cliente(dt.Rows[0]);
            else
                return new Cliente();
        }
        public static List<Cliente> GetByCelular(string celular)
        {
            List<Cliente> result = new List<Cliente>();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM a_agenda_tb WHERE numero_celular = @numero_celular;");
            cmd.Parameters.AddWithValue(@"numero_celular", celular);

            foreach (DataRow cliente in Access.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new Cliente(cliente));
            return result;
        }

        public static List<Cliente> GetByTelefone(string telefone)
        {
            List<Cliente> result = new List<Cliente>();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM a_agenda_tb WHERE numero_telefone = @numero_telefone;");
            cmd.Parameters.AddWithValue(@"numero_telefone", telefone);

            foreach (DataRow cliente in Access.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new Cliente(cliente));
            return result;
        }

        public static List<Cliente> GetByRg(string Rg)
        {
            List<Cliente> result = new List<Cliente>();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM a_agenda_tb WHERE rg = @rg;");
            cmd.Parameters.AddWithValue(@"rg", Rg);

            foreach (DataRow cliente in Access.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new Cliente(cliente));
            return result;
        }


        public static List<Cliente> GetAll(int limit = 100)
        {
            List<Cliente> result = new List<Cliente>();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM a_agenda_tb LIMIT " + limit);

            foreach (DataRow cliente in Access.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new Cliente(cliente));
            return result;
        }
    }

   
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using FuncoesAuxiliares;

namespace AgendaBE
{
    public class LogCliente
    {
        public int Id_log { get; set; }
        public TipoMovimento Tipo_Movimentacao { get; set; }
        public DateTime Data_log { get; set; }
        public Cliente Reg_antigo { get; set; }



        public LogCliente() { }
        public LogCliente(DataRow dr)
        {
            Id_log = Convert.ToInt32(dr["id_log"]);
            Tipo_Movimentacao = ((TipoMovimento)dr["tipo_movimento"]);
            Data_log = Convert.ToDateTime(dr["data_log"]);

            //Registro
            Reg_antigo = new Cliente();
            Reg_antigo.Id = (int)dr["id_registro"];
            Reg_antigo.Nome = dr["nome_antigo"].ToString();
            Reg_antigo.Rg = dr["rg_antigo"].ToString();
            Reg_antigo.Cpf = dr["cpf_antigo"].ToString();
            Reg_antigo.Endereco = dr["endereco_antigo"].ToString();
            Reg_antigo.Complemento = dr["complemento_antigo"].ToString();
            Reg_antigo.Numero_celular = dr["numero_celular_antigo"].ToString();
            Reg_antigo.Numero_telefone = dr["numero_telefone_antigo"].ToString();
            Reg_antigo.Tipo_Cliente = dr["tipo_cliente_antigo"].ToString();
            Reg_antigo.Observacao = dr["observacao_antigo"].ToString();

            //Implementar Usuario que fez a alteracao

        }


        public static void Insert(TipoMovimento tipo_movimentacao, DateTime data_log, Cliente reg_antigo)
        {
            string query = "INSERT INTO a_historico_tb (tipo_movimento, data_log, id_registro, nome_antigo, rg_antigo, cpf_antigo," +
                " endereco_antigo, complemento_antigo, numero_celular_antigo, " +
                "numero_telefone_antigo, tipo_cliente_antigo, observacao_antigo) VALUES (@tipo_movimento, @data_log, @id_registro," +
                " @nome_antigo, @rg_antigo, @cpf_antigo, @endereco_antigo, @complemento_antigo, @numero_celular_antigo, " +
                "@numero_telefone_antigo, @tipo_cliente_antigo, @observacao_antigo);";

            NpgsqlCommand cmd = new NpgsqlCommand(query);
            cmd.Parameters.AddWithValue(@"tipo_movimento", (int)tipo_movimentacao);
            cmd.Parameters.AddWithValue(@"data_log", data_log);
            cmd.Parameters.AddWithValue(@"id_registro", reg_antigo.Id);
            cmd.Parameters.AddWithValue(@"nome_antigo", reg_antigo.Nome);
            cmd.Parameters.AddWithValue(@"rg_antigo", reg_antigo.Rg);
            cmd.Parameters.AddWithValue(@"cpf_antigo", reg_antigo.Cpf);
            cmd.Parameters.AddWithValue(@"endereco_antigo", reg_antigo.Endereco);
            cmd.Parameters.AddWithValue(@"complemento_antigo", reg_antigo.Complemento);
            cmd.Parameters.AddWithValue(@"numero_celular_antigo", reg_antigo.Numero_celular);
            cmd.Parameters.AddWithValue(@"numero_telefone_antigo", reg_antigo.Numero_telefone);
            cmd.Parameters.AddWithValue(@"tipo_cliente_antigo", reg_antigo.Tipo_Cliente);
            cmd.Parameters.AddWithValue(@"observacao_antigo", reg_antigo.Observacao);

            Access.ExecuteNonQuery(cmd);
        }

        public static List<LogCliente> HistoricoById(int id_registro)
        {
            List<LogCliente> result = new List<LogCliente>();
            string query = "SELECT * FROM a_historico_tb WHERE id_registro = " + id_registro + " ORDER BY data_log;";
            NpgsqlCommand cmd = new NpgsqlCommand(query);
            foreach (DataRow dr in Access.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new LogCliente(dr));
            return result;
        }

        public override string ToString()
        {
            string result = "";
            string separador = "\r\n";
            //Retorna uma string com detalhes do registro.
            result += "MOVIMENTO: " + Tipo_Movimentacao.GetAtributoDoTipoEnum<DescriptionAttribute>().Description.ToUpper();
            result += separador + "ID Alteração: " + Id_log;
            result += separador + "ID Cliente: " + Reg_antigo.Id;
            result += separador + "Nome: " + Reg_antigo.Nome;
            result += separador + "RG: " + Reg_antigo.Rg;
            result += separador + "CPF: " + Reg_antigo.Cpf;
            result += separador + "Endereço: " + Reg_antigo.Endereco;
            result += separador + "Complemento: " + Reg_antigo.Complemento;
            result += separador + "Nº Celular: " + Reg_antigo.Numero_celular;
            result += separador + "Nº Telefone: " + Reg_antigo.Numero_telefone;
            result += separador + "Tipo cliente: " + Reg_antigo.Tipo_Cliente;
            result += separador + "Observação: " + Reg_antigo.Observacao;

            return result;
        }
    }

    public enum TipoMovimento : int
    {
        [Description("Inclusão")]
        Inclusao = 0,
        [Description("Alteração")]
        Alteracao = 1,
        [Description("Exclusão")]
        Exclusao = 2
    }
}

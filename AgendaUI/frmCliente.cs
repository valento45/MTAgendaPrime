﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaBE;
namespace AgendaUI
{
    public partial class frmCliente : Form
    {
        #region VARIAVEIS
        //variavel controladora para saber quando o registro está sendo alterado
        bool isAlteracao = false;

        /// <summary>
        /// RegDirty, váriavel bool para apontar se o objeto está sujo ( Se foi alterado ).
        /// </summary>
        bool RegDirty = false;
        private Cliente Cliente = null;

        #endregion


        #region CONSTRUTORES
        public frmCliente()
        {
            InitializeComponent();
        }
        #endregion
        private void btAcao_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                //Se inclusão
                if (!isAlteracao)
                {
                    Cliente cliente = new Cliente();
                    GravaDados(cliente);
                    if (cliente.Insert())
                    {
                        MessageBox.Show("Dados inseridos com sucesso !", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isAlteracao = true;
                        Cliente = cliente;
                        HabilitaDesabilitaAlteracao();
                    }
                }
                // senão, Alteração
                else
                {
                    GravaDados(Cliente);
                    if (Cliente.Update())
                    {
                        MessageBox.Show("Dados alterados com sucesso !", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        private bool GravaDados(Cliente client)
        {
            bool result = false;

            try
            {
                if (client == null)
                { if (isAlteracao) throw new Exception("Impossível alterar um registro que não foi selecionado!"); else client = new Cliente(); }

                client.Nome = txtNome.Text.Trim();
                client.Rg = txtRg.Text.Trim();
                client.Cpf = txtCelular.Text.Trim();
                client.Endereco = txtEndereco.Text.Trim() + ", " + txtNumero.Text.Trim() + ", " + txtBairro.Text.Trim() + ", " + txtCidade.Text.Trim() + ", " + cmbUf.Text.Trim();
                client.Complemento = txtComplemento.Text.Trim();
                client.Numero_telefone = txtTelefone.Text.Trim();
                client.Numero_celular = txtCelular.Text.Trim();
                client.Tipo_Cliente = cmbTipoCliente.Text.Trim();
                client.Observacao = txtObservacoes.Text.Trim();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("\r\n" + ex.Message, "Erro ao gravar os dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            return result;
        }
        //Método valida campos obrigatórios
        /// <summary>
        /// Valida preenchimento dos campos obrigatórios.
        /// </summary>
        /// <returns>Se tudo OK, true. Senão, exibe messageBox informando campos vazios e retorna false</returns>
        private bool ValidaCampos()
        {
            string[] camposObrigatorios = { "txtNome", "txtEndereco", "txtNumero", "txtBairro", "cmbUf", "txtCidade", "txtCelular" };
            string camposVazios = "";

            try
            {
                foreach (Control ctrlInCtrl in this.pnlFundo1.Controls)
                    foreach (Control ctrl in ctrlInCtrl.Controls)
                    {
                        if (ctrl is TextBox)
                        {
                            if (camposObrigatorios.Contains(ctrl.Name))
                                if (((TextBox)ctrl).Text == string.Empty)
                                    camposVazios += camposVazios == string.Empty ? ctrl.Name.Replace("txt", "") : ", " + ctrl.Name.Replace("txt", "");
                        }

                        else if (ctrl is ComboBox)
                        {
                            if (camposObrigatorios.Contains(ctrl.Name))
                                if (((ComboBox)ctrl).Text == string.Empty)
                                    camposVazios += camposVazios == string.Empty ? ctrl.Name.Replace("cmb", "") : ", " + ctrl.Name.Replace("cmb", "");
                        }
                        else if (ctrl is MaskedTextBox)
                        {
                            if (camposObrigatorios.Contains(ctrl.Name))
                                if (!((MaskedTextBox)ctrl).MaskCompleted)
                                    camposVazios += camposVazios == string.Empty ? ctrl.Name.Replace("txt", "") : ", " + ctrl.Name.Replace("txt", "");
                        }
                    }
            }
            catch { }

            if (camposVazios != string.Empty)
            {
                MessageBox.Show("Para prosseguir, verifique o preenchimento dos campos: \r\n" + camposVazios, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Altera propriedade Text do botão btAcao para Incluir se for inclusão, Alterar se for alteração
        /// </summary>
        private void HabilitaDesabilitaAlteracao()
        {
            if (isAlteracao)
                btAcao.Text = "Alterar";

            else
                btAcao.Text = "Incluir";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (dgvClientes.RowCount > 0)
            {
                Cliente = dgvClientes.SelectedCells[colObj.Index].Value as Cliente ?? null;

                isAlteracao = true;
                HabilitaDesabilitaAlteracao();

                //Transcreve os dados do cliente nos campos da aba 'Dados Cliente'
                GravaDadosNoControle(Cliente);

                //Alterando a tab selecionada
                if (tabControl1.SelectedTab == tabConsultar)
                    tabControl1.SelectedTab = tabCadastrar;
            }
        }
        /// <summary>
        /// Transcreve os dados do cliente nos campos da aba 'Dados Cliente'
        /// </summary>
        /// <param name="cliente"></param>
        private void GravaDadosNoControle(Cliente cliente)
        {
            if (cliente != null)
            {
                txtNome.Text = cliente.Nome;
                txtRg.Text = cliente.Rg;
                txtCpf.Text = cliente.Cpf;
                txtEndereco.Text = cliente.EnderecoArray[0];
                txtNumero.Text = cliente.EnderecoArray[1];
                txtBairro.Text = cliente.EnderecoArray[2];
                txtCidade.Text = cliente.EnderecoArray[3];
                cmbUf.SelectedText = cliente.EnderecoArray[4];
                txtComplemento.Text = cliente.Complemento;
                txtTelefone.Text = cliente.Numero_telefone;
                txtCelular.Text = cliente.Numero_celular;
                txtObservacoes.Text = cliente.Observacao;
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            SearchBy(cmbFiltro.Text);
        }

        private void SearchBy(string filtro)
        {
            List<Cliente> listCliente = new List<Cliente>();
            switch (filtro)
            {
                case "":
                    listCliente = Cliente.GetAll();
                    break;
                case "Nome":
                    listCliente = Cliente.GetByNome(txtFiltro.Text);
                    break;
                case "RG":
                    listCliente = Cliente.GetByRg(txtMaskFiltro.Text);
                    break;
                case "Telefone":
                    listCliente = Cliente.GetByTelefone(txtMaskFiltro.Text);
                    break;
                case "Celular":
                    listCliente = Cliente.GetByCelular(txtMaskFiltro.Text);
                    break;
            }

            if (listCliente.Count > 0)
            {
                dgvClientes.Rows.Clear();
                lblPesquisaNotFound.Visible = false;
                foreach (var x in listCliente)
                    dgvClientes.Rows.Add(x.Id, x.Nome, x.Rg, x.Cpf, x.Tipo_Cliente, x.Numero_telefone, x.Numero_celular, x.Endereco, x.Complemento, x.Observacao, x);
            }
            else
            {
                dgvClientes.Rows.Clear();
                lblPesquisaNotFound.Visible = true;
            }
        }

        private void dgvClientes_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            ((DataGridView)sender).SelectedCells[e.ColumnIndex].ToolTipText = ((DataGridView)sender).SelectedCells[e.ColumnIndex].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(dgvClientes.RowCount > 0)
            {

            }
        }
    }
}
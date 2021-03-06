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
using FuncoesAuxiliares;
namespace AgendaUI
{
    public partial class frmCliente : Form
    {
        #region CRÉDITOS
        /*
         * Créditos ao Senhor Deus, por ter me sustentado.
         * Créditos à Elaine Cristina Martins, minha Mãe.
         * Créditos a mim, pela persistência.     
        */
        #endregion

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
                if (txtCpf.MaskCompleted)                
                    if (!FuncoesAuxiliares.FuncoesAuxiliares.ValidaCPF(txtCpf.Text.SomenteNumeros()))
                    {
                        MessageBox.Show("CPF inválido! Verifique se digitou corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                
                //Se inclusão
                if (!isAlteracao)
                {
                    Cliente cliente = new Cliente();
                    GravaDados(cliente);
                    if (cliente.Insert())
                    {
                        LogCliente.Insert(TipoMovimento.Inclusao, DateTime.Now, cliente);
                        MessageBox.Show("Dados inseridos com sucesso !", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cliente = cliente;
                        isAlteracao = true;
                        HabilitaDesabilitaAlteracao();
                    }
                }
                // senão, Alteração
                else
                {
                    Cliente client_log = Cliente;
                    if (GravaDados(Cliente))
                        if (Cliente.Update())
                        {
                            LogCliente.Insert(TipoMovimento.Alteracao, DateTime.Now, client_log);
                            MessageBox.Show("Dados alterados com sucesso !", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dgvClientes.RowCount > 0 && dgvClientes.SelectedRows != null)
                                AtualizaDadosAlteradosGrid(Cliente);
                        }
                }
            }

        }

        /// <summary>
        /// Após atualizar / Alterar um registro, esse método atualiza os valores da GridView.
        /// Este método só pode ser chamado se tiver dados na gridView.
        /// </summary>
        /// <param name="cli"></param>
        private void AtualizaDadosAlteradosGrid(Cliente cli)
        {
            dgvClientes.SelectedCells[colNome.Index].Value = cli.Nome;
            dgvClientes.SelectedCells[colRg.Index].Value = cli.Rg;
            dgvClientes.SelectedCells[colCpf.Index].Value = cli.Cpf;
            dgvClientes.SelectedCells[colTipoCliente.Index].Value = cli.Tipo_Cliente;
            dgvClientes.SelectedCells[colTelefone.Index].Value = cli.Numero_telefone;
            dgvClientes.SelectedCells[colCelular.Index].Value = cli.Numero_celular;
            dgvClientes.SelectedCells[colEndereco.Index].Value = cli.Endereco;
            dgvClientes.SelectedCells[colComplemento.Index].Value = cli.Complemento;
            dgvClientes.SelectedCells[colObservacoes.Index].Value = cli.Observacao;
        }

        /// <summary>
        /// Método que grava os dados preenchidos nos campos do formulário no Objeto
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        private bool GravaDados(Cliente client)
        {
            bool result = false;

            try
            {
                if (client == null)
                {
                    if (isAlteracao) throw new ArgumentException("Impossível alterar um registro que não foi selecionado!"); else client = new Cliente();
                }

                client.Nome = txtNome.Text.Trim();
                client.Rg = txtRg.Text.Trim();
                client.Cpf = txtCpf.Text.Trim();
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
                result = false;
                MessageBox.Show("\r\n" + ex.Message, "Erro ao gravar os dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            List<Control> campos = new List<Control>();
            try
            {
                foreach (Control ctrlInCtrl in this.pnlFundo1.Controls)
                    foreach (Control ctrl in ctrlInCtrl.Controls)
                    {
                        if (ctrl is TextBox)
                        {
                            if (camposObrigatorios.Contains(ctrl.Name))
                                if (((TextBox)ctrl).Text == string.Empty)
                                {
                                    camposVazios += camposVazios == string.Empty ? ctrl.Name.Replace("txt", "") : ", " + ctrl.Name.Replace("txt", "");
                                    campos.Add(ctrl as TextBox);
                                }

                        }

                        else if (ctrl is ComboBox)
                        {
                            if (camposObrigatorios.Contains(ctrl.Name))
                                if (((ComboBox)ctrl).Text == string.Empty)
                                {
                                    camposVazios += camposVazios == string.Empty ? ctrl.Name.Replace("cmb", "") : ", " + ctrl.Name.Replace("cmb", "");
                                    campos.Add(ctrl as ComboBox);
                                }
                        }
                        else if (ctrl is MaskedTextBox)
                        {
                            if (camposObrigatorios.Contains(ctrl.Name))
                                if (!((MaskedTextBox)ctrl).MaskCompleted)
                                {
                                    camposVazios += camposVazios == string.Empty ? ctrl.Name.Replace("txt", "") : ", " + ctrl.Name.Replace("txt", "");
                                    campos.Add(ctrl as MaskedTextBox);
                                }
                        }
                    }
            }
            catch { }

            if (camposVazios != string.Empty)
            {
                MessageBox.Show("Para prosseguir, verifique o preenchimento dos campos: \r\n" + camposVazios, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                foreach (Control x in campos)
                    RealcaBordaControle(x);

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
        /// Altera propriedade Text do botão btAcao para 'Incluir' se for inclusão, 'Alterar' se for alteração
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
                int codigo;
                int.TryParse(dgvClientes.SelectedCells[colId.Index].Value.ToString(), out codigo);

                if (codigo > 0)
                {
                    Cliente = Cliente.GetById(codigo);
                    isAlteracao = true;
                    //Transcreve os dados do cliente nos campos da aba 'Dados Cliente'
                    GravaDadosNosControles(Cliente);

                    //Alterando a tab selecionada
                    if (isAlteracao && tabControl1.SelectedTab == tabConsultar)
                        tabControl1.SelectedTab = tabCadastrar;
                }
                else
                    isAlteracao = false;

                HabilitaDesabilitaAlteracao();
            }
        }
        /// <summary>
        /// Transcreve os dados do cliente nos campos do formulário na aba 'Dados Cliente'
        /// </summary>
        /// <param name="cliente"></param>
        private void GravaDadosNosControles(Cliente cliente)
        {
            if (cliente != null)
            {
                txtNome.Text = cliente.Nome;
                txtRg.Text = cliente.Rg;
                txtCpf.Text = cliente.Cpf;
                txtEndereco.Text = cliente.EnderecoArray[0].Trim();
                txtNumero.Text = cliente.EnderecoArray[1].Trim();
                txtBairro.Text = cliente.EnderecoArray[2].Trim();
                txtCidade.Text = cliente.EnderecoArray[3].Trim();
                cmbUf.Text = cliente.EnderecoArray[4].Trim();
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
        /// <summary>
        /// Método que preenche a gridView
        /// </summary>
        /// <param name="filtro"></param>
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
                lblPesquisaNotFound.Visible = false;
                dgvClientes.Rows.Clear();
                foreach (var x in listCliente)
                    dgvClientes.Rows.Add(x.Id, x.Nome, x.Rg, x.Cpf, x.Tipo_Cliente, x.Numero_telefone, x.Numero_celular, x.Endereco, x.Complemento, x.Observacao, x);
                btnHistA.Enabled = dgvClientes.RowCount > 0;
            }
            else
            {
                dgvClientes.Rows.Clear();
                lblPesquisaNotFound.Visible = true;
                btnHistA.Enabled = dgvClientes.RowCount > 0;
            }
        }

        private void dgvClientes_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex > 0 && e.RowIndex > 0)
                ((DataGridView)sender).SelectedCells[e.ColumnIndex].ToolTipText = ((DataGridView)sender).SelectedCells[e.ColumnIndex].Value.ToString();
        }
        //Thais Bebê
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvClientes.RowCount > 0)
            {
                int cod;
                int.TryParse(dgvClientes.SelectedCells[colId.Index].Value.ToString(), out cod);
                if (cod > 0)
                {
                    if (MessageBox.Show("Deseja realmente excluir o cliente selecionado ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Cliente cliente_log = Cliente.GetById(cod);
                        if (Cliente.Delete(cod))
                        {
                            LogCliente.Insert(TipoMovimento.Exclusao, DateTime.Now, cliente_log);

                            dgvClientes.Rows.RemoveAt(dgvClientes.SelectedRows[0].Index);
                            // MessageBox.Show("O cliente selecionado foi excluído.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Insert log
                        }
                        else
                            MessageBox.Show("O registro pode não ter sido excluído! \r\nPor favor, verifique os dados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                    MessageBox.Show("Ocorreu um problema ao excluir o registro !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void NovoRegistro()
        {
            Cliente = null;
            isAlteracao = false;
            HabilitaDesabilitaAlteracao();
            txtNome.Clear();
            txtRg.Clear();
            txtCpf.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtNumero.Clear();
            txtCidade.Clear();
            cmbUf.SelectedIndex = -1;
            txtComplemento.Clear();
            txtObservacoes.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            cmbTipoCliente.SelectedIndex = -1;
            MessageBox.Show("Os campos foram limpos!", "Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovoRegistro();
        }

        private void btHistAlteracoes_Click(object sender, EventArgs e)
        {

        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtro = cmbFiltro.Text;
            if (filtro == "Nome")
            {
                filtroNomePnl.Visible = true;
                filtroMaskPnl.Visible = false;
            }
            else
            {
                filtroNomePnl.Visible = false;
                filtroMaskPnl.Visible = true;
                DefineMascaraFiltro(cmbFiltro.Text);
            }
        }

        private void DefineMascaraFiltro(string mask)
        {
            MaskFilters filter = (MaskFilters)Enum.Parse(typeof(MaskFilters), mask);
            txtMaskFiltro.Mask = filter.GetAtributoDoTipoEnum<DescriptionAttribute>().Description;
        }

        private void btnHistA_Click(object sender, EventArgs e)
        {
            //tenta converter id do registro na gridView
            int id;
            int.TryParse(dgvClientes.SelectedCells[colId.Index].Value.ToString(), out id);

            if (id > 0)
            {
                frmHistoricoA frm = new frmHistoricoA(id);
                frm.ShowDialog();
            }
        }

        private void RealcaBordaControle(Control controlRealcar)
        {

            if (controlRealcar != null)
            {
                Graphics g = ((Control)controlRealcar).CreateGraphics();
                Rectangle bounds = ((Control)controlRealcar).DisplayRectangle;
                ControlPaint.DrawBorder(g, bounds, Color.Red, ButtonBorderStyle.Solid);
            }

        }
    }
}

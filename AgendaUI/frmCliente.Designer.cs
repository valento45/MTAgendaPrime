namespace AgendaUI
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCadastrar = new System.Windows.Forms.TabPage();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.btHistAlteracoes = new System.Windows.Forms.Button();
            this.btAcao = new System.Windows.Forms.Button();
            this.pnlFundo1 = new System.Windows.Forms.Panel();
            this.ObservacoesGroup = new System.Windows.Forms.GroupBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.ContatoGroup = new System.Windows.Forms.GroupBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DadosClienteGroup = new System.Windows.Forms.GroupBox();
            this.cmbTipoCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabConsultar = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pnlFundo2 = new System.Windows.Forms.Panel();
            this.lblPesquisaNotFound = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filtroMaskPnl = new System.Windows.Forms.Panel();
            this.txtMaskFiltro = new System.Windows.Forms.MaskedTextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.filtroNomePnl = new System.Windows.Forms.Panel();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabCadastrar.SuspendLayout();
            this.pnlFundo1.SuspendLayout();
            this.ObservacoesGroup.SuspendLayout();
            this.ContatoGroup.SuspendLayout();
            this.DadosClienteGroup.SuspendLayout();
            this.tabConsultar.SuspendLayout();
            this.pnlFundo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.filtroMaskPnl.SuspendLayout();
            this.filtroNomePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabCadastrar);
            this.tabControl1.Controls.Add(this.tabConsultar);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1024, 519);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCadastrar
            // 
            this.tabCadastrar.Controls.Add(this.btnNovo);
            this.tabCadastrar.Controls.Add(this.btFechar);
            this.tabCadastrar.Controls.Add(this.btHistAlteracoes);
            this.tabCadastrar.Controls.Add(this.btAcao);
            this.tabCadastrar.Controls.Add(this.pnlFundo1);
            this.tabCadastrar.Location = new System.Drawing.Point(4, 22);
            this.tabCadastrar.Name = "tabCadastrar";
            this.tabCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastrar.Size = new System.Drawing.Size(1016, 493);
            this.tabCadastrar.TabIndex = 0;
            this.tabCadastrar.Text = "Dados Cliente";
            this.tabCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Location = new System.Drawing.Point(178, 459);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(110, 23);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btFechar
            // 
            this.btFechar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.Location = new System.Drawing.Point(562, 459);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(110, 23);
            this.btFechar.TabIndex = 3;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btHistAlteracoes
            // 
            this.btHistAlteracoes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btHistAlteracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHistAlteracoes.Location = new System.Drawing.Point(446, 459);
            this.btHistAlteracoes.Name = "btHistAlteracoes";
            this.btHistAlteracoes.Size = new System.Drawing.Size(110, 23);
            this.btHistAlteracoes.TabIndex = 2;
            this.btHistAlteracoes.Text = "Hist. Alterações";
            this.btHistAlteracoes.UseVisualStyleBackColor = true;
            this.btHistAlteracoes.Click += new System.EventHandler(this.btHistAlteracoes_Click);
            // 
            // btAcao
            // 
            this.btAcao.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btAcao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAcao.Location = new System.Drawing.Point(330, 459);
            this.btAcao.Name = "btAcao";
            this.btAcao.Size = new System.Drawing.Size(110, 23);
            this.btAcao.TabIndex = 1;
            this.btAcao.Text = "Incluir";
            this.btAcao.UseVisualStyleBackColor = true;
            this.btAcao.Click += new System.EventHandler(this.btAcao_Click);
            // 
            // pnlFundo1
            // 
            this.pnlFundo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFundo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFundo1.Controls.Add(this.ObservacoesGroup);
            this.pnlFundo1.Controls.Add(this.ContatoGroup);
            this.pnlFundo1.Controls.Add(this.DadosClienteGroup);
            this.pnlFundo1.Location = new System.Drawing.Point(6, 6);
            this.pnlFundo1.Name = "pnlFundo1";
            this.pnlFundo1.Size = new System.Drawing.Size(1004, 442);
            this.pnlFundo1.TabIndex = 0;
            // 
            // ObservacoesGroup
            // 
            this.ObservacoesGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObservacoesGroup.Controls.Add(this.txtObservacoes);
            this.ObservacoesGroup.Location = new System.Drawing.Point(3, 304);
            this.ObservacoesGroup.Name = "ObservacoesGroup";
            this.ObservacoesGroup.Size = new System.Drawing.Size(996, 133);
            this.ObservacoesGroup.TabIndex = 2;
            this.ObservacoesGroup.TabStop = false;
            this.ObservacoesGroup.Text = "Observações";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacoes.Location = new System.Drawing.Point(18, 19);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(959, 99);
            this.txtObservacoes.TabIndex = 4;
            // 
            // ContatoGroup
            // 
            this.ContatoGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContatoGroup.Controls.Add(this.txtCelular);
            this.ContatoGroup.Controls.Add(this.label12);
            this.ContatoGroup.Controls.Add(this.txtTelefone);
            this.ContatoGroup.Controls.Add(this.label11);
            this.ContatoGroup.Controls.Add(this.txtCidade);
            this.ContatoGroup.Controls.Add(this.label10);
            this.ContatoGroup.Controls.Add(this.cmbUf);
            this.ContatoGroup.Controls.Add(this.label9);
            this.ContatoGroup.Controls.Add(this.txtComplemento);
            this.ContatoGroup.Controls.Add(this.label8);
            this.ContatoGroup.Controls.Add(this.txtBairro);
            this.ContatoGroup.Controls.Add(this.label7);
            this.ContatoGroup.Controls.Add(this.txtNumero);
            this.ContatoGroup.Controls.Add(this.label6);
            this.ContatoGroup.Controls.Add(this.txtEndereco);
            this.ContatoGroup.Controls.Add(this.label5);
            this.ContatoGroup.Location = new System.Drawing.Point(3, 155);
            this.ContatoGroup.Name = "ContatoGroup";
            this.ContatoGroup.Size = new System.Drawing.Size(996, 143);
            this.ContatoGroup.TabIndex = 1;
            this.ContatoGroup.TabStop = false;
            this.ContatoGroup.Text = "Endereço/Contato";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(341, 82);
            this.txtCelular.Mask = "(00)00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(127, 20);
            this.txtCelular.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(296, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Celular";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(151, 82);
            this.txtTelefone.Mask = "(00)0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(127, 20);
            this.txtTelefone.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(96, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Telefone";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(252, 56);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(178, 20);
            this.txtCidade.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(206, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Cidade";
            // 
            // cmbUf
            // 
            this.cmbUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.Items.AddRange(new object[] {
            "SP"});
            this.cmbUf.Location = new System.Drawing.Point(151, 56);
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(49, 21);
            this.cmbUf.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "UF";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(513, 57);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(372, 20);
            this.txtComplemento.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Complemento";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(691, 33);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(194, 20);
            this.txtBairro.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(651, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bairro";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(598, 33);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(47, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(578, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nº";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(151, 33);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(412, 20);
            this.txtEndereco.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Endereço";
            // 
            // DadosClienteGroup
            // 
            this.DadosClienteGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DadosClienteGroup.Controls.Add(this.cmbTipoCliente);
            this.DadosClienteGroup.Controls.Add(this.label4);
            this.DadosClienteGroup.Controls.Add(this.txtCpf);
            this.DadosClienteGroup.Controls.Add(this.label3);
            this.DadosClienteGroup.Controls.Add(this.txtRg);
            this.DadosClienteGroup.Controls.Add(this.label2);
            this.DadosClienteGroup.Controls.Add(this.txtNome);
            this.DadosClienteGroup.Controls.Add(this.label1);
            this.DadosClienteGroup.Location = new System.Drawing.Point(3, 3);
            this.DadosClienteGroup.Name = "DadosClienteGroup";
            this.DadosClienteGroup.Size = new System.Drawing.Size(996, 146);
            this.DadosClienteGroup.TabIndex = 0;
            this.DadosClienteGroup.TabStop = false;
            this.DadosClienteGroup.Text = "Dados cliente";
            // 
            // cmbTipoCliente
            // 
            this.cmbTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCliente.FormattingEnabled = true;
            this.cmbTipoCliente.Location = new System.Drawing.Point(553, 61);
            this.cmbTipoCliente.Name = "cmbTipoCliente";
            this.cmbTipoCliente.Size = new System.Drawing.Size(332, 21);
            this.cmbTipoCliente.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo cliente";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(336, 61);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(132, 20);
            this.txtCpf.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(151, 61);
            this.txtRg.Mask = "00,000,000-0";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(127, 20);
            this.txtRg.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "RG";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(151, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(734, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tabConsultar
            // 
            this.tabConsultar.Controls.Add(this.btnExcluir);
            this.tabConsultar.Controls.Add(this.btnEditar);
            this.tabConsultar.Controls.Add(this.pnlFundo2);
            this.tabConsultar.Location = new System.Drawing.Point(4, 22);
            this.tabConsultar.Name = "tabConsultar";
            this.tabConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultar.Size = new System.Drawing.Size(1016, 493);
            this.tabConsultar.TabIndex = 1;
            this.tabConsultar.Text = "Pesquisar";
            this.tabConsultar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(524, 464);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 23);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(408, 464);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pnlFundo2
            // 
            this.pnlFundo2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFundo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFundo2.Controls.Add(this.lblPesquisaNotFound);
            this.pnlFundo2.Controls.Add(this.dgvClientes);
            this.pnlFundo2.Controls.Add(this.groupBox1);
            this.pnlFundo2.Location = new System.Drawing.Point(6, 6);
            this.pnlFundo2.Name = "pnlFundo2";
            this.pnlFundo2.Size = new System.Drawing.Size(1004, 452);
            this.pnlFundo2.TabIndex = 1;
            // 
            // lblPesquisaNotFound
            // 
            this.lblPesquisaNotFound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPesquisaNotFound.AutoSize = true;
            this.lblPesquisaNotFound.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisaNotFound.Location = new System.Drawing.Point(259, 288);
            this.lblPesquisaNotFound.Name = "lblPesquisaNotFound";
            this.lblPesquisaNotFound.Size = new System.Drawing.Size(547, 26);
            this.lblPesquisaNotFound.TabIndex = 2;
            this.lblPesquisaNotFound.Text = "Não foram encontrados resultados para a pesquisa informada";
            this.lblPesquisaNotFound.Visible = false;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AccessibleDescription = "";
            this.dgvClientes.AccessibleName = "";
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNome,
            this.colRg,
            this.colCpf,
            this.colTipoCliente,
            this.colTelefone,
            this.colCelular,
            this.colEndereco,
            this.colComplemento,
            this.colObservacoes,
            this.colObj});
            this.dgvClientes.Location = new System.Drawing.Point(3, 176);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(996, 271);
            this.dgvClientes.TabIndex = 1;
            this.dgvClientes.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClientes_CellMouseMove);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colRg
            // 
            this.colRg.HeaderText = "RG";
            this.colRg.Name = "colRg";
            this.colRg.ReadOnly = true;
            // 
            // colCpf
            // 
            this.colCpf.HeaderText = "CPF";
            this.colCpf.Name = "colCpf";
            this.colCpf.ReadOnly = true;
            // 
            // colTipoCliente
            // 
            this.colTipoCliente.HeaderText = "Tipo";
            this.colTipoCliente.Name = "colTipoCliente";
            this.colTipoCliente.ReadOnly = true;
            // 
            // colTelefone
            // 
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            // 
            // colCelular
            // 
            this.colCelular.HeaderText = "Celular";
            this.colCelular.Name = "colCelular";
            this.colCelular.ReadOnly = true;
            // 
            // colEndereco
            // 
            this.colEndereco.HeaderText = "Endereco";
            this.colEndereco.Name = "colEndereco";
            this.colEndereco.ReadOnly = true;
            // 
            // colComplemento
            // 
            this.colComplemento.HeaderText = "Complemento";
            this.colComplemento.Name = "colComplemento";
            // 
            // colObservacoes
            // 
            this.colObservacoes.HeaderText = "Observações";
            this.colObservacoes.Name = "colObservacoes";
            this.colObservacoes.ReadOnly = true;
            // 
            // colObj
            // 
            this.colObj.HeaderText = "obj";
            this.colObj.Name = "colObj";
            this.colObj.ReadOnly = true;
            this.colObj.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.filtroMaskPnl);
            this.groupBox1.Controls.Add(this.btPesquisar);
            this.groupBox1.Controls.Add(this.cmbFiltro);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.filtroNomePnl);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(996, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar pesquisa";
            // 
            // filtroMaskPnl
            // 
            this.filtroMaskPnl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.filtroMaskPnl.Controls.Add(this.txtMaskFiltro);
            this.filtroMaskPnl.Location = new System.Drawing.Point(240, 52);
            this.filtroMaskPnl.Name = "filtroMaskPnl";
            this.filtroMaskPnl.Size = new System.Drawing.Size(569, 47);
            this.filtroMaskPnl.TabIndex = 14;
            this.filtroMaskPnl.Visible = false;
            // 
            // txtMaskFiltro
            // 
            this.txtMaskFiltro.Location = new System.Drawing.Point(21, 12);
            this.txtMaskFiltro.Name = "txtMaskFiltro";
            this.txtMaskFiltro.Size = new System.Drawing.Size(192, 20);
            this.txtMaskFiltro.TabIndex = 0;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.Location = new System.Drawing.Point(831, 62);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(110, 23);
            this.btPesquisar.TabIndex = 13;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Nome",
            "RG",
            "Telefone",
            "Celular"});
            this.cmbFiltro.Location = new System.Drawing.Point(70, 64);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(167, 21);
            this.cmbFiltro.TabIndex = 12;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Filtro";
            // 
            // filtroNomePnl
            // 
            this.filtroNomePnl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.filtroNomePnl.Controls.Add(this.txtFiltro);
            this.filtroNomePnl.Location = new System.Drawing.Point(243, 52);
            this.filtroNomePnl.Name = "filtroNomePnl";
            this.filtroNomePnl.Size = new System.Drawing.Size(569, 47);
            this.filtroNomePnl.TabIndex = 0;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(18, 12);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(502, 20);
            this.txtFiltro.TabIndex = 0;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1048, 543);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.tabControl1.ResumeLayout(false);
            this.tabCadastrar.ResumeLayout(false);
            this.pnlFundo1.ResumeLayout(false);
            this.ObservacoesGroup.ResumeLayout(false);
            this.ObservacoesGroup.PerformLayout();
            this.ContatoGroup.ResumeLayout(false);
            this.ContatoGroup.PerformLayout();
            this.DadosClienteGroup.ResumeLayout(false);
            this.DadosClienteGroup.PerformLayout();
            this.tabConsultar.ResumeLayout(false);
            this.pnlFundo2.ResumeLayout(false);
            this.pnlFundo2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.filtroMaskPnl.ResumeLayout(false);
            this.filtroMaskPnl.PerformLayout();
            this.filtroNomePnl.ResumeLayout(false);
            this.filtroNomePnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCadastrar;
        private System.Windows.Forms.TabPage tabConsultar;
        private System.Windows.Forms.Panel pnlFundo1;
        private System.Windows.Forms.Panel pnlFundo2;
        private System.Windows.Forms.GroupBox DadosClienteGroup;
        private System.Windows.Forms.GroupBox ObservacoesGroup;
        private System.Windows.Forms.GroupBox ContatoGroup;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btHistAlteracoes;
        private System.Windows.Forms.Button btAcao;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbUf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel filtroNomePnl;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Panel filtroMaskPnl;
        private System.Windows.Forms.MaskedTextBox txtMaskFiltro;
        private System.Windows.Forms.Label lblPesquisaNotFound;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObj;
    }
}
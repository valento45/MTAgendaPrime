namespace UsuarioUI
{
    partial class frmUsuario
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Usuários");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Permissões");
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenusTreeView = new System.Windows.Forms.TreeView();
            this.pnl = new System.Windows.Forms.Panel();
            this.incluiEditGroup = new System.Windows.Forms.GroupBox();
            this.usuarioTabControl = new System.Windows.Forms.TabControl();
            this.tabPageIncluiEdit = new System.Windows.Forms.TabPage();
            this.tabPagePesquisa = new System.Windows.Forms.TabPage();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filtroMaskPnl = new System.Windows.Forms.Panel();
            this.txtMaskFiltro = new System.Windows.Forms.MaskedTextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.filtroNomePnl = new System.Windows.Forms.Panel();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.pnlFundo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl.SuspendLayout();
            this.incluiEditGroup.SuspendLayout();
            this.usuarioTabControl.SuspendLayout();
            this.tabPagePesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.filtroMaskPnl.SuspendLayout();
            this.filtroNomePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFundo.BackColor = System.Drawing.Color.MintCream;
            this.pnlFundo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFundo.Controls.Add(this.pnl);
            this.pnlFundo.Controls.Add(this.panel1);
            this.pnlFundo.Location = new System.Drawing.Point(12, 12);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(1245, 553);
            this.pnlFundo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.MenusTreeView);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 543);
            this.panel1.TabIndex = 0;
            // 
            // MenusTreeView
            // 
            this.MenusTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenusTreeView.Location = new System.Drawing.Point(3, 3);
            this.MenusTreeView.Name = "MenusTreeView";
            treeNode1.Name = "usuarioMenu";
            treeNode1.Text = "Usuários";
            treeNode1.ToolTipText = "Incluir / Editar / Inativar / Excluir usuários";
            treeNode2.Name = "permMenu";
            treeNode2.Text = "Permissões";
            treeNode2.ToolTipText = "Gerenciar permissões de acesso";
            this.MenusTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.MenusTreeView.Size = new System.Drawing.Size(298, 537);
            this.MenusTreeView.TabIndex = 0;
            // 
            // pnl
            // 
            this.pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl.Controls.Add(this.incluiEditGroup);
            this.pnl.Location = new System.Drawing.Point(313, 6);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(925, 537);
            this.pnl.TabIndex = 1;
            // 
            // incluiEditGroup
            // 
            this.incluiEditGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.incluiEditGroup.Controls.Add(this.usuarioTabControl);
            this.incluiEditGroup.Location = new System.Drawing.Point(19, 18);
            this.incluiEditGroup.Name = "incluiEditGroup";
            this.incluiEditGroup.Size = new System.Drawing.Size(882, 501);
            this.incluiEditGroup.TabIndex = 0;
            this.incluiEditGroup.TabStop = false;
            this.incluiEditGroup.Text = "Incluir / Editar ";
            // 
            // usuarioTabControl
            // 
            this.usuarioTabControl.Controls.Add(this.tabPageIncluiEdit);
            this.usuarioTabControl.Controls.Add(this.tabPagePesquisa);
            this.usuarioTabControl.Location = new System.Drawing.Point(6, 19);
            this.usuarioTabControl.Name = "usuarioTabControl";
            this.usuarioTabControl.SelectedIndex = 0;
            this.usuarioTabControl.Size = new System.Drawing.Size(870, 476);
            this.usuarioTabControl.TabIndex = 0;
            // 
            // tabPageIncluiEdit
            // 
            this.tabPageIncluiEdit.Location = new System.Drawing.Point(4, 22);
            this.tabPageIncluiEdit.Name = "tabPageIncluiEdit";
            this.tabPageIncluiEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIncluiEdit.Size = new System.Drawing.Size(862, 450);
            this.tabPageIncluiEdit.TabIndex = 0;
            this.tabPageIncluiEdit.Text = "Incluir / Editar";
            this.tabPageIncluiEdit.UseVisualStyleBackColor = true;
            // 
            // tabPagePesquisa
            // 
            this.tabPagePesquisa.Controls.Add(this.groupBox1);
            this.tabPagePesquisa.Controls.Add(this.dgvUsuario);
            this.tabPagePesquisa.Location = new System.Drawing.Point(4, 22);
            this.tabPagePesquisa.Name = "tabPagePesquisa";
            this.tabPagePesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePesquisa.Size = new System.Drawing.Size(862, 450);
            this.tabPagePesquisa.TabIndex = 1;
            this.tabPagePesquisa.Text = "Pesquisar";
            this.tabPagePesquisa.UseVisualStyleBackColor = true;
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(6, 195);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(850, 249);
            this.dgvUsuario.TabIndex = 0;
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
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar pesquisa";
            // 
            // filtroMaskPnl
            // 
            this.filtroMaskPnl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.filtroMaskPnl.Controls.Add(this.txtMaskFiltro);
            this.filtroMaskPnl.Location = new System.Drawing.Point(240, 52);
            this.filtroMaskPnl.Name = "filtroMaskPnl";
            this.filtroMaskPnl.Size = new System.Drawing.Size(238, 47);
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
            this.btPesquisar.Location = new System.Drawing.Point(685, 62);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(110, 23);
            this.btPesquisar.TabIndex = 13;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
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
            this.filtroNomePnl.Size = new System.Drawing.Size(436, 47);
            this.filtroNomePnl.TabIndex = 0;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(18, 12);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(405, 20);
            this.txtFiltro.TabIndex = 0;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1269, 577);
            this.Controls.Add(this.pnlFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações de usuários";
            this.pnlFundo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnl.ResumeLayout(false);
            this.incluiEditGroup.ResumeLayout(false);
            this.usuarioTabControl.ResumeLayout(false);
            this.tabPagePesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.filtroMaskPnl.ResumeLayout(false);
            this.filtroMaskPnl.PerformLayout();
            this.filtroNomePnl.ResumeLayout(false);
            this.filtroNomePnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView MenusTreeView;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.GroupBox incluiEditGroup;
        private System.Windows.Forms.TabControl usuarioTabControl;
        private System.Windows.Forms.TabPage tabPageIncluiEdit;
        private System.Windows.Forms.TabPage tabPagePesquisa;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel filtroMaskPnl;
        private System.Windows.Forms.MaskedTextBox txtMaskFiltro;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel filtroNomePnl;
        private System.Windows.Forms.TextBox txtFiltro;
    }
}
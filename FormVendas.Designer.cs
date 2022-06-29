namespace Form_Bd
{
    partial class FormVendas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tb_Controle = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.lbl_nome_cliente_venda = new System.Windows.Forms.Label();
            this.tbx_nome_cliente_venda = new System.Windows.Forms.TextBox();
            this.lbl_cod_cliente_venda = new System.Windows.Forms.Label();
            this.tbx_cod_cliente_venda = new System.Windows.Forms.TextBox();
            this.lbl_valor_unidade_venda = new System.Windows.Forms.Label();
            this.tbx_valor_unitario_venda = new System.Windows.Forms.TextBox();
            this.lbl_quantidade_venda = new System.Windows.Forms.Label();
            this.lbl_valor_total = new System.Windows.Forms.Label();
            this.lbl_id_produto_venda = new System.Windows.Forms.Label();
            this.tbx_valor_total = new System.Windows.Forms.TextBox();
            this.tbx_quantidade_venda = new System.Windows.Forms.TextBox();
            this.tbx_id_produto_venda = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.tbx_cidade = new System.Windows.Forms.TextBox();
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgrid_cliente = new System.Windows.Forms.DataGridView();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestaoVenda_dbDataSet6 = new Form_Bd.GestaoVenda_dbDataSet6();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.tbx_endereco = new System.Windows.Forms.TextBox();
            this.tbx_cpf = new System.Windows.Forms.TextBox();
            this.tbx_telefone = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_produto_confirmar = new System.Windows.Forms.Button();
            this.lbl_cod_ean = new System.Windows.Forms.Label();
            this.lbl_nome_produto = new System.Windows.Forms.Label();
            this.lbl_qtd_estoque = new System.Windows.Forms.Label();
            this.lbl_valor_unidade = new System.Windows.Forms.Label();
            this.lbl_id_produto = new System.Windows.Forms.Label();
            this.tbx_id_produto = new System.Windows.Forms.TextBox();
            this.tbx_cod_produto = new System.Windows.Forms.TextBox();
            this.tbx_quantidade_produto = new System.Windows.Forms.TextBox();
            this.tbx_nome_produto = new System.Windows.Forms.TextBox();
            this.tbx_valor_unitario = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dtgrid_produto = new System.Windows.Forms.DataGridView();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codEANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestaoVenda_dbDataSet7 = new Form_Bd.GestaoVenda_dbDataSet7();
            this.clientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter2 = new Form_Bd.GestaoVenda_dbDataSet5TableAdapters.ClientesTableAdapter();
            this.clientesTableAdapter = new Form_Bd.GestaoVenda_dbDataSet6TableAdapters.ClientesTableAdapter();
            this.produtosTableAdapter = new Form_Bd.GestaoVenda_dbDataSet7TableAdapters.ProdutosTableAdapter();
            this.btn_atualizar_valores = new System.Windows.Forms.Button();
            this.btn_atualizar_produto = new System.Windows.Forms.Button();
            this.tb_Controle.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoVenda_dbDataSet6)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_produto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoVenda_dbDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Controle
            // 
            this.tb_Controle.Controls.Add(this.tabPage1);
            this.tb_Controle.Controls.Add(this.tabPage2);
            this.tb_Controle.Controls.Add(this.tabPage3);
            this.tb_Controle.Location = new System.Drawing.Point(3, 2);
            this.tb_Controle.Name = "tb_Controle";
            this.tb_Controle.SelectedIndex = 0;
            this.tb_Controle.Size = new System.Drawing.Size(584, 317);
            this.tb_Controle.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_atualizar_valores);
            this.tabPage1.Controls.Add(this.btn_confirmar);
            this.tabPage1.Controls.Add(this.lbl_nome_cliente_venda);
            this.tabPage1.Controls.Add(this.tbx_nome_cliente_venda);
            this.tabPage1.Controls.Add(this.lbl_cod_cliente_venda);
            this.tabPage1.Controls.Add(this.tbx_cod_cliente_venda);
            this.tabPage1.Controls.Add(this.lbl_valor_unidade_venda);
            this.tabPage1.Controls.Add(this.tbx_valor_unitario_venda);
            this.tabPage1.Controls.Add(this.lbl_quantidade_venda);
            this.tabPage1.Controls.Add(this.lbl_valor_total);
            this.tabPage1.Controls.Add(this.lbl_id_produto_venda);
            this.tabPage1.Controls.Add(this.tbx_valor_total);
            this.tabPage1.Controls.Add(this.tbx_quantidade_venda);
            this.tabPage1.Controls.Add(this.tbx_id_produto_venda);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 291);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vendas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(215, 196);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(146, 39);
            this.btn_confirmar.TabIndex = 39;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click_1);
            // 
            // lbl_nome_cliente_venda
            // 
            this.lbl_nome_cliente_venda.AutoSize = true;
            this.lbl_nome_cliente_venda.Location = new System.Drawing.Point(247, 101);
            this.lbl_nome_cliente_venda.Name = "lbl_nome_cliente_venda";
            this.lbl_nome_cliente_venda.Size = new System.Drawing.Size(73, 13);
            this.lbl_nome_cliente_venda.TabIndex = 38;
            this.lbl_nome_cliente_venda.Text = "Nome Cliente:";
            // 
            // tbx_nome_cliente_venda
            // 
            this.tbx_nome_cliente_venda.Location = new System.Drawing.Point(234, 117);
            this.tbx_nome_cliente_venda.Name = "tbx_nome_cliente_venda";
            this.tbx_nome_cliente_venda.Size = new System.Drawing.Size(99, 20);
            this.tbx_nome_cliente_venda.TabIndex = 37;
            // 
            // lbl_cod_cliente_venda
            // 
            this.lbl_cod_cliente_venda.AutoSize = true;
            this.lbl_cod_cliente_venda.Location = new System.Drawing.Point(93, 101);
            this.lbl_cod_cliente_venda.Name = "lbl_cod_cliente_venda";
            this.lbl_cod_cliente_venda.Size = new System.Drawing.Size(78, 13);
            this.lbl_cod_cliente_venda.TabIndex = 36;
            this.lbl_cod_cliente_venda.Text = "Código Cliente:";
            // 
            // tbx_cod_cliente_venda
            // 
            this.tbx_cod_cliente_venda.Location = new System.Drawing.Point(83, 117);
            this.tbx_cod_cliente_venda.Name = "tbx_cod_cliente_venda";
            this.tbx_cod_cliente_venda.Size = new System.Drawing.Size(99, 20);
            this.tbx_cod_cliente_venda.TabIndex = 35;
            // 
            // lbl_valor_unidade_venda
            // 
            this.lbl_valor_unidade_venda.AutoSize = true;
            this.lbl_valor_unidade_venda.Location = new System.Drawing.Point(247, 42);
            this.lbl_valor_unidade_venda.Name = "lbl_valor_unidade_venda";
            this.lbl_valor_unidade_venda.Size = new System.Drawing.Size(70, 13);
            this.lbl_valor_unidade_venda.TabIndex = 34;
            this.lbl_valor_unidade_venda.Text = "Valor Unitário";
            // 
            // tbx_valor_unitario_venda
            // 
            this.tbx_valor_unitario_venda.Location = new System.Drawing.Point(234, 62);
            this.tbx_valor_unitario_venda.Name = "tbx_valor_unitario_venda";
            this.tbx_valor_unitario_venda.Size = new System.Drawing.Size(99, 20);
            this.tbx_valor_unitario_venda.TabIndex = 33;
            // 
            // lbl_quantidade_venda
            // 
            this.lbl_quantidade_venda.AutoSize = true;
            this.lbl_quantidade_venda.Location = new System.Drawing.Point(409, 42);
            this.lbl_quantidade_venda.Name = "lbl_quantidade_venda";
            this.lbl_quantidade_venda.Size = new System.Drawing.Size(65, 13);
            this.lbl_quantidade_venda.TabIndex = 32;
            this.lbl_quantidade_venda.Text = "Quantidade:";
            // 
            // lbl_valor_total
            // 
            this.lbl_valor_total.AutoSize = true;
            this.lbl_valor_total.Location = new System.Drawing.Point(413, 101);
            this.lbl_valor_total.Name = "lbl_valor_total";
            this.lbl_valor_total.Size = new System.Drawing.Size(61, 13);
            this.lbl_valor_total.TabIndex = 31;
            this.lbl_valor_total.Text = "Valor Total:";
            // 
            // lbl_id_produto_venda
            // 
            this.lbl_id_produto_venda.AutoSize = true;
            this.lbl_id_produto_venda.Location = new System.Drawing.Point(100, 42);
            this.lbl_id_produto_venda.Name = "lbl_id_produto_venda";
            this.lbl_id_produto_venda.Size = new System.Drawing.Size(61, 13);
            this.lbl_id_produto_venda.TabIndex = 30;
            this.lbl_id_produto_venda.Text = "ID Produto:";
            // 
            // tbx_valor_total
            // 
            this.tbx_valor_total.Location = new System.Drawing.Point(393, 117);
            this.tbx_valor_total.Name = "tbx_valor_total";
            this.tbx_valor_total.Size = new System.Drawing.Size(100, 20);
            this.tbx_valor_total.TabIndex = 29;
            // 
            // tbx_quantidade_venda
            // 
            this.tbx_quantidade_venda.Location = new System.Drawing.Point(393, 62);
            this.tbx_quantidade_venda.Name = "tbx_quantidade_venda";
            this.tbx_quantidade_venda.Size = new System.Drawing.Size(100, 20);
            this.tbx_quantidade_venda.TabIndex = 28;
            // 
            // tbx_id_produto_venda
            // 
            this.tbx_id_produto_venda.Location = new System.Drawing.Point(83, 62);
            this.tbx_id_produto_venda.Name = "tbx_id_produto_venda";
            this.tbx_id_produto_venda.Size = new System.Drawing.Size(100, 20);
            this.tbx_id_produto_venda.TabIndex = 27;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.btn_voltar);
            this.tabPage2.Controls.Add(this.lbl_cidade);
            this.tabPage2.Controls.Add(this.lbl_endereco);
            this.tabPage2.Controls.Add(this.tbx_cidade);
            this.tabPage2.Controls.Add(this.tbx_email);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dtgrid_cliente);
            this.tabPage2.Controls.Add(this.lbl_nome);
            this.tabPage2.Controls.Add(this.lbl_cpf);
            this.tabPage2.Controls.Add(this.lbl_email);
            this.tabPage2.Controls.Add(this.lbl_telefone);
            this.tabPage2.Controls.Add(this.tbx_nome);
            this.tabPage2.Controls.Add(this.tbx_endereco);
            this.tabPage2.Controls.Add(this.tbx_cpf);
            this.tabPage2.Controls.Add(this.tbx_telefone);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(260, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 41);
            this.button3.TabIndex = 36;
            this.button3.Text = "Preencher Venda";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(432, 202);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(138, 42);
            this.btn_voltar.TabIndex = 35;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.Location = new System.Drawing.Point(15, 170);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(54, 16);
            this.lbl_cidade.TabIndex = 32;
            this.lbl_cidade.Text = "Cidade:";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endereco.Location = new System.Drawing.Point(15, 144);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(69, 16);
            this.lbl_endereco.TabIndex = 31;
            this.lbl_endereco.Text = "Endereço:";
            // 
            // tbx_cidade
            // 
            this.tbx_cidade.Location = new System.Drawing.Point(87, 166);
            this.tbx_cidade.Name = "tbx_cidade";
            this.tbx_cidade.Size = new System.Drawing.Size(93, 20);
            this.tbx_cidade.TabIndex = 30;
            // 
            // tbx_email
            // 
            this.tbx_email.Location = new System.Drawing.Point(87, 192);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(93, 20);
            this.tbx_email.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 34);
            this.button1.TabIndex = 28;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Cadastrar";
            // 
            // dtgrid_cliente
            // 
            this.dtgrid_cliente.AutoGenerateColumns = false;
            this.dtgrid_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dtgrid_cliente.DataSource = this.clientesBindingSource;
            this.dtgrid_cliente.Location = new System.Drawing.Point(221, 1);
            this.dtgrid_cliente.Name = "dtgrid_cliente";
            this.dtgrid_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrid_cliente.Size = new System.Drawing.Size(355, 195);
            this.dtgrid_cliente.TabIndex = 27;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.gestaoVenda_dbDataSet6;
            // 
            // gestaoVenda_dbDataSet6
            // 
            this.gestaoVenda_dbDataSet6.DataSetName = "GestaoVenda_dbDataSet6";
            this.gestaoVenda_dbDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(15, 56);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(47, 16);
            this.lbl_nome.TabIndex = 26;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(15, 88);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(30, 16);
            this.lbl_cpf.TabIndex = 25;
            this.lbl_cpf.Text = "Cpf:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(15, 196);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(44, 16);
            this.lbl_email.TabIndex = 24;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(15, 118);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(64, 16);
            this.lbl_telefone.TabIndex = 23;
            this.lbl_telefone.Text = "Telefone:";
            // 
            // tbx_nome
            // 
            this.tbx_nome.Location = new System.Drawing.Point(87, 56);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(93, 20);
            this.tbx_nome.TabIndex = 22;
            // 
            // tbx_endereco
            // 
            this.tbx_endereco.Location = new System.Drawing.Point(87, 140);
            this.tbx_endereco.Name = "tbx_endereco";
            this.tbx_endereco.Size = new System.Drawing.Size(93, 20);
            this.tbx_endereco.TabIndex = 21;
            // 
            // tbx_cpf
            // 
            this.tbx_cpf.Location = new System.Drawing.Point(87, 88);
            this.tbx_cpf.Name = "tbx_cpf";
            this.tbx_cpf.Size = new System.Drawing.Size(93, 20);
            this.tbx_cpf.TabIndex = 20;
            // 
            // tbx_telefone
            // 
            this.tbx_telefone.Location = new System.Drawing.Point(87, 114);
            this.tbx_telefone.Name = "tbx_telefone";
            this.tbx_telefone.Size = new System.Drawing.Size(93, 20);
            this.tbx_telefone.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(5, 1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 284);
            this.textBox1.TabIndex = 33;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_atualizar_produto);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.btn_produto_confirmar);
            this.tabPage3.Controls.Add(this.lbl_cod_ean);
            this.tabPage3.Controls.Add(this.lbl_nome_produto);
            this.tabPage3.Controls.Add(this.lbl_qtd_estoque);
            this.tabPage3.Controls.Add(this.lbl_valor_unidade);
            this.tabPage3.Controls.Add(this.lbl_id_produto);
            this.tabPage3.Controls.Add(this.tbx_id_produto);
            this.tabPage3.Controls.Add(this.tbx_cod_produto);
            this.tabPage3.Controls.Add(this.tbx_quantidade_produto);
            this.tabPage3.Controls.Add(this.tbx_nome_produto);
            this.tabPage3.Controls.Add(this.tbx_valor_unitario);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.dtgrid_produto);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(576, 291);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Produtos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 36);
            this.button2.TabIndex = 41;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Cadastrar";
            // 
            // btn_produto_confirmar
            // 
            this.btn_produto_confirmar.Location = new System.Drawing.Point(16, 226);
            this.btn_produto_confirmar.Name = "btn_produto_confirmar";
            this.btn_produto_confirmar.Size = new System.Drawing.Size(194, 27);
            this.btn_produto_confirmar.TabIndex = 38;
            this.btn_produto_confirmar.Text = "Confirmar";
            this.btn_produto_confirmar.UseVisualStyleBackColor = true;
            this.btn_produto_confirmar.Click += new System.EventHandler(this.btn_produto_confirmar_Click);
            // 
            // lbl_cod_ean
            // 
            this.lbl_cod_ean.AutoSize = true;
            this.lbl_cod_ean.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_cod_ean.Location = new System.Drawing.Point(32, 88);
            this.lbl_cod_ean.Name = "lbl_cod_ean";
            this.lbl_cod_ean.Size = new System.Drawing.Size(83, 13);
            this.lbl_cod_ean.TabIndex = 37;
            this.lbl_cod_ean.Text = "Codigo Produto:";
            // 
            // lbl_nome_produto
            // 
            this.lbl_nome_produto.AutoSize = true;
            this.lbl_nome_produto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_nome_produto.Location = new System.Drawing.Point(32, 120);
            this.lbl_nome_produto.Name = "lbl_nome_produto";
            this.lbl_nome_produto.Size = new System.Drawing.Size(78, 13);
            this.lbl_nome_produto.TabIndex = 36;
            this.lbl_nome_produto.Text = "Nome Produto:";
            // 
            // lbl_qtd_estoque
            // 
            this.lbl_qtd_estoque.AutoSize = true;
            this.lbl_qtd_estoque.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_qtd_estoque.Location = new System.Drawing.Point(32, 148);
            this.lbl_qtd_estoque.Name = "lbl_qtd_estoque";
            this.lbl_qtd_estoque.Size = new System.Drawing.Size(65, 13);
            this.lbl_qtd_estoque.TabIndex = 35;
            this.lbl_qtd_estoque.Text = "Quantidade:";
            // 
            // lbl_valor_unidade
            // 
            this.lbl_valor_unidade.AutoSize = true;
            this.lbl_valor_unidade.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_valor_unidade.Location = new System.Drawing.Point(32, 177);
            this.lbl_valor_unidade.Name = "lbl_valor_unidade";
            this.lbl_valor_unidade.Size = new System.Drawing.Size(70, 13);
            this.lbl_valor_unidade.TabIndex = 34;
            this.lbl_valor_unidade.Text = "Valor Unitário";
            // 
            // lbl_id_produto
            // 
            this.lbl_id_produto.AutoSize = true;
            this.lbl_id_produto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_id_produto.Location = new System.Drawing.Point(32, 58);
            this.lbl_id_produto.Name = "lbl_id_produto";
            this.lbl_id_produto.Size = new System.Drawing.Size(21, 13);
            this.lbl_id_produto.TabIndex = 33;
            this.lbl_id_produto.Text = "ID:";
            // 
            // tbx_id_produto
            // 
            this.tbx_id_produto.Location = new System.Drawing.Point(120, 55);
            this.tbx_id_produto.Name = "tbx_id_produto";
            this.tbx_id_produto.Size = new System.Drawing.Size(51, 20);
            this.tbx_id_produto.TabIndex = 32;
            // 
            // tbx_cod_produto
            // 
            this.tbx_cod_produto.Location = new System.Drawing.Point(120, 85);
            this.tbx_cod_produto.Name = "tbx_cod_produto";
            this.tbx_cod_produto.Size = new System.Drawing.Size(83, 20);
            this.tbx_cod_produto.TabIndex = 31;
            // 
            // tbx_quantidade_produto
            // 
            this.tbx_quantidade_produto.Location = new System.Drawing.Point(120, 148);
            this.tbx_quantidade_produto.Name = "tbx_quantidade_produto";
            this.tbx_quantidade_produto.Size = new System.Drawing.Size(83, 20);
            this.tbx_quantidade_produto.TabIndex = 30;
            // 
            // tbx_nome_produto
            // 
            this.tbx_nome_produto.Location = new System.Drawing.Point(120, 117);
            this.tbx_nome_produto.Name = "tbx_nome_produto";
            this.tbx_nome_produto.Size = new System.Drawing.Size(83, 20);
            this.tbx_nome_produto.TabIndex = 29;
            // 
            // tbx_valor_unitario
            // 
            this.tbx_valor_unitario.Location = new System.Drawing.Point(120, 174);
            this.tbx_valor_unitario.Name = "tbx_valor_unitario";
            this.tbx_valor_unitario.Size = new System.Drawing.Size(83, 20);
            this.tbx_valor_unitario.TabIndex = 28;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(3, -1);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 285);
            this.textBox2.TabIndex = 39;
            // 
            // dtgrid_produto
            // 
            this.dtgrid_produto.AutoGenerateColumns = false;
            this.dtgrid_produto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_produto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.codEANDataGridViewTextBoxColumn,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.estoqueDataGridViewTextBoxColumn,
            this.valorProdutoDataGridViewTextBoxColumn});
            this.dtgrid_produto.DataSource = this.produtosBindingSource;
            this.dtgrid_produto.Location = new System.Drawing.Point(244, 3);
            this.dtgrid_produto.Name = "dtgrid_produto";
            this.dtgrid_produto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrid_produto.Size = new System.Drawing.Size(321, 187);
            this.dtgrid_produto.TabIndex = 27;
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "idProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "idProduto";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codEANDataGridViewTextBoxColumn
            // 
            this.codEANDataGridViewTextBoxColumn.DataPropertyName = "codEAN";
            this.codEANDataGridViewTextBoxColumn.HeaderText = "codEAN";
            this.codEANDataGridViewTextBoxColumn.Name = "codEANDataGridViewTextBoxColumn";
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "nomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "nomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            // 
            // estoqueDataGridViewTextBoxColumn
            // 
            this.estoqueDataGridViewTextBoxColumn.DataPropertyName = "estoque";
            this.estoqueDataGridViewTextBoxColumn.HeaderText = "estoque";
            this.estoqueDataGridViewTextBoxColumn.Name = "estoqueDataGridViewTextBoxColumn";
            // 
            // valorProdutoDataGridViewTextBoxColumn
            // 
            this.valorProdutoDataGridViewTextBoxColumn.DataPropertyName = "valorProduto";
            this.valorProdutoDataGridViewTextBoxColumn.HeaderText = "valorProduto";
            this.valorProdutoDataGridViewTextBoxColumn.Name = "valorProdutoDataGridViewTextBoxColumn";
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.gestaoVenda_dbDataSet7;
            // 
            // gestaoVenda_dbDataSet7
            // 
            this.gestaoVenda_dbDataSet7.DataSetName = "GestaoVenda_dbDataSet7";
            this.gestaoVenda_dbDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter2
            // 
            this.clientesTableAdapter2.ClearBeforeFill = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // btn_atualizar_valores
            // 
            this.btn_atualizar_valores.Location = new System.Drawing.Point(503, 6);
            this.btn_atualizar_valores.Name = "btn_atualizar_valores";
            this.btn_atualizar_valores.Size = new System.Drawing.Size(67, 27);
            this.btn_atualizar_valores.TabIndex = 40;
            this.btn_atualizar_valores.Text = "Atualizar ";
            this.btn_atualizar_valores.UseVisualStyleBackColor = true;
            this.btn_atualizar_valores.Click += new System.EventHandler(this.btn_atualizar_valores_Click);
            // 
            // btn_atualizar_produto
            // 
            this.btn_atualizar_produto.Location = new System.Drawing.Point(297, 194);
            this.btn_atualizar_produto.Name = "btn_atualizar_produto";
            this.btn_atualizar_produto.Size = new System.Drawing.Size(103, 41);
            this.btn_atualizar_produto.TabIndex = 42;
            this.btn_atualizar_produto.Text = "Preencher Venda";
            this.btn_atualizar_produto.UseVisualStyleBackColor = true;
            this.btn_atualizar_produto.Click += new System.EventHandler(this.btn_atualizar_produto_Click);
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 320);
            this.Controls.Add(this.tb_Controle);
            this.Name = "FormVendas";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            this.tb_Controle.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoVenda_dbDataSet6)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_produto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoVenda_dbDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tb_Controle;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Label lbl_nome_cliente_venda;
        private System.Windows.Forms.TextBox tbx_nome_cliente_venda;
        private System.Windows.Forms.Label lbl_cod_cliente_venda;
        private System.Windows.Forms.TextBox tbx_cod_cliente_venda;
        private System.Windows.Forms.Label lbl_valor_unidade_venda;
        private System.Windows.Forms.TextBox tbx_valor_unitario_venda;
        private System.Windows.Forms.Label lbl_quantidade_venda;
        private System.Windows.Forms.Label lbl_valor_total;
        private System.Windows.Forms.Label lbl_id_produto_venda;
        private System.Windows.Forms.TextBox tbx_valor_total;
        private System.Windows.Forms.TextBox tbx_quantidade_venda;
        private System.Windows.Forms.TextBox tbx_id_produto_venda;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.TextBox tbx_cidade;
        private System.Windows.Forms.TextBox tbx_email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgrid_cliente;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.TextBox tbx_endereco;
        private System.Windows.Forms.TextBox tbx_cpf;
        private System.Windows.Forms.TextBox tbx_telefone;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_produto_confirmar;
        private System.Windows.Forms.Label lbl_cod_ean;
        private System.Windows.Forms.Label lbl_nome_produto;
        private System.Windows.Forms.Label lbl_qtd_estoque;
        private System.Windows.Forms.Label lbl_valor_unidade;
        private System.Windows.Forms.Label lbl_id_produto;
        private System.Windows.Forms.TextBox tbx_id_produto;
        private System.Windows.Forms.TextBox tbx_cod_produto;
        private System.Windows.Forms.TextBox tbx_quantidade_produto;
        private System.Windows.Forms.TextBox tbx_nome_produto;
        private System.Windows.Forms.TextBox tbx_valor_unitario;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dtgrid_produto;
        private System.Windows.Forms.BindingSource clientesBindingSource2;
        private GestaoVenda_dbDataSet5TableAdapters.ClientesTableAdapter clientesTableAdapter2;
        private GestaoVenda_dbDataSet6 gestaoVenda_dbDataSet6;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private GestaoVenda_dbDataSet6TableAdapters.ClientesTableAdapter clientesTableAdapter;
        private GestaoVenda_dbDataSet7 gestaoVenda_dbDataSet7;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private GestaoVenda_dbDataSet7TableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_atualizar_valores;
        private System.Windows.Forms.Button btn_atualizar_produto;
    }
}


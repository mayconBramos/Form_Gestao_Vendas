namespace Form_Bd
{
    partial class FormProduto
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
            this.components = new System.ComponentModel.Container();
            this.dtgrid_produto = new System.Windows.Forms.DataGridView();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codEANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestaoVenda_dbDataSet1 = new Form_Bd.GestaoVenda_dbDataSet1();
            this.produtosTableAdapter = new Form_Bd.GestaoVenda_dbDataSet1TableAdapters.ProdutosTableAdapter();
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_produto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoVenda_dbDataSet1)).BeginInit();
            this.SuspendLayout();
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
            this.dtgrid_produto.Location = new System.Drawing.Point(275, 48);
            this.dtgrid_produto.Name = "dtgrid_produto";
            this.dtgrid_produto.Size = new System.Drawing.Size(513, 307);
            this.dtgrid_produto.TabIndex = 11;
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
            this.produtosBindingSource.DataSource = this.gestaoVenda_dbDataSet1;
            // 
            // gestaoVenda_dbDataSet1
            // 
            this.gestaoVenda_dbDataSet1.DataSetName = "GestaoVenda_dbDataSet1";
            this.gestaoVenda_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_cod_ean
            // 
            this.lbl_cod_ean.AutoSize = true;
            this.lbl_cod_ean.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_cod_ean.Location = new System.Drawing.Point(32, 137);
            this.lbl_cod_ean.Name = "lbl_cod_ean";
            this.lbl_cod_ean.Size = new System.Drawing.Size(83, 13);
            this.lbl_cod_ean.TabIndex = 21;
            this.lbl_cod_ean.Text = "Codigo Produto:";
            // 
            // lbl_nome_produto
            // 
            this.lbl_nome_produto.AutoSize = true;
            this.lbl_nome_produto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_nome_produto.Location = new System.Drawing.Point(32, 169);
            this.lbl_nome_produto.Name = "lbl_nome_produto";
            this.lbl_nome_produto.Size = new System.Drawing.Size(78, 13);
            this.lbl_nome_produto.TabIndex = 20;
            this.lbl_nome_produto.Text = "Nome Produto:";
            // 
            // lbl_qtd_estoque
            // 
            this.lbl_qtd_estoque.AutoSize = true;
            this.lbl_qtd_estoque.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_qtd_estoque.Location = new System.Drawing.Point(32, 197);
            this.lbl_qtd_estoque.Name = "lbl_qtd_estoque";
            this.lbl_qtd_estoque.Size = new System.Drawing.Size(65, 13);
            this.lbl_qtd_estoque.TabIndex = 19;
            this.lbl_qtd_estoque.Text = "Quantidade:";
            // 
            // lbl_valor_unidade
            // 
            this.lbl_valor_unidade.AutoSize = true;
            this.lbl_valor_unidade.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_valor_unidade.Location = new System.Drawing.Point(32, 226);
            this.lbl_valor_unidade.Name = "lbl_valor_unidade";
            this.lbl_valor_unidade.Size = new System.Drawing.Size(70, 13);
            this.lbl_valor_unidade.TabIndex = 18;
            this.lbl_valor_unidade.Text = "Valor Unitário";
            // 
            // lbl_id_produto
            // 
            this.lbl_id_produto.AutoSize = true;
            this.lbl_id_produto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_id_produto.Location = new System.Drawing.Point(32, 107);
            this.lbl_id_produto.Name = "lbl_id_produto";
            this.lbl_id_produto.Size = new System.Drawing.Size(21, 13);
            this.lbl_id_produto.TabIndex = 17;
            this.lbl_id_produto.Text = "ID:";
            // 
            // tbx_id_produto
            // 
            this.tbx_id_produto.Location = new System.Drawing.Point(120, 104);
            this.tbx_id_produto.Name = "tbx_id_produto";
            this.tbx_id_produto.Size = new System.Drawing.Size(67, 20);
            this.tbx_id_produto.TabIndex = 16;
            // 
            // tbx_cod_produto
            // 
            this.tbx_cod_produto.Location = new System.Drawing.Point(120, 134);
            this.tbx_cod_produto.Name = "tbx_cod_produto";
            this.tbx_cod_produto.Size = new System.Drawing.Size(99, 20);
            this.tbx_cod_produto.TabIndex = 15;
            // 
            // tbx_quantidade_produto
            // 
            this.tbx_quantidade_produto.Location = new System.Drawing.Point(120, 197);
            this.tbx_quantidade_produto.Name = "tbx_quantidade_produto";
            this.tbx_quantidade_produto.Size = new System.Drawing.Size(99, 20);
            this.tbx_quantidade_produto.TabIndex = 14;
            // 
            // tbx_nome_produto
            // 
            this.tbx_nome_produto.Location = new System.Drawing.Point(120, 166);
            this.tbx_nome_produto.Name = "tbx_nome_produto";
            this.tbx_nome_produto.Size = new System.Drawing.Size(99, 20);
            this.tbx_nome_produto.TabIndex = 13;
            // 
            // tbx_valor_unitario
            // 
            this.tbx_valor_unitario.Location = new System.Drawing.Point(120, 223);
            this.tbx_valor_unitario.Name = "tbx_valor_unitario";
            this.tbx_valor_unitario.Size = new System.Drawing.Size(99, 20);
            this.tbx_valor_unitario.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Cadastrar";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(3, 48);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 307);
            this.textBox1.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 32);
            this.button1.TabIndex = 23;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(650, 375);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(138, 42);
            this.btn_voltar.TabIndex = 26;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_cod_ean);
            this.Controls.Add(this.lbl_nome_produto);
            this.Controls.Add(this.lbl_qtd_estoque);
            this.Controls.Add(this.lbl_valor_unidade);
            this.Controls.Add(this.lbl_id_produto);
            this.Controls.Add(this.tbx_id_produto);
            this.Controls.Add(this.tbx_cod_produto);
            this.Controls.Add(this.tbx_quantidade_produto);
            this.Controls.Add(this.tbx_nome_produto);
            this.Controls.Add(this.tbx_valor_unitario);
            this.Controls.Add(this.dtgrid_produto);
            this.Controls.Add(this.textBox1);
            this.Name = "FormProduto";
            this.Text = "Cadastro Produto";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_produto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoVenda_dbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgrid_produto;
        private GestaoVenda_dbDataSet1 gestaoVenda_dbDataSet1;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private GestaoVenda_dbDataSet1TableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorProdutoDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_voltar;
    }
}
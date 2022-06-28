namespace Form_Bd
{
    partial class FormCliente
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
            this.tbx_telefone = new System.Windows.Forms.TextBox();
            this.tbx_cpf = new System.Windows.Forms.TextBox();
            this.tbx_endereco = new System.Windows.Forms.TextBox();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.dtgrid_cliente = new System.Windows.Forms.DataGridView();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestaoVenda_dbDataSet = new Form_Bd.GestaoVenda_dbDataSet();
            this.clientesTableAdapter = new Form_Bd.GestaoVenda_dbDataSetTableAdapters.ClientesTableAdapter();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.tbx_cidade = new System.Windows.Forms.TextBox();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoVenda_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_telefone
            // 
            this.tbx_telefone.Location = new System.Drawing.Point(84, 156);
            this.tbx_telefone.Name = "tbx_telefone";
            this.tbx_telefone.Size = new System.Drawing.Size(99, 20);
            this.tbx_telefone.TabIndex = 0;
            // 
            // tbx_cpf
            // 
            this.tbx_cpf.Location = new System.Drawing.Point(84, 130);
            this.tbx_cpf.Name = "tbx_cpf";
            this.tbx_cpf.Size = new System.Drawing.Size(99, 20);
            this.tbx_cpf.TabIndex = 1;
            // 
            // tbx_endereco
            // 
            this.tbx_endereco.Location = new System.Drawing.Point(84, 182);
            this.tbx_endereco.Name = "tbx_endereco";
            this.tbx_endereco.Size = new System.Drawing.Size(99, 20);
            this.tbx_endereco.TabIndex = 2;
            // 
            // tbx_nome
            // 
            this.tbx_nome.Location = new System.Drawing.Point(84, 98);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(99, 20);
            this.tbx_nome.TabIndex = 3;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(12, 160);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(64, 16);
            this.lbl_telefone.TabIndex = 6;
            this.lbl_telefone.Text = "Telefone:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(12, 238);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(44, 16);
            this.lbl_email.TabIndex = 7;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(12, 130);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(30, 16);
            this.lbl_cpf.TabIndex = 8;
            this.lbl_cpf.Text = "Cpf:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(12, 98);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(47, 16);
            this.lbl_nome.TabIndex = 9;
            this.lbl_nome.Text = "Nome:";
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
            this.dtgrid_cliente.Location = new System.Drawing.Point(275, 52);
            this.dtgrid_cliente.Name = "dtgrid_cliente";
            this.dtgrid_cliente.Size = new System.Drawing.Size(513, 307);
            this.dtgrid_cliente.TabIndex = 10;
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
            this.clientesBindingSource.DataSource = this.gestaoVenda_dbDataSet;
            // 
            // gestaoVenda_dbDataSet
            // 
            this.gestaoVenda_dbDataSet.DataSetName = "GestaoVenda_dbDataSet";
            this.gestaoVenda_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(15, 283);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(184, 32);
            this.btn_confirmar.TabIndex = 11;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // tbx_email
            // 
            this.tbx_email.Location = new System.Drawing.Point(84, 234);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(99, 20);
            this.tbx_email.TabIndex = 12;
            // 
            // tbx_cidade
            // 
            this.tbx_cidade.Location = new System.Drawing.Point(84, 208);
            this.tbx_cidade.Name = "tbx_cidade";
            this.tbx_cidade.Size = new System.Drawing.Size(99, 20);
            this.tbx_cidade.TabIndex = 13;
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endereco.Location = new System.Drawing.Point(12, 186);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(69, 16);
            this.lbl_endereco.TabIndex = 14;
            this.lbl_endereco.Text = "Endereço:";
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.Location = new System.Drawing.Point(12, 212);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(54, 16);
            this.lbl_cidade.TabIndex = 15;
            this.lbl_cidade.Text = "Cidade:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(2, 43);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 316);
            this.textBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cadastrar";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(650, 365);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(138, 42);
            this.btn_voltar.TabIndex = 18;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.lbl_endereco);
            this.Controls.Add(this.tbx_cidade);
            this.Controls.Add(this.tbx_email);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.dtgrid_cliente);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.tbx_nome);
            this.Controls.Add(this.tbx_endereco);
            this.Controls.Add(this.tbx_cpf);
            this.Controls.Add(this.tbx_telefone);
            this.Controls.Add(this.textBox1);
            this.Name = "FormCliente";
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoVenda_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_telefone;
        private System.Windows.Forms.TextBox tbx_cpf;
        private System.Windows.Forms.TextBox tbx_endereco;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.DataGridView dtgrid_cliente;
        private GestaoVenda_dbDataSet gestaoVenda_dbDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private GestaoVenda_dbDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.TextBox tbx_email;
        private System.Windows.Forms.TextBox tbx_cidade;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_voltar;
    }
}
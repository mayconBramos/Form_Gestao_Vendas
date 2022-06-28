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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_cadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_produto = new System.Windows.Forms.ToolStripMenuItem();
            this.tbx_id_produto_venda = new System.Windows.Forms.TextBox();
            this.tbx_quantidade_venda = new System.Windows.Forms.TextBox();
            this.tbx_valor_total = new System.Windows.Forms.TextBox();
            this.lbl_id_produto_venda = new System.Windows.Forms.Label();
            this.lbl_valor_total = new System.Windows.Forms.Label();
            this.lbl_quantidade_venda = new System.Windows.Forms.Label();
            this.lbl_valor_unidade_venda = new System.Windows.Forms.Label();
            this.tbx_valor_unitario_venda = new System.Windows.Forms.TextBox();
            this.lbl_cod_cliente_venda = new System.Windows.Forms.Label();
            this.tbx_cod_cliente_venda = new System.Windows.Forms.TextBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.lbl_id_venda = new System.Windows.Forms.Label();
            this.tbx_id_venda = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cadastrar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(590, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_cadastrar
            // 
            this.menu_cadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cliente,
            this.menu_produto});
            this.menu_cadastrar.Name = "menu_cadastrar";
            this.menu_cadastrar.Size = new System.Drawing.Size(125, 20);
            this.menu_cadastrar.Text = "Consultar/Cadastrar";
            // 
            // menu_cliente
            // 
            this.menu_cliente.Name = "menu_cliente";
            this.menu_cliente.Size = new System.Drawing.Size(180, 22);
            this.menu_cliente.Text = "Cliente";
            this.menu_cliente.Click += new System.EventHandler(this.menu_cliente_Click);
            // 
            // menu_produto
            // 
            this.menu_produto.Name = "menu_produto";
            this.menu_produto.Size = new System.Drawing.Size(180, 22);
            this.menu_produto.Text = "Produto";
            this.menu_produto.Click += new System.EventHandler(this.menu_produto_Click);
            // 
            // tbx_id_produto_venda
            // 
            this.tbx_id_produto_venda.Location = new System.Drawing.Point(79, 74);
            this.tbx_id_produto_venda.Name = "tbx_id_produto_venda";
            this.tbx_id_produto_venda.Size = new System.Drawing.Size(100, 20);
            this.tbx_id_produto_venda.TabIndex = 1;
            // 
            // tbx_quantidade_venda
            // 
            this.tbx_quantidade_venda.Location = new System.Drawing.Point(389, 74);
            this.tbx_quantidade_venda.Name = "tbx_quantidade_venda";
            this.tbx_quantidade_venda.Size = new System.Drawing.Size(100, 20);
            this.tbx_quantidade_venda.TabIndex = 2;
            // 
            // tbx_valor_total
            // 
            this.tbx_valor_total.Location = new System.Drawing.Point(230, 129);
            this.tbx_valor_total.Name = "tbx_valor_total";
            this.tbx_valor_total.Size = new System.Drawing.Size(100, 20);
            this.tbx_valor_total.TabIndex = 3;
            // 
            // lbl_id_produto_venda
            // 
            this.lbl_id_produto_venda.AutoSize = true;
            this.lbl_id_produto_venda.Location = new System.Drawing.Point(96, 54);
            this.lbl_id_produto_venda.Name = "lbl_id_produto_venda";
            this.lbl_id_produto_venda.Size = new System.Drawing.Size(61, 13);
            this.lbl_id_produto_venda.TabIndex = 4;
            this.lbl_id_produto_venda.Text = "ID Produto:";
            // 
            // lbl_valor_total
            // 
            this.lbl_valor_total.AutoSize = true;
            this.lbl_valor_total.Location = new System.Drawing.Point(252, 113);
            this.lbl_valor_total.Name = "lbl_valor_total";
            this.lbl_valor_total.Size = new System.Drawing.Size(61, 13);
            this.lbl_valor_total.TabIndex = 5;
            this.lbl_valor_total.Text = "Valor Total:";
            // 
            // lbl_quantidade_venda
            // 
            this.lbl_quantidade_venda.AutoSize = true;
            this.lbl_quantidade_venda.Location = new System.Drawing.Point(405, 54);
            this.lbl_quantidade_venda.Name = "lbl_quantidade_venda";
            this.lbl_quantidade_venda.Size = new System.Drawing.Size(65, 13);
            this.lbl_quantidade_venda.TabIndex = 6;
            this.lbl_quantidade_venda.Text = "Quantidade:";
            // 
            // lbl_valor_unidade_venda
            // 
            this.lbl_valor_unidade_venda.AutoSize = true;
            this.lbl_valor_unidade_venda.Location = new System.Drawing.Point(243, 54);
            this.lbl_valor_unidade_venda.Name = "lbl_valor_unidade_venda";
            this.lbl_valor_unidade_venda.Size = new System.Drawing.Size(70, 13);
            this.lbl_valor_unidade_venda.TabIndex = 20;
            this.lbl_valor_unidade_venda.Text = "Valor Unitário";
            // 
            // tbx_valor_unitario_venda
            // 
            this.tbx_valor_unitario_venda.Location = new System.Drawing.Point(230, 74);
            this.tbx_valor_unitario_venda.Name = "tbx_valor_unitario_venda";
            this.tbx_valor_unitario_venda.Size = new System.Drawing.Size(99, 20);
            this.tbx_valor_unitario_venda.TabIndex = 19;
            // 
            // lbl_cod_cliente_venda
            // 
            this.lbl_cod_cliente_venda.AutoSize = true;
            this.lbl_cod_cliente_venda.Location = new System.Drawing.Point(89, 113);
            this.lbl_cod_cliente_venda.Name = "lbl_cod_cliente_venda";
            this.lbl_cod_cliente_venda.Size = new System.Drawing.Size(78, 13);
            this.lbl_cod_cliente_venda.TabIndex = 22;
            this.lbl_cod_cliente_venda.Text = "Código Cliente:";
            // 
            // tbx_cod_cliente_venda
            // 
            this.tbx_cod_cliente_venda.Location = new System.Drawing.Point(79, 129);
            this.tbx_cod_cliente_venda.Name = "tbx_cod_cliente_venda";
            this.tbx_cod_cliente_venda.Size = new System.Drawing.Size(99, 20);
            this.tbx_cod_cliente_venda.TabIndex = 21;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(211, 222);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(146, 39);
            this.btn_confirmar.TabIndex = 26;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // lbl_id_venda
            // 
            this.lbl_id_venda.AutoSize = true;
            this.lbl_id_venda.Location = new System.Drawing.Point(414, 113);
            this.lbl_id_venda.Name = "lbl_id_venda";
            this.lbl_id_venda.Size = new System.Drawing.Size(55, 13);
            this.lbl_id_venda.TabIndex = 24;
            this.lbl_id_venda.Text = "ID Venda:";
            // 
            // tbx_id_venda
            // 
            this.tbx_id_venda.Location = new System.Drawing.Point(389, 129);
            this.tbx_id_venda.Name = "tbx_id_venda";
            this.tbx_id_venda.Size = new System.Drawing.Size(99, 20);
            this.tbx_id_venda.TabIndex = 23;
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 320);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.lbl_id_venda);
            this.Controls.Add(this.tbx_id_venda);
            this.Controls.Add(this.lbl_cod_cliente_venda);
            this.Controls.Add(this.tbx_cod_cliente_venda);
            this.Controls.Add(this.lbl_valor_unidade_venda);
            this.Controls.Add(this.tbx_valor_unitario_venda);
            this.Controls.Add(this.lbl_quantidade_venda);
            this.Controls.Add(this.lbl_valor_total);
            this.Controls.Add(this.lbl_id_produto_venda);
            this.Controls.Add(this.tbx_valor_total);
            this.Controls.Add(this.tbx_quantidade_venda);
            this.Controls.Add(this.tbx_id_produto_venda);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormVendas";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_cadastrar;
        private System.Windows.Forms.ToolStripMenuItem menu_cliente;
        private System.Windows.Forms.ToolStripMenuItem menu_produto;
        private System.Windows.Forms.TextBox tbx_id_produto_venda;
        private System.Windows.Forms.TextBox tbx_quantidade_venda;
        private System.Windows.Forms.TextBox tbx_valor_total;
        private System.Windows.Forms.Label lbl_id_produto_venda;
        private System.Windows.Forms.Label lbl_valor_total;
        private System.Windows.Forms.Label lbl_quantidade_venda;
        private System.Windows.Forms.Label lbl_valor_unidade_venda;
        private System.Windows.Forms.TextBox tbx_valor_unitario_venda;
        private System.Windows.Forms.Label lbl_cod_cliente_venda;
        private System.Windows.Forms.TextBox tbx_cod_cliente_venda;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Label lbl_id_venda;
        private System.Windows.Forms.TextBox tbx_id_venda;
    }
}


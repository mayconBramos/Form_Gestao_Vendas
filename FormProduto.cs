using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Bd
{
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gestaoVenda_dbDataSet1.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.gestaoVenda_dbDataSet1.Produtos);

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            string codEan = tbx_cod_produto.Text;
            string nome_produto =  tbx_nome_produto.Text;
            int qntd= int.Parse(tbx_quantidade_produto.Text);
            double valor_unitario = double.Parse(tbx_valor_unitario.Text);

            Estoque produto = new Estoque(codEan,nome_produto,qntd,valor_unitario);
            produto.cadastrarProduto();
            this.produtosTableAdapter.Fill(this.gestaoVenda_dbDataSet1.Produtos);
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

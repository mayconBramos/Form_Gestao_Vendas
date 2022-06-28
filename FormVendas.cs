using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Bd
{
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();
        }
        
        private void menu_cliente_Click(object sender, EventArgs e)
        {
            var cad_cliente = new FormCliente();

            cad_cliente.Show();
        }

        private void menu_produto_Click(object sender, EventArgs e)
        {

            var cad_produto = new FormProduto();

            cad_produto.Show();
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            int idCliente = int.Parse(tbx_cod_cliente_venda.Text);
            int idProduto = int.Parse(tbx_id_produto_venda.Text);
            double valorTotal = double.Parse(tbx_valor_total.Text);
            double valorUnidade = double.Parse(tbx_valor_unitario_venda.Text);
            int qntd = int.Parse(tbx_quantidade_venda.Text);

            Venda venda = new Venda(idCliente, valorTotal);
            venda.gravarVenda();

            Venda itemVenda = new Venda(idProduto,valorUnidade,qntd,valorTotal);
            itemVenda.ItemVendido();

        }
    }
}

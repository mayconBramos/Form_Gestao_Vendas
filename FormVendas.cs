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
        



        private void FormVendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gestaoVenda_dbDataSet7.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.gestaoVenda_dbDataSet7.Produtos);
            // TODO: esta linha de código carrega dados na tabela 'gestaoVenda_dbDataSet6.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.gestaoVenda_dbDataSet6.Clientes);
         

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

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = tbx_nome.Text;
            string cpf = tbx_cpf.Text;
            string telefone = tbx_telefone.Text;
            string endereco = tbx_endereco.Text;
            string cidade = tbx_cidade.Text;
            string email = tbx_email.Text;

            Cliente cliente = new Cliente(nome, cpf, telefone, endereco, cidade, email);
            cliente.cadastrarCliente();
            this.clientesTableAdapter.Fill(this.gestaoVenda_dbDataSet6.Clientes);
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_produto_confirmar_Click(object sender, EventArgs e)
        {
            if (tbx_valor_total == null)
            {
                MessageBox.Show("Clique em Atualizar para somar os valores");
            }
            else {
                string codEan = tbx_cod_produto.Text;
                string nome_produto = tbx_nome_produto.Text;
                int qntd = int.Parse(tbx_quantidade_produto.Text);
                double valor_unitario = double.Parse(tbx_valor_unitario.Text);

                Estoque produto = new Estoque(codEan, nome_produto, qntd, valor_unitario);
                produto.cadastrarProduto();
                this.produtosTableAdapter.Fill(this.gestaoVenda_dbDataSet7.Produtos);
            }
        }


        private void btn_confirmar_Click_1(object sender, EventArgs e)
        {
            int idCliente = int.Parse(tbx_cod_cliente_venda.Text);
            int idProduto = int.Parse(tbx_id_produto_venda.Text);
            double valorTotal = double.Parse(tbx_valor_total.Text);
            double valorUnidade = double.Parse(tbx_valor_unitario_venda.Text);
            int qntd = int.Parse(tbx_quantidade_venda.Text);

            Venda venda = new Venda(idCliente, valorTotal);
            venda.gravarVenda();

            Venda itemVenda = new Venda(idProduto, valorUnidade, qntd, valorTotal);
            itemVenda.ItemVendido();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbx_cod_cliente_venda.Text = dtgrid_cliente.CurrentRow.Cells[0].Value.ToString();
            tbx_nome_cliente_venda.Text = dtgrid_cliente.CurrentRow.Cells[1].Value.ToString();

        }

        private void btn_atualizar_valores_Click(object sender, EventArgs e)
        {
            if( tbx_quantidade_venda == null)
            {
                MessageBox.Show("Insira uma quantidade valida!");
            }
            else
            {
                int qtnd = int.Parse(tbx_quantidade_venda.Text);
                double valorUnidade = double.Parse(tbx_valor_unitario_venda.Text);


                Venda venda = new Venda(valorUnidade, qtnd);
                tbx_valor_total.Text = venda.SomarValor(valorUnidade, qtnd).ToString();
            }
            
        }

        private void btn_atualizar_produto_Click(object sender, EventArgs e)
        {
            tbx_valor_unitario_venda.Text = dtgrid_produto.CurrentRow.Cells[4].Value.ToString();
            tbx_id_produto_venda.Text = dtgrid_produto.CurrentRow.Cells[0].Value.ToString();


        }
    }
}

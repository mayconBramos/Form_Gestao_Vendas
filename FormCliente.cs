using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Form_Bd
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }


        private void FormCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gestaoVenda_dbDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.gestaoVenda_dbDataSet.Clientes);

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            string nome = tbx_nome.Text;
            string cpf = tbx_cpf.Text;
            string telefone = tbx_telefone.Text;
            string endereco = tbx_endereco.Text;
            string cidade = tbx_cidade.Text;
            string email = tbx_email.Text;



            Cliente cliente = new Cliente(nome,cpf,telefone,endereco,cidade,email);
            cliente.cadastrarCliente();
            this.clientesTableAdapter.Fill(this.gestaoVenda_dbDataSet.Clientes);

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
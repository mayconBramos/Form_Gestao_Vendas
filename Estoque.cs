using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Bd
{
    internal class Estoque
    {

        string codEan;
        string nome_produto;
        int qntd;
        double valor_unitario;

        public Estoque(string codEan,string nome_produto,int qntd, double valor_unitario)
        {
            this.codEan = codEan;
            this.nome_produto = nome_produto;
            this.qntd = qntd;
            this.valor_unitario = valor_unitario;

        }
        public void cadastrarProduto()
        {
            

                Banco banco = new Banco();
                SqlConnection cn = banco.abrirConexao();
                SqlTransaction tran = cn.BeginTransaction();
                SqlCommand command = new SqlCommand();
                command.Connection = cn;
                command.Transaction = tran;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO Produtos VALUES" + "(@codEan,@nomeProduto,@estoque,@valorProduto)";
                command.Parameters.AddWithValue("@codEan", this.codEan);
                command.Parameters.AddWithValue("@nomeProduto",this.nome_produto);
                command.Parameters.AddWithValue("@estoque", this.qntd);
                command.Parameters.AddWithValue("@valorProduto", this.valor_unitario);
              
                try
                {
                    MessageBox.Show("Cadastro Realizado!");
                    command.ExecuteNonQuery();
                    tran.Commit();

            }
                catch (Exception e)
                {
                    tran.Rollback();
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    banco.fecharConexao();
                }
         }
    }
}


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Form_Bd
{

    class Venda
    {
        public int idCliente;
        public int idProduto;
        public double valorTotal;
        public double valorUnidade;
        public int qntd;


        public Venda(int idProduto, double valorUnidade, int qntd, double valortotal)
        {
            this.idProduto = idProduto;
            this.valorUnidade = valorUnidade;
            this.qntd = qntd;
            this.valorTotal = valortotal;
        }


        public Venda(int idCliente, double valortotal)
        {
            this.idCliente = idCliente;
            this.valorTotal = valortotal;
        }
        public Venda(double valorUnidade, int qntd)
        {
            this.valorUnidade = valorUnidade;
            this.qntd=qntd;
           
            
        }

        public void gravarVenda()
        {
            
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO Vendas VALUES (@codigoCliente, @valorTotal)";
            command.Parameters.AddWithValue("@codigoCliente",idCliente);
            command.Parameters.AddWithValue("@valorTotal",valorTotal);

            try
            {
                MessageBox.Show("Venda Realizada!");
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

        public void ItemVendido()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO ItemVenda VALUES (@idProduto, @valorUnidade, @quantidade, @valorTotal)";
            command.Parameters.AddWithValue("@idProduto", idProduto);
            command.Parameters.AddWithValue("@valorUnidade",valorUnidade);
            command.Parameters.AddWithValue("@quantidade",qntd);
            command.Parameters.AddWithValue("@valorTotal",valorTotal);

            try
            {
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

        public double SomarValor(double valor_unitario, int qtnd)
        {
            double valor_Total = valor_unitario * qtnd;
            
            return valor_Total;

        }
    }
}
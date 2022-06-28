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
    internal class Cliente
    {

       
        public string nome;
        public string cpf;
        public string telefone;
        public string endereco;
        public string cidade;
        public string email;


        public Cliente(string nome,string cpf,string telefone,string endereco,string cidade,string email)
        {
            this.nome = nome;
            this.cpf = cpf; 
            this.telefone = telefone;
            this.endereco = endereco;   
            this.cidade = cidade;
            this.email = email;
        }
        public void cadastrarCliente()
        {
           

                Banco banco = new Banco();
                SqlConnection cn = banco.abrirConexao();
                SqlTransaction tran = cn.BeginTransaction();
                SqlCommand command = new SqlCommand();
                command.Connection = cn;
                command.Transaction = tran;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO Clientes VALUES" + "(@nome,@cpf,@telefone,@endereco,@cidade,@email)";
                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@cpf", cpf);
                command.Parameters.AddWithValue("@telefone", telefone);
                command.Parameters.AddWithValue("@endereco", endereco);
                command.Parameters.AddWithValue("@cidade", cidade);
                command.Parameters.AddWithValue("@email", email);
                

                

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


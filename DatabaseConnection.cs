using LearnCodeDesktop.PontoAprendizagem;
using System.Data.SqlClient; //Importando o namespace


namespace LearnCodeDesktop.PontoAprendizagem //Definição do namespace
{
    public class DatabaseConnection //Criação da classe
    {
        // Variável de Referência (meu tipo é uma classe)
        private SqlConnection connection;
           
        //Construir vazio no parâmeto 
        public DatabaseConnection()
        {
            // Define a connection string com as informações do servidor e do banco de dados
            string connectionString = "Server=DESKTOP-7BKR55I;Database=LearnCode;Integrated Security=True;";
            this.connection = new SqlConnection(connectionString);//objeto (instância)
        }

        public void Open()//método (void) - retorno é vazio
        {
            this.connection.Open();
        }

        public void Close()//método (void) - retorno é vazio abre a conexão
        {
            this.connection.Close();
        }
        
        public SqlConnection GetConnection()//método (SqlConnection) -  retornar uma conexão SQL, pq o Objetivo dele é fechar a conexão
        {
            return this.connection;
        }
    }

}


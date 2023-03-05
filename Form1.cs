using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnCodeDesktop.PontoAprendizagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            dbConnection.Open();

            //Realizar as operações desejadas utilizando a conexão obitida com o método GetConnection()
            MessageBox.Show(dbConnection.GetConnection().ToString());

            dbConnection.Close();
        }
    }
}

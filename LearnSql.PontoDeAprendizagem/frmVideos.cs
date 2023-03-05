using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnSql.PontoDeAprendizagem
{
    public partial class frmVideos : Form
    {
        public frmVideos()
        {
            InitializeComponent();
        }

        private void frmVideos_Load(object sender, EventArgs e)
        {
            //Exibição em detalhes
            lvlVideos.View = View.Details;

            //Permite selecionar a linha toda
            lvlVideos.FullRowSelect = true;

            //Exibir as linha de grades 
            lvlVideos.GridLines = true;

            //Criar as colunas
            lvlVideos.Columns.Add("Vídeos", 400, HorizontalAlignment.Left);
            lvlVideos.Columns.Add("Horário",200, HorizontalAlignment.Right);

            //Carregar o Formulário pra ele da o foco no cursor piscando
            txtUrl.Select();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            //Verificar se o campo URL foi preenchido 
            if (txtUrl.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve informar a URL do vídeo!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Adiciona na listview
            ListViewItem lvi = new ListViewItem(txtUrl.Text.Trim());
            lvi.SubItems.Add(DateTime.Now.ToString("dd/MM/yyyy 'às' HH:mm:ss", new CultureInfo("pt-BR")));
            lvlVideos.Items.Add(lvi);
            //Exibir o vídeo
            string html = "<html><head>";
            html += "<meta content= 'IE=Edge' http-equiv= 'X-UA-Compatible'/>";
            html += "<center><iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='560' height='315' frameborder='0' allowfullscreen='true'></iframe><center>";
            html += "</body></html>";

            wbVideo.DocumentText = string.Format(html, txtUrl.Text.Trim().Split('=')[1]);

            txtUrl.Text = string.Empty;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void frmDataAtual_Click(object sender, EventArgs e)
        {

        }

        private void WbIntro_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            

        }

        private void lvlVideos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void wbVideo_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

      
    }
}
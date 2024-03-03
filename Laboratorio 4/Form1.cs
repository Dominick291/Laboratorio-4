using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Laboratorio_4
{
    public partial class Form1 : Form
    {
        List<URL> urls2 = new List<URL>();
        public Form1()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);

        }
        private void Form_Resize(object sender, EventArgs e)
        {
            webView21.Size = this.ClientSize - new System.Drawing.Size(webView21.Location);
            buscar.Left = this.ClientSize.Width - buscar.Width;
            comboBox1.Width = buscar.Left - comboBox1.Left;
        }

        private void Grabar(string Filename)
        {
            FileStream stream = new FileStream(Filename, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var url in urls2)
            {
                writer.WriteLine(url.Pagina);
                writer.WriteLine(url.Veces);
                writer.WriteLine(url.Fecha);
            }
            writer.Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            string url = comboBox1.Text.ToString();
            if (url.Contains(".") || url.Contains("/") || url.Contains(":"))
            {
                if (url.Contains("https"))
                    webView21.CoreWebView2.Navigate(url);
                else
                {
                    url = "https://" + url;
                    webView21.CoreWebView2.Navigate(url);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(url))
                {
                    url = "https://www.google.com/search?q=" + url;
                    webView21.CoreWebView2.Navigate(url);
                }
            }

            URL urlExiste = urls2.Find(u => u.Pagina == url);
            if (urlExiste == null)
            {
                URL urlNueva = new URL();
                urlNueva.Pagina = url;
                urlNueva.Veces = 1;
                urlNueva.Fecha = DateTime.Now;
                urls2.Add(urlNueva);
                Grabar("historial.txt");
                webView21.CoreWebView2.Navigate(url);
            }
            else
            {
                urlExiste.Veces++;
                urlExiste.Fecha = DateTime.Now;
                Grabar("historial.txt");
                webView21.CoreWebView2.Navigate(urlExiste.Pagina);
            }
        }

    

         

 

        private void leer()
        {
            string fileName = "historial.txt";
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                URL url = new URL();
                url.Pagina = reader.ReadLine();
                url.Veces = Convert.ToInt32(reader.ReadLine());
                url.Fecha = Convert.ToDateTime(reader.ReadLine());
                urls2.Add(url);
            }

            reader.Close();
            comboBox1.DisplayMember = "pagina";
            comboBox1.DataSource = null;
            comboBox1.DataSource = urls2;
            comboBox1.Refresh();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            leer();
        }


        private void webView21_Click_1(object sender, EventArgs e)
        {

        }

        private void bienvenidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.bing.com");
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.GoBack();
        }

        private void haciaDelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.GoForward();
        }
    }
}

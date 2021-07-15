using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace Organize
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        ExtOrg.EXTorg ext = new ExtOrg.EXTorg();
        
        bool atualizar()
        {            
            return false;
        }

        long Versao()
        {
            return Convert.ToInt64(ProductVersion.Replace(".", ""));
        }

        
        /* Function Copyright from Reza Aghaei published on
         Jan 8 16 at 18h08 at
         http://stackoverflow.com/questions/34683257/how-do-i-get-the-copyright-property-of-the-entry-application */

        string Copyright()
        {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
        }

        void CriarDiretorio(string nome)
        {
            if (Directory.Exists(nome) == false)
            {
                Directory.CreateDirectory(nome);
            }
        }

        void MoverArquivo(string nome, string dest)
        {
            if (File.Exists(nome) == false)
            {
                File.Move(nome, dest);
            }
        }

        string ArquivoSemExtensão(string nome)
        {
            return nome.Split('.')[0];
        }

        SearchOption TipoPesquisa()
        {
            if (rdEstaPasta.Checked == true) { return SearchOption.TopDirectoryOnly; }
            if (rdSubPasta.Checked == true) { return SearchOption.AllDirectories; }
            return SearchOption.TopDirectoryOnly;
        }

        private void cmdIn_Click(object sender, EventArgs e)
        {
            string dir = txtPrc.Text;            
            double @base = 0;
            double prc = 0;
            int count = 0;
            if (dir == "")
            {
                MessageBox.Show("Você deve especificar uma pasta para organizar :)", 
                    "Vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 
                    MessageBoxDefaultButton.Button1);
                txtPrc.Focus();
                return;
            }
            if (Directory.Exists(dir) == false)
            {
                MessageBox.Show("A pasta que você especificou não existe :(",
                    "Não existe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                txtPrc.Focus();
                return;
            }

            DirectoryInfo dirinfo = new DirectoryInfo(@dir);
            foreach (FileInfo f in dirinfo.GetFiles("*", TipoPesquisa()))
            {                
                count++;
                lblPrg.Text = count.ToString() + " arquivos encontrados";
                lblPrg.Update();
                this.Update();
            }
            @base = 100 / count;
            int etapa = 0;
            this.Cursor = Cursors.WaitCursor;
            foreach (FileInfo f in dirinfo.GetFiles("*", TipoPesquisa()))
            {                
                string newdir = ext.CriarDescrição(f.Extension);
                string fn = f.Name;
                string fne = ArquivoSemExtensão(fn);
                if (newdir == "")
                {
                    newdir = "SEM EXTENSÃO";
                }
                CriarDiretorio(dir + "\\" + newdir);
                this.Update();
                while (File.Exists(dir + "\\" + newdir + "\\" + fne + f.Extension) == true)
                {
                    fne += "_";
                    this.Update();
                } 
                f.MoveTo(dir + "\\" + newdir + "\\" + fne +f.Extension);                
                prc = +@base;
                etapa++;
                lblPrg.Text = etapa.ToString() + " de " + count.ToString() + " arquivos processados";
                lblPrg.Update();
                this.Update();
            }
            this.Cursor = Cursors.Default;
        }

        private void cmdPrc_Click(object sender, EventArgs e)
        {
            if (fldSelect.ShowDialog() == DialogResult.OK)
            {
                txtPrc.Text = fldSelect.SelectedPath;                
            }

        }

        private void main_Load(object sender, EventArgs e)
        {
            lblDsc.Text = Properties.Resources.description;
            lblVr.Text = Copyright() + "\nVersão " + Versao().ToString();

        }

        private void lblVr_Click(object sender, EventArgs e)
        {
            Process.Start("apps.siaelcarvalho.com");
        }

        private void lblVr_MouseHover(object sender, EventArgs e)
        {
            lblVr.ForeColor = Color.Blue;
            lblVr.Font = new Font(lblVr.Font, FontStyle.Underline);
        }
    }
}

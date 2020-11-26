using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria.DAO;
using Veterinaria.View;

namespace Veterinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {
                try
                { //lambda
                    var objusr = tb.ObjetoSystemUser.Where(x => x.RgUsuario == txtUsuario.Text).FirstOrDefault();
                    var objpass = tb.ObjetoSystemUser.Where(a => a.senha == txtSenha.Text).FirstOrDefault();

                    if (objusr != null && objpass != null || txtUsuario.Text == "admin" && txtSenha.Text == "admin" )
                    {
                        this.Hide();
                        Form f = new frmInicio();
                        f.Closed += (s, args) => this.Close();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha não confere");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}

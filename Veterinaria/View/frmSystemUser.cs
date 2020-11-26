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
using System.Data.Entity;
using Veterinaria.Entidades;

namespace Veterinaria.View
{
    public partial class frmSystemUser : Form
    {
        public frmSystemUser()
        {
            InitializeComponent();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {
                try
                {
                    tb.ObjetoSystemUser.Add(new SystemUser
                    {
                        NomeComp = txtNome.Text,
                        senha = txtSenha.Text,
                        RgUsuario = txtRg.Text,
                        Cargo = txtCargo.Text
                    });
                    tb.SaveChanges();
                    limpacampos();
                    AtualizaGrid();
                    MessageBox.Show("Incluido com sucesso", "Inclusão");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void limpacampos()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtSenha.Text = "";
            txtRg.Text = "";
            txtCargo.Text = "";
            txtNome.Focus();
            AtualizaGrid();
        }
        private void dgSystemUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgSystemUser.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgSystemUser.CurrentRow.Cells[2].Value.ToString();
            txtRg.Text = dgSystemUser.CurrentRow.Cells[1].Value.ToString();
            txtSenha.Text = dgSystemUser.CurrentRow.Cells[3].Value.ToString();
            txtCargo.Text = dgSystemUser.CurrentRow.Cells[4].Value.ToString();

        }

        public void AtualizaGrid()
        {
            using (var tb = new Contexto())
            {
                dgSystemUser.DataSource = null;
                dgSystemUser.DataSource = tb.ObjetoSystemUser.ToList();
            }
        }
        private void frmSystemUser_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {
                try
                {
                    var objeto = tb.ObjetoSystemUser.Find(Convert.ToInt32(txtId.Text));
                    objeto.NomeComp = txtNome.Text;
                    objeto.RgUsuario = txtRg.Text;
                    objeto.senha = txtSenha.Text;
                    objeto.Cargo = txtCargo.Text;

                    tb.Entry(objeto).State = EntityState.Modified;
                    tb.SaveChanges();
                    MessageBox.Show("Alterado com sucesso", "Alterado");
                    AtualizaGrid();
                    limpacampos();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {
                try
                {
                    var objeto = tb.ObjetoSystemUser.Find(Convert.ToInt32(txtId.Text));
                    tb.ObjetoSystemUser.Remove(objeto);
                    tb.SaveChanges();
                    MessageBox.Show("Excluido com sucesso", "Excluir");
                    limpacampos();
                    AtualizaGrid();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSystemUser_Load_1(object sender, EventArgs e)
        {
            AtualizaGrid();
            txtNome.Focus();
        }
    }
}

        
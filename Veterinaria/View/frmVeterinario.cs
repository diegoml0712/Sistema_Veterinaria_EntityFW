using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria.DAO;
using Veterinaria.Entidades;

namespace Veterinaria.View
{
    public partial class frmVeterinario : Form
    {
        public frmVeterinario()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {
                try
                {
                    tb.ObjetoVeterinario.Add(new Veterinario
                    {
                        Nome = txtNome.Text,
                        RG = txtRg.Text,
                        Telefone = txtTelefone.Text,
                        Especialidade = txtEspecialidade.Text,
                        
                    });
                    tb.SaveChanges();
                    limpacampos();
                    AtualizaGrid();
                    MessageBox.Show("Incluido com sucesso", "Inclusão");
                }
                catch
                {

                }
            }
        }
        public void limpacampos()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtRg.Text = "";
            txtTelefone.Text = "";
            txtEspecialidade.Text = "";
            txtNome.Focus();
            AtualizaGrid();
        }
        public void AtualizaGrid()
        {
            using (var tb = new Contexto())
            {
                DgVeterinario.DataSource = null;
                DgVeterinario.DataSource = tb.ObjetoVeterinario.ToList();
            }
        }
        private void DgVeteronario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = DgVeterinario.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = DgVeterinario.CurrentRow.Cells[1].Value.ToString();
            txtRg.Text = DgVeterinario.CurrentRow.Cells[2].Value.ToString();
            txtTelefone.Text = DgVeterinario.CurrentRow.Cells[3].Value.ToString();
            txtEspecialidade.Text = DgVeterinario.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void frmVeterinario_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            txtNome.Focus();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {
                try
                {
                    var objeto = tb.ObjetoVeterinario.Find(Convert.ToInt32(txtId.Text));
                    objeto.Nome = txtNome.Text;
                    objeto.RG = txtRg.Text;
                    objeto.Telefone = txtTelefone.Text;
                    objeto.Especialidade = txtEspecialidade.Text;
                                        

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
                    var objeto = tb.ObjetoVeterinario.Find(Convert.ToInt32(txtId.Text));
                    tb.ObjetoVeterinario.Remove(objeto);
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
    }
}

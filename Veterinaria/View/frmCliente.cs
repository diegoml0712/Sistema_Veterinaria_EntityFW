using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria.DAO;
using Veterinaria.EncontraCep;
using Veterinaria.Entidades;

namespace Veterinaria.View
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        //Buscar CEP
        private void txtCep_Leave(object sender, EventArgs e)
        {
            LocalizaCEP();
        }

        private void LocalizaCEP()
        {
            using (var ws = new EncontraCep.AtendeClienteClient())
            {
                var resultado = ws.consultaCEP(txtCep.Text);
                txtUf.Text = resultado.uf;
                txtCidade.Text = resultado.cidade;
                txtBairro.Text = resultado.bairro;
                txtRua.Text = resultado.end;
            }
        }

        //Botão Buscar Cep
        private void btnBusca_Click(object sender, EventArgs e)
        {
            LocalizaCEP();
        }

        //Botão Sair
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Botão Adicionar
        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {
                try
                {
                    tb.ObjetoCliente.Add(new Cliente
                    {
                        NomeComp = txtNome.Text,
                        RgUsuario = txtRg.Text,
                        CPF = txtCpf.Text,
                        Telefone = txtTelefone.Text,
                        Cep = txtCep.Text,
                        UF = txtUf.Text,
                        Cidade = txtCidade.Text,
                        Bairro = txtBairro.Text,
                        Rua = txtRua.Text,
                        Numero = txtNumero.Text,
                        Complemento = txtComplemento.Text,
                        Referencia = txtReferencia.Text
                    });
                    tb.SaveChanges();
                    limpacampos();
                    AtualizaGrid();
                    MessageBox.Show("Incluido com sucesso", "Inclusão");
                }
                catch (System.Exception pt)
                {
                    MessageBox.Show(pt.Message);
                }
            }
        }

        //Limpar Campos
        public void limpacampos()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtRg.Text = "";
            txtCpf.Text = "";
            txtTelefone.Text = "";
            txtCep.Text = "";
            txtUf.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            txtRua.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtReferencia.Text = "";
            txtNome.Focus();
            AtualizaGrid();
        }

        //Data Grid
        private void DgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = DgCliente.CurrentRow.Cells[1].Value.ToString();
            txtNome.Text = DgCliente.CurrentRow.Cells[0].Value.ToString();
            txtRg.Text = DgCliente.CurrentRow.Cells[1].Value.ToString();
            txtCpf.Text = DgCliente.CurrentRow.Cells[2].Value.ToString();
            txtTelefone.Text = DgCliente.CurrentRow.Cells[3].Value.ToString();
            txtCep.Text = DgCliente.CurrentRow.Cells[4].Value.ToString();
            txtUf.Text = DgCliente.CurrentRow.Cells[5].Value.ToString();
            txtCidade.Text = DgCliente.CurrentRow.Cells[6].Value.ToString();
            txtBairro.Text = DgCliente.CurrentRow.Cells[7].Value.ToString();
            txtRua.Text = DgCliente.CurrentRow.Cells[8].Value.ToString();
            txtNumero.Text = DgCliente.CurrentRow.Cells[9].Value.ToString();
            txtComplemento.Text = DgCliente.CurrentRow.Cells[10].Value.ToString();
            txtReferencia.Text = DgCliente.CurrentRow.Cells[11].Value.ToString();
        }

        // Atualizar GRID
        public void AtualizaGrid()
        {
            using (var tb = new Contexto())
            {
                DgCliente.DataSource = null;
                DgCliente.DataSource = tb.ObjetoCliente.ToList();
            }
        }
        

       

        //Botão Editar
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {
                try
                {
                    var objeto = tb.ObjetoCliente.Find(Convert.ToInt32(txtId.Text));
                    objeto.NomeComp = txtNome.Text;
                    objeto.RgUsuario = txtRg.Text;
                    objeto.CPF = txtCpf.Text;
                    objeto.Telefone = txtTelefone.Text;
                    objeto.Cep = txtCep.Text;
                    objeto.UF = txtUf.Text;
                    objeto.Cidade = txtCidade.Text;
                    objeto.Bairro = txtBairro.Text;
                    objeto.Rua = txtRua.Text;
                    objeto.Numero = txtNumero.Text;
                    objeto.Complemento = txtComplemento.Text;
                    objeto.Referencia = txtReferencia.Text;

                    tb.Entry(objeto).State = EntityState.Modified;
                    tb.SaveChanges();
                    MessageBox.Show("Alterado com sucesso", "Alterado");
                    AtualizaGrid();
                    limpacampos();
                }
                catch (System.Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Botão Excluir
        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {
                try
                {
                    var objeto = tb.ObjetoCliente.Find(txtId.Text);
                    tb.ObjetoCliente.Remove(objeto);
                    tb.SaveChanges();
                    MessageBox.Show("Excluido com sucesso", "Excluir");
                    limpacampos();
                    AtualizaGrid();
                }
                catch (System.Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Botão Cadastrar Pet
        private void cadastrarPetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPet cadpet = new frmPet();
            cadpet.Show();
        }

        //Códigos Carregados ao iniciar projeto
        private void frmCliente_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
            AtualizaGrid();
            
        }

        //Botão Filtrar RG
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {
                var resultado = tb.ObjetoCliente.Where(y => y.RgUsuario == txtRgPesq.Text);
                DgCliente.DataSource = null;
                DgCliente.DataSource = resultado.ToList();
            }
        }

        //Limpar Filtro
        private void btn_Lp_filtro_Click(object sender, EventArgs e)
        {
            AtualizaGrid();
            txtRgPesq.Clear();
        }
    }
}


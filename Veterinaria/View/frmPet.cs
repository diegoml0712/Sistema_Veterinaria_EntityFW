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
    public partial class frmPet : Form
    {
        public frmPet()
        {
            InitializeComponent();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapturarForm();
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            /*var image = new Bitmap(this.Width, this.Height);
            var graphics = Graphics.FromImage(image);
            graphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);*/
            e.Graphics.DrawImage(captura, 20, 20);
        }

        Bitmap captura = null;

        private void CapturarForm()
        {
            WindowHelper.Rect rect;
            WindowHelper.DwmGetWindowAttribute(this.Handle, (int)WindowHelper.Dwmwndowattribute.DwmwaExtendedFrameBounds,
                out rect, System.Runtime.InteropServices.Marshal.SizeOf(typeof(WindowHelper.Rect)));
            var rectangle = rect.ToRectangle();

            captura = new Bitmap(460, 350);
            var graphics = Graphics.FromImage(captura);
            graphics.CopyFromScreen(this.Location.X + 32, this.Location.Y + 60, 0, 0, new Size(460, 350));
        }

        public static class WindowHelper
        {
            [Serializable, System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
            public struct Rect
            {
                public int Left;
                public int Top;
                public int Right;
                public int Bottom;

                public System.Drawing.Rectangle ToRectangle()
                {
                    return System.Drawing.Rectangle.FromLTRB(Left, Top, Right, Bottom);
                }
            }
            [System.Runtime.InteropServices.DllImport(@"dwmapi.dll")]
            public static extern int DwmGetWindowAttribute(IntPtr hwnd, int dwAttribute, out Rect pvAttribute, int cbAttribute);
            public enum Dwmwndowattribute
            {
                DwmwaExtendedFrameBounds = 9
            }
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {
                try
                {
                    tb.ObjetoPet.Add(new Pet
                    {
                        NomePet = txtNome.Text,
                        RgUsuario = txtRg.Text,
                        Nascimento = Convert.ToDateTime(txtNascimento.Text),
                        Especie = txtEspecie.Text,
                        Raca = txtRaca.Text,
                        UltimaConsulta = Convert.ToDateTime(txtUCon.Text),
                        ProximaConsulta = Convert.ToDateTime(txtPCon.Text),
                        Historico = txtHistorico.Text,
                        RgVet = txtRgVet.Text,

                    });
                    tb.SaveChanges();
                    limpacampos();
                    AtualizaGrid();
                    MessageBox.Show("Incluido com sucesso", "Inclusão");
                }

                catch (System.Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void AtualizaGrid()
        {/*
            using (var tb = new Contexto())
            {
                dgPet.DataSource = null;
                dgPet.DataSource = tb.ObjetoPet.ToList();
            }*/

            var contexto = new Contexto();
            //var resultado = from Pet in contexto.ObjetoPet
            //                join left in contexto.ObjetoCliente
            //                on Pet.RgUsuario equals left.RgUsuario
            //                into leftOrder
            //                from Cliente in leftOrder.DefaultIfEmpty()

            //                select new
            //                {
            //                    Pet.IdPet,
            //                    Pet.RgUsuario,
            //                    Pet.NomePet,
            //                    Pet.Nascimento,
            //                    Pet.Especie,
            //                    Pet.Raca,
            //                    Pet.UltimaConsulta,
            //                    Pet.ProximaConsulta,
            //                    Pet.Historico,
            //                    Cliente.NomeComp
            //                };

            var resultado = from Pet in contexto.ObjetoPet
                            join left in contexto.ObjetoCliente
                            on Pet.RgUsuario equals left.RgUsuario
                            into leftOrder
                            from Cliente in leftOrder.DefaultIfEmpty()
                            
                            join left in contexto.ObjetoVeterinario

                            on Pet.RgVet equals left.RG
                            into leftOrder2
                            from Veterinario in leftOrder2.DefaultIfEmpty()
                            
                            select new
                            {
                                Pet.IdPet,
                                Pet.RgUsuario,
                                Pet.NomePet,
                                Pet.Nascimento,
                                Pet.Especie,
                                Pet.Raca,
                                Pet.UltimaConsulta,
                                Pet.ProximaConsulta,
                                Pet.Historico,
                                Cliente.NomeComp,
                                Veterinario.RG,

                            };


            dgPet.DataSource = resultado.ToList();
        }


        private void frmPet_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            txtRg.Focus();
        }
        public void limpacampos()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtNomeTutor.Text = "";
            txtRg.Text = "";
            txtNascimento.Text = "";
            txtEspecie.Text = "";
            txtRaca.Text = "";
            txtUCon.Text = "";
            txtPCon.Text = "";
            txtHistorico.Text = "";
            txtRgVet.Text = "";
            txtRg.Focus();
            AtualizaGrid();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {
                try
                {
                    var objeto = tb.ObjetoPet.Find(Convert.ToInt32(txtId.Text));
                    objeto.NomePet = txtNome.Text;
                    objeto.RgUsuario = txtRg.Text;
                    objeto.Nascimento = Convert.ToDateTime(txtNascimento.Text);
                    objeto.Especie = txtEspecie.Text;
                    objeto.Raca = txtRaca.Text;
                    objeto.UltimaConsulta = Convert.ToDateTime(txtUCon.Text);
                    objeto.ProximaConsulta = Convert.ToDateTime(txtPCon.Text);
                    objeto.Historico = txtHistorico.Text;
                    objeto.RgVet = txtRgVet.Text;
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

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {
                try
                {
                    var objeto = tb.ObjetoPet.Find(Convert.ToInt32(txtId.Text));
                    tb.ObjetoPet.Remove(objeto);
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
        private void dgPet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgPet.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgPet.CurrentRow.Cells[2].Value.ToString();
            txtNomeTutor.Text = dgPet.CurrentRow.Cells[9].Value.ToString();
            txtRg.Text = dgPet.CurrentRow.Cells[1].Value.ToString();
            txtNascimento.Text = dgPet.CurrentRow.Cells[3].Value.ToString();
            txtEspecie.Text = dgPet.CurrentRow.Cells[4].Value.ToString();
            txtRaca.Text = dgPet.CurrentRow.Cells[5].Value.ToString();
            txtUCon.Text = dgPet.CurrentRow.Cells[6].Value.ToString();
            txtPCon.Text = dgPet.CurrentRow.Cells[7].Value.ToString();
            txtHistorico.Text = dgPet.CurrentRow.Cells[8].Value.ToString();
            txtRgVet.Text = dgPet.CurrentRow.Cells[10].Value.ToString();
           
        }


        
        //limparFiltro
        private void button1_Click(object sender, EventArgs e)
        {
            AtualizaGrid();
            txtRgPesq.Clear();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {

                //var resultado = tb.ObjetoPet.Where(y => y.RgUsuario == txtRgPesq.Text);
                //dgPet.DataSource = null;
                //dgPet.DataSource = resultado.ToList();

                var resultado = from Pet in tb.ObjetoPet
                                join left in tb.ObjetoCliente
                                on Pet.RgUsuario equals left.RgUsuario
                                into leftOrder
                                from Cliente in leftOrder.DefaultIfEmpty()
                                where Pet.RgUsuario == txtRgPesq.Text
                                join left in tb.ObjetoVeterinario

                                on Pet.RgVet equals left.RG
                                into leftOrder2
                                from Veterinario in leftOrder2.DefaultIfEmpty()
                                //where Pet.RgVet == txtRgVet.Text
                                select new
                                {
                                    Pet.IdPet,
                                    Pet.RgUsuario,
                                    Pet.NomePet,
                                    Pet.Nascimento,
                                    Pet.Especie,
                                    Pet.Raca,
                                    Pet.UltimaConsulta,
                                    Pet.ProximaConsulta,
                                    Pet.Historico,
                                    Cliente.NomeComp,
                                    Veterinario.RG,

                                };



                dgPet.DataSource = resultado.ToList();
                txtRgPesq.Clear();
            }
        }

        private void txtRg_Leave(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {
                var resultado = tb.ObjetoCliente.Where(u => u.RgUsuario == txtRg.Text)
                     .Select(u => u.NomeComp)
                     .SingleOrDefault();
                txtNomeTutor.Text = resultado;

            }



        }

        private void txtRgVet_Leave(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {
                var resultado = tb.ObjetoVeterinario.Where(u => u.RG == txtRgVet.Text)
                     .Select(u => u.Nome)
                     .SingleOrDefault();
                txtVetNome.Text = resultado;

            }
        }
    }
}


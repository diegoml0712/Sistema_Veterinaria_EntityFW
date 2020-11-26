using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria.View
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cadcli = new frmCliente();
            cadcli.Show();
        }

        private void petToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPet cadpet = new frmPet();
            cadpet.Show();
        }

        private void veterinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVeterinario cadvet = new frmVeterinario();
            cadvet.Show();
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSystemUser cadUser = new frmSystemUser();
            cadUser.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void img_cliente_Click(object sender, EventArgs e)
        {
            frmCliente cadcli = new frmCliente();
            cadcli.Show();
        }

        private void img_pet_Click(object sender, EventArgs e)
        {
            frmPet cadpet = new frmPet();
            cadpet.Show();
        }

        private void img_vet_Click(object sender, EventArgs e)
        {
            frmVeterinario cadvet = new frmVeterinario();
            cadvet.Show();
        }

        private void img_conf_Click(object sender, EventArgs e)
        {
            frmSystemUser cadUser = new frmSystemUser();
            cadUser.Show();
        }

        private void img_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

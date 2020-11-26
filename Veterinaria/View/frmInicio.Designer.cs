namespace Veterinaria.View
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.img_cliente = new System.Windows.Forms.Button();
            this.img_pet = new System.Windows.Forms.Button();
            this.img_vet = new System.Windows.Forms.Button();
            this.img_conf = new System.Windows.Forms.Button();
            this.img_sair = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(386, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.petToolStripMenuItem,
            this.veterinarioToolStripMenuItem,
            this.novoUsuárioToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // petToolStripMenuItem
            // 
            this.petToolStripMenuItem.Name = "petToolStripMenuItem";
            this.petToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.petToolStripMenuItem.Text = "Pet";
            this.petToolStripMenuItem.Click += new System.EventHandler(this.petToolStripMenuItem_Click);
            // 
            // veterinarioToolStripMenuItem
            // 
            this.veterinarioToolStripMenuItem.Name = "veterinarioToolStripMenuItem";
            this.veterinarioToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.veterinarioToolStripMenuItem.Text = "Veterinário";
            this.veterinarioToolStripMenuItem.Click += new System.EventHandler(this.veterinarioToolStripMenuItem_Click);
            // 
            // novoUsuárioToolStripMenuItem
            // 
            this.novoUsuárioToolStripMenuItem.Name = "novoUsuárioToolStripMenuItem";
            this.novoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.novoUsuárioToolStripMenuItem.Text = "Novo Usuário";
            this.novoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.novoUsuárioToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // img_cliente
            // 
            this.img_cliente.FlatAppearance.BorderSize = 0;
            this.img_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.img_cliente.Image = ((System.Drawing.Image)(resources.GetObject("img_cliente.Image")));
            this.img_cliente.Location = new System.Drawing.Point(92, 52);
            this.img_cliente.Name = "img_cliente";
            this.img_cliente.Size = new System.Drawing.Size(64, 64);
            this.img_cliente.TabIndex = 1;
            this.img_cliente.UseVisualStyleBackColor = true;
            this.img_cliente.Click += new System.EventHandler(this.img_cliente_Click);
            // 
            // img_pet
            // 
            this.img_pet.FlatAppearance.BorderSize = 0;
            this.img_pet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.img_pet.Image = ((System.Drawing.Image)(resources.GetObject("img_pet.Image")));
            this.img_pet.Location = new System.Drawing.Point(219, 52);
            this.img_pet.Name = "img_pet";
            this.img_pet.Size = new System.Drawing.Size(64, 64);
            this.img_pet.TabIndex = 1;
            this.img_pet.UseVisualStyleBackColor = true;
            this.img_pet.Click += new System.EventHandler(this.img_pet_Click);
            // 
            // img_vet
            // 
            this.img_vet.FlatAppearance.BorderSize = 0;
            this.img_vet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.img_vet.Image = ((System.Drawing.Image)(resources.GetObject("img_vet.Image")));
            this.img_vet.Location = new System.Drawing.Point(92, 141);
            this.img_vet.Name = "img_vet";
            this.img_vet.Size = new System.Drawing.Size(64, 64);
            this.img_vet.TabIndex = 1;
            this.img_vet.UseVisualStyleBackColor = true;
            this.img_vet.Click += new System.EventHandler(this.img_vet_Click);
            // 
            // img_conf
            // 
            this.img_conf.FlatAppearance.BorderSize = 0;
            this.img_conf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.img_conf.Image = ((System.Drawing.Image)(resources.GetObject("img_conf.Image")));
            this.img_conf.Location = new System.Drawing.Point(219, 143);
            this.img_conf.Name = "img_conf";
            this.img_conf.Size = new System.Drawing.Size(64, 64);
            this.img_conf.TabIndex = 1;
            this.img_conf.UseVisualStyleBackColor = true;
            this.img_conf.Click += new System.EventHandler(this.img_conf_Click);
            // 
            // img_sair
            // 
            this.img_sair.FlatAppearance.BorderSize = 0;
            this.img_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.img_sair.Image = ((System.Drawing.Image)(resources.GetObject("img_sair.Image")));
            this.img_sair.Location = new System.Drawing.Point(158, 231);
            this.img_sair.Name = "img_sair";
            this.img_sair.Size = new System.Drawing.Size(64, 64);
            this.img_sair.TabIndex = 1;
            this.img_sair.UseVisualStyleBackColor = true;
            this.img_sair.Click += new System.EventHandler(this.img_sair_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(386, 322);
            this.Controls.Add(this.img_sair);
            this.Controls.Add(this.img_conf);
            this.Controls.Add(this.img_pet);
            this.Controls.Add(this.img_vet);
            this.Controls.Add(this.img_cliente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem petToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veterinarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button img_cliente;
        private System.Windows.Forms.Button img_pet;
        private System.Windows.Forms.Button img_vet;
        private System.Windows.Forms.Button img_conf;
        private System.Windows.Forms.Button img_sair;
    }
}
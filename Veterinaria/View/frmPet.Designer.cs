namespace Veterinaria.View
{
    partial class frmPet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPet));
            this.lblRg = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtVetNome = new System.Windows.Forms.TextBox();
            this.txtNomeTutor = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPCon = new System.Windows.Forms.MaskedTextBox();
            this.txtUCon = new System.Windows.Forms.MaskedTextBox();
            this.txtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtRgVet = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.lblPCon = new System.Windows.Forms.Label();
            this.lblUCon = new System.Windows.Forms.Label();
            this.lblRaca = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblvet = new System.Windows.Forms.Label();
            this.lblNomeTutor = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRgVet = new System.Windows.Forms.Label();
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.dgPet = new System.Windows.Forms.DataGridView();
            this.txtRgPesq = new System.Windows.Forms.MaskedTextBox();
            this.lvlId = new System.Windows.Forms.Label();
            this.lblRgPesq = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(16, 28);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(54, 13);
            this.lblRg.TabIndex = 0;
            this.lblRg.Text = "RG Tutor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRaca);
            this.groupBox1.Controls.Add(this.txtEspecie);
            this.groupBox1.Controls.Add(this.txtVetNome);
            this.groupBox1.Controls.Add(this.txtNomeTutor);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtPCon);
            this.groupBox1.Controls.Add(this.txtUCon);
            this.groupBox1.Controls.Add(this.txtNascimento);
            this.groupBox1.Controls.Add(this.txtRgVet);
            this.groupBox1.Controls.Add(this.txtRg);
            this.groupBox1.Controls.Add(this.lblHistorico);
            this.groupBox1.Controls.Add(this.lblPCon);
            this.groupBox1.Controls.Add(this.lblUCon);
            this.groupBox1.Controls.Add(this.lblRaca);
            this.groupBox1.Controls.Add(this.lblEspecie);
            this.groupBox1.Controls.Add(this.lblNascimento);
            this.groupBox1.Controls.Add(this.lblvet);
            this.groupBox1.Controls.Add(this.lblNomeTutor);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.lblRgVet);
            this.groupBox1.Controls.Add(this.lblRg);
            this.groupBox1.Controls.Add(this.txtHistorico);
            this.groupBox1.Location = new System.Drawing.Point(32, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 315);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro do Pet";
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(267, 86);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(151, 20);
            this.txtRaca.TabIndex = 5;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(60, 86);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(140, 20);
            this.txtEspecie.TabIndex = 4;
            // 
            // txtVetNome
            // 
            this.txtVetNome.Location = new System.Drawing.Point(230, 285);
            this.txtVetNome.Name = "txtVetNome";
            this.txtVetNome.ReadOnly = true;
            this.txtVetNome.Size = new System.Drawing.Size(188, 20);
            this.txtVetNome.TabIndex = 100;
            // 
            // txtNomeTutor
            // 
            this.txtNomeTutor.Location = new System.Drawing.Point(230, 25);
            this.txtNomeTutor.Name = "txtNomeTutor";
            this.txtNomeTutor.ReadOnly = true;
            this.txtNomeTutor.Size = new System.Drawing.Size(188, 20);
            this.txtNomeTutor.TabIndex = 100;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(60, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(188, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtPCon
            // 
            this.txtPCon.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtPCon.Location = new System.Drawing.Point(314, 117);
            this.txtPCon.Mask = "00/00/0000 00:00";
            this.txtPCon.Name = "txtPCon";
            this.txtPCon.Size = new System.Drawing.Size(104, 20);
            this.txtPCon.TabIndex = 7;
            this.txtPCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPCon.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // txtUCon
            // 
            this.txtUCon.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtUCon.Location = new System.Drawing.Point(107, 117);
            this.txtUCon.Mask = "00/00/0000";
            this.txtUCon.Name = "txtUCon";
            this.txtUCon.Size = new System.Drawing.Size(72, 20);
            this.txtUCon.TabIndex = 6;
            this.txtUCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUCon.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // txtNascimento
            // 
            this.txtNascimento.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtNascimento.Location = new System.Drawing.Point(346, 61);
            this.txtNascimento.Mask = "00/00/0000";
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(72, 20);
            this.txtNascimento.TabIndex = 3;
            this.txtNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNascimento.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // txtRgVet
            // 
            this.txtRgVet.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtRgVet.Location = new System.Drawing.Point(70, 285);
            this.txtRgVet.Mask = "00.000.000-0";
            this.txtRgVet.Name = "txtRgVet";
            this.txtRgVet.Size = new System.Drawing.Size(84, 20);
            this.txtRgVet.TabIndex = 9;
            this.txtRgVet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRgVet.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtRgVet.TextChanged += new System.EventHandler(this.txtRgVet_Leave);
            this.txtRgVet.Leave += new System.EventHandler(this.txtRgVet_Leave);
            // 
            // txtRg
            // 
            this.txtRg.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtRg.Location = new System.Drawing.Point(70, 25);
            this.txtRg.Mask = "00.000.000-0";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(84, 20);
            this.txtRg.TabIndex = 1;
            this.txtRg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtRg.Leave += new System.EventHandler(this.txtRg_Leave);
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Location = new System.Drawing.Point(19, 160);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(51, 13);
            this.lblHistorico.TabIndex = 0;
            this.lblHistorico.Text = "Histórico:";
            // 
            // lblPCon
            // 
            this.lblPCon.AutoSize = true;
            this.lblPCon.Location = new System.Drawing.Point(225, 124);
            this.lblPCon.Name = "lblPCon";
            this.lblPCon.Size = new System.Drawing.Size(91, 13);
            this.lblPCon.TabIndex = 0;
            this.lblPCon.Text = "Próxima Consulta:";
            // 
            // lblUCon
            // 
            this.lblUCon.AutoSize = true;
            this.lblUCon.Location = new System.Drawing.Point(18, 120);
            this.lblUCon.Name = "lblUCon";
            this.lblUCon.Size = new System.Drawing.Size(83, 13);
            this.lblUCon.TabIndex = 0;
            this.lblUCon.Text = "Ultima Consulta:";
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Location = new System.Drawing.Point(225, 89);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(36, 13);
            this.lblRaca.TabIndex = 0;
            this.lblRaca.Text = "Raça:";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(16, 89);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(48, 13);
            this.lblEspecie.TabIndex = 0;
            this.lblEspecie.Text = "Espécie:";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(266, 64);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(66, 13);
            this.lblNascimento.TabIndex = 0;
            this.lblNascimento.Text = "Nascimento:";
            // 
            // lblvet
            // 
            this.lblvet.AutoSize = true;
            this.lblvet.Location = new System.Drawing.Point(166, 288);
            this.lblvet.Name = "lblvet";
            this.lblvet.Size = new System.Drawing.Size(60, 13);
            this.lblvet.TabIndex = 0;
            this.lblvet.Text = "Veterinário:";
            // 
            // lblNomeTutor
            // 
            this.lblNomeTutor.AutoSize = true;
            this.lblNomeTutor.Location = new System.Drawing.Point(162, 28);
            this.lblNomeTutor.Name = "lblNomeTutor";
            this.lblNomeTutor.Size = new System.Drawing.Size(66, 13);
            this.lblNomeTutor.TabIndex = 0;
            this.lblNomeTutor.Text = "Nome Tutor:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 64);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblRgVet
            // 
            this.lblRgVet.AutoSize = true;
            this.lblRgVet.Location = new System.Drawing.Point(16, 288);
            this.lblRgVet.Name = "lblRgVet";
            this.lblRgVet.Size = new System.Drawing.Size(40, 13);
            this.lblRgVet.TabIndex = 0;
            this.lblRgVet.Text = "RG Dr:";
            // 
            // txtHistorico
            // 
            this.txtHistorico.Location = new System.Drawing.Point(20, 179);
            this.txtHistorico.Multiline = true;
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.Size = new System.Drawing.Size(398, 101);
            this.txtHistorico.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnPesquisa);
            this.groupBox2.Controls.Add(this.dgPet);
            this.groupBox2.Controls.Add(this.txtRgPesq);
            this.groupBox2.Controls.Add(this.lvlId);
            this.groupBox2.Controls.Add(this.lblRgPesq);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Location = new System.Drawing.Point(503, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 315);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(180, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 25);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisa.FlatAppearance.BorderSize = 0;
            this.btnPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.Image")));
            this.btnPesquisa.Location = new System.Drawing.Point(153, 26);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(26, 25);
            this.btnPesquisa.TabIndex = 10;
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // dgPet
            // 
            this.dgPet.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPet.Location = new System.Drawing.Point(17, 63);
            this.dgPet.Name = "dgPet";
            this.dgPet.Size = new System.Drawing.Size(294, 238);
            this.dgPet.TabIndex = 12;
            this.dgPet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPet_CellContentClick);
            // 
            // txtRgPesq
            // 
            this.txtRgPesq.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtRgPesq.Location = new System.Drawing.Point(67, 28);
            this.txtRgPesq.Mask = "00.000.000-0";
            this.txtRgPesq.Name = "txtRgPesq";
            this.txtRgPesq.Size = new System.Drawing.Size(84, 20);
            this.txtRgPesq.TabIndex = 17;
            this.txtRgPesq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRgPesq.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lvlId
            // 
            this.lvlId.AutoSize = true;
            this.lvlId.Location = new System.Drawing.Point(236, 31);
            this.lvlId.Name = "lvlId";
            this.lvlId.Size = new System.Drawing.Size(21, 13);
            this.lvlId.TabIndex = 0;
            this.lvlId.Text = "ID:";
            // 
            // lblRgPesq
            // 
            this.lblRgPesq.AutoSize = true;
            this.lblRgPesq.Location = new System.Drawing.Point(14, 30);
            this.lblRgPesq.Name = "lblRgPesq";
            this.lblRgPesq.Size = new System.Drawing.Size(55, 13);
            this.lblRgPesq.TabIndex = 0;
            this.lblRgPesq.Text = "RG Dono:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(259, 28);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(50, 20);
            this.txtId.TabIndex = 13;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(843, 390);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro do Pet";
            this.Load += new System.EventHandler(this.frmPet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtPCon;
        private System.Windows.Forms.MaskedTextBox txtUCon;
        private System.Windows.Forms.MaskedTextBox txtNascimento;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.Label lblPCon;
        private System.Windows.Forms.Label lblUCon;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgPet;
        private System.Windows.Forms.MaskedTextBox txtRgPesq;
        private System.Windows.Forms.Label lblRgPesq;
        private System.Windows.Forms.TextBox txtNomeTutor;
        private System.Windows.Forms.Label lblNomeTutor;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lvlId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtVetNome;
        private System.Windows.Forms.MaskedTextBox txtRgVet;
        private System.Windows.Forms.Label lblvet;
        private System.Windows.Forms.Label lblRgVet;
    }
}
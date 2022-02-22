namespace LoginDM
{
    partial class SistemaDoma
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemaDoma));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.gbPeriodo = new System.Windows.Forms.GroupBox();
            this.rbNoite = new System.Windows.Forms.RadioButton();
            this.rbTarde = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.funçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarManualmenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pbPeriodo = new System.Windows.Forms.PictureBox();
            this.btnDesconectar = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbStatus = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbPeriodo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDesconectar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(187, 73);
            this.txtUsuario.MaxLength = 5;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(213, 30);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown_1);
            // 
            // gbPeriodo
            // 
            this.gbPeriodo.Controls.Add(this.rbNoite);
            this.gbPeriodo.Controls.Add(this.rbTarde);
            this.gbPeriodo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPeriodo.Location = new System.Drawing.Point(104, 55);
            this.gbPeriodo.Name = "gbPeriodo";
            this.gbPeriodo.Size = new System.Drawing.Size(77, 88);
            this.gbPeriodo.TabIndex = 5;
            this.gbPeriodo.TabStop = false;
            this.gbPeriodo.Text = "Período";
            this.gbPeriodo.Enter += new System.EventHandler(this.gbPeriodo_Enter);
            this.gbPeriodo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.gbPeriodo_PreviewKeyDown);
            // 
            // rbNoite
            // 
            this.rbNoite.AutoSize = true;
            this.rbNoite.Location = new System.Drawing.Point(6, 52);
            this.rbNoite.Name = "rbNoite";
            this.rbNoite.Size = new System.Drawing.Size(54, 19);
            this.rbNoite.TabIndex = 1;
            this.rbNoite.Text = "Noite";
            this.rbNoite.UseVisualStyleBackColor = true;
            this.rbNoite.CheckedChanged += new System.EventHandler(this.rbNoite_CheckedChanged);
            // 
            // rbTarde
            // 
            this.rbTarde.AutoSize = true;
            this.rbTarde.Location = new System.Drawing.Point(6, 26);
            this.rbTarde.Name = "rbTarde";
            this.rbTarde.Size = new System.Drawing.Size(53, 19);
            this.rbTarde.TabIndex = 0;
            this.rbTarde.Text = "Tarde";
            this.rbTarde.UseVisualStyleBackColor = true;
            this.rbTarde.CheckedChanged += new System.EventHandler(this.rbTarde_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sistemas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(298, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Minha Pasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Transmissão";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sala de Aula";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::LoginDM.Properties.Resources.dir;
            this.pictureBox4.Location = new System.Drawing.Point(305, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(63, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::LoginDM.Properties.Resources.live1;
            this.pictureBox3.Location = new System.Drawing.Point(144, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(107, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::LoginDM.Properties.Resources.google_classroom_logo_2;
            this.pictureBox2.Location = new System.Drawing.Point(28, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(241, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Desenvolvido por: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(336, 271);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(64, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Luan Costa";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funçõesToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(412, 25);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // funçõesToolStripMenuItem
            // 
            this.funçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarManualmenteToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.funçõesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funçõesToolStripMenuItem.Name = "funçõesToolStripMenuItem";
            this.funçõesToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.funçõesToolStripMenuItem.Text = "Funções";
            // 
            // conectarManualmenteToolStripMenuItem
            // 
            this.conectarManualmenteToolStripMenuItem.Image = global::LoginDM.Properties.Resources.conectar;
            this.conectarManualmenteToolStripMenuItem.Name = "conectarManualmenteToolStripMenuItem";
            this.conectarManualmenteToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.conectarManualmenteToolStripMenuItem.Text = "Conectar Manualmente";
            this.conectarManualmenteToolStripMenuItem.Click += new System.EventHandler(this.conectarManualmenteToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::LoginDM.Properties.Resources.desconectar;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.sairToolStripMenuItem.Text = "Desconectar Manualmente";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem1});
            this.sobreToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.sobreToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem1
            // 
            this.sobreToolStripMenuItem1.Image = global::LoginDM.Properties.Resources.info;
            this.sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            this.sobreToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.sobreToolStripMenuItem1.Text = "Sobre";
            this.sobreToolStripMenuItem1.Click += new System.EventHandler(this.sobreToolStripMenuItem1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Usuário:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(372, 25);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(31, 13);
            this.lblUser.TabIndex = 14;
            this.lblUser.Text = "????";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(189, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Período:";
            // 
            // pbPeriodo
            // 
            this.pbPeriodo.Location = new System.Drawing.Point(236, 2);
            this.pbPeriodo.Name = "pbPeriodo";
            this.pbPeriodo.Size = new System.Drawing.Size(17, 17);
            this.pbPeriodo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPeriodo.TabIndex = 15;
            this.pbPeriodo.TabStop = false;
            this.pbPeriodo.Click += new System.EventHandler(this.pbPeriodo_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesconectar.Image = global::LoginDM.Properties.Resources.BT2;
            this.btnDesconectar.Location = new System.Drawing.Point(298, 106);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(102, 38);
            this.btnDesconectar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDesconectar.TabIndex = 13;
            this.btnDesconectar.TabStop = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Image = global::LoginDM.Properties.Resources.BT1;
            this.btnLogin.Location = new System.Drawing.Point(187, 106);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(102, 37);
            this.btnLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogin.TabIndex = 10;
            this.btnLogin.TabStop = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginDM.Properties.Resources.logo_dommacario_borda;
            this.pictureBox1.Location = new System.Drawing.Point(12, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbStatus
            // 
            this.pbStatus.Image = global::LoginDM.Properties.Resources.offline;
            this.pbStatus.Location = new System.Drawing.Point(389, 4);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(17, 17);
            this.pbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStatus.TabIndex = 16;
            this.pbStatus.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(269, 8);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Status:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Teste";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SistemaDoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 293);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbPeriodo);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbPeriodo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SistemaDoma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema - Casa Dom Macário";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPeriodo.ResumeLayout(false);
            this.gbPeriodo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDesconectar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbPeriodo;
        private System.Windows.Forms.RadioButton rbNoite;
        private System.Windows.Forms.RadioButton rbTarde;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox btnLogin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem funçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox btnDesconectar;
        private System.Windows.Forms.ToolStripMenuItem conectarManualmenteToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbPeriodo;
        private System.Windows.Forms.PictureBox pbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button button1;
    }
}


namespace LoginDM
{
    partial class Backup
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
            this.lbxOrigem = new System.Windows.Forms.ListBox();
            this.lbxDestino = new System.Windows.Forms.ListBox();
            this.gpPeriodo = new System.Windows.Forms.GroupBox();
            this.rbNoite = new System.Windows.Forms.RadioButton();
            this.rbTarde = new System.Windows.Forms.RadioButton();
            this.cbSemestre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dpAno = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtProgresso = new System.Windows.Forms.Label();
            this.tbLogs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAbrirDestino = new System.Windows.Forms.Button();
            this.llBaseOrigem = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.llBaseDestino = new System.Windows.Forms.LinkLabel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAbrirOrigem = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.gpPeriodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxOrigem
            // 
            this.lbxOrigem.FormattingEnabled = true;
            this.lbxOrigem.Location = new System.Drawing.Point(167, 27);
            this.lbxOrigem.Name = "lbxOrigem";
            this.lbxOrigem.Size = new System.Drawing.Size(243, 212);
            this.lbxOrigem.TabIndex = 1;
            // 
            // lbxDestino
            // 
            this.lbxDestino.FormattingEnabled = true;
            this.lbxDestino.Location = new System.Drawing.Point(416, 27);
            this.lbxDestino.Name = "lbxDestino";
            this.lbxDestino.Size = new System.Drawing.Size(368, 212);
            this.lbxDestino.TabIndex = 1;
            // 
            // gpPeriodo
            // 
            this.gpPeriodo.Controls.Add(this.rbNoite);
            this.gpPeriodo.Controls.Add(this.rbTarde);
            this.gpPeriodo.Location = new System.Drawing.Point(16, 120);
            this.gpPeriodo.Name = "gpPeriodo";
            this.gpPeriodo.Size = new System.Drawing.Size(130, 51);
            this.gpPeriodo.TabIndex = 3;
            this.gpPeriodo.TabStop = false;
            this.gpPeriodo.Text = "Período";
            this.gpPeriodo.Enter += new System.EventHandler(this.gpPeriodo_Enter);
            // 
            // rbNoite
            // 
            this.rbNoite.AutoSize = true;
            this.rbNoite.Location = new System.Drawing.Point(65, 19);
            this.rbNoite.Name = "rbNoite";
            this.rbNoite.Size = new System.Drawing.Size(50, 17);
            this.rbNoite.TabIndex = 1;
            this.rbNoite.TabStop = true;
            this.rbNoite.Text = "Noite";
            this.rbNoite.UseVisualStyleBackColor = true;
            this.rbNoite.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbTarde
            // 
            this.rbTarde.AutoSize = true;
            this.rbTarde.Location = new System.Drawing.Point(6, 19);
            this.rbTarde.Name = "rbTarde";
            this.rbTarde.Size = new System.Drawing.Size(53, 17);
            this.rbTarde.TabIndex = 0;
            this.rbTarde.TabStop = true;
            this.rbTarde.Text = "Tarde";
            this.rbTarde.UseVisualStyleBackColor = true;
            this.rbTarde.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cbSemestre
            // 
            this.cbSemestre.FormattingEnabled = true;
            this.cbSemestre.Items.AddRange(new object[] {
            "1º Semestre",
            "2º Semestre"});
            this.cbSemestre.Location = new System.Drawing.Point(16, 89);
            this.cbSemestre.Name = "cbSemestre";
            this.cbSemestre.Size = new System.Drawing.Size(130, 21);
            this.cbSemestre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Semestre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ano";
            // 
            // dpAno
            // 
            this.dpAno.Location = new System.Drawing.Point(19, 39);
            this.dpAno.Name = "dpAno";
            this.dpAno.Size = new System.Drawing.Size(130, 20);
            this.dpAno.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Origem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Destino";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(167, 283);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(617, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // txtProgresso
            // 
            this.txtProgresso.AutoSize = true;
            this.txtProgresso.Location = new System.Drawing.Point(164, 313);
            this.txtProgresso.Name = "txtProgresso";
            this.txtProgresso.Size = new System.Drawing.Size(37, 13);
            this.txtProgresso.TabIndex = 5;
            this.txtProgresso.Text = "Status";
            // 
            // tbLogs
            // 
            this.tbLogs.Location = new System.Drawing.Point(16, 261);
            this.tbLogs.Multiline = true;
            this.tbLogs.Name = "tbLogs";
            this.tbLogs.Size = new System.Drawing.Size(133, 66);
            this.tbLogs.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Logs";
            // 
            // btnAbrirDestino
            // 
            this.btnAbrirDestino.Image = global::LoginDM.Properties.Resources.pasta;
            this.btnAbrirDestino.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirDestino.Location = new System.Drawing.Point(416, 244);
            this.btnAbrirDestino.Name = "btnAbrirDestino";
            this.btnAbrirDestino.Size = new System.Drawing.Size(90, 31);
            this.btnAbrirDestino.TabIndex = 10;
            this.btnAbrirDestino.Text = "Abrir Destino";
            this.btnAbrirDestino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirDestino.UseVisualStyleBackColor = true;
            this.btnAbrirDestino.Click += new System.EventHandler(this.btnAbrirDestino_Click);
            // 
            // llBaseOrigem
            // 
            this.llBaseOrigem.AutoSize = true;
            this.llBaseOrigem.LinkColor = System.Drawing.Color.Black;
            this.llBaseOrigem.Location = new System.Drawing.Point(260, 261);
            this.llBaseOrigem.Name = "llBaseOrigem";
            this.llBaseOrigem.Size = new System.Drawing.Size(55, 13);
            this.llBaseOrigem.TabIndex = 12;
            this.llBaseOrigem.TabStop = true;
            this.llBaseOrigem.Text = "linkLabel1";
            this.llBaseOrigem.Click += new System.EventHandler(this.llBaseOrigem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Base";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Base";
            // 
            // llBaseDestino
            // 
            this.llBaseDestino.AutoSize = true;
            this.llBaseDestino.LinkColor = System.Drawing.Color.Black;
            this.llBaseDestino.Location = new System.Drawing.Point(507, 260);
            this.llBaseDestino.Name = "llBaseDestino";
            this.llBaseDestino.Size = new System.Drawing.Size(55, 13);
            this.llBaseDestino.TabIndex = 14;
            this.llBaseDestino.TabStop = true;
            this.llBaseDestino.Text = "linkLabel2";
            this.llBaseDestino.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llBaseDestino_LinkClicked);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::LoginDM.Properties.Resources.limpar_limpo;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.Location = new System.Drawing.Point(81, 177);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(59, 31);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAbrirOrigem
            // 
            this.btnAbrirOrigem.Image = global::LoginDM.Properties.Resources.pasta;
            this.btnAbrirOrigem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirOrigem.Location = new System.Drawing.Point(167, 244);
            this.btnAbrirOrigem.Name = "btnAbrirOrigem";
            this.btnAbrirOrigem.Size = new System.Drawing.Size(86, 31);
            this.btnAbrirOrigem.TabIndex = 10;
            this.btnAbrirOrigem.Text = "Abrir Origem";
            this.btnAbrirOrigem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirOrigem.UseVisualStyleBackColor = true;
            this.btnAbrirOrigem.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnBackup
            // 
            this.btnBackup.Image = global::LoginDM.Properties.Resources.copia_de_dados2;
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackup.Location = new System.Drawing.Point(16, 214);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(124, 25);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "Efetuar Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnListar
            // 
            this.btnListar.Image = global::LoginDM.Properties.Resources.tarefa;
            this.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListar.Location = new System.Drawing.Point(16, 177);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(59, 31);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 339);
            this.Controls.Add(this.llBaseDestino);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.llBaseOrigem);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAbrirDestino);
            this.Controls.Add(this.btnAbrirOrigem);
            this.Controls.Add(this.tbLogs);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dpAno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProgresso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSemestre);
            this.Controls.Add(this.gpPeriodo);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.lbxDestino);
            this.Controls.Add(this.lbxOrigem);
            this.Controls.Add(this.btnListar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.Backup_Load);
            this.gpPeriodo.ResumeLayout(false);
            this.gpPeriodo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ListBox lbxOrigem;
        private System.Windows.Forms.ListBox lbxDestino;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.GroupBox gpPeriodo;
        private System.Windows.Forms.RadioButton rbNoite;
        private System.Windows.Forms.RadioButton rbTarde;
        private System.Windows.Forms.ComboBox cbSemestre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpAno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label txtProgresso;
        private System.Windows.Forms.TextBox tbLogs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAbrirOrigem;
        private System.Windows.Forms.Button btnAbrirDestino;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.LinkLabel llBaseOrigem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel llBaseDestino;
    }
}
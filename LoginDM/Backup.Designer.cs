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
            this.btnListar = new System.Windows.Forms.Button();
            this.lbxOrigem = new System.Windows.Forms.ListBox();
            this.lbxDestino = new System.Windows.Forms.ListBox();
            this.btnBackup = new System.Windows.Forms.Button();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gpPeriodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(16, 177);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(59, 31);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbxOrigem
            // 
            this.lbxOrigem.FormattingEnabled = true;
            this.lbxOrigem.Location = new System.Drawing.Point(167, 27);
            this.lbxOrigem.Name = "lbxOrigem";
            this.lbxOrigem.Size = new System.Drawing.Size(243, 238);
            this.lbxOrigem.TabIndex = 1;
            // 
            // lbxDestino
            // 
            this.lbxDestino.FormattingEnabled = true;
            this.lbxDestino.Location = new System.Drawing.Point(416, 27);
            this.lbxDestino.Name = "lbxDestino";
            this.lbxDestino.Size = new System.Drawing.Size(243, 238);
            this.lbxDestino.TabIndex = 1;
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(81, 177);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(65, 31);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.button2_Click);
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
            this.progressBar1.Location = new System.Drawing.Point(167, 281);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(492, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // txtProgresso
            // 
            this.txtProgresso.AutoSize = true;
            this.txtProgresso.Location = new System.Drawing.Point(164, 307);
            this.txtProgresso.Name = "txtProgresso";
            this.txtProgresso.Size = new System.Drawing.Size(37, 13);
            this.txtProgresso.TabIndex = 5;
            this.txtProgresso.Text = "Status";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 242);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 79);
            this.textBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Logs";
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 333);
            this.Controls.Add(this.textBox1);
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
            this.Name = "Backup";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}
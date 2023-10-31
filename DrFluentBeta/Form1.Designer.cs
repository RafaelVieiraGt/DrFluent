namespace DrFluentBeta
{
    partial class RegistroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroForm));
            this.NomeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TelefoneBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nvlingBox = new System.Windows.Forms.ComboBox();
            this.EnviarButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAlunos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NomeBox
            // 
            this.NomeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.NomeBox.Location = new System.Drawing.Point(186, 101);
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.Size = new System.Drawing.Size(190, 22);
            this.NomeBox.TabIndex = 0;
            this.NomeBox.TextChanged += new System.EventHandler(this.NomeBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(87)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(113, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(87)))), ((int)(((byte)(137)))));
            this.label2.Location = new System.Drawing.Point(107, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-mail";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.EmailBox.Location = new System.Drawing.Point(186, 149);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(190, 22);
            this.EmailBox.TabIndex = 2;
            this.EmailBox.TextChanged += new System.EventHandler(this.EmailBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(87)))), ((int)(((byte)(137)))));
            this.label3.Location = new System.Drawing.Point(102, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Celular";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TelefoneBox
            // 
            this.TelefoneBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.TelefoneBox.Location = new System.Drawing.Point(186, 194);
            this.TelefoneBox.Name = "TelefoneBox";
            this.TelefoneBox.Size = new System.Drawing.Size(190, 22);
            this.TelefoneBox.TabIndex = 4;
            this.TelefoneBox.TextChanged += new System.EventHandler(this.TelefoneBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(87)))), ((int)(((byte)(137)))));
            this.label4.Location = new System.Drawing.Point(41, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nivel de Inglês";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nvlingBox
            // 
            this.nvlingBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.nvlingBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nvlingBox.FormattingEnabled = true;
            this.nvlingBox.Items.AddRange(new object[] {
            "Iniciante",
            "Intermediário",
            "Avançado"});
            this.nvlingBox.Location = new System.Drawing.Point(186, 233);
            this.nvlingBox.Name = "nvlingBox";
            this.nvlingBox.Size = new System.Drawing.Size(190, 24);
            this.nvlingBox.TabIndex = 8;
            this.nvlingBox.SelectedIndexChanged += new System.EventHandler(this.nvlingBox_SelectedIndexChanged);
            // 
            // EnviarButton
            // 
            this.EnviarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(87)))), ((int)(((byte)(137)))));
            this.EnviarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnviarButton.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnviarButton.ForeColor = System.Drawing.Color.White;
            this.EnviarButton.Location = new System.Drawing.Point(117, 290);
            this.EnviarButton.Name = "EnviarButton";
            this.EnviarButton.Size = new System.Drawing.Size(88, 33);
            this.EnviarButton.TabIndex = 9;
            this.EnviarButton.Text = "ENVIAR";
            this.EnviarButton.UseVisualStyleBackColor = false;
            this.EnviarButton.Click += new System.EventHandler(this.EnviarButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.sairButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sairButton.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(87)))), ((int)(((byte)(137)))));
            this.sairButton.Location = new System.Drawing.Point(322, 290);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(88, 33);
            this.sairButton.TabIndex = 10;
            this.sairButton.Text = "SAIR";
            this.sairButton.UseVisualStyleBackColor = false;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(87)))), ((int)(((byte)(137)))));
            this.label5.Location = new System.Drawing.Point(104, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 58);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cadastro Aluno:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAlunos
            // 
            this.buttonAlunos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(87)))), ((int)(((byte)(137)))));
            this.buttonAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlunos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlunos.ForeColor = System.Drawing.Color.White;
            this.buttonAlunos.Location = new System.Drawing.Point(219, 290);
            this.buttonAlunos.Name = "buttonAlunos";
            this.buttonAlunos.Size = new System.Drawing.Size(88, 33);
            this.buttonAlunos.TabIndex = 21;
            this.buttonAlunos.Text = "ALUNOS";
            this.buttonAlunos.UseVisualStyleBackColor = false;
            this.buttonAlunos.Click += new System.EventHandler(this.buttonAlunos_Click);
            // 
            // RegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(522, 363);
            this.Controls.Add(this.buttonAlunos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.EnviarButton);
            this.Controls.Add(this.nvlingBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TelefoneBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomeBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Professores";
            this.Load += new System.EventHandler(this.RegistroForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NomeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TelefoneBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox nvlingBox;
        private System.Windows.Forms.Button EnviarButton;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAlunos;
    }
}


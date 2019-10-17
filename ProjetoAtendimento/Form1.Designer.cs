namespace ProjetoAtendimento
{
    partial class Form1
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
            this.listSenhasGeradas = new System.Windows.Forms.ListBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnListarSenhas = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnListarAtendimentos = new System.Windows.Forms.Button();
            this.btnChamar = new System.Windows.Forms.Button();
            this.listAtendimentosChamados = new System.Windows.Forms.ListBox();
            this.tbGuicheChamado = new System.Windows.Forms.TextBox();
            this.labelGuichesAbertos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listSenhasGeradas
            // 
            this.listSenhasGeradas.FormattingEnabled = true;
            this.listSenhasGeradas.Location = new System.Drawing.Point(21, 91);
            this.listSenhasGeradas.Margin = new System.Windows.Forms.Padding(2);
            this.listSenhasGeradas.Name = "listSenhasGeradas";
            this.listSenhasGeradas.Size = new System.Drawing.Size(190, 95);
            this.listSenhasGeradas.TabIndex = 0;
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.Transparent;
            this.btnGerar.Location = new System.Drawing.Point(21, 49);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(91, 19);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "Gerar Senha";
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnListarSenhas
            // 
            this.btnListarSenhas.BackColor = System.Drawing.Color.Transparent;
            this.btnListarSenhas.Location = new System.Drawing.Point(116, 49);
            this.btnListarSenhas.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarSenhas.Name = "btnListarSenhas";
            this.btnListarSenhas.Size = new System.Drawing.Size(95, 19);
            this.btnListarSenhas.TabIndex = 2;
            this.btnListarSenhas.Text = "Listar Senhas";
            this.btnListarSenhas.UseVisualStyleBackColor = false;
            this.btnListarSenhas.Click += new System.EventHandler(this.btnListarSenhas_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(396, 14);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(70, 19);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnListarAtendimentos
            // 
            this.btnListarAtendimentos.Location = new System.Drawing.Point(415, 49);
            this.btnListarAtendimentos.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarAtendimentos.Name = "btnListarAtendimentos";
            this.btnListarAtendimentos.Size = new System.Drawing.Size(117, 19);
            this.btnListarAtendimentos.TabIndex = 4;
            this.btnListarAtendimentos.Text = "Listar Atendimentos";
            this.btnListarAtendimentos.UseVisualStyleBackColor = true;
            this.btnListarAtendimentos.Click += new System.EventHandler(this.btnListarAtendimentos_Click);
            // 
            // btnChamar
            // 
            this.btnChamar.Location = new System.Drawing.Point(355, 49);
            this.btnChamar.Margin = new System.Windows.Forms.Padding(2);
            this.btnChamar.Name = "btnChamar";
            this.btnChamar.Size = new System.Drawing.Size(56, 19);
            this.btnChamar.TabIndex = 5;
            this.btnChamar.Text = "Chamar";
            this.btnChamar.UseVisualStyleBackColor = true;
            this.btnChamar.Click += new System.EventHandler(this.btnChamar_Click);
            // 
            // listAtendimentosChamados
            // 
            this.listAtendimentosChamados.FormattingEnabled = true;
            this.listAtendimentosChamados.Location = new System.Drawing.Point(268, 91);
            this.listAtendimentosChamados.Margin = new System.Windows.Forms.Padding(2);
            this.listAtendimentosChamados.Name = "listAtendimentosChamados";
            this.listAtendimentosChamados.Size = new System.Drawing.Size(328, 95);
            this.listAtendimentosChamados.TabIndex = 6;
            // 
            // tbGuicheChamado
            // 
            this.tbGuicheChamado.Location = new System.Drawing.Point(322, 48);
            this.tbGuicheChamado.Name = "tbGuicheChamado";
            this.tbGuicheChamado.Size = new System.Drawing.Size(28, 20);
            this.tbGuicheChamado.TabIndex = 7;
            // 
            // labelGuichesAbertos
            // 
            this.labelGuichesAbertos.AutoSize = true;
            this.labelGuichesAbertos.Location = new System.Drawing.Point(378, 17);
            this.labelGuichesAbertos.Name = "labelGuichesAbertos";
            this.labelGuichesAbertos.Size = new System.Drawing.Size(13, 13);
            this.labelGuichesAbertos.TabIndex = 8;
            this.labelGuichesAbertos.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nº Guiches Abertos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Guiche:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(611, 207);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelGuichesAbertos);
            this.Controls.Add(this.tbGuicheChamado);
            this.Controls.Add(this.listAtendimentosChamados);
            this.Controls.Add(this.btnChamar);
            this.Controls.Add(this.btnListarAtendimentos);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnListarSenhas);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.listSenhasGeradas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Projeto Atendimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listSenhasGeradas;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnListarSenhas;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnListarAtendimentos;
        private System.Windows.Forms.Button btnChamar;
        private System.Windows.Forms.ListBox listAtendimentosChamados;
        private System.Windows.Forms.TextBox tbGuicheChamado;
        private System.Windows.Forms.Label labelGuichesAbertos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


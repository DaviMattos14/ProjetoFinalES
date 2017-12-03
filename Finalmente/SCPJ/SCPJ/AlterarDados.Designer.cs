namespace SCPJ
{
    partial class AlterarDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarDados));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNewRota2 = new System.Windows.Forms.ComboBox();
            this.cbNewRota1 = new System.Windows.Forms.ComboBox();
            this.txtConfirNewSenha = new System.Windows.Forms.TextBox();
            this.txtNewSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbNewRota2);
            this.groupBox1.Controls.Add(this.cbNewRota1);
            this.groupBox1.Controls.Add(this.txtConfirNewSenha);
            this.groupBox1.Controls.Add(this.txtNewSenha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alterar Dados:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbNewRota2
            // 
            this.cbNewRota2.FormattingEnabled = true;
            this.cbNewRota2.Location = new System.Drawing.Point(126, 185);
            this.cbNewRota2.Name = "cbNewRota2";
            this.cbNewRota2.Size = new System.Drawing.Size(140, 22);
            this.cbNewRota2.TabIndex = 10;
            // 
            // cbNewRota1
            // 
            this.cbNewRota1.FormattingEnabled = true;
            this.cbNewRota1.Location = new System.Drawing.Point(126, 158);
            this.cbNewRota1.Name = "cbNewRota1";
            this.cbNewRota1.Size = new System.Drawing.Size(130, 22);
            this.cbNewRota1.TabIndex = 9;
            // 
            // txtConfirNewSenha
            // 
            this.txtConfirNewSenha.Location = new System.Drawing.Point(167, 118);
            this.txtConfirNewSenha.Name = "txtConfirNewSenha";
            this.txtConfirNewSenha.PasswordChar = '*';
            this.txtConfirNewSenha.Size = new System.Drawing.Size(235, 20);
            this.txtConfirNewSenha.TabIndex = 8;
            // 
            // txtNewSenha
            // 
            this.txtNewSenha.Location = new System.Drawing.Point(110, 88);
            this.txtNewSenha.Name = "txtNewSenha";
            this.txtNewSenha.PasswordChar = '*';
            this.txtNewSenha.Size = new System.Drawing.Size(235, 20);
            this.txtNewSenha.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rota Secundária:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rota Primária:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirmar nova senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nova Senha:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "←";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(386, 252);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 37);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar Alterações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(270, 252);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 37);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir Conta";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // AlterarDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SCPJ.Properties.Resources.AlterarDadosp;
            this.ClientSize = new System.Drawing.Size(512, 298);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AlterarDados";
            this.Text = "Sistema de Composições Para Jogadores - SCPJ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbNewRota2;
        private System.Windows.Forms.ComboBox cbNewRota1;
        private System.Windows.Forms.TextBox txtConfirNewSenha;
        private System.Windows.Forms.TextBox txtNewSenha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
    }
}
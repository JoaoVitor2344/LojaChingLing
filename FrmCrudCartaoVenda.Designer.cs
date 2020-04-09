namespace LojaCL
{
    partial class FrmCrudCartaoVenda
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
            this.dgv_cartaoVenda = new System.Windows.Forms.DataGridView();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.Usuário = new System.Windows.Forms.Label();
            this.Número = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.cbx_usuario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cartaoVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_cartaoVenda
            // 
            this.dgv_cartaoVenda.AllowUserToAddRows = false;
            this.dgv_cartaoVenda.AllowUserToDeleteRows = false;
            this.dgv_cartaoVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cartaoVenda.Location = new System.Drawing.Point(12, 163);
            this.dgv_cartaoVenda.Name = "dgv_cartaoVenda";
            this.dgv_cartaoVenda.ReadOnly = true;
            this.dgv_cartaoVenda.Size = new System.Drawing.Size(423, 150);
            this.dgv_cartaoVenda.TabIndex = 61;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Location = new System.Drawing.Point(195, 16);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 60;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(348, 105);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 59;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(348, 76);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 58;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(348, 47);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 57;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(58, 50);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(212, 20);
            this.txt_numero.TabIndex = 54;
            // 
            // Usuário
            // 
            this.Usuário.AutoSize = true;
            this.Usuário.Location = new System.Drawing.Point(9, 87);
            this.Usuário.Name = "Usuário";
            this.Usuário.Size = new System.Drawing.Size(43, 13);
            this.Usuário.TabIndex = 52;
            this.Usuário.Text = "Usuário";
            // 
            // Número
            // 
            this.Número.AutoSize = true;
            this.Número.Location = new System.Drawing.Point(8, 50);
            this.Número.Name = "Número";
            this.Número.Size = new System.Drawing.Size(44, 13);
            this.Número.TabIndex = 51;
            this.Número.Text = "Número";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(58, 16);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(122, 20);
            this.txtId.TabIndex = 50;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(25, 19);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 49;
            this.lblId.Text = "ID";
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(348, 16);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnCadastro.TabIndex = 48;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // cbx_usuario
            // 
            this.cbx_usuario.FormattingEnabled = true;
            this.cbx_usuario.Location = new System.Drawing.Point(58, 87);
            this.cbx_usuario.Name = "cbx_usuario";
            this.cbx_usuario.Size = new System.Drawing.Size(214, 21);
            this.cbx_usuario.TabIndex = 62;
            this.cbx_usuario.SelectedIndexChanged += new System.EventHandler(this.cbx_usuario_SelectedIndexChanged);
            // 
            // FrmCrudCartaoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 333);
            this.Controls.Add(this.cbx_usuario);
            this.Controls.Add(this.dgv_cartaoVenda);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.Usuário);
            this.Controls.Add(this.Número);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCadastro);
            this.Name = "FrmCrudCartaoVenda";
            this.Text = "FrmCrudCartaoVenda";
            this.Load += new System.EventHandler(this.FrmCrudCartaoVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cartaoVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cartaoVenda;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label Usuário;
        private System.Windows.Forms.Label Número;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.ComboBox cbx_usuario;
    }
}
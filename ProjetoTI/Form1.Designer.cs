namespace ProjetoTI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.dtpMatricula = new System.Windows.Forms.DateTimePicker();
            this.pbFotoAluno = new System.Windows.Forms.PictureBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.btProcurar = new System.Windows.Forms.Button();
            this.dgAluno = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data da Matrícula";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(192, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(363, 66);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 5;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(192, 129);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 6;
            // 
            // dtpMatricula
            // 
            this.dtpMatricula.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMatricula.Location = new System.Drawing.Point(363, 130);
            this.dtpMatricula.Name = "dtpMatricula";
            this.dtpMatricula.Size = new System.Drawing.Size(100, 20);
            this.dtpMatricula.TabIndex = 7;
            // 
            // pbFotoAluno
            // 
            this.pbFotoAluno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFotoAluno.Location = new System.Drawing.Point(36, 49);
            this.pbFotoAluno.Name = "pbFotoAluno";
            this.pbFotoAluno.Size = new System.Drawing.Size(100, 101);
            this.pbFotoAluno.TabIndex = 8;
            this.pbFotoAluno.TabStop = false;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btCadastrar.Image")));
            this.btCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastrar.Location = new System.Drawing.Point(167, 191);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(95, 23);
            this.btCadastrar.TabIndex = 9;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btLimpar.Image")));
            this.btLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLimpar.Location = new System.Drawing.Point(268, 191);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(93, 23);
            this.btLimpar.TabIndex = 10;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btDeletar.Image")));
            this.btDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDeletar.Location = new System.Drawing.Point(367, 191);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(100, 23);
            this.btDeletar.TabIndex = 11;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // btProcurar
            // 
            this.btProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btProcurar.Image")));
            this.btProcurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btProcurar.Location = new System.Drawing.Point(33, 191);
            this.btProcurar.Name = "btProcurar";
            this.btProcurar.Size = new System.Drawing.Size(103, 23);
            this.btProcurar.TabIndex = 12;
            this.btProcurar.Text = "Procurar";
            this.btProcurar.UseVisualStyleBackColor = true;
            this.btProcurar.Click += new System.EventHandler(this.btProcurar_Click);
            // 
            // dgAluno
            // 
            this.dgAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAluno.Location = new System.Drawing.Point(36, 251);
            this.dgAluno.Name = "dgAluno";
            this.dgAluno.Size = new System.Drawing.Size(427, 218);
            this.dgAluno.TabIndex = 13;
            this.dgAluno.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgAluno_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 495);
            this.Controls.Add(this.dgAluno);
            this.Controls.Add(this.btProcurar);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.pbFotoAluno);
            this.Controls.Add(this.dtpMatricula);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.DateTimePicker dtpMatricula;
        private System.Windows.Forms.PictureBox pbFotoAluno;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btProcurar;
        private System.Windows.Forms.DataGridView dgAluno;
    }
}


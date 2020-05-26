namespace ProjetoAtleta
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.lblIMC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(31, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(180, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(238, 59);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(180, 20);
            this.txtIdade.TabIndex = 1;
            this.txtIdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdade.TextChanged += new System.EventHandler(this.txtIdade_TextChanged);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(31, 112);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(180, 20);
            this.txtAltura.TabIndex = 2;
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(238, 112);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(180, 20);
            this.txtPeso.TabIndex = 3;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(42, 40);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 16);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.BackColor = System.Drawing.Color.Transparent;
            this.lblIdade.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(250, 40);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(47, 16);
            this.lblIdade.TabIndex = 5;
            this.lblIdade.Text = "Idade";
            this.lblIdade.Click += new System.EventHandler(this.lblIdade_Click);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.BackColor = System.Drawing.Color.Transparent;
            this.lblAltura.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(41, 93);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(49, 16);
            this.lblAltura.TabIndex = 6;
            this.lblAltura.Text = "Altura";
            this.lblAltura.Click += new System.EventHandler(this.lblAltura_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.Transparent;
            this.lblPeso.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(250, 93);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(43, 16);
            this.lblPeso.TabIndex = 7;
            this.lblPeso.Text = "Peso";
            this.lblPeso.Click += new System.EventHandler(this.lblPeso_Click);
            // 
            // btnCalculo
            // 
            this.btnCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculo.Location = new System.Drawing.Point(238, 157);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(123, 32);
            this.btnCalculo.TabIndex = 8;
            this.btnCalculo.Text = "Calcular";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(88, 157);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(123, 32);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar Dados";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtIMC
            // 
            this.txtIMC.Enabled = false;
            this.txtIMC.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIMC.Location = new System.Drawing.Point(176, 236);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(90, 34);
            this.txtIMC.TabIndex = 10;
            this.txtIMC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIMC.TextChanged += new System.EventHandler(this.txtIMC_TextChanged);
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.BackColor = System.Drawing.Color.Transparent;
            this.lblIMC.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMC.Location = new System.Drawing.Point(180, 209);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(83, 16);
            this.lblIMC.TabIndex = 11;
            this.lblIMC.Text = "Resultado:";
            this.lblIMC.Click += new System.EventHandler(this.lblIMC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "IMC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(452, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNome);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.Label label1;
    }
}


namespace Estruturas_de_Repetição
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
            this.lbl_inicial = new System.Windows.Forms.Label();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.txt_inicial = new System.Windows.Forms.TextBox();
            this.lbl_final = new System.Windows.Forms.Label();
            this.txt_final = new System.Windows.Forms.TextBox();
            this.lbl_imprimir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_inicial
            // 
            this.lbl_inicial.AutoSize = true;
            this.lbl_inicial.Location = new System.Drawing.Point(164, 134);
            this.lbl_inicial.Name = "lbl_inicial";
            this.lbl_inicial.Size = new System.Drawing.Size(74, 13);
            this.lbl_inicial.TabIndex = 0;
            this.lbl_inicial.Text = "Numero Inicial";
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(290, 216);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(100, 23);
            this.btn_iniciar.TabIndex = 1;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // txt_inicial
            // 
            this.txt_inicial.Location = new System.Drawing.Point(290, 134);
            this.txt_inicial.Name = "txt_inicial";
            this.txt_inicial.Size = new System.Drawing.Size(100, 20);
            this.txt_inicial.TabIndex = 2;
            // 
            // lbl_final
            // 
            this.lbl_final.AutoSize = true;
            this.lbl_final.Location = new System.Drawing.Point(164, 178);
            this.lbl_final.Name = "lbl_final";
            this.lbl_final.Size = new System.Drawing.Size(69, 13);
            this.lbl_final.TabIndex = 3;
            this.lbl_final.Text = "Numero Final";
            // 
            // txt_final
            // 
            this.txt_final.Location = new System.Drawing.Point(290, 175);
            this.txt_final.Name = "txt_final";
            this.txt_final.Size = new System.Drawing.Size(100, 20);
            this.txt_final.TabIndex = 4;
            // 
            // lbl_imprimir
            // 
            this.lbl_imprimir.AutoSize = true;
            this.lbl_imprimir.Location = new System.Drawing.Point(451, 156);
            this.lbl_imprimir.Name = "lbl_imprimir";
            this.lbl_imprimir.Size = new System.Drawing.Size(13, 13);
            this.lbl_imprimir.TabIndex = 5;
            this.lbl_imprimir.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_imprimir);
            this.Controls.Add(this.txt_final);
            this.Controls.Add(this.lbl_final);
            this.Controls.Add(this.txt_inicial);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.lbl_inicial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_inicial;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.TextBox txt_inicial;
        private System.Windows.Forms.Label lbl_final;
        private System.Windows.Forms.TextBox txt_final;
        private System.Windows.Forms.Label lbl_imprimir;
    }
}


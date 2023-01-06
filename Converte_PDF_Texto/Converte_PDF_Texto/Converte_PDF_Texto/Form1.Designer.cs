namespace Converte_PDF_Texto
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
            this.txtCaminoNomePDF = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtArquivoTexto = new System.Windows.Forms.TextBox();
            this.btnConvertePDF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txtCaminoNomePDF
            // 
            this.txtCaminoNomePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminoNomePDF.Location = new System.Drawing.Point(22, 42);
            this.txtCaminoNomePDF.Name = "txtCaminoNomePDF";
            this.txtCaminoNomePDF.Size = new System.Drawing.Size(400, 22);
            this.txtCaminoNomePDF.TabIndex = 0;
            this.txtCaminoNomePDF.Text = "c:\\dados\\Livro_Teste.pdf";
            // 
            // btnProcurar
            // 
            this.btnProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.Location = new System.Drawing.Point(428, 41);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 1;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtArquivoTexto
            // 
            this.txtArquivoTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivoTexto.Location = new System.Drawing.Point(22, 106);
            this.txtArquivoTexto.Multiline = true;
            this.txtArquivoTexto.Name = "txtArquivoTexto";
            this.txtArquivoTexto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArquivoTexto.Size = new System.Drawing.Size(482, 316);
            this.txtArquivoTexto.TabIndex = 2;
            // 
            // btnConvertePDF
            // 
            this.btnConvertePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertePDF.Location = new System.Drawing.Point(22, 70);
            this.btnConvertePDF.Name = "btnConvertePDF";
            this.btnConvertePDF.Size = new System.Drawing.Size(218, 24);
            this.btnConvertePDF.TabIndex = 3;
            this.btnConvertePDF.Text = "Converter para Texto";
            this.btnConvertePDF.UseVisualStyleBackColor = true;
            this.btnConvertePDF.Click += new System.EventHandler(this.btnConvertePDF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informe o caminho e nome do arquivo pDF";
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(271, 70);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(217, 24);
            this.btn_salvar.TabIndex = 5;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(526, 446);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvertePDF);
            this.Controls.Add(this.txtArquivoTexto);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtCaminoNomePDF);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCaminoNomePDF;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtArquivoTexto;
        private System.Windows.Forms.Button btnConvertePDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


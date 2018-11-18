namespace Pokemon
{
    partial class FormLogarTreinador
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnescolha = new System.Windows.Forms.Button();
            this.listBTreinadores = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnescolha);
            this.groupBox1.Controls.Add(this.listBTreinadores);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 353);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha um treinador: ";
            // 
            // btnescolha
            // 
            this.btnescolha.Location = new System.Drawing.Point(6, 21);
            this.btnescolha.Name = "btnescolha";
            this.btnescolha.Size = new System.Drawing.Size(84, 27);
            this.btnescolha.TabIndex = 7;
            this.btnescolha.Text = "Acessar";
            this.btnescolha.UseVisualStyleBackColor = true;
            this.btnescolha.Click += new System.EventHandler(this.btnescolha_Click);
            // 
            // listBTreinadores
            // 
            this.listBTreinadores.FormattingEnabled = true;
            this.listBTreinadores.ItemHeight = 16;
            this.listBTreinadores.Location = new System.Drawing.Point(6, 54);
            this.listBTreinadores.Name = "listBTreinadores";
            this.listBTreinadores.Size = new System.Drawing.Size(326, 292);
            this.listBTreinadores.TabIndex = 5;
            // 
            // FormLogarTreinador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 377);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogarTreinador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogarTreinador";
            this.Load += new System.EventHandler(this.FormLogarTreinador_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBTreinadores;
        private System.Windows.Forms.Button btnescolha;
    }
}
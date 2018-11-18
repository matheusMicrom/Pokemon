namespace Pokemon
{
    partial class FormTreinadorCadastro
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
            this.textBoxNomeTreinador = new System.Windows.Forms.TextBox();
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.radioButtonFemme = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculo = new System.Windows.Forms.RadioButton();
            this.buttonCadstroTreinadr = new System.Windows.Forms.Button();
            this.groupBoxImgTreinador = new System.Windows.Forms.GroupBox();
            this.pictureBoxImgTreinador = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxSexo.SuspendLayout();
            this.groupBoxImgTreinador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgTreinador)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNomeTreinador);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nome do Treinador";
            // 
            // textBoxNomeTreinador
            // 
            this.textBoxNomeTreinador.Location = new System.Drawing.Point(7, 39);
            this.textBoxNomeTreinador.Name = "textBoxNomeTreinador";
            this.textBoxNomeTreinador.Size = new System.Drawing.Size(493, 20);
            this.textBoxNomeTreinador.TabIndex = 0;
            // 
            // groupBoxSexo
            // 
            this.groupBoxSexo.Controls.Add(this.radioButtonFemme);
            this.groupBoxSexo.Controls.Add(this.radioButtonMasculo);
            this.groupBoxSexo.Location = new System.Drawing.Point(19, 184);
            this.groupBoxSexo.Name = "groupBoxSexo";
            this.groupBoxSexo.Size = new System.Drawing.Size(200, 100);
            this.groupBoxSexo.TabIndex = 1;
            this.groupBoxSexo.TabStop = false;
            this.groupBoxSexo.Text = "Selecione o genero";
            // 
            // radioButtonFemme
            // 
            this.radioButtonFemme.AutoSize = true;
            this.radioButtonFemme.Location = new System.Drawing.Point(109, 42);
            this.radioButtonFemme.Name = "radioButtonFemme";
            this.radioButtonFemme.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFemme.TabIndex = 1;
            this.radioButtonFemme.TabStop = true;
            this.radioButtonFemme.Text = "Feminino";
            this.radioButtonFemme.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasculo
            // 
            this.radioButtonMasculo.AutoSize = true;
            this.radioButtonMasculo.Location = new System.Drawing.Point(7, 42);
            this.radioButtonMasculo.Name = "radioButtonMasculo";
            this.radioButtonMasculo.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculo.TabIndex = 0;
            this.radioButtonMasculo.TabStop = true;
            this.radioButtonMasculo.Text = "Masculino";
            this.radioButtonMasculo.UseVisualStyleBackColor = true;
            // 
            // buttonCadstroTreinadr
            // 
            this.buttonCadstroTreinadr.BackColor = System.Drawing.Color.Gray;
            this.buttonCadstroTreinadr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCadstroTreinadr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadstroTreinadr.Location = new System.Drawing.Point(57, 332);
            this.buttonCadstroTreinadr.Name = "buttonCadstroTreinadr";
            this.buttonCadstroTreinadr.Size = new System.Drawing.Size(118, 41);
            this.buttonCadstroTreinadr.TabIndex = 2;
            this.buttonCadstroTreinadr.Text = "Cadastrar";
            this.buttonCadstroTreinadr.UseVisualStyleBackColor = false;
            this.buttonCadstroTreinadr.Click += new System.EventHandler(this.buttonCadstroTreinadr_Click);
            // 
            // groupBoxImgTreinador
            // 
            this.groupBoxImgTreinador.Controls.Add(this.pictureBoxImgTreinador);
            this.groupBoxImgTreinador.Location = new System.Drawing.Point(310, 159);
            this.groupBoxImgTreinador.Name = "groupBoxImgTreinador";
            this.groupBoxImgTreinador.Size = new System.Drawing.Size(208, 239);
            this.groupBoxImgTreinador.TabIndex = 3;
            this.groupBoxImgTreinador.TabStop = false;
            this.groupBoxImgTreinador.Text = "Selecione uma imagem";
            // 
            // pictureBoxImgTreinador
            // 
            this.pictureBoxImgTreinador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxImgTreinador.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxImgTreinador.Name = "pictureBoxImgTreinador";
            this.pictureBoxImgTreinador.Size = new System.Drawing.Size(196, 214);
            this.pictureBoxImgTreinador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImgTreinador.TabIndex = 0;
            this.pictureBoxImgTreinador.TabStop = false;
            this.pictureBoxImgTreinador.Click += new System.EventHandler(this.pictureBoxImgTreinador_Click);
            // 
            // FormTreinadorCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 411);
            this.Controls.Add(this.groupBoxImgTreinador);
            this.Controls.Add(this.buttonCadstroTreinadr);
            this.Controls.Add(this.groupBoxSexo);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTreinadorCadastro";
            this.Text = "FormTreinadorCadastro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSexo.ResumeLayout(false);
            this.groupBoxSexo.PerformLayout();
            this.groupBoxImgTreinador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgTreinador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNomeTreinador;
        private System.Windows.Forms.GroupBox groupBoxSexo;
        private System.Windows.Forms.RadioButton radioButtonFemme;
        private System.Windows.Forms.RadioButton radioButtonMasculo;
        private System.Windows.Forms.Button buttonCadstroTreinadr;
        private System.Windows.Forms.GroupBox groupBoxImgTreinador;
        private System.Windows.Forms.PictureBox pictureBoxImgTreinador;
    }
}
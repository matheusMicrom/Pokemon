namespace Pokemon
{
    partial class FormPokemonsCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPokemonsCadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.txtbImg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbEvolu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudAltura = new System.Windows.Forms.NumericUpDown();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnImg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do pokemon: ";
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(148, 13);
            this.txtbNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(159, 22);
            this.txtbNome.TabIndex = 1;
            // 
            // txtbImg
            // 
            this.txtbImg.Enabled = false;
            this.txtbImg.Location = new System.Drawing.Point(149, 57);
            this.txtbImg.Margin = new System.Windows.Forms.Padding(4);
            this.txtbImg.Name = "txtbImg";
            this.txtbImg.Size = new System.Drawing.Size(159, 22);
            this.txtbImg.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Imagem do pokemon: ";
            // 
            // txtbEvolu
            // 
            this.txtbEvolu.Location = new System.Drawing.Point(149, 101);
            this.txtbEvolu.Margin = new System.Windows.Forms.Padding(4);
            this.txtbEvolu.Name = "txtbEvolu";
            this.txtbEvolu.Size = new System.Drawing.Size(159, 22);
            this.txtbEvolu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome da evolução: ";
            // 
            // nudPeso
            // 
            this.nudPeso.DecimalPlaces = 2;
            this.nudPeso.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPeso.Location = new System.Drawing.Point(149, 189);
            this.nudPeso.Margin = new System.Windows.Forms.Padding(4);
            this.nudPeso.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(160, 22);
            this.nudPeso.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Peso: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Altura: ";
            // 
            // nudAltura
            // 
            this.nudAltura.DecimalPlaces = 2;
            this.nudAltura.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudAltura.Location = new System.Drawing.Point(149, 145);
            this.nudAltura.Margin = new System.Windows.Forms.Padding(4);
            this.nudAltura.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudAltura.Name = "nudAltura";
            this.nudAltura.Size = new System.Drawing.Size(160, 22);
            this.nudAltura.TabIndex = 6;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(14, 237);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(101, 37);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "Cadastrar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(351, 54);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(75, 28);
            this.btnImg.TabIndex = 8;
            this.btnImg.Text = "Procurar";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(315, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 28);
            this.button1.TabIndex = 45;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPokemonsCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 290);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.nudAltura);
            this.Controls.Add(this.nudPeso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbEvolu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbImg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPokemonsCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pokemons";
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.TextBox txtbImg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbEvolu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPeso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudAltura;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Button button1;
    }
}
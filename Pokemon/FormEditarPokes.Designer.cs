namespace Pokemon
{
    partial class FormEditarPokes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarPokes));
            this.label9 = new System.Windows.Forms.Label();
            this.btnImg = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.nudAltura = new System.Windows.Forms.NumericUpDown();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.NudForca = new System.Windows.Forms.NumericUpDown();
            this.nudEfeito = new System.Windows.Forms.NumericUpDown();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbEvolu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbImg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudForca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEfeito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(17, 339);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 36);
            this.label9.TabIndex = 42;
            this.label9.Text = "Atenção: Atributo de força calculado com base: \r\nraiz((altura x peso) + efeito), " +
    "calculo será refeito.\r\n\r\n";
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(314, 87);
            this.btnImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(77, 28);
            this.btnImg.TabIndex = 41;
            this.btnImg.Text = "Procurar";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(19, 380);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(111, 36);
            this.btnEnviar.TabIndex = 39;
            this.btnEnviar.Text = "Salvar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // nudAltura
            // 
            this.nudAltura.DecimalPlaces = 2;
            this.nudAltura.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudAltura.Location = new System.Drawing.Point(90, 182);
            this.nudAltura.Margin = new System.Windows.Forms.Padding(6);
            this.nudAltura.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudAltura.Name = "nudAltura";
            this.nudAltura.Size = new System.Drawing.Size(183, 21);
            this.nudAltura.TabIndex = 34;
            // 
            // nudID
            // 
            this.nudID.Enabled = false;
            this.nudID.Location = new System.Drawing.Point(90, 7);
            this.nudID.Margin = new System.Windows.Forms.Padding(6);
            this.nudID.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(183, 21);
            this.nudID.TabIndex = 35;
            // 
            // NudForca
            // 
            this.NudForca.DecimalPlaces = 2;
            this.NudForca.Enabled = false;
            this.NudForca.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.NudForca.Location = new System.Drawing.Point(90, 308);
            this.NudForca.Margin = new System.Windows.Forms.Padding(6);
            this.NudForca.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.NudForca.Name = "NudForca";
            this.NudForca.Size = new System.Drawing.Size(183, 21);
            this.NudForca.TabIndex = 36;
            // 
            // nudEfeito
            // 
            this.nudEfeito.DecimalPlaces = 2;
            this.nudEfeito.Enabled = false;
            this.nudEfeito.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudEfeito.Location = new System.Drawing.Point(90, 271);
            this.nudEfeito.Margin = new System.Windows.Forms.Padding(6);
            this.nudEfeito.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudEfeito.Name = "nudEfeito";
            this.nudEfeito.Size = new System.Drawing.Size(183, 21);
            this.nudEfeito.TabIndex = 37;
            // 
            // nudPeso
            // 
            this.nudPeso.DecimalPlaces = 2;
            this.nudPeso.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPeso.Location = new System.Drawing.Point(90, 227);
            this.nudPeso.Margin = new System.Windows.Forms.Padding(6);
            this.nudPeso.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(183, 21);
            this.nudPeso.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Altura: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-11, -38);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "ID: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 310);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Força: ";
            // 
            // txtbEvolu
            // 
            this.txtbEvolu.Location = new System.Drawing.Point(90, 136);
            this.txtbEvolu.Margin = new System.Windows.Forms.Padding(6);
            this.txtbEvolu.Name = "txtbEvolu";
            this.txtbEvolu.Size = new System.Drawing.Size(180, 21);
            this.txtbEvolu.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 273);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "Efeito: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Peso: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Evolução: ";
            // 
            // txtbImg
            // 
            this.txtbImg.Enabled = false;
            this.txtbImg.Location = new System.Drawing.Point(90, 91);
            this.txtbImg.Margin = new System.Windows.Forms.Padding(6);
            this.txtbImg.Name = "txtbImg";
            this.txtbImg.Size = new System.Drawing.Size(180, 21);
            this.txtbImg.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Imagem: ";
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(90, 45);
            this.txtbNome.Margin = new System.Windows.Forms.Padding(6);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(180, 21);
            this.txtbNome.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nome: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 15);
            this.label10.TabIndex = 43;
            this.label10.Text = "ID: ";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(277, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 28);
            this.button1.TabIndex = 44;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormEditarPokes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 428);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.nudAltura);
            this.Controls.Add(this.nudID);
            this.Controls.Add(this.NudForca);
            this.Controls.Add(this.nudEfeito);
            this.Controls.Add(this.nudPeso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbEvolu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbImg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEditarPokes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudForca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEfeito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.NumericUpDown nudAltura;
        private System.Windows.Forms.NumericUpDown nudID;
        private System.Windows.Forms.NumericUpDown NudForca;
        private System.Windows.Forms.NumericUpDown nudEfeito;
        private System.Windows.Forms.NumericUpDown nudPeso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbEvolu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbImg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}
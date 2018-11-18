namespace Pokemon
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.btnPokemons = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bntTreinador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPokemons
            // 
            this.btnPokemons.Location = new System.Drawing.Point(13, 87);
            this.btnPokemons.Margin = new System.Windows.Forms.Padding(4);
            this.btnPokemons.Name = "btnPokemons";
            this.btnPokemons.Size = new System.Drawing.Size(153, 62);
            this.btnPokemons.TabIndex = 0;
            this.btnPokemons.Text = "Treinadores";
            this.btnPokemons.UseVisualStyleBackColor = true;
            this.btnPokemons.Click += new System.EventHandler(this.btnPokemons_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pokemons";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPokemons_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 157);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 62);
            this.button2.TabIndex = 0;
            this.button2.Text = "Relacionar Pokemon/Treinadores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bntTreinador
            // 
            this.bntTreinador.Location = new System.Drawing.Point(173, 12);
            this.bntTreinador.Name = "bntTreinador";
            this.bntTreinador.Size = new System.Drawing.Size(153, 62);
            this.bntTreinador.TabIndex = 1;
            this.bntTreinador.Text = "Logar c/ Treinador";
            this.bntTreinador.UseVisualStyleBackColor = true;
            this.bntTreinador.Click += new System.EventHandler(this.bntTreinador_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 277);
            this.Controls.Add(this.bntTreinador);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPokemons);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPokemons;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bntTreinador;
    }
}


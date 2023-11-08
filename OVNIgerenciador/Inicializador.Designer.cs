namespace OVNIgerenciador
{
    partial class Inicializador
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblPlanetaorigen = new System.Windows.Forms.Label();
            this.nudAbduzidos = new System.Windows.Forms.NumericUpDown();
            this.nudTripulantes = new System.Windows.Forms.NumericUpDown();
            this.cmbPlaneta = new System.Windows.Forms.ComboBox();
            this.btnInicializar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAbduzidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTripulantes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(207, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(212, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gerenciador de OVNI";
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Location = new System.Drawing.Point(208, 46);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(82, 13);
            this.lblAbduzidos.TabIndex = 1;
            this.lblAbduzidos.Text = "Max.Abduzidos:";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(208, 73);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(85, 13);
            this.lblTripulantes.TabIndex = 2;
            this.lblTripulantes.Text = "Max.Tripulantes:";
            this.lblTripulantes.Click += new System.EventHandler(this.lblTripulantes_Click);
            // 
            // lblPlanetaorigen
            // 
            this.lblPlanetaorigen.AutoSize = true;
            this.lblPlanetaorigen.Location = new System.Drawing.Point(208, 96);
            this.lblPlanetaorigen.Name = "lblPlanetaorigen";
            this.lblPlanetaorigen.Size = new System.Drawing.Size(97, 13);
            this.lblPlanetaorigen.TabIndex = 3;
            this.lblPlanetaorigen.Text = "Planeta de Origem:";
            // 
            // nudAbduzidos
            // 
            this.nudAbduzidos.Location = new System.Drawing.Point(311, 39);
            this.nudAbduzidos.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudAbduzidos.Name = "nudAbduzidos";
            this.nudAbduzidos.Size = new System.Drawing.Size(105, 20);
            this.nudAbduzidos.TabIndex = 4;
            // 
            // nudTripulantes
            // 
            this.nudTripulantes.Location = new System.Drawing.Point(311, 62);
            this.nudTripulantes.Name = "nudTripulantes";
            this.nudTripulantes.Size = new System.Drawing.Size(105, 20);
            this.nudTripulantes.TabIndex = 5;
            // 
            // cmbPlaneta
            // 
            this.cmbPlaneta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlaneta.FormattingEnabled = true;
            this.cmbPlaneta.Location = new System.Drawing.Point(311, 88);
            this.cmbPlaneta.Name = "cmbPlaneta";
            this.cmbPlaneta.Size = new System.Drawing.Size(105, 21);
            this.cmbPlaneta.TabIndex = 6;
            // 
            // btnInicializar
            // 
            this.btnInicializar.Location = new System.Drawing.Point(211, 115);
            this.btnInicializar.Name = "btnInicializar";
            this.btnInicializar.Size = new System.Drawing.Size(205, 44);
            this.btnInicializar.TabIndex = 7;
            this.btnInicializar.Text = "INICIAR";
            this.btnInicializar.UseVisualStyleBackColor = true;
            this.btnInicializar.Click += new System.EventHandler(this.btnInicializar_Click);
            // 
            // Inicializador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 195);
            this.Controls.Add(this.btnInicializar);
            this.Controls.Add(this.cmbPlaneta);
            this.Controls.Add(this.nudTripulantes);
            this.Controls.Add(this.nudAbduzidos);
            this.Controls.Add(this.lblPlanetaorigen);
            this.Controls.Add(this.lblTripulantes);
            this.Controls.Add(this.lblAbduzidos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Inicializador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicializador";
            this.Load += new System.EventHandler(this.Inicializador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAbduzidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTripulantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblPlanetaorigen;
        private System.Windows.Forms.NumericUpDown nudAbduzidos;
        private System.Windows.Forms.NumericUpDown nudTripulantes;
        private System.Windows.Forms.ComboBox cmbPlaneta;
        private System.Windows.Forms.Button btnInicializar;
    }
}
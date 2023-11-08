namespace OVNIgerenciador
{
    partial class Painel
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
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnAddtripulante = new System.Windows.Forms.Button();
            this.btnRemovertripulantes = new System.Windows.Forms.Button();
            this.btnAbduzir = new System.Windows.Forms.Button();
            this.btnDesabduzir = new System.Windows.Forms.Button();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.btnMudar = new System.Windows.Forms.Button();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.grbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.lblPlaneta);
            this.grbDados.Controls.Add(this.lblTripulantes);
            this.grbDados.Controls.Add(this.lblAbduzidos);
            this.grbDados.Controls.Add(this.lblSituacao);
            this.grbDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDados.Location = new System.Drawing.Point(13, 13);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(264, 161);
            this.grbDados.TabIndex = 0;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(10, 25);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(76, 20);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Situação:";
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbduzidos.Location = new System.Drawing.Point(10, 57);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(88, 20);
            this.lblAbduzidos.TabIndex = 1;
            this.lblAbduzidos.Text = "Abduzidos:";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripulantes.Location = new System.Drawing.Point(10, 90);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(91, 20);
            this.lblTripulantes.TabIndex = 2;
            this.lblTripulantes.Text = "Tripulantes:";
            // 
            // btnLigar
            // 
            this.btnLigar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLigar.Location = new System.Drawing.Point(12, 180);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(265, 39);
            this.btnLigar.TabIndex = 3;
            this.btnLigar.Text = "LIGAR";
            this.btnLigar.UseVisualStyleBackColor = true;
            // 
            // btnDesligar
            // 
            this.btnDesligar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesligar.Location = new System.Drawing.Point(13, 226);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(264, 43);
            this.btnDesligar.TabIndex = 4;
            this.btnDesligar.Text = "DESLIGAR";
            this.btnDesligar.UseVisualStyleBackColor = true;
            // 
            // btnAddtripulante
            // 
            this.btnAddtripulante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtripulante.Location = new System.Drawing.Point(283, 27);
            this.btnAddtripulante.Name = "btnAddtripulante";
            this.btnAddtripulante.Size = new System.Drawing.Size(204, 31);
            this.btnAddtripulante.TabIndex = 5;
            this.btnAddtripulante.Text = "Adicionar Tripulante";
            this.btnAddtripulante.UseVisualStyleBackColor = true;
            // 
            // btnRemovertripulantes
            // 
            this.btnRemovertripulantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovertripulantes.Location = new System.Drawing.Point(283, 64);
            this.btnRemovertripulantes.Name = "btnRemovertripulantes";
            this.btnRemovertripulantes.Size = new System.Drawing.Size(204, 33);
            this.btnRemovertripulantes.TabIndex = 6;
            this.btnRemovertripulantes.Text = "Remover Tripulantes";
            this.btnRemovertripulantes.UseVisualStyleBackColor = true;
            // 
            // btnAbduzir
            // 
            this.btnAbduzir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbduzir.Location = new System.Drawing.Point(283, 103);
            this.btnAbduzir.Name = "btnAbduzir";
            this.btnAbduzir.Size = new System.Drawing.Size(204, 27);
            this.btnAbduzir.TabIndex = 7;
            this.btnAbduzir.Text = "Abduzir";
            this.btnAbduzir.UseVisualStyleBackColor = true;
            // 
            // btnDesabduzir
            // 
            this.btnDesabduzir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesabduzir.Location = new System.Drawing.Point(283, 138);
            this.btnDesabduzir.Name = "btnDesabduzir";
            this.btnDesabduzir.Size = new System.Drawing.Size(204, 29);
            this.btnDesabduzir.TabIndex = 8;
            this.btnDesabduzir.Text = "Desabduzir";
            this.btnDesabduzir.UseVisualStyleBackColor = true;
            // 
            // btnRetornar
            // 
            this.btnRetornar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetornar.Location = new System.Drawing.Point(283, 173);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(204, 31);
            this.btnRetornar.TabIndex = 9;
            this.btnRetornar.Text = "Retornar a Origem";
            this.btnRetornar.UseVisualStyleBackColor = true;
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(283, 217);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(107, 21);
            this.cmbPlanetas.TabIndex = 10;
            // 
            // btnMudar
            // 
            this.btnMudar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMudar.Location = new System.Drawing.Point(396, 210);
            this.btnMudar.Name = "btnMudar";
            this.btnMudar.Size = new System.Drawing.Size(91, 31);
            this.btnMudar.TabIndex = 11;
            this.btnMudar.Text = "Mudar";
            this.btnMudar.UseVisualStyleBackColor = true;
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaneta.Location = new System.Drawing.Point(10, 125);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(67, 20);
            this.lblPlaneta.TabIndex = 3;
            this.lblPlaneta.Text = "Planeta:";
            // 
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 305);
            this.Controls.Add(this.btnMudar);
            this.Controls.Add(this.cmbPlanetas);
            this.Controls.Add(this.btnAddtripulante);
            this.Controls.Add(this.btnRemovertripulantes);
            this.Controls.Add(this.btnAbduzir);
            this.Controls.Add(this.btnDesabduzir);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.grbDados);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnLigar);
            this.Name = "Painel";
            this.Text = "Painel";
            this.Load += new System.EventHandler(this.Painel_Load);
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button btnAddtripulante;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnDesabduzir;
        private System.Windows.Forms.Button btnAbduzir;
        private System.Windows.Forms.Button btnRemovertripulantes;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.Button btnMudar;
        private System.Windows.Forms.Label lblPlaneta;
    }
}
﻿namespace MatriculaAluno
{
    partial class FormMatriculaAluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnoUltimoAniversario = new System.Windows.Forms.TextBox();
            this.btnIdentificarCategoria = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(65, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(219, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Ano nascimento:";
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(116, 51);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtAnoNascimento.TabIndex = 3;
            this.txtAnoNascimento.Validating += new System.ComponentModel.CancelEventHandler(this.txtAnoUltimoAniversario_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Ano último aniversário:";
            // 
            // txtAnoUltimoAniversario
            // 
            this.txtAnoUltimoAniversario.Location = new System.Drawing.Point(358, 51);
            this.txtAnoUltimoAniversario.Name = "txtAnoUltimoAniversario";
            this.txtAnoUltimoAniversario.Size = new System.Drawing.Size(100, 20);
            this.txtAnoUltimoAniversario.TabIndex = 5;
            this.txtAnoUltimoAniversario.Enter += new System.EventHandler(this.txtAnoUltimoAniversario_Enter);
            // 
            // btnIdentificarCategoria
            // 
            this.btnIdentificarCategoria.Location = new System.Drawing.Point(27, 90);
            this.btnIdentificarCategoria.Name = "btnIdentificarCategoria";
            this.btnIdentificarCategoria.Size = new System.Drawing.Size(130, 23);
            this.btnIdentificarCategoria.TabIndex = 6;
            this.btnIdentificarCategoria.Text = "Identificar Categoria";
            this.btnIdentificarCategoria.UseVisualStyleBackColor = true;
            this.btnIdentificarCategoria.Click += new System.EventHandler(this.btnIdentificarCategoria_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.BackColor = System.Drawing.SystemColors.Info;
            this.lblCategoria.Location = new System.Drawing.Point(242, 93);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(168, 20);
            this.lblCategoria.TabIndex = 8;
            // 
            // FormMatriculaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 135);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIdentificarCategoria);
            this.Controls.Add(this.txtAnoUltimoAniversario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "FormMatriculaAluno";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnoNascimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnoUltimoAniversario;
        private System.Windows.Forms.Button btnIdentificarCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lblCategoria;
    }
}


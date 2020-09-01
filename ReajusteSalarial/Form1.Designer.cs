namespace ReajusteSalarial
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.gbxCategoria = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gbxTurno = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.txtSituacaoEstagiario = new System.Windows.Forms.TextBox();
            this.lbxResumo = new System.Windows.Forms.ListBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbxCategoria.SuspendLayout();
            this.gbxTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salário Mínimo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horas Trabalhadas:";
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.Location = new System.Drawing.Point(131, 31);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioMinimo.TabIndex = 2;
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(131, 61);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(100, 20);
            this.txtHorasTrabalhadas.TabIndex = 3;
            // 
            // gbxCategoria
            // 
            this.gbxCategoria.Controls.Add(this.radioButton2);
            this.gbxCategoria.Controls.Add(this.radioButton1);
            this.gbxCategoria.Location = new System.Drawing.Point(31, 99);
            this.gbxCategoria.Name = "gbxCategoria";
            this.gbxCategoria.Size = new System.Drawing.Size(200, 40);
            this.gbxCategoria.TabIndex = 4;
            this.gbxCategoria.TabStop = false;
            this.gbxCategoria.Text = "Categoria";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(100, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Veterano";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Calouro";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // gbxTurno
            // 
            this.gbxTurno.Controls.Add(this.radioButton5);
            this.gbxTurno.Controls.Add(this.radioButton4);
            this.gbxTurno.Controls.Add(this.radioButton3);
            this.gbxTurno.Location = new System.Drawing.Point(256, 31);
            this.gbxTurno.Name = "gbxTurno";
            this.gbxTurno.Size = new System.Drawing.Size(121, 100);
            this.gbxTurno.TabIndex = 5;
            this.gbxTurno.TabStop = false;
            this.gbxTurno.Text = "Turno";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(16, 70);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(63, 17);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Noturno";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(16, 46);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(75, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Vespertino";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(16, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(66, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Matutino";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // txtSituacaoEstagiario
            // 
            this.txtSituacaoEstagiario.BackColor = System.Drawing.SystemColors.Info;
            this.txtSituacaoEstagiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacaoEstagiario.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtSituacaoEstagiario.Location = new System.Drawing.Point(31, 246);
            this.txtSituacaoEstagiario.Name = "txtSituacaoEstagiario";
            this.txtSituacaoEstagiario.Size = new System.Drawing.Size(224, 20);
            this.txtSituacaoEstagiario.TabIndex = 6;
            this.txtSituacaoEstagiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbxResumo
            // 
            this.lbxResumo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxResumo.FormattingEnabled = true;
            this.lbxResumo.ItemHeight = 14;
            this.lbxResumo.Location = new System.Drawing.Point(31, 145);
            this.lbxResumo.MultiColumn = true;
            this.lbxResumo.Name = "lbxResumo";
            this.lbxResumo.Size = new System.Drawing.Size(346, 88);
            this.lbxResumo.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(272, 244);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(105, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Ajuda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 272);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbxResumo);
            this.Controls.Add(this.txtSituacaoEstagiario);
            this.Controls.Add(this.gbxTurno);
            this.Controls.Add(this.gbxCategoria);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.txtSalarioMinimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cálculo de Salário";
            this.gbxCategoria.ResumeLayout(false);
            this.gbxCategoria.PerformLayout();
            this.gbxTurno.ResumeLayout(false);
            this.gbxTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalarioMinimo;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.GroupBox gbxCategoria;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox gbxTurno;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox txtSituacaoEstagiario;
        private System.Windows.Forms.ListBox lbxResumo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


namespace csharpexercs2023
{
    partial class frmposto
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
            this.lblcod = new System.Windows.Forms.Label();
            this.lblquant = new System.Windows.Forms.Label();
            this.lblvalorp = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtquant = new System.Windows.Forms.TextBox();
            this.txtvalorp = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Location = new System.Drawing.Point(126, 57);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(193, 13);
            this.lblcod.TabIndex = 0;
            this.lblcod.Text = "Escreva o tipo de combustível(A ou G):";
            // 
            // lblquant
            // 
            this.lblquant.AutoSize = true;
            this.lblquant.Location = new System.Drawing.Point(130, 89);
            this.lblquant.Name = "lblquant";
            this.lblquant.Size = new System.Drawing.Size(148, 13);
            this.lblquant.TabIndex = 1;
            this.lblquant.Text = "Escreva a quantidade de litro:";
            // 
            // lblvalorp
            // 
            this.lblvalorp.AutoSize = true;
            this.lblvalorp.Location = new System.Drawing.Point(130, 120);
            this.lblvalorp.Name = "lblvalorp";
            this.lblvalorp.Size = new System.Drawing.Size(94, 13);
            this.lblvalorp.TabIndex = 2;
            this.lblvalorp.Text = "O valor pago será:";
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(380, 53);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(137, 20);
            this.txtcod.TabIndex = 3;
            // 
            // txtquant
            // 
            this.txtquant.Location = new System.Drawing.Point(383, 91);
            this.txtquant.Name = "txtquant";
            this.txtquant.Size = new System.Drawing.Size(133, 20);
            this.txtquant.TabIndex = 4;
            // 
            // txtvalorp
            // 
            this.txtvalorp.Location = new System.Drawing.Point(380, 129);
            this.txtvalorp.Name = "txtvalorp";
            this.txtvalorp.Size = new System.Drawing.Size(136, 20);
            this.txtvalorp.TabIndex = 5;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(59, 229);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(112, 46);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(265, 229);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(117, 46);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(483, 229);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(117, 46);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmposto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtvalorp);
            this.Controls.Add(this.txtquant);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.lblvalorp);
            this.Controls.Add(this.lblquant);
            this.Controls.Add(this.lblcod);
            this.Name = "frmposto";
            this.Text = "Posto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.Label lblquant;
        private System.Windows.Forms.Label lblvalorp;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtquant;
        private System.Windows.Forms.TextBox txtvalorp;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}
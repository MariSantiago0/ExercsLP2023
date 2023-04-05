namespace csharpexercs2023
{
    partial class frmvoto
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
            this.lblvoto = new System.Windows.Forms.Label();
            this.lblvencedor = new System.Windows.Forms.Label();
            this.lblvt = new System.Windows.Forms.Label();
            this.lblporcent = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtvoto = new System.Windows.Forms.TextBox();
            this.txtvencedor = new System.Windows.Forms.TextBox();
            this.txtvt = new System.Windows.Forms.TextBox();
            this.txtporcent = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblvoto
            // 
            this.lblvoto.AutoSize = true;
            this.lblvoto.Location = new System.Drawing.Point(17, 20);
            this.lblvoto.Name = "lblvoto";
            this.lblvoto.Size = new System.Drawing.Size(174, 13);
            this.lblvoto.TabIndex = 0;
            this.lblvoto.Text = " Digite qual candidato deseja votar:";
            // 
            // lblvencedor
            // 
            this.lblvencedor.AutoSize = true;
            this.lblvencedor.Location = new System.Drawing.Point(17, 62);
            this.lblvencedor.Name = "lblvencedor";
            this.lblvencedor.Size = new System.Drawing.Size(130, 13);
            this.lblvencedor.TabIndex = 1;
            this.lblvencedor.Text = "O(A) candidato(a) eleito é:";
            // 
            // lblvt
            // 
            this.lblvt.AutoSize = true;
            this.lblvt.Location = new System.Drawing.Point(22, 96);
            this.lblvt.Name = "lblvt";
            this.lblvt.Size = new System.Drawing.Size(201, 13);
            this.lblvt.TabIndex = 2;
            this.lblvt.Text = "Os votos totais do(a) candidato(a) foram: ";
            // 
            // lblporcent
            // 
            this.lblporcent.AutoSize = true;
            this.lblporcent.Location = new System.Drawing.Point(22, 134);
            this.lblporcent.Name = "lblporcent";
            this.lblporcent.Size = new System.Drawing.Size(160, 13);
            this.lblporcent.TabIndex = 3;
            this.lblporcent.Text = "A porcentagem dos votos foram:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(23, 169);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(109, 13);
            this.lbltotal.TabIndex = 4;
            this.lbltotal.Text = "Os votos totais foram:";
            // 
            // txtvoto
            // 
            this.txtvoto.Location = new System.Drawing.Point(253, 18);
            this.txtvoto.Name = "txtvoto";
            this.txtvoto.Size = new System.Drawing.Size(190, 20);
            this.txtvoto.TabIndex = 5;
            // 
            // txtvencedor
            // 
            this.txtvencedor.Location = new System.Drawing.Point(255, 57);
            this.txtvencedor.Name = "txtvencedor";
            this.txtvencedor.Size = new System.Drawing.Size(187, 20);
            this.txtvencedor.TabIndex = 6;
            // 
            // txtvt
            // 
            this.txtvt.Location = new System.Drawing.Point(255, 96);
            this.txtvt.Name = "txtvt";
            this.txtvt.Size = new System.Drawing.Size(187, 20);
            this.txtvt.TabIndex = 7;
            // 
            // txtporcent
            // 
            this.txtporcent.Location = new System.Drawing.Point(255, 137);
            this.txtporcent.Name = "txtporcent";
            this.txtporcent.Size = new System.Drawing.Size(187, 20);
            this.txtporcent.TabIndex = 8;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(255, 174);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(187, 20);
            this.txttotal.TabIndex = 9;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(27, 249);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(131, 48);
            this.btncalcular.TabIndex = 10;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(223, 251);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(115, 45);
            this.btnlimpar.TabIndex = 11;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(402, 255);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(106, 40);
            this.btnvoltar.TabIndex = 12;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmvoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 330);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtporcent);
            this.Controls.Add(this.txtvt);
            this.Controls.Add(this.txtvencedor);
            this.Controls.Add(this.txtvoto);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblporcent);
            this.Controls.Add(this.lblvt);
            this.Controls.Add(this.lblvencedor);
            this.Controls.Add(this.lblvoto);
            this.Name = "frmvoto";
            this.Text = "Voto";
            this.Load += new System.EventHandler(this.frmvoto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvoto;
        private System.Windows.Forms.Label lblvencedor;
        private System.Windows.Forms.Label lblvt;
        private System.Windows.Forms.Label lblporcent;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtvoto;
        private System.Windows.Forms.TextBox txtvencedor;
        private System.Windows.Forms.TextBox txtvt;
        private System.Windows.Forms.TextBox txtporcent;
        private System.Windows.Forms.TextBox txttotal;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}
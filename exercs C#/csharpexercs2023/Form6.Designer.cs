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
            this.btnvotar = new System.Windows.Forms.Button();
            this.btnencerrar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblvoto
            // 
            this.lblvoto.AutoSize = true;
            this.lblvoto.Location = new System.Drawing.Point(14, 25);
            this.lblvoto.Name = "lblvoto";
            this.lblvoto.Size = new System.Drawing.Size(205, 13);
            this.lblvoto.TabIndex = 0;
            this.lblvoto.Text = "Digite as siglas do seu candidato(js, mj, jt):";
            // 
            // lblvencedor
            // 
            this.lblvencedor.AutoSize = true;
            this.lblvencedor.Location = new System.Drawing.Point(15, 64);
            this.lblvencedor.Name = "lblvencedor";
            this.lblvencedor.Size = new System.Drawing.Size(130, 13);
            this.lblvencedor.TabIndex = 1;
            this.lblvencedor.Text = "O(A) candidato(a) eleito é:";
            // 
            // lblvt
            // 
            this.lblvt.AutoSize = true;
            this.lblvt.Location = new System.Drawing.Point(18, 98);
            this.lblvt.Name = "lblvt";
            this.lblvt.Size = new System.Drawing.Size(198, 13);
            this.lblvt.TabIndex = 2;
            this.lblvt.Text = "Os votos totais do(a) candidato(a) foram:";
            // 
            // lblporcent
            // 
            this.lblporcent.AutoSize = true;
            this.lblporcent.Location = new System.Drawing.Point(20, 133);
            this.lblporcent.Name = "lblporcent";
            this.lblporcent.Size = new System.Drawing.Size(160, 13);
            this.lblporcent.TabIndex = 3;
            this.lblporcent.Text = "A porcentagem dos votos foram:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(17, 164);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(109, 13);
            this.lbltotal.TabIndex = 4;
            this.lbltotal.Text = "Os votos totais foram:";
            // 
            // txtvoto
            // 
            this.txtvoto.Location = new System.Drawing.Point(286, 22);
            this.txtvoto.Name = "txtvoto";
            this.txtvoto.Size = new System.Drawing.Size(135, 20);
            this.txtvoto.TabIndex = 5;
            // 
            // txtvencedor
            // 
            this.txtvencedor.Location = new System.Drawing.Point(286, 56);
            this.txtvencedor.Name = "txtvencedor";
            this.txtvencedor.Size = new System.Drawing.Size(135, 20);
            this.txtvencedor.TabIndex = 6;
            // 
            // txtvt
            // 
            this.txtvt.Location = new System.Drawing.Point(286, 95);
            this.txtvt.Name = "txtvt";
            this.txtvt.Size = new System.Drawing.Size(134, 20);
            this.txtvt.TabIndex = 7;
            // 
            // txtporcent
            // 
            this.txtporcent.Location = new System.Drawing.Point(286, 129);
            this.txtporcent.Name = "txtporcent";
            this.txtporcent.Size = new System.Drawing.Size(134, 20);
            this.txtporcent.TabIndex = 8;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(285, 171);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(135, 20);
            this.txttotal.TabIndex = 9;
            // 
            // btnvotar
            // 
            this.btnvotar.Location = new System.Drawing.Point(21, 230);
            this.btnvotar.Name = "btnvotar";
            this.btnvotar.Size = new System.Drawing.Size(123, 43);
            this.btnvotar.TabIndex = 10;
            this.btnvotar.Text = "Votar";
            this.btnvotar.UseVisualStyleBackColor = true;
            this.btnvotar.Click += new System.EventHandler(this.btnvotar_Click);
            // 
            // btnencerrar
            // 
            this.btnencerrar.Location = new System.Drawing.Point(179, 230);
            this.btnencerrar.Name = "btnencerrar";
            this.btnencerrar.Size = new System.Drawing.Size(116, 42);
            this.btnencerrar.TabIndex = 11;
            this.btnencerrar.Text = "Encerrar";
            this.btnencerrar.UseVisualStyleBackColor = true;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(363, 230);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(125, 43);
            this.btnlimpar.TabIndex = 12;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(542, 229);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(129, 44);
            this.btnvoltar.TabIndex = 13;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            // 
            // frmvoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnencerrar);
            this.Controls.Add(this.btnvotar);
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
        private System.Windows.Forms.Button btnvotar;
        private System.Windows.Forms.Button btnencerrar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}
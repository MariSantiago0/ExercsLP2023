namespace csharpexercs2023
{
    partial class frmtabwhile
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
            this.lblnum = new System.Windows.Forms.Label();
            this.lbltabwhileresult = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txttabwhileresult = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(26, 68);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(139, 13);
            this.lblnum.TabIndex = 0;
            this.lblnum.Text = "Insira o número da tabuada:";
            // 
            // lbltabwhileresult
            // 
            this.lbltabwhileresult.AutoSize = true;
            this.lbltabwhileresult.Location = new System.Drawing.Point(27, 106);
            this.lbltabwhileresult.Name = "lbltabwhileresult";
            this.lbltabwhileresult.Size = new System.Drawing.Size(99, 13);
            this.lbltabwhileresult.TabIndex = 1;
            this.lbltabwhileresult.Text = "Tabuada completa:";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(225, 65);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(129, 20);
            this.txtnum.TabIndex = 2;
            // 
            // txttabwhileresult
            // 
            this.txttabwhileresult.Location = new System.Drawing.Point(225, 105);
            this.txttabwhileresult.Name = "txttabwhileresult";
            this.txttabwhileresult.Size = new System.Drawing.Size(412, 20);
            this.txttabwhileresult.TabIndex = 3;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(33, 212);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(111, 40);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(262, 212);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(119, 40);
            this.btnlimpar.TabIndex = 5;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(498, 212);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(116, 40);
            this.btnvoltar.TabIndex = 6;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmtabwhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txttabwhileresult);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lbltabwhileresult);
            this.Controls.Add(this.lblnum);
            this.Name = "frmtabwhile";
            this.Text = "Tabuada while";
            this.Load += new System.EventHandler(this.frmtabwhile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lbltabwhileresult;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txttabwhileresult;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}
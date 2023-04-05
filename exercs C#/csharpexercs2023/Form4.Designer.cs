namespace csharpexercs2023
{
    partial class frmtabdowhile
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
            this.lbltabdowhileresult = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txttabdowhileresult = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(59, 80);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(139, 13);
            this.lblnum.TabIndex = 0;
            this.lblnum.Text = "Insira o número da tabuada:";
            // 
            // lbltabdowhileresult
            // 
            this.lbltabdowhileresult.AutoSize = true;
            this.lbltabdowhileresult.Location = new System.Drawing.Point(59, 121);
            this.lbltabdowhileresult.Name = "lbltabdowhileresult";
            this.lbltabdowhileresult.Size = new System.Drawing.Size(99, 13);
            this.lbltabdowhileresult.TabIndex = 1;
            this.lbltabdowhileresult.Text = "Tabuada completa:";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(236, 78);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(134, 20);
            this.txtnum.TabIndex = 2;
            // 
            // txttabdowhileresult
            // 
            this.txttabdowhileresult.Location = new System.Drawing.Point(236, 121);
            this.txttabdowhileresult.Name = "txttabdowhileresult";
            this.txttabdowhileresult.Size = new System.Drawing.Size(324, 20);
            this.txttabdowhileresult.TabIndex = 3;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(46, 227);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(112, 43);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(257, 227);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(113, 43);
            this.btnlimpar.TabIndex = 5;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(470, 227);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(116, 43);
            this.btnvoltar.TabIndex = 6;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmtabdowhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txttabdowhileresult);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lbltabdowhileresult);
            this.Controls.Add(this.lblnum);
            this.Name = "frmtabdowhile";
            this.Text = "Tabuada do...while";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lbltabdowhileresult;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txttabdowhileresult;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}
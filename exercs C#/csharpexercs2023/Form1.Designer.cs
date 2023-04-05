namespace csharpexercs2023
{
    partial class frmmenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaWhileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaDowhileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaForToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.votoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.postoToolStripMenuItem,
            this.tabuadaWhileToolStripMenuItem,
            this.tabuadaDowhileToolStripMenuItem,
            this.tabuadaForToolStripMenuItem,
            this.votoToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programasToolStripMenuItem.Text = "Programas";
            // 
            // postoToolStripMenuItem
            // 
            this.postoToolStripMenuItem.Name = "postoToolStripMenuItem";
            this.postoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.postoToolStripMenuItem.Text = "Posto";
            this.postoToolStripMenuItem.Click += new System.EventHandler(this.postoToolStripMenuItem_Click);
            // 
            // tabuadaWhileToolStripMenuItem
            // 
            this.tabuadaWhileToolStripMenuItem.Name = "tabuadaWhileToolStripMenuItem";
            this.tabuadaWhileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tabuadaWhileToolStripMenuItem.Text = "Tabuada while";
            this.tabuadaWhileToolStripMenuItem.Click += new System.EventHandler(this.tabuadaWhileToolStripMenuItem_Click);
            // 
            // tabuadaDowhileToolStripMenuItem
            // 
            this.tabuadaDowhileToolStripMenuItem.Name = "tabuadaDowhileToolStripMenuItem";
            this.tabuadaDowhileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tabuadaDowhileToolStripMenuItem.Text = "Tabuada do...while";
            this.tabuadaDowhileToolStripMenuItem.Click += new System.EventHandler(this.tabuadaDowhileToolStripMenuItem_Click);
            // 
            // tabuadaForToolStripMenuItem
            // 
            this.tabuadaForToolStripMenuItem.Name = "tabuadaForToolStripMenuItem";
            this.tabuadaForToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tabuadaForToolStripMenuItem.Text = "Tabuada for";
            this.tabuadaForToolStripMenuItem.Click += new System.EventHandler(this.tabuadaForToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // votoToolStripMenuItem
            // 
            this.votoToolStripMenuItem.Name = "votoToolStripMenuItem";
            this.votoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.votoToolStripMenuItem.Text = "Voto";
            this.votoToolStripMenuItem.Click += new System.EventHandler(this.votoToolStripMenuItem_Click_2);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmenu";
            this.Text = "Menu";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabuadaWhileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabuadaDowhileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabuadaForToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem votoToolStripMenuItem;
    }
}


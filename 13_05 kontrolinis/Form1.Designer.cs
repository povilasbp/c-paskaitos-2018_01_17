namespace _13_05_kontrolinis
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.failasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atidarytiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skaiciavimaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baigtiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBoxAtsakymas = new System.Windows.Forms.GroupBox();
            this.textBoxAtsakymas1 = new System.Windows.Forms.TextBox();
            this.textBoxAtsakymas2 = new System.Windows.Forms.TextBox();
            this.labelAtsakymas1 = new System.Windows.Forms.Label();
            this.labelAtsakymas2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBoxAtsakymas.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.failasToolStripMenuItem,
            this.skaiciavimaiToolStripMenuItem,
            this.baigtiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(471, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // failasToolStripMenuItem
            // 
            this.failasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atidarytiToolStripMenuItem});
            this.failasToolStripMenuItem.Name = "failasToolStripMenuItem";
            this.failasToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.failasToolStripMenuItem.Text = "Failas";
            // 
            // atidarytiToolStripMenuItem
            // 
            this.atidarytiToolStripMenuItem.Name = "atidarytiToolStripMenuItem";
            this.atidarytiToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.atidarytiToolStripMenuItem.Text = "Atidaryti";
            this.atidarytiToolStripMenuItem.Click += new System.EventHandler(this.atidarytiToolStripMenuItem_Click);
            // 
            // skaiciavimaiToolStripMenuItem
            // 
            this.skaiciavimaiToolStripMenuItem.Enabled = false;
            this.skaiciavimaiToolStripMenuItem.Name = "skaiciavimaiToolStripMenuItem";
            this.skaiciavimaiToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.skaiciavimaiToolStripMenuItem.Text = "Skaiciavimai";
            this.skaiciavimaiToolStripMenuItem.Click += new System.EventHandler(this.skaiciavimaiToolStripMenuItem_Click);
            // 
            // baigtiToolStripMenuItem
            // 
            this.baigtiToolStripMenuItem.Name = "baigtiToolStripMenuItem";
            this.baigtiToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.baigtiToolStripMenuItem.Text = "Baigti";
            this.baigtiToolStripMenuItem.Click += new System.EventHandler(this.baigtiToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(471, 290);
            this.tabControl1.TabIndex = 1;
            // 
            // groupBoxAtsakymas
            // 
            this.groupBoxAtsakymas.Controls.Add(this.labelAtsakymas2);
            this.groupBoxAtsakymas.Controls.Add(this.labelAtsakymas1);
            this.groupBoxAtsakymas.Controls.Add(this.textBoxAtsakymas2);
            this.groupBoxAtsakymas.Controls.Add(this.textBoxAtsakymas1);
            this.groupBoxAtsakymas.Location = new System.Drawing.Point(0, 205);
            this.groupBoxAtsakymas.Name = "groupBoxAtsakymas";
            this.groupBoxAtsakymas.Size = new System.Drawing.Size(437, 149);
            this.groupBoxAtsakymas.TabIndex = 2;
            this.groupBoxAtsakymas.TabStop = false;
            this.groupBoxAtsakymas.Visible = false;
            // 
            // textBoxAtsakymas1
            // 
            this.textBoxAtsakymas1.Location = new System.Drawing.Point(64, 54);
            this.textBoxAtsakymas1.Name = "textBoxAtsakymas1";
            this.textBoxAtsakymas1.ReadOnly = true;
            this.textBoxAtsakymas1.Size = new System.Drawing.Size(142, 22);
            this.textBoxAtsakymas1.TabIndex = 1;
            // 
            // textBoxAtsakymas2
            // 
            this.textBoxAtsakymas2.Location = new System.Drawing.Point(295, 54);
            this.textBoxAtsakymas2.Name = "textBoxAtsakymas2";
            this.textBoxAtsakymas2.ReadOnly = true;
            this.textBoxAtsakymas2.Size = new System.Drawing.Size(122, 22);
            this.textBoxAtsakymas2.TabIndex = 2;
            // 
            // labelAtsakymas1
            // 
            this.labelAtsakymas1.AutoSize = true;
            this.labelAtsakymas1.Location = new System.Drawing.Point(61, 34);
            this.labelAtsakymas1.Name = "labelAtsakymas1";
            this.labelAtsakymas1.Size = new System.Drawing.Size(0, 17);
            this.labelAtsakymas1.TabIndex = 3;
            // 
            // labelAtsakymas2
            // 
            this.labelAtsakymas2.AutoSize = true;
            this.labelAtsakymas2.Location = new System.Drawing.Point(292, 34);
            this.labelAtsakymas2.Name = "labelAtsakymas2";
            this.labelAtsakymas2.Size = new System.Drawing.Size(0, 17);
            this.labelAtsakymas2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 318);
            this.Controls.Add(this.groupBoxAtsakymas);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxAtsakymas.ResumeLayout(false);
            this.groupBoxAtsakymas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem failasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atidarytiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skaiciavimaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baigtiToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBoxAtsakymas;
        private System.Windows.Forms.TextBox textBoxAtsakymas1;
        private System.Windows.Forms.TextBox textBoxAtsakymas2;
        private System.Windows.Forms.Label labelAtsakymas2;
        private System.Windows.Forms.Label labelAtsakymas1;
    }
}


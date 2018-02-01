namespace _13_03_uzduotis
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
            this.nuskaitytiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skaiciavimaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baigtiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.failasToolStripMenuItem,
            this.skaiciavimaiToolStripMenuItem,
            this.baigtiToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(543, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // failasToolStripMenuItem
            // 
            this.failasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuskaitytiToolStripMenuItem});
            this.failasToolStripMenuItem.Name = "failasToolStripMenuItem";
            this.failasToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.failasToolStripMenuItem.Text = "Failas";
            // 
            // nuskaitytiToolStripMenuItem
            // 
            this.nuskaitytiToolStripMenuItem.Name = "nuskaitytiToolStripMenuItem";
            this.nuskaitytiToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.nuskaitytiToolStripMenuItem.Text = "Nuskaityti";
            this.nuskaitytiToolStripMenuItem.Click += new System.EventHandler(this.nuskaitytiToolStripMenuItem_Click);
            // 
            // skaiciavimaiToolStripMenuItem
            // 
            this.skaiciavimaiToolStripMenuItem.Name = "skaiciavimaiToolStripMenuItem";
            this.skaiciavimaiToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.skaiciavimaiToolStripMenuItem.Text = "Skaiciavimai";
            this.skaiciavimaiToolStripMenuItem.Click += new System.EventHandler(this.skaiciavimaiToolStripMenuItem_Click);
            // 
            // baigtiToolStripMenuItem1
            // 
            this.baigtiToolStripMenuItem1.Name = "baigtiToolStripMenuItem1";
            this.baigtiToolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
            this.baigtiToolStripMenuItem1.Text = "Baigti";
            this.baigtiToolStripMenuItem1.Click += new System.EventHandler(this.baigtiToolStripMenuItem1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(543, 453);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 481);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem failasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuskaitytiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skaiciavimaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baigtiToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


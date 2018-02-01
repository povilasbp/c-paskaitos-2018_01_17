namespace _13_05_kontrolinis
{
    partial class baigti
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
            this.buttonTaip = new System.Windows.Forms.Button();
            this.buttonNe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ar tikrai norite baigti darba?";
            // 
            // buttonTaip
            // 
            this.buttonTaip.Location = new System.Drawing.Point(18, 49);
            this.buttonTaip.Name = "buttonTaip";
            this.buttonTaip.Size = new System.Drawing.Size(75, 23);
            this.buttonTaip.TabIndex = 1;
            this.buttonTaip.Text = "Taip";
            this.buttonTaip.UseVisualStyleBackColor = true;
            this.buttonTaip.Click += new System.EventHandler(this.buttonTaip_Click);
            // 
            // buttonNe
            // 
            this.buttonNe.Location = new System.Drawing.Point(99, 49);
            this.buttonNe.Name = "buttonNe";
            this.buttonNe.Size = new System.Drawing.Size(75, 23);
            this.buttonNe.TabIndex = 2;
            this.buttonNe.Text = "Ne";
            this.buttonNe.UseVisualStyleBackColor = true;
            this.buttonNe.Click += new System.EventHandler(this.buttonNe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTaip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonNe);
            this.groupBox1.Location = new System.Drawing.Point(53, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 94);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // baigti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 126);
            this.Controls.Add(this.groupBox1);
            this.Name = "baigti";
            this.Text = "baigti";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTaip;
        private System.Windows.Forms.Button buttonNe;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
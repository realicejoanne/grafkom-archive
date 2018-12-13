namespace BresenhamAlgorithm
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
            this.button1 = new System.Windows.Forms.Button();
            this.X1 = new System.Windows.Forms.TextBox();
            this.X2 = new System.Windows.Forms.TextBox();
            this.Y1 = new System.Windows.Forms.TextBox();
            this.Y2 = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Let\'s Draw It!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(544, 26);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(220, 26);
            this.X1.TabIndex = 1;
            this.X1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(544, 89);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(220, 26);
            this.X2.TabIndex = 2;
            // 
            // Y1
            // 
            this.Y1.Location = new System.Drawing.Point(544, 146);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(220, 26);
            this.Y1.TabIndex = 3;
            // 
            // Y2
            // 
            this.Y2.Location = new System.Drawing.Point(544, 205);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(220, 26);
            this.Y2.TabIndex = 4;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel.Location = new System.Drawing.Point(32, 26);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(484, 205);
            this.panel.TabIndex = 5;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(32, 273);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(484, 141);
            this.richTextBox.TabIndex = 6;
            this.richTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.Y2);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.TextBox Y1;
        private System.Windows.Forms.TextBox Y2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}


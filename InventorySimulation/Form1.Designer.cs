namespace InventorySimulation
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
            this.Tests = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.OpenTestCases = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Tests
            // 
            this.Tests.FormattingEnabled = true;
            this.Tests.Location = new System.Drawing.Point(148, 140);
            this.Tests.Name = "Tests";
            this.Tests.Size = new System.Drawing.Size(266, 24);
            this.Tests.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenTestCases
            // 
            this.OpenTestCases.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tests);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Tests;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog OpenTestCases;
    }
}
namespace DeviceTreeGenerator
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
            this.ImageDescriptionLabel = new System.Windows.Forms.Label();
            this.SelectButton = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.ImageLocationBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ImageDescriptionLabel
            // 
            this.ImageDescriptionLabel.AutoSize = true;
            this.ImageDescriptionLabel.Location = new System.Drawing.Point(10, 83);
            this.ImageDescriptionLabel.Name = "ImageDescriptionLabel";
            this.ImageDescriptionLabel.Size = new System.Drawing.Size(80, 13);
            this.ImageDescriptionLabel.TabIndex = 15;
            this.ImageDescriptionLabel.Text = "Path to images:";
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(199, 78);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(75, 25);
            this.SelectButton.TabIndex = 14;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(10, 151);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(22, 13);
            this.Label4.TabIndex = 13;
            this.Label4.Text = "1.0";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(124, 61);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(0, 13);
            this.Label2.TabIndex = 12;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(49, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(176, 13);
            this.HeaderLabel.TabIndex = 11;
            this.HeaderLabel.Text = "Welcome to Device Tree Generator";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(99, 142);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 10;
            this.Button1.Text = "Generate";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // ImageLocationBox
            // 
            this.ImageLocationBox.Location = new System.Drawing.Point(93, 80);
            this.ImageLocationBox.Name = "ImageLocationBox";
            this.ImageLocationBox.Size = new System.Drawing.Size(100, 20);
            this.ImageLocationBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 175);
            this.Controls.Add(this.ImageDescriptionLabel);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.ImageLocationBox);
            this.Name = "Form1";
            this.Text = "DTGen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label ImageDescriptionLabel;
        internal System.Windows.Forms.Button SelectButton;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label HeaderLabel;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox ImageLocationBox;
    }
}


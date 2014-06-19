namespace MVPDemo.Views.Main
{
    partial class MainForm
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputTextLabel = new System.Windows.Forms.Label();
            this.capitalizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 27);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(265, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(9, 11);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(58, 13);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Input Text:";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(9, 101);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(42, 13);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "Output:";
            // 
            // outputTextLabel
            // 
            this.outputTextLabel.AutoSize = true;
            this.outputTextLabel.Location = new System.Drawing.Point(9, 114);
            this.outputTextLabel.Name = "outputTextLabel";
            this.outputTextLabel.Size = new System.Drawing.Size(84, 13);
            this.outputTextLabel.TabIndex = 3;
            this.outputTextLabel.Text = "outputTextLabel";
            // 
            // capitalizeButton
            // 
            this.capitalizeButton.Location = new System.Drawing.Point(12, 53);
            this.capitalizeButton.Name = "capitalizeButton";
            this.capitalizeButton.Size = new System.Drawing.Size(75, 23);
            this.capitalizeButton.TabIndex = 4;
            this.capitalizeButton.Text = "Capitalize";
            this.capitalizeButton.UseVisualStyleBackColor = true;
            this.capitalizeButton.Click += new System.EventHandler(this.capitalizeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 140);
            this.Controls.Add(this.capitalizeButton);
            this.Controls.Add(this.outputTextLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.inputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Capitalizer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label outputTextLabel;
        private System.Windows.Forms.Button capitalizeButton;
    }
}


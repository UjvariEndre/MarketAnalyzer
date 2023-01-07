
namespace MarketAnalyzer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.apiKeyInput = new System.Windows.Forms.TextBox();
            this.apiKeyLabel = new System.Windows.Forms.Label();
            this.apiSecretLabel = new System.Windows.Forms.Label();
            this.apiSecretInput = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "This software works with Binance platform only. Please add your API key and secre" +
    "t!";
            // 
            // apiKeyInput
            // 
            this.apiKeyInput.Location = new System.Drawing.Point(120, 116);
            this.apiKeyInput.Name = "apiKeyInput";
            this.apiKeyInput.Size = new System.Drawing.Size(594, 23);
            this.apiKeyInput.TabIndex = 1;
            // 
            // apiKeyLabel
            // 
            this.apiKeyLabel.AutoSize = true;
            this.apiKeyLabel.Location = new System.Drawing.Point(38, 119);
            this.apiKeyLabel.Name = "apiKeyLabel";
            this.apiKeyLabel.Size = new System.Drawing.Size(46, 15);
            this.apiKeyLabel.TabIndex = 2;
            this.apiKeyLabel.Text = "API key";
            // 
            // apiSecretLabel
            // 
            this.apiSecretLabel.AutoSize = true;
            this.apiSecretLabel.Location = new System.Drawing.Point(38, 181);
            this.apiSecretLabel.Name = "apiSecretLabel";
            this.apiSecretLabel.Size = new System.Drawing.Size(59, 15);
            this.apiSecretLabel.TabIndex = 3;
            this.apiSecretLabel.Text = "API secret";
            // 
            // apiSecretInput
            // 
            this.apiSecretInput.Location = new System.Drawing.Point(120, 178);
            this.apiSecretInput.Name = "apiSecretInput";
            this.apiSecretInput.Size = new System.Drawing.Size(594, 23);
            this.apiSecretInput.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(632, 229);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(82, 28);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 322);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.apiSecretInput);
            this.Controls.Add(this.apiSecretLabel);
            this.Controls.Add(this.apiKeyLabel);
            this.Controls.Add(this.apiKeyInput);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Market Analyzer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox apiKeyInput;
        private System.Windows.Forms.Label apiKeyLabel;
        private System.Windows.Forms.Label apiSecretLabel;
        private System.Windows.Forms.TextBox apiSecretInput;
        private System.Windows.Forms.Button saveButton;
    }
}


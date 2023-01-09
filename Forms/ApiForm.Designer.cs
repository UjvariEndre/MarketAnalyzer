
namespace MarketAnalyzer.Forms
{
    partial class ApiForm
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
            this.apiKeyInputLabel = new System.Windows.Forms.Label();
            this.apiSecretInputLabel = new System.Windows.Forms.Label();
            this.apiKeyInput = new System.Windows.Forms.TextBox();
            this.apiSecretInput = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "This software works with Binance platform, please insert your API key and secret!" +
    "";
            // 
            // apiKeyInputLabel
            // 
            this.apiKeyInputLabel.AutoSize = true;
            this.apiKeyInputLabel.Location = new System.Drawing.Point(32, 78);
            this.apiKeyInputLabel.Name = "apiKeyInputLabel";
            this.apiKeyInputLabel.Size = new System.Drawing.Size(46, 15);
            this.apiKeyInputLabel.TabIndex = 1;
            this.apiKeyInputLabel.Text = "API key";
            // 
            // apiSecretInputLabel
            // 
            this.apiSecretInputLabel.AutoSize = true;
            this.apiSecretInputLabel.Location = new System.Drawing.Point(32, 125);
            this.apiSecretInputLabel.Name = "apiSecretInputLabel";
            this.apiSecretInputLabel.Size = new System.Drawing.Size(59, 15);
            this.apiSecretInputLabel.TabIndex = 2;
            this.apiSecretInputLabel.Text = "API secret";
            // 
            // apiKeyInput
            // 
            this.apiKeyInput.Location = new System.Drawing.Point(98, 75);
            this.apiKeyInput.Name = "apiKeyInput";
            this.apiKeyInput.Size = new System.Drawing.Size(576, 23);
            this.apiKeyInput.TabIndex = 3;
            // 
            // apiSecretInput
            // 
            this.apiSecretInput.Location = new System.Drawing.Point(98, 122);
            this.apiSecretInput.Name = "apiSecretInput";
            this.apiSecretInput.Size = new System.Drawing.Size(576, 23);
            this.apiSecretInput.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(592, 170);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(82, 27);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ApiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 223);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.apiSecretInput);
            this.Controls.Add(this.apiKeyInput);
            this.Controls.Add(this.apiSecretInputLabel);
            this.Controls.Add(this.apiKeyInputLabel);
            this.Controls.Add(this.label1);
            this.Name = "ApiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market Analyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label apiKeyInputLabel;
        private System.Windows.Forms.Label apiSecretInputLabel;
        private System.Windows.Forms.TextBox apiKeyInput;
        private System.Windows.Forms.TextBox apiSecretInput;
        private System.Windows.Forms.Button saveButton;
    }
}
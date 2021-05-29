namespace WebBrowser
{
    partial class Form_Settings
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
            this.button_save = new System.Windows.Forms.Button();
            this.label_searchEngine = new System.Windows.Forms.Label();
            this.textBox_searchEngine = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_resetSearchEngine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Location = new System.Drawing.Point(190, 77);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_searchEngine
            // 
            this.label_searchEngine.AutoSize = true;
            this.label_searchEngine.Location = new System.Drawing.Point(12, 13);
            this.label_searchEngine.Name = "label_searchEngine";
            this.label_searchEngine.Size = new System.Drawing.Size(127, 13);
            this.label_searchEngine.TabIndex = 0;
            this.label_searchEngine.Text = "Search Engine Base URL:";
            // 
            // textBox_searchEngine
            // 
            this.textBox_searchEngine.Location = new System.Drawing.Point(15, 28);
            this.textBox_searchEngine.Name = "textBox_searchEngine";
            this.textBox_searchEngine.Size = new System.Drawing.Size(250, 20);
            this.textBox_searchEngine.TabIndex = 1;
            this.textBox_searchEngine.Text = "https://www.google.com/search?q=";
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.Location = new System.Drawing.Point(271, 77);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_resetSearchEngine
            // 
            this.button_resetSearchEngine.Location = new System.Drawing.Point(271, 27);
            this.button_resetSearchEngine.Name = "button_resetSearchEngine";
            this.button_resetSearchEngine.Size = new System.Drawing.Size(75, 23);
            this.button_resetSearchEngine.TabIndex = 2;
            this.button_resetSearchEngine.Text = "Reset";
            this.button_resetSearchEngine.UseVisualStyleBackColor = true;
            this.button_resetSearchEngine.Click += new System.EventHandler(this.button_resetSearchEngine_Click);
            // 
            // Form_Settings
            // 
            this.AcceptButton = this.button_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(359, 112);
            this.Controls.Add(this.textBox_searchEngine);
            this.Controls.Add(this.label_searchEngine);
            this.Controls.Add(this.button_resetSearchEngine);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_searchEngine;
        private System.Windows.Forms.TextBox textBox_searchEngine;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_resetSearchEngine;
    }
}
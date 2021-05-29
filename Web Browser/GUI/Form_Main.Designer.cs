namespace WebBrowser
{
    partial class Form_Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.webBrowser_main = new System.Windows.Forms.WebBrowser();
            this.textBox_query = new System.Windows.Forms.TextBox();
            this.button_go = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser_main
            // 
            this.webBrowser_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser_main.Location = new System.Drawing.Point(3, 41);
            this.webBrowser_main.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_main.Name = "webBrowser_main";
            this.webBrowser_main.Size = new System.Drawing.Size(886, 478);
            this.webBrowser_main.TabIndex = 2;
            // 
            // textBox_query
            // 
            this.textBox_query.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_query.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WebBrowser.Properties.Settings.Default, "Query", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_query.Location = new System.Drawing.Point(12, 12);
            this.textBox_query.Name = "textBox_query";
            this.textBox_query.Size = new System.Drawing.Size(765, 20);
            this.textBox_query.TabIndex = 0;
            this.textBox_query.Text = global::WebBrowser.Properties.Settings.Default.Query;
            this.textBox_query.Enter += new System.EventHandler(this.textBox_query_Enter);
            // 
            // button_go
            // 
            this.button_go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_go.Image = global::WebBrowser.Properties.Resources.resultset_next;
            this.button_go.Location = new System.Drawing.Point(783, 10);
            this.button_go.Name = "button_go";
            this.button_go.Size = new System.Drawing.Size(32, 23);
            this.button_go.TabIndex = 1;
            this.button_go.UseVisualStyleBackColor = true;
            this.button_go.Click += new System.EventHandler(this.button_go_Click);
            // 
            // button_about
            // 
            this.button_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_about.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_about.FlatAppearance.BorderSize = 0;
            this.button_about.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button_about.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_about.Image = global::WebBrowser.Properties.Resources.information;
            this.button_about.Location = new System.Drawing.Point(859, 10);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(16, 23);
            this.button_about.TabIndex = 1;
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // button_settings
            // 
            this.button_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_settings.Image = ((System.Drawing.Image)(resources.GetObject("button_settings.Image")));
            this.button_settings.Location = new System.Drawing.Point(821, 10);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(32, 23);
            this.button_settings.TabIndex = 1;
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            // 
            // Form_Main
            // 
            this.AcceptButton = this.button_go;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 517);
            this.Controls.Add(this.textBox_query);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.button_go);
            this.Controls.Add(this.webBrowser_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser_main;
        private System.Windows.Forms.Button button_go;
        private System.Windows.Forms.TextBox textBox_query;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.Button button_settings;
    }
}


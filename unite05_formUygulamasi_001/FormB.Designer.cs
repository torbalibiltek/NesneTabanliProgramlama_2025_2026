namespace unite05_formUygulamasi_001
{
    partial class FormB
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
            this.button_Hise = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Hise
            // 
            this.button_Hise.Location = new System.Drawing.Point(341, 90);
            this.button_Hise.Name = "button_Hise";
            this.button_Hise.Size = new System.Drawing.Size(75, 23);
            this.button_Hise.TabIndex = 0;
            this.button_Hise.Text = "Hide";
            this.button_Hise.UseVisualStyleBackColor = true;
            this.button_Hise.Click += new System.EventHandler(this.button_Hise_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(341, 163);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 0;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // FormB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Hise);
            this.Name = "FormB";
            this.Text = "FormB";
            this.Load += new System.EventHandler(this.FormB_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Hise;
        private System.Windows.Forms.Button button_Close;
    }
}
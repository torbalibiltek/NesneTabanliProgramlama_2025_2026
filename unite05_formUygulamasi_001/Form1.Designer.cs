namespace unite05_formUygulamasi_001
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
            this.button_Accept = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_ControlBox = new System.Windows.Forms.Button();
            this.button_CentertToScreen = new System.Windows.Forms.Button();
            this.button_Show = new System.Windows.Forms.Button();
            this.button_ShowDialog = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Accept
            // 
            this.button_Accept.Location = new System.Drawing.Point(79, 25);
            this.button_Accept.Name = "button_Accept";
            this.button_Accept.Size = new System.Drawing.Size(75, 23);
            this.button_Accept.TabIndex = 0;
            this.button_Accept.Text = "Accept";
            this.button_Accept.UseVisualStyleBackColor = true;
            this.button_Accept.Click += new System.EventHandler(this.button_Accept_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(79, 66);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 0;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_ControlBox
            // 
            this.button_ControlBox.Location = new System.Drawing.Point(79, 110);
            this.button_ControlBox.Name = "button_ControlBox";
            this.button_ControlBox.Size = new System.Drawing.Size(75, 23);
            this.button_ControlBox.TabIndex = 0;
            this.button_ControlBox.Text = "Control Box";
            this.button_ControlBox.UseVisualStyleBackColor = true;
            this.button_ControlBox.Click += new System.EventHandler(this.button_ControlBox_Click);
            // 
            // button_CentertToScreen
            // 
            this.button_CentertToScreen.Location = new System.Drawing.Point(80, 162);
            this.button_CentertToScreen.Name = "button_CentertToScreen";
            this.button_CentertToScreen.Size = new System.Drawing.Size(113, 23);
            this.button_CentertToScreen.TabIndex = 0;
            this.button_CentertToScreen.Text = "Center To Screen";
            this.button_CentertToScreen.UseVisualStyleBackColor = true;
            this.button_CentertToScreen.Click += new System.EventHandler(this.button_CentertToScreen_Click);
            // 
            // button_Show
            // 
            this.button_Show.Location = new System.Drawing.Point(79, 216);
            this.button_Show.Name = "button_Show";
            this.button_Show.Size = new System.Drawing.Size(75, 23);
            this.button_Show.TabIndex = 0;
            this.button_Show.Text = "Show";
            this.button_Show.UseVisualStyleBackColor = true;
            this.button_Show.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // button_ShowDialog
            // 
            this.button_ShowDialog.Location = new System.Drawing.Point(79, 269);
            this.button_ShowDialog.Name = "button_ShowDialog";
            this.button_ShowDialog.Size = new System.Drawing.Size(75, 23);
            this.button_ShowDialog.TabIndex = 0;
            this.button_ShowDialog.Text = "Show Dialog";
            this.button_ShowDialog.UseVisualStyleBackColor = true;
            this.button_ShowDialog.Click += new System.EventHandler(this.button_ShowDialog_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(439, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AcceptButton = this.button_Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_ShowDialog);
            this.Controls.Add(this.button_Show);
            this.Controls.Add(this.button_CentertToScreen);
            this.Controls.Add(this.button_ControlBox);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Accept);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Accept;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_ControlBox;
        private System.Windows.Forms.Button button_CentertToScreen;
        private System.Windows.Forms.Button button_Show;
        private System.Windows.Forms.Button button_ShowDialog;
        private System.Windows.Forms.TextBox textBox1;
    }
}


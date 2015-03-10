namespace K2Field.SmartObject.Services.CMIS.Sandbox
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
            this.btnDoSomething = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDoSomething
            // 
            this.btnDoSomething.Location = new System.Drawing.Point(136, 45);
            this.btnDoSomething.Name = "btnDoSomething";
            this.btnDoSomething.Size = new System.Drawing.Size(112, 23);
            this.btnDoSomething.TabIndex = 0;
            this.btnDoSomething.Text = "Do Something";
            this.btnDoSomething.UseVisualStyleBackColor = true;
            this.btnDoSomething.Click += new System.EventHandler(this.btnDoSomething_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnDoSomething);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoSomething;
    }
}


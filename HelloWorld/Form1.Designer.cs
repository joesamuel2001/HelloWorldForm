namespace HelloWorld
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
            this.lblHello = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.Location = new System.Drawing.Point(12, 53);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(352, 73);
            this.lblHello.TabIndex = 0;
            this.lblHello.Text = "label1";
            this.lblHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(122, 153);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(130, 48);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 299);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lblHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnDisplay;
    }
}


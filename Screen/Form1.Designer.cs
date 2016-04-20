namespace Screen
{
    sealed partial class Screen
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
            this.components = new System.ComponentModel.Container();
            this.scaleUp = new System.Windows.Forms.Button();
            this.scaleDown = new System.Windows.Forms.Button();
            this.scaleGB = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scaleGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // scaleUp
            // 
            this.scaleUp.Location = new System.Drawing.Point(37, 19);
            this.scaleUp.Name = "scaleUp";
            this.scaleUp.Size = new System.Drawing.Size(25, 25);
            this.scaleUp.TabIndex = 2;
            this.scaleUp.Text = "+";
            this.scaleUp.UseVisualStyleBackColor = true;
            this.scaleUp.Click += new System.EventHandler(this.scaleUp_Click);
            // 
            // scaleDown
            // 
            this.scaleDown.Location = new System.Drawing.Point(6, 19);
            this.scaleDown.Name = "scaleDown";
            this.scaleDown.Size = new System.Drawing.Size(25, 25);
            this.scaleDown.TabIndex = 3;
            this.scaleDown.Text = "-";
            this.scaleDown.UseVisualStyleBackColor = true;
            this.scaleDown.Click += new System.EventHandler(this.scaleDown_Click);
            // 
            // scaleGB
            // 
            this.scaleGB.BackColor = System.Drawing.Color.Transparent;
            this.scaleGB.Controls.Add(this.scaleUp);
            this.scaleGB.Controls.Add(this.scaleDown);
            this.scaleGB.Location = new System.Drawing.Point(12, 12);
            this.scaleGB.Name = "scaleGB";
            this.scaleGB.Size = new System.Drawing.Size(69, 55);
            this.scaleGB.TabIndex = 98;
            this.scaleGB.TabStop = false;
            this.scaleGB.Text = "Figure";
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(558, 436);
            this.Controls.Add(this.scaleGB);
            this.Name = "Screen";
            this.Text = "Form1";
            this.scaleGB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button scaleUp;
        private System.Windows.Forms.Button scaleDown;
        private System.Windows.Forms.GroupBox scaleGB;
        private System.Windows.Forms.Timer timer1;
    }
}


namespace PracticeVelocity
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
            this.txtResultDisplay = new System.Windows.Forms.RichTextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnDiagnose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultDisplay
            // 
            this.txtResultDisplay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtResultDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultDisplay.Location = new System.Drawing.Point(46, 106);
            this.txtResultDisplay.Name = "txtResultDisplay";
            this.txtResultDisplay.Size = new System.Drawing.Size(589, 582);
            this.txtResultDisplay.TabIndex = 0;
            this.txtResultDisplay.Text = "";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(198, 43);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(111, 34);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnDiagnose
            // 
            this.btnDiagnose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnose.Location = new System.Drawing.Point(380, 42);
            this.btnDiagnose.Name = "btnDiagnose";
            this.btnDiagnose.Size = new System.Drawing.Size(112, 35);
            this.btnDiagnose.TabIndex = 2;
            this.btnDiagnose.Text = "Diagnose";
            this.btnDiagnose.UseVisualStyleBackColor = true;
            this.btnDiagnose.Click += new System.EventHandler(this.btnDiagnose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 747);
            this.Controls.Add(this.btnDiagnose);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtResultDisplay);
            this.Name = "Form1";
            this.Text = "Practice Velocity Code Challenge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtResultDisplay;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnDiagnose;
    }
}


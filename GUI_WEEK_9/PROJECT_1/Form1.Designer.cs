
namespace Project_1
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
            this.Button1 = new System.Windows.Forms.RadioButton();
            this.Button2 = new System.Windows.Forms.RadioButton();
            this.CHECK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.AutoSize = true;
            this.Button1.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(884, 220);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(103, 28);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "SignUp";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Button2
            // 
            this.Button2.AutoSize = true;
            this.Button2.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(884, 315);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(94, 28);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "SignIn";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // CHECK
            // 
            this.CHECK.Location = new System.Drawing.Point(884, 529);
            this.CHECK.Name = "CHECK";
            this.CHECK.Size = new System.Drawing.Size(126, 71);
            this.CHECK.TabIndex = 3;
            this.CHECK.Text = "NEXT";
            this.CHECK.UseVisualStyleBackColor = true;
            this.CHECK.Click += new System.EventHandler(this.CHECK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(715, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sign In And Sign Up Application";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(884, 414);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(235, 28);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Close The Application";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1745, 636);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CHECK);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Button1;
        private System.Windows.Forms.RadioButton Button2;
        private System.Windows.Forms.Button CHECK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}


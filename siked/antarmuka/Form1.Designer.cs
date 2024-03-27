
namespace siked
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.pwd_txt = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "USERNAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "PASSWORD";
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(311, 230);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(296, 26);
            this.username_txt.TabIndex = 5;
            // 
            // pwd_txt
            // 
            this.pwd_txt.Location = new System.Drawing.Point(311, 276);
            this.pwd_txt.Name = "pwd_txt";
            this.pwd_txt.Size = new System.Drawing.Size(296, 26);
            this.pwd_txt.TabIndex = 6;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(280, 350);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(116, 39);
            this.login_btn.TabIndex = 7;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(439, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sistem Informasi Kependudukan Desa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(445, 350);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(116, 39);
            this.exit_btn.TabIndex = 9;
            this.exit_btn.Text = "EXIT";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pwd_txt);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form Login SIKED";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.TextBox pwd_txt;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exit_btn;
    }
}


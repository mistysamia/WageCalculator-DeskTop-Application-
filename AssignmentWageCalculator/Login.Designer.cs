
namespace AssignmentWageCalculator
{
    partial class CheckBox
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
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Title_label = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Pass_Label = new System.Windows.Forms.Label();
            this.Pass_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Error_Label = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Name_textBox
            // 
            this.Name_textBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_textBox.Location = new System.Drawing.Point(336, 186);
            this.Name_textBox.Multiline = true;
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(287, 36);
            this.Name_textBox.TabIndex = 0;
            this.Name_textBox.TextChanged += new System.EventHandler(this.Name_textBox_TextChanged);
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.ForeColor = System.Drawing.Color.DarkRed;
            this.Title_label.Location = new System.Drawing.Point(293, 38);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(221, 70);
            this.Title_label.TabIndex = 1;
            this.Title_label.Text = "Sign In";
            this.Title_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.ForeColor = System.Drawing.Color.DimGray;
            this.Name_Label.Location = new System.Drawing.Point(182, 186);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(133, 40);
            this.Name_Label.TabIndex = 3;
            this.Name_Label.Text = "Name :";
            this.Name_Label.Click += new System.EventHandler(this.label3_Click);
            // 
            // Pass_Label
            // 
            this.Pass_Label.AutoSize = true;
            this.Pass_Label.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_Label.ForeColor = System.Drawing.Color.DimGray;
            this.Pass_Label.Location = new System.Drawing.Point(133, 302);
            this.Pass_Label.Name = "Pass_Label";
            this.Pass_Label.Size = new System.Drawing.Size(187, 40);
            this.Pass_Label.TabIndex = 5;
            this.Pass_Label.Text = "Password :";
            this.Pass_Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // Pass_textBox
            // 
            this.Pass_textBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_textBox.Location = new System.Drawing.Point(336, 302);
            this.Pass_textBox.Multiline = true;
            this.Pass_textBox.Name = "Pass_textBox";
            this.Pass_textBox.Size = new System.Drawing.Size(287, 36);
            this.Pass_textBox.TabIndex = 4;
            this.Pass_textBox.TextChanged += new System.EventHandler(this.Pass_textBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Menu;
            this.button1.Location = new System.Drawing.Point(305, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 58);
            this.button1.TabIndex = 6;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Error_Label
            // 
            this.Error_Label.AutoSize = true;
            this.Error_Label.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_Label.ForeColor = System.Drawing.Color.Red;
            this.Error_Label.Location = new System.Drawing.Point(296, 366);
            this.Error_Label.Name = "Error_Label";
            this.Error_Label.Size = new System.Drawing.Size(0, 25);
            this.Error_Label.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(629, 289);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(305, 64);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(802, 515);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Error_Label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pass_Label);
            this.Controls.Add(this.Pass_textBox);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.Title_label);
            this.Controls.Add(this.Name_textBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LavenderBlush;
            this.Name = "CheckBox";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Pass_Label;
        private System.Windows.Forms.TextBox Pass_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Error_Label;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}


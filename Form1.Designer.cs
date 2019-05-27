namespace calculatorWithFunction1
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
            this.lbl_1stnum = new System.Windows.Forms.Label();
            this.lbl_2ndnum = new System.Windows.Forms.Label();
            this.lbl_res = new System.Windows.Forms.Label();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_divi = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_1stnum
            // 
            this.lbl_1stnum.AutoSize = true;
            this.lbl_1stnum.Location = new System.Drawing.Point(75, 82);
            this.lbl_1stnum.Name = "lbl_1stnum";
            this.lbl_1stnum.Size = new System.Drawing.Size(66, 13);
            this.lbl_1stnum.TabIndex = 0;
            this.lbl_1stnum.Text = "First Number";
            // 
            // lbl_2ndnum
            // 
            this.lbl_2ndnum.AutoSize = true;
            this.lbl_2ndnum.Location = new System.Drawing.Point(75, 124);
            this.lbl_2ndnum.Name = "lbl_2ndnum";
            this.lbl_2ndnum.Size = new System.Drawing.Size(84, 13);
            this.lbl_2ndnum.TabIndex = 1;
            this.lbl_2ndnum.Text = "Second Number";
            // 
            // lbl_res
            // 
            this.lbl_res.AutoSize = true;
            this.lbl_res.Location = new System.Drawing.Point(75, 166);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(37, 13);
            this.lbl_res.TabIndex = 2;
            this.lbl_res.Text = "Result";
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(184, 82);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(100, 20);
            this.txt_num1.TabIndex = 3;
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(184, 124);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(100, 20);
            this.txt_num2.TabIndex = 4;
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(184, 159);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(100, 20);
            this.txt_result.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(67, 215);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(34, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(121, 215);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(38, 23);
            this.btn_sub.TabIndex = 7;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.Btn_sub_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.Location = new System.Drawing.Point(172, 215);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(38, 23);
            this.btn_multi.TabIndex = 8;
            this.btn_multi.Text = "X";
            this.btn_multi.UseVisualStyleBackColor = true;
            this.btn_multi.Click += new System.EventHandler(this.Btn_multi_Click);
            // 
            // btn_divi
            // 
            this.btn_divi.Location = new System.Drawing.Point(225, 215);
            this.btn_divi.Name = "btn_divi";
            this.btn_divi.Size = new System.Drawing.Size(36, 23);
            this.btn_divi.TabIndex = 9;
            this.btn_divi.Text = "/";
            this.btn_divi.UseVisualStyleBackColor = true;
            this.btn_divi.Click += new System.EventHandler(this.Btn_divi_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(278, 215);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(35, 23);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "CL";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(133, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Simple Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(382, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_divi);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.lbl_2ndnum);
            this.Controls.Add(this.lbl_1stnum);
            this.Name = "Form1";
            this.Text = "Calculator ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_1stnum;
        private System.Windows.Forms.Label lbl_2ndnum;
        private System.Windows.Forms.Label lbl_res;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_divi;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label1;
    }
}


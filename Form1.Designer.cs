namespace Lab04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBirthYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSumAge = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textPerson = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textGPA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textMax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textMin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textAvg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textGPA_personMin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textGPA_personMax = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(77, 25);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(125, 27);
            this.textName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ชื่อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ปีเกิด";
            // 
            // textBirthYear
            // 
            this.textBirthYear.Location = new System.Drawing.Point(77, 73);
            this.textBirthYear.Name = "textBirthYear";
            this.textBirthYear.Size = new System.Drawing.Size(125, 27);
            this.textBirthYear.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "อายุรวม";
            // 
            // textSumAge
            // 
            this.textSumAge.Location = new System.Drawing.Point(287, 158);
            this.textSumAge.Name = "textSumAge";
            this.textSumAge.Size = new System.Drawing.Size(125, 27);
            this.textSumAge.TabIndex = 4;
            this.textSumAge.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 67);
            this.button1.TabIndex = 6;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textPerson
            // 
            this.textPerson.Location = new System.Drawing.Point(287, 189);
            this.textPerson.Multiline = true;
            this.textPerson.Name = "textPerson";
            this.textPerson.Size = new System.Drawing.Size(125, 243);
            this.textPerson.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "GPA";
            // 
            // textGPA
            // 
            this.textGPA.Location = new System.Drawing.Point(77, 117);
            this.textGPA.Name = "textGPA";
            this.textGPA.Size = new System.Drawing.Size(125, 27);
            this.textGPA.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "GPA Max";
            // 
            // textMax
            // 
            this.textMax.Location = new System.Drawing.Point(287, 55);
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(125, 27);
            this.textMax.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "GPA Min";
            // 
            // textMin
            // 
            this.textMin.Location = new System.Drawing.Point(287, 88);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(125, 27);
            this.textMin.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "GPA Avg";
            // 
            // textAvg
            // 
            this.textAvg.Location = new System.Drawing.Point(287, 121);
            this.textAvg.Name = "textAvg";
            this.textAvg.Size = new System.Drawing.Size(125, 27);
            this.textAvg.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "รายชื่อ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(426, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "ชื่อ";
            // 
            // textGPA_personMin
            // 
            this.textGPA_personMin.Location = new System.Drawing.Point(247, 102);
            this.textGPA_personMin.Name = "textGPA_personMin";
            this.textGPA_personMin.Size = new System.Drawing.Size(125, 27);
            this.textGPA_personMin.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(425, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "ชื่อ";
            // 
            // textGPA_personMax
            // 
            this.textGPA_personMax.Location = new System.Drawing.Point(451, 58);
            this.textGPA_personMax.Name = "textGPA_personMax";
            this.textGPA_personMax.Size = new System.Drawing.Size(125, 27);
            this.textGPA_personMax.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(484, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "GPA สูงสุด";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textGPA_personMin);
            this.groupBox1.Location = new System.Drawing.Point(208, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 426);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลรายวิชา";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(271, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "GPA ต่ำสุด";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textGPA_personMax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textAvg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textGPA);
            this.Controls.Add(this.textPerson);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSumAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBirthYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textName;
        private Label label1;
        private Label label2;
        private TextBox textBirthYear;
        private Label label3;
        private TextBox textSumAge;
        private Button button1;
        private TextBox textPerson;
        private Label label4;
        private TextBox textGPA;
        private Label label5;
        private TextBox textMax;
        private Label label6;
        private TextBox textMin;
        private Label label7;
        private TextBox textAvg;
        private Label label8;
        private Label label9;
        private TextBox textGPA_personMin;
        private Label label10;
        private TextBox textGPA_personMax;
        private Label label11;
        private GroupBox groupBox1;
        private Label label12;
    }
}
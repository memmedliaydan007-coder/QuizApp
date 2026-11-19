namespace QuizApp
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
            progressBar1 = new ProgressBar();
            lblQuestion = new Label();
            grpAnswers = new GroupBox();
            rbOption1 = new RadioButton();
            rbOption2 = new RadioButton();
            rbOption3 = new RadioButton();
            rbOption4 = new RadioButton();
            btnNext = new Button();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(331, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 0;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(12, 51);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(38, 15);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "label1";
            // 
            // grpAnswers
            // 
            grpAnswers.Location = new Point(12, 69);
            grpAnswers.Name = "grpAnswers";
            grpAnswers.Size = new Size(200, 100);
            grpAnswers.TabIndex = 2;
            grpAnswers.TabStop = false;
            grpAnswers.Text = "groupBox1";
            // 
            // rbOption1
            // 
            rbOption1.AutoSize = true;
            rbOption1.Location = new Point(12, 191);
            rbOption1.Name = "rbOption1";
            rbOption1.Size = new Size(94, 19);
            rbOption1.TabIndex = 0;
            rbOption1.TabStop = true;
            rbOption1.Text = "radioButton1";
            rbOption1.UseVisualStyleBackColor = true;
            // 
            // rbOption2
            // 
            rbOption2.AutoSize = true;
            rbOption2.Location = new Point(12, 216);
            rbOption2.Name = "rbOption2";
            rbOption2.Size = new Size(94, 19);
            rbOption2.TabIndex = 3;
            rbOption2.TabStop = true;
            rbOption2.Text = "radioButton2";
            rbOption2.UseVisualStyleBackColor = true;
            // 
            // rbOption3
            // 
            rbOption3.AutoSize = true;
            rbOption3.Location = new Point(12, 241);
            rbOption3.Name = "rbOption3";
            rbOption3.Size = new Size(94, 19);
            rbOption3.TabIndex = 4;
            rbOption3.TabStop = true;
            rbOption3.Text = "radioButton3";
            rbOption3.UseVisualStyleBackColor = true;
            // 
            // rbOption4
            // 
            rbOption4.AutoSize = true;
            rbOption4.Location = new Point(12, 266);
            rbOption4.Name = "rbOption4";
            rbOption4.Size = new Size(94, 19);
            rbOption4.TabIndex = 5;
            rbOption4.TabStop = true;
            rbOption4.Text = "radioButton4";
            rbOption4.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(653, 317);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 6;
            btnNext.Text = "button1";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNext);
            Controls.Add(rbOption4);
            Controls.Add(rbOption3);
            Controls.Add(rbOption2);
            Controls.Add(rbOption1);
            Controls.Add(grpAnswers);
            Controls.Add(lblQuestion);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label lblQuestion;
        private GroupBox grpAnswers;
        private RadioButton rbOption1;
        private RadioButton rbOption2;
        private RadioButton rbOption3;
        private RadioButton rbOption4;
        private Button btnNext;
    }
}

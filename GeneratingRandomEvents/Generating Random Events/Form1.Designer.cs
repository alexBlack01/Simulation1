
namespace Generating_Random_Events
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
            this.answerForYesOrNo = new System.Windows.Forms.Button();
            this.textBoxQuestionForYesOrNo = new System.Windows.Forms.TextBox();
            this.textBoxAnswerForYesOrNo = new System.Windows.Forms.TextBox();
            this.errorTextForYesOrNo = new System.Windows.Forms.Label();
            this.appYesOrNo = new System.Windows.Forms.Label();
            this.questionForYesOrNo = new System.Windows.Forms.Label();
            this.appOrbOfPredict = new System.Windows.Forms.Label();
            this.questionForOrb = new System.Windows.Forms.Label();
            this.textBoxQuestionForOrb = new System.Windows.Forms.TextBox();
            this.errorTextForOrb = new System.Windows.Forms.Label();
            this.buttonForOrb = new System.Windows.Forms.Button();
            this.textBoxAnswerForOrb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // answerForYesOrNo
            // 
            this.answerForYesOrNo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.answerForYesOrNo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.answerForYesOrNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.answerForYesOrNo.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.answerForYesOrNo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.answerForYesOrNo.ForeColor = System.Drawing.Color.White;
            this.answerForYesOrNo.Location = new System.Drawing.Point(94, 174);
            this.answerForYesOrNo.Name = "answerForYesOrNo";
            this.answerForYesOrNo.Size = new System.Drawing.Size(135, 41);
            this.answerForYesOrNo.TabIndex = 0;
            this.answerForYesOrNo.Text = "Ответ";
            this.answerForYesOrNo.UseVisualStyleBackColor = false;
            this.answerForYesOrNo.Click += new System.EventHandler(this.Answer_Click);
            // 
            // textBoxQuestionForYesOrNo
            // 
            this.textBoxQuestionForYesOrNo.Location = new System.Drawing.Point(12, 103);
            this.textBoxQuestionForYesOrNo.Name = "textBoxQuestionForYesOrNo";
            this.textBoxQuestionForYesOrNo.Size = new System.Drawing.Size(300, 27);
            this.textBoxQuestionForYesOrNo.TabIndex = 1;
            // 
            // textBoxAnswerForYesOrNo
            // 
            this.textBoxAnswerForYesOrNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAnswerForYesOrNo.BackColor = System.Drawing.Color.White;
            this.textBoxAnswerForYesOrNo.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxAnswerForYesOrNo.ForeColor = System.Drawing.Color.White;
            this.textBoxAnswerForYesOrNo.Location = new System.Drawing.Point(71, 244);
            this.textBoxAnswerForYesOrNo.Multiline = true;
            this.textBoxAnswerForYesOrNo.Name = "textBoxAnswerForYesOrNo";
            this.textBoxAnswerForYesOrNo.Size = new System.Drawing.Size(180, 90);
            this.textBoxAnswerForYesOrNo.TabIndex = 2;
            this.textBoxAnswerForYesOrNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorTextForYesOrNo
            // 
            this.errorTextForYesOrNo.AutoSize = true;
            this.errorTextForYesOrNo.Location = new System.Drawing.Point(12, 133);
            this.errorTextForYesOrNo.Name = "errorTextForYesOrNo";
            this.errorTextForYesOrNo.Size = new System.Drawing.Size(0, 20);
            this.errorTextForYesOrNo.TabIndex = 3;
            // 
            // appYesOrNo
            // 
            this.appYesOrNo.AutoSize = true;
            this.appYesOrNo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.appYesOrNo.Location = new System.Drawing.Point(12, 14);
            this.appYesOrNo.Name = "appYesOrNo";
            this.appYesOrNo.Size = new System.Drawing.Size(304, 32);
            this.appYesOrNo.TabIndex = 4;
            this.appYesOrNo.Text = "Приложение \"Да или нет\"";
            // 
            // questionForYesOrNo
            // 
            this.questionForYesOrNo.AutoSize = true;
            this.questionForYesOrNo.Location = new System.Drawing.Point(12, 80);
            this.questionForYesOrNo.Name = "questionForYesOrNo";
            this.questionForYesOrNo.Size = new System.Drawing.Size(105, 20);
            this.questionForYesOrNo.TabIndex = 5;
            this.questionForYesOrNo.Text = "Задай вопрос";
            // 
            // appOrbOfPredict
            // 
            this.appOrbOfPredict.AutoSize = true;
            this.appOrbOfPredict.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.appOrbOfPredict.Location = new System.Drawing.Point(459, 14);
            this.appOrbOfPredict.Name = "appOrbOfPredict";
            this.appOrbOfPredict.Size = new System.Drawing.Size(393, 32);
            this.appOrbOfPredict.TabIndex = 6;
            this.appOrbOfPredict.Text = "Приложение \"Шар предсказаний\"";
            // 
            // questionForOrb
            // 
            this.questionForOrb.AutoSize = true;
            this.questionForOrb.Location = new System.Drawing.Point(459, 80);
            this.questionForOrb.Name = "questionForOrb";
            this.questionForOrb.Size = new System.Drawing.Size(105, 20);
            this.questionForOrb.TabIndex = 7;
            this.questionForOrb.Text = "Задай вопрос";
            // 
            // textBoxQuestionForOrb
            // 
            this.textBoxQuestionForOrb.Location = new System.Drawing.Point(459, 103);
            this.textBoxQuestionForOrb.Name = "textBoxQuestionForOrb";
            this.textBoxQuestionForOrb.Size = new System.Drawing.Size(372, 27);
            this.textBoxQuestionForOrb.TabIndex = 8;
            // 
            // errorTextForOrb
            // 
            this.errorTextForOrb.AutoSize = true;
            this.errorTextForOrb.Location = new System.Drawing.Point(459, 133);
            this.errorTextForOrb.Name = "errorTextForOrb";
            this.errorTextForOrb.Size = new System.Drawing.Size(0, 20);
            this.errorTextForOrb.TabIndex = 9;
            // 
            // buttonForOrb
            // 
            this.buttonForOrb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonForOrb.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonForOrb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonForOrb.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.buttonForOrb.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonForOrb.ForeColor = System.Drawing.Color.White;
            this.buttonForOrb.Location = new System.Drawing.Point(576, 174);
            this.buttonForOrb.Name = "buttonForOrb";
            this.buttonForOrb.Size = new System.Drawing.Size(135, 41);
            this.buttonForOrb.TabIndex = 10;
            this.buttonForOrb.Text = "Ответ";
            this.buttonForOrb.UseVisualStyleBackColor = false;
            this.buttonForOrb.Click += new System.EventHandler(this.ButtonForOrb_Click);
            // 
            // textBoxAnswerForOrb
            // 
            this.textBoxAnswerForOrb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAnswerForOrb.BackColor = System.Drawing.Color.White;
            this.textBoxAnswerForOrb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxAnswerForOrb.ForeColor = System.Drawing.Color.White;
            this.textBoxAnswerForOrb.Location = new System.Drawing.Point(459, 244);
            this.textBoxAnswerForOrb.Multiline = true;
            this.textBoxAnswerForOrb.Name = "textBoxAnswerForOrb";
            this.textBoxAnswerForOrb.Size = new System.Drawing.Size(372, 40);
            this.textBoxAnswerForOrb.TabIndex = 11;
            this.textBoxAnswerForOrb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.textBoxAnswerForOrb);
            this.Controls.Add(this.buttonForOrb);
            this.Controls.Add(this.errorTextForOrb);
            this.Controls.Add(this.textBoxQuestionForOrb);
            this.Controls.Add(this.questionForOrb);
            this.Controls.Add(this.appOrbOfPredict);
            this.Controls.Add(this.questionForYesOrNo);
            this.Controls.Add(this.appYesOrNo);
            this.Controls.Add(this.errorTextForYesOrNo);
            this.Controls.Add(this.textBoxAnswerForYesOrNo);
            this.Controls.Add(this.textBoxQuestionForYesOrNo);
            this.Controls.Add(this.answerForYesOrNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button answerForYesOrNo;
        private System.Windows.Forms.TextBox textBoxQuestionForYesOrNo;
        private System.Windows.Forms.TextBox textBoxAnswerForYesOrNo;
        private System.Windows.Forms.Label errorTextForYesOrNo;
        private System.Windows.Forms.Label appYesOrNo;
        private System.Windows.Forms.Label questionForYesOrNo;
        private System.Windows.Forms.Label appOrbOfPredict;
        private System.Windows.Forms.Label questionForOrb;
        private System.Windows.Forms.TextBox textBoxQuestionForOrb;
        private System.Windows.Forms.Label errorTextForOrb;
        private System.Windows.Forms.Button buttonForOrb;
        private System.Windows.Forms.TextBox textBoxAnswerForOrb;
    }
}


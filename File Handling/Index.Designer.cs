namespace File_Handling
{
    partial class Questões
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
            this.OptionsBox = new System.Windows.Forms.ComboBox();
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.Enunciado = new System.Windows.Forms.Label();
            this.EnunciadoTextBox = new System.Windows.Forms.TextBox();
            this.AlternativasGroupBox = new System.Windows.Forms.GroupBox();
            this.OptionA = new System.Windows.Forms.RadioButton();
            this.OptionB = new System.Windows.Forms.RadioButton();
            this.OptionC = new System.Windows.Forms.RadioButton();
            this.OptionD = new System.Windows.Forms.RadioButton();
            this.OptionE = new System.Windows.Forms.RadioButton();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.AnswerButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.ComentLabel = new System.Windows.Forms.Label();
            this.ComentTextBox = new System.Windows.Forms.TextBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.AlternativasGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionsBox
            // 
            this.OptionsBox.FormattingEnabled = true;
            this.OptionsBox.Items.AddRange(new object[] {
            "Linguagem de Programação III",
            "Linguagem de Programação IV",
            "Banco de Dados",
            "Pokemons"});
            this.OptionsBox.Location = new System.Drawing.Point(148, 11);
            this.OptionsBox.Name = "OptionsBox";
            this.OptionsBox.Size = new System.Drawing.Size(185, 21);
            this.OptionsBox.TabIndex = 0;
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.AutoSize = true;
            this.OptionsLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsLabel.Location = new System.Drawing.Point(12, 12);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(130, 20);
            this.OptionsLabel.TabIndex = 1;
            this.OptionsLabel.Text = "Perguntas Sobre";
            // 
            // Enunciado
            // 
            this.Enunciado.AutoSize = true;
            this.Enunciado.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enunciado.Location = new System.Drawing.Point(12, 45);
            this.Enunciado.Name = "Enunciado";
            this.Enunciado.Size = new System.Drawing.Size(84, 20);
            this.Enunciado.TabIndex = 2;
            this.Enunciado.Text = "Enunciado";
            // 
            // EnunciadoTextBox
            // 
            this.EnunciadoTextBox.Location = new System.Drawing.Point(12, 68);
            this.EnunciadoTextBox.Multiline = true;
            this.EnunciadoTextBox.Name = "EnunciadoTextBox";
            this.EnunciadoTextBox.Size = new System.Drawing.Size(553, 122);
            this.EnunciadoTextBox.TabIndex = 3;
            // 
            // AlternativasGroupBox
            // 
            this.AlternativasGroupBox.Controls.Add(this.labelE);
            this.AlternativasGroupBox.Controls.Add(this.labelD);
            this.AlternativasGroupBox.Controls.Add(this.labelC);
            this.AlternativasGroupBox.Controls.Add(this.labelB);
            this.AlternativasGroupBox.Controls.Add(this.labelA);
            this.AlternativasGroupBox.Controls.Add(this.OptionE);
            this.AlternativasGroupBox.Controls.Add(this.OptionD);
            this.AlternativasGroupBox.Controls.Add(this.OptionC);
            this.AlternativasGroupBox.Controls.Add(this.OptionB);
            this.AlternativasGroupBox.Controls.Add(this.OptionA);
            this.AlternativasGroupBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlternativasGroupBox.Location = new System.Drawing.Point(12, 196);
            this.AlternativasGroupBox.Name = "AlternativasGroupBox";
            this.AlternativasGroupBox.Size = new System.Drawing.Size(553, 200);
            this.AlternativasGroupBox.TabIndex = 5;
            this.AlternativasGroupBox.TabStop = false;
            this.AlternativasGroupBox.Text = "Alternativas";
            // 
            // OptionA
            // 
            this.OptionA.AutoSize = true;
            this.OptionA.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionA.Location = new System.Drawing.Point(30, 27);
            this.OptionA.Name = "OptionA";
            this.OptionA.Size = new System.Drawing.Size(108, 23);
            this.OptionA.TabIndex = 0;
            this.OptionA.TabStop = true;
            this.OptionA.Text = "radioButton1";
            this.OptionA.UseVisualStyleBackColor = true;
            // 
            // OptionB
            // 
            this.OptionB.AutoSize = true;
            this.OptionB.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionB.Location = new System.Drawing.Point(30, 57);
            this.OptionB.Name = "OptionB";
            this.OptionB.Size = new System.Drawing.Size(108, 23);
            this.OptionB.TabIndex = 1;
            this.OptionB.TabStop = true;
            this.OptionB.Text = "radioButton2";
            this.OptionB.UseVisualStyleBackColor = true;
            // 
            // OptionC
            // 
            this.OptionC.AutoSize = true;
            this.OptionC.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionC.Location = new System.Drawing.Point(30, 89);
            this.OptionC.Name = "OptionC";
            this.OptionC.Size = new System.Drawing.Size(108, 23);
            this.OptionC.TabIndex = 2;
            this.OptionC.TabStop = true;
            this.OptionC.Text = "radioButton3";
            this.OptionC.UseVisualStyleBackColor = true;
            // 
            // OptionD
            // 
            this.OptionD.AutoSize = true;
            this.OptionD.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionD.Location = new System.Drawing.Point(30, 121);
            this.OptionD.Name = "OptionD";
            this.OptionD.Size = new System.Drawing.Size(108, 23);
            this.OptionD.TabIndex = 3;
            this.OptionD.TabStop = true;
            this.OptionD.Text = "radioButton4";
            this.OptionD.UseVisualStyleBackColor = true;
            // 
            // OptionE
            // 
            this.OptionE.AutoSize = true;
            this.OptionE.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionE.Location = new System.Drawing.Point(30, 153);
            this.OptionE.Name = "OptionE";
            this.OptionE.Size = new System.Drawing.Size(108, 23);
            this.OptionE.TabIndex = 4;
            this.OptionE.TabStop = true;
            this.OptionE.Text = "radioButton5";
            this.OptionE.UseVisualStyleBackColor = true;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.Location = new System.Drawing.Point(7, 29);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(17, 18);
            this.labelA.TabIndex = 5;
            this.labelA.Text = "A";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.Location = new System.Drawing.Point(6, 57);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(18, 18);
            this.labelB.TabIndex = 6;
            this.labelB.Text = "B";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC.Location = new System.Drawing.Point(6, 89);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(19, 18);
            this.labelC.TabIndex = 7;
            this.labelC.Text = "C";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelD.Location = new System.Drawing.Point(6, 121);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(19, 18);
            this.labelD.TabIndex = 8;
            this.labelD.Text = "D";
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelE.Location = new System.Drawing.Point(6, 153);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(18, 18);
            this.labelE.TabIndex = 9;
            this.labelE.Text = "E";
            // 
            // AnswerButton
            // 
            this.AnswerButton.Location = new System.Drawing.Point(16, 402);
            this.AnswerButton.Name = "AnswerButton";
            this.AnswerButton.Size = new System.Drawing.Size(134, 44);
            this.AnswerButton.TabIndex = 6;
            this.AnswerButton.Text = "Responder";
            this.AnswerButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(156, 402);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(409, 44);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "Proxima Pergunta ";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // ComentLabel
            // 
            this.ComentLabel.AutoSize = true;
            this.ComentLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComentLabel.Location = new System.Drawing.Point(16, 453);
            this.ComentLabel.Name = "ComentLabel";
            this.ComentLabel.Size = new System.Drawing.Size(217, 20);
            this.ComentLabel.TabIndex = 8;
            this.ComentLabel.Text = "Resolução com Comentarios";
            // 
            // ComentTextBox
            // 
            this.ComentTextBox.Location = new System.Drawing.Point(12, 477);
            this.ComentTextBox.Multiline = true;
            this.ComentTextBox.Name = "ComentTextBox";
            this.ComentTextBox.Size = new System.Drawing.Size(553, 72);
            this.ComentTextBox.TabIndex = 9;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(148, 555);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(417, 23);
            this.ProgressBar.TabIndex = 10;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressLabel.Location = new System.Drawing.Point(41, 557);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(55, 21);
            this.ProgressLabel.TabIndex = 11;
            this.ProgressLabel.Text = "label8";
            this.ProgressLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 599);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ComentTextBox);
            this.Controls.Add(this.ComentLabel);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.AnswerButton);
            this.Controls.Add(this.AlternativasGroupBox);
            this.Controls.Add(this.EnunciadoTextBox);
            this.Controls.Add(this.Enunciado);
            this.Controls.Add(this.OptionsLabel);
            this.Controls.Add(this.OptionsBox);
            this.Name = "Cadastro";
            this.Text = "Form2";
            this.AlternativasGroupBox.ResumeLayout(false);
            this.AlternativasGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox OptionsBox;
        private System.Windows.Forms.Label OptionsLabel;
        private System.Windows.Forms.Label Enunciado;
        private System.Windows.Forms.TextBox EnunciadoTextBox;
        private System.Windows.Forms.GroupBox AlternativasGroupBox;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.RadioButton OptionE;
        private System.Windows.Forms.RadioButton OptionD;
        private System.Windows.Forms.RadioButton OptionC;
        private System.Windows.Forms.RadioButton OptionB;
        private System.Windows.Forms.RadioButton OptionA;
        private System.Windows.Forms.Button AnswerButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label ComentLabel;
        private System.Windows.Forms.TextBox ComentTextBox;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label ProgressLabel;
    }
}
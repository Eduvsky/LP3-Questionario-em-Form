namespace File_Handling
{
    partial class Index
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
            this.CadastroDisciplina = new System.Windows.Forms.ComboBox();
            this.CadastroDisciplinaLabel = new System.Windows.Forms.Label();
            this.CadastroEnunciadoLabel = new System.Windows.Forms.Label();
            this.CadastroEnunciadoBox = new System.Windows.Forms.TextBox();
            this.CadastroAlternativas = new System.Windows.Forms.GroupBox();
            this.TextBoxE = new System.Windows.Forms.TextBox();
            this.TextBoxD = new System.Windows.Forms.TextBox();
            this.TextBoxC = new System.Windows.Forms.TextBox();
            this.TextBoxB = new System.Windows.Forms.TextBox();
            this.TextBoxA = new System.Windows.Forms.TextBox();
            this.CadastroE = new System.Windows.Forms.Label();
            this.CadastroD = new System.Windows.Forms.Label();
            this.CadastroC = new System.Windows.Forms.Label();
            this.CadastroB = new System.Windows.Forms.Label();
            this.CadastroA = new System.Windows.Forms.Label();
            this.ResolucaoLabel = new System.Windows.Forms.Label();
            this.ResolucaoTextBox = new System.Windows.Forms.TextBox();
            this.AlternativaCorreta = new System.Windows.Forms.GroupBox();
            this.ButtonE = new System.Windows.Forms.RadioButton();
            this.ButtonD = new System.Windows.Forms.RadioButton();
            this.ButtonC = new System.Windows.Forms.RadioButton();
            this.ButtonB = new System.Windows.Forms.RadioButton();
            this.ButtonA = new System.Windows.Forms.RadioButton();
            this.SendCadastroButton = new System.Windows.Forms.Button();
            this.CadastroAlternativas.SuspendLayout();
            this.AlternativaCorreta.SuspendLayout();
            this.SuspendLayout();
            // 
            // CadastroDisciplina
            // 
            this.CadastroDisciplina.FormattingEnabled = true;
            this.CadastroDisciplina.Items.AddRange(new object[] {
            "Linguagem de Programação III",
            "Linguagem de Programação IV",
            "Banco de Dados",
            "Pokemon"});
            this.CadastroDisciplina.Location = new System.Drawing.Point(302, 12);
            this.CadastroDisciplina.Name = "CadastroDisciplina";
            this.CadastroDisciplina.Size = new System.Drawing.Size(162, 21);
            this.CadastroDisciplina.TabIndex = 0;
            // 
            // CadastroDisciplinaLabel
            // 
            this.CadastroDisciplinaLabel.AutoSize = true;
            this.CadastroDisciplinaLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastroDisciplinaLabel.Location = new System.Drawing.Point(123, 12);
            this.CadastroDisciplinaLabel.Name = "CadastroDisciplinaLabel";
            this.CadastroDisciplinaLabel.Size = new System.Drawing.Size(173, 21);
            this.CadastroDisciplinaLabel.TabIndex = 1;
            this.CadastroDisciplinaLabel.Text = "Selecione a Disciplina";
            // 
            // CadastroEnunciadoLabel
            // 
            this.CadastroEnunciadoLabel.AutoSize = true;
            this.CadastroEnunciadoLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastroEnunciadoLabel.Location = new System.Drawing.Point(8, 55);
            this.CadastroEnunciadoLabel.Name = "CadastroEnunciadoLabel";
            this.CadastroEnunciadoLabel.Size = new System.Drawing.Size(312, 21);
            this.CadastroEnunciadoLabel.TabIndex = 2;
            this.CadastroEnunciadoLabel.Text = "Coloque um enunciado bem legal aqui ";
            // 
            // CadastroEnunciadoBox
            // 
            this.CadastroEnunciadoBox.Location = new System.Drawing.Point(12, 88);
            this.CadastroEnunciadoBox.Multiline = true;
            this.CadastroEnunciadoBox.Name = "CadastroEnunciadoBox";
            this.CadastroEnunciadoBox.Size = new System.Drawing.Size(563, 67);
            this.CadastroEnunciadoBox.TabIndex = 3;
            // 
            // CadastroAlternativas
            // 
            this.CadastroAlternativas.Controls.Add(this.TextBoxE);
            this.CadastroAlternativas.Controls.Add(this.TextBoxD);
            this.CadastroAlternativas.Controls.Add(this.TextBoxC);
            this.CadastroAlternativas.Controls.Add(this.TextBoxB);
            this.CadastroAlternativas.Controls.Add(this.TextBoxA);
            this.CadastroAlternativas.Controls.Add(this.CadastroE);
            this.CadastroAlternativas.Controls.Add(this.CadastroD);
            this.CadastroAlternativas.Controls.Add(this.CadastroC);
            this.CadastroAlternativas.Controls.Add(this.CadastroB);
            this.CadastroAlternativas.Controls.Add(this.CadastroA);
            this.CadastroAlternativas.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastroAlternativas.Location = new System.Drawing.Point(12, 161);
            this.CadastroAlternativas.Name = "CadastroAlternativas";
            this.CadastroAlternativas.Size = new System.Drawing.Size(563, 202);
            this.CadastroAlternativas.TabIndex = 4;
            this.CadastroAlternativas.TabStop = false;
            this.CadastroAlternativas.Text = "Escreva as alternativas";
            // 
            // TextBoxE
            // 
            this.TextBoxE.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxE.Location = new System.Drawing.Point(66, 155);
            this.TextBoxE.Name = "TextBoxE";
            this.TextBoxE.Size = new System.Drawing.Size(491, 23);
            this.TextBoxE.TabIndex = 9;
            // 
            // TextBoxD
            // 
            this.TextBoxD.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxD.Location = new System.Drawing.Point(66, 126);
            this.TextBoxD.Name = "TextBoxD";
            this.TextBoxD.Size = new System.Drawing.Size(491, 23);
            this.TextBoxD.TabIndex = 8;
            // 
            // TextBoxC
            // 
            this.TextBoxC.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxC.Location = new System.Drawing.Point(66, 97);
            this.TextBoxC.Name = "TextBoxC";
            this.TextBoxC.Size = new System.Drawing.Size(491, 23);
            this.TextBoxC.TabIndex = 7;
            // 
            // TextBoxB
            // 
            this.TextBoxB.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxB.Location = new System.Drawing.Point(66, 68);
            this.TextBoxB.Name = "TextBoxB";
            this.TextBoxB.Size = new System.Drawing.Size(491, 23);
            this.TextBoxB.TabIndex = 6;
            // 
            // TextBoxA
            // 
            this.TextBoxA.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxA.Location = new System.Drawing.Point(66, 39);
            this.TextBoxA.Name = "TextBoxA";
            this.TextBoxA.Size = new System.Drawing.Size(491, 23);
            this.TextBoxA.TabIndex = 5;
            // 
            // CadastroE
            // 
            this.CadastroE.AutoSize = true;
            this.CadastroE.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastroE.Location = new System.Drawing.Point(29, 156);
            this.CadastroE.Name = "CadastroE";
            this.CadastroE.Size = new System.Drawing.Size(16, 19);
            this.CadastroE.TabIndex = 4;
            this.CadastroE.Text = "E";
            // 
            // CadastroD
            // 
            this.CadastroD.AutoSize = true;
            this.CadastroD.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastroD.Location = new System.Drawing.Point(29, 128);
            this.CadastroD.Name = "CadastroD";
            this.CadastroD.Size = new System.Drawing.Size(19, 19);
            this.CadastroD.TabIndex = 3;
            this.CadastroD.Text = "D";
            // 
            // CadastroC
            // 
            this.CadastroC.AutoSize = true;
            this.CadastroC.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastroC.Location = new System.Drawing.Point(29, 98);
            this.CadastroC.Name = "CadastroC";
            this.CadastroC.Size = new System.Drawing.Size(18, 19);
            this.CadastroC.TabIndex = 2;
            this.CadastroC.Text = "C";
            // 
            // CadastroB
            // 
            this.CadastroB.AutoSize = true;
            this.CadastroB.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastroB.Location = new System.Drawing.Point(29, 69);
            this.CadastroB.Name = "CadastroB";
            this.CadastroB.Size = new System.Drawing.Size(17, 19);
            this.CadastroB.TabIndex = 1;
            this.CadastroB.Text = "B";
            // 
            // CadastroA
            // 
            this.CadastroA.AutoSize = true;
            this.CadastroA.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastroA.Location = new System.Drawing.Point(29, 39);
            this.CadastroA.Name = "CadastroA";
            this.CadastroA.Size = new System.Drawing.Size(18, 19);
            this.CadastroA.TabIndex = 0;
            this.CadastroA.Text = "A";
            // 
            // ResolucaoLabel
            // 
            this.ResolucaoLabel.AutoSize = true;
            this.ResolucaoLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResolucaoLabel.Location = new System.Drawing.Point(12, 370);
            this.ResolucaoLabel.Name = "ResolucaoLabel";
            this.ResolucaoLabel.Size = new System.Drawing.Size(87, 21);
            this.ResolucaoLabel.TabIndex = 5;
            this.ResolucaoLabel.Text = "Resolução";
            // 
            // ResolucaoTextBox
            // 
            this.ResolucaoTextBox.Location = new System.Drawing.Point(16, 395);
            this.ResolucaoTextBox.Multiline = true;
            this.ResolucaoTextBox.Name = "ResolucaoTextBox";
            this.ResolucaoTextBox.Size = new System.Drawing.Size(563, 67);
            this.ResolucaoTextBox.TabIndex = 6;
            // 
            // AlternativaCorreta
            // 
            this.AlternativaCorreta.Controls.Add(this.ButtonE);
            this.AlternativaCorreta.Controls.Add(this.ButtonD);
            this.AlternativaCorreta.Controls.Add(this.ButtonC);
            this.AlternativaCorreta.Controls.Add(this.ButtonB);
            this.AlternativaCorreta.Controls.Add(this.ButtonA);
            this.AlternativaCorreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlternativaCorreta.Location = new System.Drawing.Point(16, 481);
            this.AlternativaCorreta.Name = "AlternativaCorreta";
            this.AlternativaCorreta.Size = new System.Drawing.Size(559, 100);
            this.AlternativaCorreta.TabIndex = 7;
            this.AlternativaCorreta.TabStop = false;
            this.AlternativaCorreta.Text = "AlternativaCorreta";
            // 
            // ButtonE
            // 
            this.ButtonE.AutoSize = true;
            this.ButtonE.Location = new System.Drawing.Point(507, 42);
            this.ButtonE.Name = "ButtonE";
            this.ButtonE.Size = new System.Drawing.Size(36, 22);
            this.ButtonE.TabIndex = 4;
            this.ButtonE.TabStop = true;
            this.ButtonE.Text = "E";
            this.ButtonE.UseVisualStyleBackColor = true;
            // 
            // ButtonD
            // 
            this.ButtonD.AutoSize = true;
            this.ButtonD.Location = new System.Drawing.Point(388, 42);
            this.ButtonD.Name = "ButtonD";
            this.ButtonD.Size = new System.Drawing.Size(37, 22);
            this.ButtonD.TabIndex = 3;
            this.ButtonD.TabStop = true;
            this.ButtonD.Text = "D";
            this.ButtonD.UseVisualStyleBackColor = true;
            // 
            // ButtonC
            // 
            this.ButtonC.AutoSize = true;
            this.ButtonC.Location = new System.Drawing.Point(267, 42);
            this.ButtonC.Name = "ButtonC";
            this.ButtonC.Size = new System.Drawing.Size(37, 22);
            this.ButtonC.TabIndex = 2;
            this.ButtonC.TabStop = true;
            this.ButtonC.Text = "C";
            this.ButtonC.UseVisualStyleBackColor = true;
            // 
            // ButtonB
            // 
            this.ButtonB.AutoSize = true;
            this.ButtonB.Location = new System.Drawing.Point(144, 42);
            this.ButtonB.Name = "ButtonB";
            this.ButtonB.Size = new System.Drawing.Size(36, 22);
            this.ButtonB.TabIndex = 1;
            this.ButtonB.TabStop = true;
            this.ButtonB.Text = "B";
            this.ButtonB.UseVisualStyleBackColor = true;
            // 
            // ButtonA
            // 
            this.ButtonA.AutoSize = true;
            this.ButtonA.Location = new System.Drawing.Point(9, 42);
            this.ButtonA.Name = "ButtonA";
            this.ButtonA.Size = new System.Drawing.Size(35, 22);
            this.ButtonA.TabIndex = 0;
            this.ButtonA.TabStop = true;
            this.ButtonA.Text = "A";
            this.ButtonA.UseVisualStyleBackColor = true;
            // 
            // SendCadastroButton
            // 
            this.SendCadastroButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendCadastroButton.Location = new System.Drawing.Point(190, 601);
            this.SendCadastroButton.Name = "SendCadastroButton";
            this.SendCadastroButton.Size = new System.Drawing.Size(194, 51);
            this.SendCadastroButton.TabIndex = 8;
            this.SendCadastroButton.Text = "Pronto";
            this.SendCadastroButton.UseVisualStyleBackColor = true;
            this.SendCadastroButton.Click += new System.EventHandler(this.SendCadastroButton_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 663);
            this.Controls.Add(this.SendCadastroButton);
            this.Controls.Add(this.AlternativaCorreta);
            this.Controls.Add(this.ResolucaoTextBox);
            this.Controls.Add(this.ResolucaoLabel);
            this.Controls.Add(this.CadastroAlternativas);
            this.Controls.Add(this.CadastroEnunciadoBox);
            this.Controls.Add(this.CadastroEnunciadoLabel);
            this.Controls.Add(this.CadastroDisciplinaLabel);
            this.Controls.Add(this.CadastroDisciplina);
            this.Name = "Index";
            this.Text = "form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_FormClosed);
            this.CadastroAlternativas.ResumeLayout(false);
            this.CadastroAlternativas.PerformLayout();
            this.AlternativaCorreta.ResumeLayout(false);
            this.AlternativaCorreta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CadastroDisciplina;
        private System.Windows.Forms.Label CadastroDisciplinaLabel;
        private System.Windows.Forms.Label CadastroEnunciadoLabel;
        private System.Windows.Forms.TextBox CadastroEnunciadoBox;
        private System.Windows.Forms.GroupBox CadastroAlternativas;
        private System.Windows.Forms.TextBox TextBoxE;
        private System.Windows.Forms.TextBox TextBoxD;
        private System.Windows.Forms.TextBox TextBoxC;
        private System.Windows.Forms.TextBox TextBoxB;
        private System.Windows.Forms.TextBox TextBoxA;
        private System.Windows.Forms.Label CadastroE;
        private System.Windows.Forms.Label CadastroD;
        private System.Windows.Forms.Label CadastroC;
        private System.Windows.Forms.Label CadastroB;
        private System.Windows.Forms.Label CadastroA;
        private System.Windows.Forms.Label ResolucaoLabel;
        private System.Windows.Forms.TextBox ResolucaoTextBox;
        private System.Windows.Forms.GroupBox AlternativaCorreta;
        private System.Windows.Forms.RadioButton ButtonE;
        private System.Windows.Forms.RadioButton ButtonD;
        private System.Windows.Forms.RadioButton ButtonC;
        private System.Windows.Forms.RadioButton ButtonB;
        private System.Windows.Forms.RadioButton ButtonA;
        private System.Windows.Forms.Button SendCadastroButton;
    }
}
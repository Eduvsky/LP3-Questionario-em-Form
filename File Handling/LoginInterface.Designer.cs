namespace File_Handling
{
    partial class LoginInterface
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.SignInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "User";
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(42, 233);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(388, 29);
            this.NameBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(42, 327);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(388, 29);
            this.PasswordBox.TabIndex = 4;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // GoButton
            // 
            this.GoButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoButton.Location = new System.Drawing.Point(261, 403);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(137, 51);
            this.GoButton.TabIndex = 5;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.Location = new System.Drawing.Point(59, 403);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(137, 51);
            this.SignInButton.TabIndex = 6;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // LoginInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 499);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginInterface";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Button SignInButton;
    }
}


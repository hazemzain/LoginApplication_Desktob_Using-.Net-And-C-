namespace Login_Task
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
            Btn_1 = new Button();
            Username_Txt = new TextBox();
            Password_Txt = new TextBox();
            MassegeDesplay_Txt = new TextBox();
            SuspendLayout();
            // 
            // Btn_1
            // 
            Btn_1.Location = new Point(319, 261);
            Btn_1.Name = "Btn_1";
            Btn_1.Size = new Size(94, 29);
            Btn_1.TabIndex = 0;
            Btn_1.Text = "Login";
            Btn_1.UseVisualStyleBackColor = true;
            Btn_1.Click += Btn_1_Click;
            // 
            // Username_Txt
            // 
            Username_Txt.Location = new Point(206, 87);
            Username_Txt.Name = "Username_Txt";
            Username_Txt.Size = new Size(339, 27);
            Username_Txt.TabIndex = 1;
            Username_Txt.TextChanged += Username_Txt_TextChanged;
            // 
            // Password_Txt
            // 
            Password_Txt.AcceptsReturn = true;
            Password_Txt.Location = new Point(206, 156);
            Password_Txt.Name = "Password_Txt";
            Password_Txt.Size = new Size(339, 27);
            Password_Txt.TabIndex = 2;
            Password_Txt.TextChanged += Password_Txt_TextChanged;
            // 
            // MassegeDesplay_Txt
            // 
            MassegeDesplay_Txt.Location = new Point(201, 347);
            MassegeDesplay_Txt.Name = "MassegeDesplay_Txt";
            MassegeDesplay_Txt.Size = new Size(344, 27);
            MassegeDesplay_Txt.TabIndex = 3;
            MassegeDesplay_Txt.TextChanged += MassegeDesplay_Txt_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MassegeDesplay_Txt);
            Controls.Add(Password_Txt);
            Controls.Add(Username_Txt);
            Controls.Add(Btn_1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_1;
        private TextBox Username_Txt;
        private TextBox Password_Txt;
        private TextBox MassegeDesplay_Txt;
    }
}

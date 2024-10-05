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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btn_5 = new Button();
            label4 = new Label();
            label3 = new Label();
            btn_3 = new Button();
            btn_2 = new Button();
            SubmitPassword = new TextBox();
            SubmitUserName = new TextBox();
            panel3 = new Panel();
            label6 = new Label();
            label5 = new Label();
            btn_4 = new Button();
            Password_Update = new TextBox();
            Username_Update = new TextBox();
            colorDialog1 = new ColorDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_1
            // 
            Btn_1.BackColor = Color.Lime;
            Btn_1.Location = new Point(232, 108);
            Btn_1.Name = "Btn_1";
            Btn_1.Size = new Size(94, 29);
            Btn_1.TabIndex = 0;
            Btn_1.Text = "Login";
            Btn_1.UseVisualStyleBackColor = false;
            Btn_1.Click += Btn_1_Click;
            // 
            // Username_Txt
            // 
            Username_Txt.Location = new Point(112, 14);
            Username_Txt.Name = "Username_Txt";
            Username_Txt.Size = new Size(308, 27);
            Username_Txt.TabIndex = 1;
            Username_Txt.TextChanged += Username_Txt_TextChanged;
            // 
            // Password_Txt
            // 
            Password_Txt.AcceptsReturn = true;
            Password_Txt.Location = new Point(112, 66);
            Password_Txt.Name = "Password_Txt";
            Password_Txt.Size = new Size(311, 27);
            Password_Txt.TabIndex = 2;
            Password_Txt.TextChanged += Password_Txt_TextChanged;
            // 
            // MassegeDesplay_Txt
            // 
            MassegeDesplay_Txt.Location = new Point(112, 176);
            MassegeDesplay_Txt.Name = "MassegeDesplay_Txt";
            MassegeDesplay_Txt.Size = new Size(308, 27);
            MassegeDesplay_Txt.TabIndex = 3;
            MassegeDesplay_Txt.TextChanged += MassegeDesplay_Txt_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Username_Txt);
            panel1.Controls.Add(MassegeDesplay_Txt);
            panel1.Controls.Add(Password_Txt);
            panel1.Controls.Add(Btn_1);
            panel1.Location = new Point(12, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 270);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 73);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 5;
            label2.Text = "EnterPassword";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 17);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 4;
            label1.Text = "EnterUserName";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btn_3);
            panel2.Controls.Add(btn_2);
            panel2.Controls.Add(SubmitPassword);
            panel2.Controls.Add(SubmitUserName);
            panel2.Location = new Point(456, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(339, 325);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // btn_5
            // 
            btn_5.BackColor = Color.Red;
            btn_5.Location = new Point(110, 264);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(112, 29);
            btn_5.TabIndex = 7;
            btn_5.Text = "Delete Data";
            btn_5.UseVisualStyleBackColor = false;
            btn_5.Click += btn_5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 69);
            label4.Name = "label4";
            label4.Size = new Size(347, 20);
            label4.TabIndex = 6;
            label4.Text = "EnterNewPasswordOrOld Data ToUpdateOR Delete";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-1, 9);
            label3.Name = "label3";
            label3.Size = new Size(351, 20);
            label3.TabIndex = 5;
            label3.Text = "EnterNewUserNameOrOld Data ToUpdateOr Delete";
            label3.Click += label3_Click;
            // 
            // btn_3
            // 
            btn_3.BackColor = Color.Cyan;
            btn_3.Location = new Point(110, 219);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(103, 29);
            btn_3.TabIndex = 3;
            btn_3.Text = "UpdateData";
            btn_3.UseVisualStyleBackColor = false;
            btn_3.Click += button1_Click_1;
            // 
            // btn_2
            // 
            btn_2.BackColor = Color.Yellow;
            btn_2.Location = new Point(110, 165);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(103, 29);
            btn_2.TabIndex = 2;
            btn_2.Text = "InsertData";
            btn_2.UseVisualStyleBackColor = false;
            btn_2.Click += button1_Click;
            // 
            // SubmitPassword
            // 
            SubmitPassword.Location = new Point(27, 99);
            SubmitPassword.Name = "SubmitPassword";
            SubmitPassword.Size = new Size(281, 27);
            SubmitPassword.TabIndex = 1;
            SubmitPassword.TextChanged += SubmitPassword_TextChanged;
            // 
            // SubmitUserName
            // 
            SubmitUserName.Location = new Point(27, 32);
            SubmitUserName.Name = "SubmitUserName";
            SubmitUserName.Size = new Size(281, 27);
            SubmitUserName.TabIndex = 0;
            SubmitUserName.TextChanged += SubmitUserName_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(btn_4);
            panel3.Controls.Add(Password_Update);
            panel3.Controls.Add(Username_Update);
            panel3.Location = new Point(801, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 252);
            panel3.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 112);
            label6.Name = "label6";
            label6.Size = new Size(153, 20);
            label6.TabIndex = 6;
            label6.Text = "EnterUpdatePassword";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 43);
            label5.Name = "label5";
            label5.Size = new Size(158, 20);
            label5.TabIndex = 5;
            label5.Text = "EnterUpdateUsername";
            // 
            // btn_4
            // 
            btn_4.Location = new Point(102, 189);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(94, 29);
            btn_4.TabIndex = 2;
            btn_4.Text = "OK";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_4_Click;
            // 
            // Password_Update
            // 
            Password_Update.Location = new Point(90, 136);
            Password_Update.Name = "Password_Update";
            Password_Update.Size = new Size(125, 27);
            Password_Update.TabIndex = 1;
            Password_Update.TextChanged += Password_Update_TextChanged;
            // 
            // Username_Update
            // 
            Username_Update.Location = new Point(90, 70);
            Username_Update.Name = "Username_Update";
            Username_Update.Size = new Size(125, 27);
            Username_Update.TabIndex = 0;
            Username_Update.TextChanged += Username_Update_TextChanged;
            // 
            // colorDialog1
            // 
            colorDialog1.Color = Color.Yellow;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 639);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_1;
        private TextBox Username_Txt;
        private TextBox Password_Txt;
        private TextBox MassegeDesplay_Txt;
        private Panel panel1;
        private Panel panel2;
        private Button btn_2;
        private TextBox SubmitPassword;
        private TextBox SubmitUserName;
        private Button btn_3;
        private Panel panel3;
        private Button btn_4;
        private TextBox Password_Update;
        private TextBox Username_Update;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private Button btn_5;
        private ColorDialog colorDialog1;
    }
}

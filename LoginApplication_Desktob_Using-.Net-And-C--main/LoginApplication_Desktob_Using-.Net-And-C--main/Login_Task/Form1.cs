using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Login_Task
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();
        }
        private void Username_Txt_TextChanged(object sender, EventArgs e)
        {


        }

        private void Password_Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void MassegeDesplay_Txt_TextChanged(object sender, EventArgs e)
        {



        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            //String Username_Test = "hazemzain17@gmail.com";
            //String Password_Test = "mmm@1999";
            int flag = 0;


            if (Username_Txt.Text=="" || Password_Txt.Text=="")
            {
                MassegeDesplay_Txt.Text="the user name or password fields empty ";
                MessageBox.Show("the user name or password fields empty");
                return;

            }

            String connectionstring = "Data Source=SAIFZAIN;Initial Catalog=users;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM user_Info ", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                String DB_Username = reader["username"].ToString();
                String DB_Password = reader["PasswordHash"].ToString();
                if (DB_Username.ToLower()==Username_Txt.Text.ToLower())
                {
                    flag = 1;
                    if (DB_Password==Password_Txt.Text)
                    {
                        MassegeDesplay_Txt.Text="the user login successfully ";
                        MessageBox.Show("login successfully");
                        // Thread.Sleep(10000);
                        panel1.Hide();
                        panel2.Show();
                        //this.Controls.Remove(panel1);

                    }

                    else if (DB_Password!=Password_Txt.Text)
                    {
                        MassegeDesplay_Txt.Text="the password  fields is wrong ";
                        MessageBox.Show("the password  fields is wrong");


                    }
                }



            }
            if (flag == 0)
            {
                MassegeDesplay_Txt.Text="the user name  fields is wrong ";
                MessageBox.Show("the user name  fields is wrong");

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel2.Hide();
            panel3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = SubmitUserName.Text.ToLower();
            String pass = SubmitPassword.Text;
            //MessageBox.Show(name+"AND"+pass);
            string queure1 = $"INSERT INTO user_Info   VALUES('{name}','{pass}')";
            string queure2 = $"SELECT COUNT(*) from user_Info Where  username='{name}' AND PasswordHash='{pass}'";

            String connectionstring = "Data Source=SAIFZAIN;Initial Catalog=users;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand command1 = new SqlCommand(queure2, connection);
            object x = command1.ExecuteScalar();
            String z = x.ToString();
            int result = Convert.ToInt32(z);
            if (result>0)
            {
                MessageBox.Show("this data aready is in table ");
            }
            else
            {
                SqlCommand command = new SqlCommand(queure1, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("this data submitted correctly  ");



            }

            //SqlCommand command = new SqlCommand(queure1, connection);
            //command.ExecuteNonQuery();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SubmitUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = SubmitUserName.Text.ToLower();
            String pass = SubmitPassword.Text;
            string queure1 = $"SELECT COUNT(*) from user_Info Where  username='{name}' AND PasswordHash='{pass}'";
            String connectionstring = "Data Source=SAIFZAIN;Initial Catalog=users;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand command1 = new SqlCommand(queure1, connection);
            object x = command1.ExecuteScalar();
            String z = x.ToString();
            int result = Convert.ToInt32(z);
            if (result<=0)
            {
                MessageBox.Show("sorry,this data you want to update not in table  ");
                return;
            }
            panel2.Hide();
            panel3.Show();

        }

        private void Username_Update_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_Update_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            string name = SubmitUserName.Text.ToLower();
            String pass = SubmitPassword.Text;
            string nameUpdate = Username_Update.Text.ToLower();
            String passUpade = Password_Update.Text;
            // string queure1 = $"SELECT COUNT(*) from user_Info Where  username='{name}' AND PasswordHash='{pass}'";
            string queure2 = $"UPDATE user_Info SET username='{nameUpdate}',PasswordHash='{passUpade}' Where  username='{name}' ";

            String connectionstring = "Data Source=SAIFZAIN;Initial Catalog=users;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand command2 = new SqlCommand(queure2, connection);
            command2.ExecuteNonQuery();
            MessageBox.Show("this data Updated correctly  ");




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            string name = SubmitUserName.Text.ToLower();
            String pass = SubmitPassword.Text;
            string queure1 = $"DELETE FROM user_Info  Where  username='{name}' AND PasswordHash='{pass}' ";
            string queure2 = $"SELECT COUNT(*) from user_Info Where  username='{name}' AND PasswordHash='{pass}'";
            String connectionstring = "Data Source=SAIFZAIN;Initial Catalog=users;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand command1 = new SqlCommand(queure2, connection);
            object x = command1.ExecuteScalar();
            String z = x.ToString();
            int result = Convert.ToInt32(z);
            if (result<=0)
            {
                MessageBox.Show("sorry,this data you want to delete not in table  ");

            }
            else
            {
                SqlCommand command2 = new SqlCommand(queure1, connection);
                command2.ExecuteNonQuery();
                MessageBox.Show("this data deleted correctly  ");

            }




        }
    }
}

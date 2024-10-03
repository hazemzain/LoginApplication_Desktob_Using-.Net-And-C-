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
            String Username_Test = "hazemzain17@gmail.com";
            String Password_Test = "mmm@1999";
            int flag = 0;


             if (Username_Txt.Text=="" || Password_Txt.Text=="")
            {
                MassegeDesplay_Txt.Text="the user name or password fields empty ";


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
                if (DB_Username==Username_Txt.Text)
                {
                    flag = 1;
                    if (DB_Password==Password_Txt.Text)
                    {
                        MassegeDesplay_Txt.Text="the user login successfully ";

                    }

                    else if (Password_Test!=Password_Txt.Text)
                    {
                        MassegeDesplay_Txt.Text="the password  fields is wrong ";

                    }
                }
                


            }
            if (flag == 0) {
                MassegeDesplay_Txt.Text="the user name  fields is wrong ";

            }
            

        }

        
    }
}

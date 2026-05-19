using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FileAnalyzer.WinForms
{
    public partial class Form2 : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["FileAnalyzerLoginDb"]?.ConnectionString;

        public Form2()
        {
            InitializeComponent();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            if (this.Text != "Log In")
            {
                this.Text = "Log In";
                return;
            }

            if (!EnsureLoginDatabaseConfigured())
            {
                return;
            }

            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and Password cannot be empty!");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Username, Password FROM LogInTable";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        bool foundUser = false;

                        while (reader.Read())
                        {
                            string thisUsername = reader["Username"].ToString();
                            string thisPassword = reader["Password"].ToString();

                            if (thisUsername == username && thisPassword == password)
                            {
                                foundUser = true;
                                break;
                            }
                        }

                        if (foundUser)
                        {
                            Form1 form1 = new Form1();
                            form1.Show();
                            this.Hide();
                            MessageBox.Show($"Welcome {username}!");
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password!");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Login database is unavailable: {ex.Message}");
            }
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (this.Text != "Sign Up")
            {
                this.Text = "Sign Up";
                return;
            }

            if (!EnsureLoginDatabaseConfigured())
            {
                return;
            }

            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and Password cannot be empty!");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Username FROM LogInTable";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string thisUsername = reader["Username"].ToString();

                            if (thisUsername == username)
                            {
                                MessageBox.Show("Username already exists!");
                                return;
                            }
                        }
                    }

                    string insertQuery = "INSERT INTO LogInTable (Username, Password) VALUES (@username, @password)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@username", username);
                        insertCommand.Parameters.AddWithValue("@password", password);
                        insertCommand.ExecuteNonQuery();
                    }
                }

                this.Text = "Log In";
                MessageBox.Show("User registered successfully!");
                textBox1.Clear();
                textBox2.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Login database is unavailable: {ex.Message}");
            }
        }

        private void GuestBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            MessageBox.Show("Welcome Guest!");
        }

        private bool EnsureLoginDatabaseConfigured()
        {
            if (!string.IsNullOrWhiteSpace(connectionString))
            {
                return true;
            }

            MessageBox.Show("Login database connection is not configured. You can continue as guest.");
            return false;
        }
    }
}

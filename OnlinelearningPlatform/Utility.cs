using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinelearningPlatform
{
    public class Utility
    {
        public static Tuple<bool, string> Register(string username, string password)
        {
            try
            {
                string query = string.Empty;
                if (string.IsNullOrEmpty(username) || !username.Contains('@')) throw new InvalidDataException("Invalid username");

                string name = username.Split('@')[0];
                string identifier = username.Split('@')[1];

                string connectionString = "Data Source=ZOON;Initial Catalog=\"Online Learning Platform\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    switch (identifier)
                    {
                        case "student.com":
                            query = "insert into Student(Email, Pass, Created_at) values(@email, @pass, @created_at)";
                            break;
                        case "instructor.com":
                            query = "insert into Instructor(Email, Pass, Created_at) values(@email, @pass, @created_at)";
                            break;
                        case "admin.com":
                            query = "insert into Administrator(Email, Pass, Created_at) values(@email, @pass, @created_at)";
                            break;
                        default:
                            throw new InvalidDataException("Invalid identifier. must be: student, instructor, or admin");
                    }
                    SqlCommand cmd = new SqlCommand(query, connection);
                    //cmd.Parameters.AddWithValue("id", 10);
                    cmd.Parameters.AddWithValue("email", username);
                    cmd.Parameters.AddWithValue("pass", password);
                    cmd.Parameters.AddWithValue("created_at", DateTime.Now);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return Tuple.Create(true, identifier);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return Tuple.Create(false, string.Empty);
        }
        public static Tuple<bool, string> Login(string username, string password)
        {
            try
            {
                string query = string.Empty;
                if (string.IsNullOrEmpty(username) || !username.Contains('@')) throw new InvalidDataException("Invalid username");

                string name = username.Split('@')[0];
                string identifier = username.Split('@')[1];

                string connectionString = "Data Source=ZOON;Initial Catalog=\"Online Learning Platform\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    switch (identifier)
                    {
                        case "student.com":
                            query = "select * from Student where Email = @email and Pass = @pass";
                            break;
                        case "instructor.com":
                            query = "select * from Instructor where Email = @email and Pass = @pass";
                            break;
                        case "admin.com":
                            query = "select * from Administrator where Email = @email and Pass = @pass";
                            break;
                        default:
                            throw new InvalidDataException("Invalid identifier. must be: student, instructor, or admin");
                    }
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("email", username);
                    cmd.Parameters.AddWithValue("pass", password);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    connection.Open();
                    sda.Fill(dt);
                   // MessageBox.Show(dt.Rows[0]["Email"].ToString());
                   if (username == dt.Rows[0]["Email"].ToString() && password == dt.Rows[0]["Pass"].ToString()) return Tuple.Create(true, identifier);
                    connection.Close();
                    return Tuple.Create(true, identifier);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return Tuple.Create(false, string.Empty);
        }
        public static string GetID(string username)
        {
            try
            {
                string connectionString = "Data Source=ZOON;Initial Catalog=\"Online Learning Platform\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                string query = "select ID from Student";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    connection.Open();
                    sda.Fill(dt);
                    connection.Close();
                    return dt.Rows[0]["ID"].ToString();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            return null;
        }
        public static DataTable GetReport(string username, string identifier)
        {
            try
            {
                string connectionString = "Data Source=ZOON;Initial Catalog=\"Online Learning Platform\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                string query = "select ID, Date, Content from Report join Receive_Report on Report.ID = Receive_Report.Report_ID where Receive_Report.Student_ID = @studentID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("studentID", GetID(username));
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    connection.Open();
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
            return null;
        }
    }
}

using System.Data;
using System.Data.SqlClient;

namespace OnlinelearningPlatform
{
    public class Utility
    {
        static string connectionString = "Data Source=ZOON;Initial Catalog=\"Online Learning Platform\";Integrated Security=True;TrustServerCertificate=True";

        public static Tuple<bool, string> Register(string username, string password)
        {
            try
            {
                string query = string.Empty;
                if (string.IsNullOrEmpty(username) || !username.Contains('@')) throw new InvalidDataException("Invalid username");

                string name = username.Split('@')[0];
                string identifier = username.Split('@')[1];

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
                            query = "insert into Adminstrator(Email, Pass, Created_at) values(@email, @pass, @created_at)";
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
            catch (Exception ex) { MessageBox.Show(ex.Message + "AT Register"); }
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
                            query = "select * from Adminstrator where Email = @email and Pass = @pass";
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
            catch (Exception ex) { MessageBox.Show(ex.Message + "AT LogIN"); }
            return Tuple.Create(false, string.Empty);
        }
        public static string GetStudentID(string username)
        {
            try
            {
                string query = "select ID from Student where Student.Email = @email";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("email", username + "@student.com");
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    connection.Open();
                    sda.Fill(dt);
                    connection.Close();
                    return dt.Rows[0]["ID"].ToString();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message + "AT GetStudentID"); }
            return null;
        }
        public static DataTable GetReport(string username)
        {
            try
            {
                string query = "select ID, Date, Content from Report join Receive_Report on Report.ID = Receive_Report.Report_ID where Receive_Report.Student_ID = @studentID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("studentID", GetStudentID(username));
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    connection.Open();
                    sda.Fill(dt);
                    connection.Close();
                    return dt;
                }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message + "AT getReport"); }
            return null;
        }
        public static DataTable GetAssessments(string username)
        {
            try
            {
                string query = @"select assessment.id, course.title, assessment.content
                                from assessment as ases
                                join course as c on c.id = ases.course_id
                                join instructor as ins on ins.id = course.instructor_id
                                join ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("studentID", GetStudentID(username));
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    connection.Open();
                    sda.Fill(dt);
                    connection.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message + "AT getAssessment"); }
            return null;
        }

        public static string GetCourse(string username)
        {

            try
            {
                string query = "select Title from Course join Instructor on Course.Instructor_ID = Instructor.ID where Instructor.Email = @email";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("email", username);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    connection.Open();
                    sda.Fill(dt);
                    connection.Close();
                    switch (dt.Rows[0]["Title"])
                    {
                        case "Intelligent Systems":
                            return "intelligent systems";
                        case "Computer Networks":
                            return "computer networks";
                        case "Database Systems":
                            return "database systems";
                        default:
                            return "No Courses";

                    }

                }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message + "AT getCourse"); }
            return string.Empty;

        }
        public static DataTable GetStudentGrades(string username)
        {
            try
            {
                string query = @"SELECT sp.Student_ID, s.Name, c.Title AS [Course Exam], sp.Grade, 
    CASE 
        WHEN sp.Grade < 5 THEN 'Not sigma' 
        ELSE 'Sigma' 
    END AS [is sigma?]
FROM 
    Student AS s
JOIN 
    Student_Participates AS sp ON s.ID = sp.Student_ID
JOIN 
    Course AS c ON c.ID = sp.Course_ID
JOIN 
    Instructor ON Instructor.ID = c.Instructor_ID
WHERE 
    Instructor.Email = @email 
    AND s.Name IS NOT NULL
ORDER BY 
    sp.Student_ID, 
    s.Name;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("email", username);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    connection.Open();
                    sda.Fill(dt);
                    connection.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message + "AT getStudentGrade"); }
            return null;
        }

        public static bool UpdateGrade(int id, int value)
        {
            try
            {
                string query = "update Student_Participates set Grade = @value where Student_ID = @id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("value", value);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                return true;
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message + "AT updateGrade"); } return false;
        }
    }
}

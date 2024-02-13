using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5._3_database_milan_26806
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            Console.WriteLine("Enter Option");
            Console.WriteLine("1 For Insert Student");
            Console.WriteLine("2 For Update Student");
            Console.WriteLine("3 For Delete Student");
            Console.WriteLine("4 For Fetch All Student");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Address: ");
                    string address = Console.ReadLine();
                    Console.Write("Enter Gender: ");
                    string gender = Console.ReadLine();
                    st.InsertStudent(name, address, gender);
                    Console.WriteLine("Record Inserted");
                    break;
                case "2":
                    Console.Write("Enter Id To Update: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    string uname = Console.ReadLine();
                    Console.Write("Enter Address: ");
                    string uaddress = Console.ReadLine();
                    Console.Write("Enter Gender: ");
                    string ugender = Console.ReadLine();
                    st.UpdateStudent(uname, uaddress, ugender, id);
                    Console.WriteLine("Record Updated");
                    break;
                case "3":
                    Console.Write("Enter Id To Update: ");
                    int did = Convert.ToInt32(Console.ReadLine());
                    st.DeleteStudent(did);
                    Console.WriteLine("Record Deleted");
                    break;
                case "4":
                    DataTable dt = st.DisplayStudentData();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Console.WriteLine("Name:{0}   Address:{1}    Gender:{2}",
                        dt.Rows[i]["Name"], dt.Rows[i]["Address"], dt.Rows[i]["Gender"]);
                    }
                    break;

                default:
                    break;
            }
            Console.ReadLine();


        }
    }
    public class Student
    {
        public void InsertStudent(string name, string address, string gender)
        {
            string connStr = @"Data Source=(localdb)\MSSqlLocalDB; Database=SamriddhiData; Integrated Security=true";
            SqlConnection con = new SqlConnection(connStr);
            string sql = "insert into tblStudent values(@name,@address,@gender)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@gender", gender);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void UpdateStudent(string name, string address, string gender, int id)
        {
            string connStr = @"Data Source=(localdb)\MSSqlLocalDB; Database=SamriddhiData; Integrated Security=true";
            SqlConnection con = new SqlConnection(connStr);
            string sql = "update tblStudent set Name=@name, Address=@address, Gender=@gender where Id=@id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void DeleteStudent(int id)
        {
            string connStr = @"Data Source=(localdb)\MSSqlLocalDB; Database=SamriddhiData; Integrated Security=true";
            SqlConnection con = new SqlConnection(connStr);
            string sql = "delete from tblStudent whwere Id=@id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public DataTable DisplayStudentData()
        {
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB; Database=SamriddhiData; Integrated Security=true";
            SqlConnection con = new SqlConnection(conStr);//
            SqlCommand cmd = new SqlCommand("select *from tblStudent", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);//works as mediator between datasource=datatable
            DataTable dt = new DataTable();//row column 
            da.Fill(dt);
            return dt;

        }
    }

}

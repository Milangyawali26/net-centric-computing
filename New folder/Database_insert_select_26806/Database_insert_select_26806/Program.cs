using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;//MS SQL Server

namespace Databaseinsert_select_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student st = new student();
            //st.InsertStudent();
            st.DisplayStudentData();
            Console.ReadLine();
        }
    }
    public class student
    {
        public void InsertStudent()
        {
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Database=SamriddhiDB;Integrated Security=true";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("insert into tblStudent values(@Name,@Address,@Gender)", con);
            cmd.Parameters.AddWithValue("@Name", "Prashant Bista");
            cmd.Parameters.AddWithValue("@Address", "Lalitpur");
            cmd.Parameters.AddWithValue("@Gender", "Male");
            con.Open();
            cmd.ExecuteNonQuery();// insert update delete
            con.Close();
            Console.WriteLine("Record Inserted");
        }
        public void DisplayStudentData()
        {
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Database=SamriddhiDB;Integrated Security=true";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("select * from tblStudent", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine("Name: {0}  Address: {1}  Gender: {2}", dt.Rows[i]["Name"], dt.Rows[i]["Address"], dt.Rows[i]["Gender"]);
            }
        }
    }

}
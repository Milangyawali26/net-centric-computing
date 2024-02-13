using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5._1_database_select_insert_milan_26806
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentInsert_Select obj = new StudentInsert_Select();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter Student:" + (i + 1));
                Console.Write("Enter Name:");
                string name = Console.ReadLine();
                Console.Write("Enter Address:");
                string address = Console.ReadLine();
                Console.Write("Enter Gender:");
                string gender = Console.ReadLine();
                obj.Insert(name, address, gender);
                Console.WriteLine("Record Inserted");

            }
            Console.WriteLine();
            Console.WriteLine("*********************");
            Console.WriteLine("All Student");
            DataTable dt = obj.GetAllStudent();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string name = dt.Rows[i]["Name"].ToString();
                string address = dt.Rows[i]["Address"].ToString();
                string gender = dt.Rows[i]["Gender"].ToString();
                Console.WriteLine("Name:{0}   Address:{1}    Gender:{2}", name, address, gender);
            }
            Console.WriteLine("*******************");
            Console.WriteLine("Total No of Student: " + dt.Rows.Count);
            Console.ReadLine();
        }
    }
    public class StudentInsert_Select
    {
        public void Insert(string name, string address, string gender)
        {
            string connStr = @"Data Source=(localdb)\MSSqlLocalDB; Database=SamriddhiData; Integrated Security=true";
            SqlConnection con = new SqlConnection(connStr);
            string sql = "insert into tblStudent values(@name,@address,@gender)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@gender", gender);
            con.Open();
            cmd.ExecuteReader();
            con.Close();

        }
        public DataTable GetAllStudent()
        {
            string connStr = @"Data Source=(localdb)\MSSqlLocalDB; Database=SamriddhiData; Integrated Security=true";
            SqlConnection con = new SqlConnection(connStr);
            string sql = "select *from tblStudent";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();//can hold data in tabular format
            da.Fill(dt);

            return dt;
        }
    }


}

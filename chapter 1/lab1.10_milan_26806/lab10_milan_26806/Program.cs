using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10_milan_26806
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> st = new List<Student>();
            st.Add(new Student() { id = 1, Name = "Hari maya", Address = "Kathmandu", Gender = "Female" });
            st.Add(new Student() { id = 2, Name = "Dhan maya", Address = "Lalitpur", Gender = "Female" });
            st.Add(new Student() { id = 3, Name = "Gun Maya", Address = "Kathmandu", Gender = "Female" });
            st.Add(new Student() { id = 4, Name = "Man maya", Address = "Lalitpur", Gender = "Female" });
            st.Add(new Student() { id = 5, Name = "sun Maya", Address = "Kathmandu", Gender = "Female" });
            st.Add(new Student() { id = 6, Name = "Hari kumar", Address = "Bhaktapur", Gender = "Male" });
            st.Add(new Student() { id = 7, Name = "Dhan kumar", Address = "Kathmandu", Gender = "Male" });
            st.Add(new Student() { id = 9, Name = "Sun kumar", Address = "Kathmandu", Gender = "Male" });
            st.Add(new Student() { id = 10, Name = "Gun Kumar", Address = "Bhaktapur", Gender = "Male" });
            st.Add(new Student() { id = 10, Name = "Gun Kumar", Address = "Bhaktapur", Gender = "Male" });
            Console.WriteLine("**********************************List of Students********************");
            foreach (var item in st)
            {
                Console.WriteLine("Name:{0} Address:{1} Gender:{2}", item.Name, item.Address, item.Gender);
            }
            List<Student> filterStudent = FindStudentByAddress(st, "Kathmandu");
            Console.WriteLine("**********************************Students with Address Kathmandu********************");
            foreach (var item in filterStudent)
            {
                Console.WriteLine("Name:{0} Address:{1} Gender:{2}", item.Name, item.Address, item.Gender);
            }
            Console.ReadLine();
        }

        public static List<Student> FindStudentByAddress(List<Student> students, String searchAddress)
        {
            List<Student> filterstudent = new List<Student>();
            foreach (Student item in students)
            {
                if (item.Address == searchAddress)
                {
                    filterstudent.Add(item);
                }
            }
            return filterstudent;
        }

    }
    public class Student
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

    }

}
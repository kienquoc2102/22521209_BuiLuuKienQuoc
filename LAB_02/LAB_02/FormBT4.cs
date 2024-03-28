using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms.Design;

namespace LAB_02
{
    public partial class FormBT4 : Form
    {
        public FormBT4()
        {
            InitializeComponent();
        }

        //Danh sách sinh viên
        List<Student> students = new List<Student>();

        //Biến đếm
        int count = 0;

        class Student
        {
            public string name { get; set; }

            public string id { get; set; }
            public string phone { get; set; }
            public float course1 { get; set; }
            public float course2 { get; set; }
            public float course3 { get; set; }
            public float avg { get; set; }

            public Student(string Name, string ID, string Phone, float Course1, float Course2, float Course3)
            {
                name = Name;
                id = ID;
                phone = Phone;
                course1 = Course1;
                course2 = Course2;
                course3 = Course3;
                avg = (course1 + course2 + course3) / 3;
            }

            public string StringInput()
            {
                return $"{name},{id},{phone},{course1},{course2},{course3}";
            }
            public string StringOutput()
            {
                return $"{name},{id},{phone},{course1},{course2},{course3},{avg}";
            }
        }

        //Hàm Clear
        private void Clear()
        {
            txt_input_Name.Text = null;
            txt_input_ID.Text = null;
            txt_input_Phone.Text = null;
            txt_input_Course1.Text = null;
            txt_input_Course2.Text = null;
            txt_input_Course3.Text = null;
        }

        //Hàm kiểm tra điều kiện
        private bool checkPhone(string phone)
        {
            if (phone.Length == 10 && phone.StartsWith("0"))
                return true;
            return false;
        }
        private bool checkID(string id)
        {
            if (id.ToString().Length == 8) 
                return true;
            else
                return false;
        }
        private bool checkScore(float score)
        {
            if (0 <= score && score <=10)
                return true;
            else
                return false;
        }

        private void btn_Add_Input_Click(object sender, EventArgs e)
        {
            if (checkPhone(txt_input_Phone.Text) && 
                checkID(txt_input_ID.Text) && 
                checkScore(float.Parse(txt_input_Course1.Text)) && 
                checkScore(float.Parse(txt_input_Course2.Text)) && 
                checkScore(float.Parse(txt_input_Course3.Text)))
            {
                string Name = txt_input_Name.Text;
                string Phone = txt_input_Phone.Text;
                string ID = txt_input_ID.Text;
                float Course1 = float.Parse(txt_input_Course1.Text);
                float Course2 = float.Parse(txt_input_Course2.Text);
                float Course3 = float.Parse(txt_input_Course3.Text);
                Student student = new Student(Name, ID, Phone, Course1, Course2, Course3);
                students.Add(student);

                SerializeToFileStream("Input4.txt", students, "in");
            }
            else
                MessageBox.Show("Số điện thoại phải có 10 chữ số \nMã số sinh viên là một số có 8 chữ số \nCác điểm của từng học phần từ 0 đến 10");

            Clear();
        }

        //Serialize
        private static void SerializeToFileStream(string filePath, List<Student> students, string state)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var student in students)
                    {
                        if (state == "in")
                            writer.WriteLine(student.StringInput());
                        else if (state == "out")
                            writer.WriteLine(student.StringOutput());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        //Deserialize
        private static List<Student> DeserializeFromFileStream(string filePath)
        {
            List<Student> temp_students = new List<Student>();
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 6)
                        {
                            string name = parts[0].Trim();
                            string id = parts[1].Trim();
                            string phone = parts[2].Trim();
                            float course1 = float.Parse(parts[3].Trim());
                            float course2 = float.Parse(parts[4].Trim());
                            float course3 = float.Parse(parts[5].Trim());
                            temp_students.Add(new Student(name, id, phone, course1, course2, course3));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }
            return temp_students;
        }

        private void btn_Write_Output_Click(object sender, EventArgs e)
        {
            
            List<Student> deserializeStudentStream = DeserializeFromFileStream("Input4.txt");
            SerializeToFileStream("Output4.txt", deserializeStudentStream, "out");
        }

        private void btn_Read_Output_Click(object sender, EventArgs e)
        {
            List<Student> deserializeStudentStream = DeserializeFromFileStream("Input4.txt");
            string temp = "";
            foreach (Student student in deserializeStudentStream)
            {
                temp += student.StringOutput() + Environment.NewLine;
            }
            txt_display_File.Text = temp;

            DisplayInfo(deserializeStudentStream, count);
        }

        //Hàm hiển thị thông tin 
        private void DisplayInfo (List<Student> students, int index)
        {
            if (index >= 0 && index < students.Count)
            {
                txt_output_Name.Text = students[index].name;
                txt_output_ID.Text = students[index].id.ToString();
                txt_output_Phone.Text = students[index].phone;
                txt_output_Course1.Text = students[index].course1.ToString();
                txt_output_Course2.Text = students[index].course2.ToString();
                txt_output_Course3.Text = students[index].course3.ToString();
                txt_output_AVG.Text = students[index].avg.ToString();   
            }
        }

        //Nút bấm Back và Next
        private void btn_Back_Click(object sender, EventArgs e)
        {
            List<Student> deserializeStudentStream = DeserializeFromFileStream("Input4.txt");
            if (count >= 0 && count < deserializeStudentStream.Count)
            {
                count--;
            }
            else { count = 0; }
            DisplayInfo(deserializeStudentStream, count);
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            List<Student> deserializeStudentStream = DeserializeFromFileStream("Input4.txt");
            if (count >= 0 && count < deserializeStudentStream.Count)
            {
                count++;
            }
            else { count = 0; }
            DisplayInfo(deserializeStudentStream, count);
        }
    }
}

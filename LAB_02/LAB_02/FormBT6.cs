using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LAB_02
{
    public partial class FormBT6 : Form
    {
        public FormBT6()
        {
            InitializeComponent();
            LoadMenu();
        }

        //Chuỗi kết nối
        public static string connectionString = @"Data Source=DESKTOP-DSII5ET\SQLEXPRESS;Initial Catalog=BAITAP4;Integrated Security=True;";

        //Đóng Form
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Hiển thị Món Ăn
        private void LoadMenu()
        {
            dataGridView_DisplayFood.DataSource = GetAllFood().Tables[0];
            dataGridView_DisplayFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Hàm lấy món ăn từ cơ sở dữ liệu
        private DataSet GetAllFood()
        {
            DataSet data = new DataSet();

            //Chuỗi truy vấn
            string query = "select TenMonAn as 'Ten Mon an', Ten as 'Ten Quan an' From NhaCungCap, MonAn where NhaCungCap.IDNCC = MonAn.IDNCC";

            //SQLConnection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return data;
        }

        //Thêm món ăn
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string food_name = txt_Food.Text;
            string rest_name = txt_Name.Text;
            AddFood(food_name, rest_name);
            LoadMenu();
        }
        private void AddFood(string food_name, string rest_name)
        {
            int ran_id_rest = RandomID();
            int ran_id_food = RandomID();
            string add_query_rest = "INSERT INTO NhaCungCap(IDNCC, Ten, QuyenHan) VALUES (@IDNCC, @Ten, 'Chu Quan')";
            string add_query_Food = "INSERT INTO MonAn (IDMA, TenMonAn, HinhAnh, IDNCC) VALUES (@IDMA, @TenMonAn, 'food.png', @IDNCC);";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(add_query_rest, con);
                command.Parameters.AddWithValue("@IDNCC", ran_id_rest);
                command.Parameters.AddWithValue("@Ten", rest_name);
                command.ExecuteNonQuery();
                con.Close();
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(add_query_Food, con);
                command.Parameters.AddWithValue("@IDMA", ran_id_food);
                command.Parameters.AddWithValue("@TenMonAn", food_name);
                command.Parameters.AddWithValue("@IDNCC", ran_id_rest);
                command.ExecuteNonQuery();
                con.Close();
            }
        }
        private int RandomID()
        {
            Random rand = new Random();
            int rand_id = rand.Next(1, 201);
            return rand_id;
        }

        //Tìm món ăn
        private void btn_Random_Click(object sender, EventArgs e)
        {
            List<string[]> food_list = new List<string[]>();
            food_list = GetFoodFromDb();
            text_DisplayFood.Text = RandomFood(food_list);
        }
        //Hàm tạo mảng món ăn
        private List<string[]> GetFoodFromDb()
        {
            List<string[]> food_list = new List<string[]>();
            foreach (DataGridViewRow dg in dataGridView_DisplayFood.Rows)
            {
                if (!dg.IsNewRow && dg.Cells[0].Value != null)
                {
                    string[] food = new string[2];
                    food[0] = dg.Cells[0].Value.ToString();
                    food[1] = dg.Cells[1].Value.ToString();
                    food_list.Add(food);
                }
            }    
            return food_list;
        }
        //Hàm random
        private string RandomFood(List<string[]> food_list)
        {
            Random rand = new Random();
            int rand_i = rand.Next(0, food_list.Count);
            string[] food = food_list[rand_i];
            return $"{food[0]}\r\nTại quán {food[1]}\r\n";
        }
    }
}

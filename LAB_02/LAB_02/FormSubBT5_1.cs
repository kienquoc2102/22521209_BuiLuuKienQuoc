using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_02
{
    public partial class FormSubBT5_1 : Form
    {
        private FormBT5 parentForm { get; set; }
        public FormSubBT5_1(FormBT5 parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            LoadInfo();
        }
        List<Statis> items = new List<Statis>();
        public class Statis
        {
            public string film_name { get; set; }
            public int sold_ticket { get; set; }
            public int remain_ticket { get; set; }
            public long total_money { get; set; }
            //public int rank { get; set; }
            public Statis(string film_name, int sold_ticket, int remain_ticket, long total_money)
            {
                this.film_name = film_name;
                this.sold_ticket = sold_ticket;
                this.remain_ticket = remain_ticket;
                this.total_money = total_money;
                //this.rank = rank;
            }
            public string ToString()
            {
                return $"{film_name}-{sold_ticket}-{remain_ticket}-{total_money}";
            }
        }
        //Deserialize Output5
        public List<Statis> DeserializeToFileStream_Output5(string filePath)
        {
            List<Statis> items = new List<Statis>();
            try
            {
                using (StreamReader rd = new StreamReader(filePath))
                {
                    string line;
                    while ((line = rd.ReadLine()) != null)
                    {
                        string[] parts = line.Split("-");
                        if (parts.Length == 4)
                        {
                            string film_name = parts[0];
                            int sold_ticket = int.Parse(parts[1]);
                            int remain_ticket = int.Parse(parts[2]);
                            long total_money = long.Parse(parts[3]);
                            //int rank = int.Parse(parts[4]);
                            items.Add(new Statis(film_name, sold_ticket, remain_ticket, total_money));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            return items;
        }
        private void LoadInfo()
        {
            items = DeserializeToFileStream_Output5("Output5.txt");
            items.Sort((x, y) => x.total_money.CompareTo(y.total_money));
            string detail = "";
            string rank = "";
            int rank_id = 0;
            for (int i = items.Count -1 ; i >= 0; i--)
            {
                //Xếp hạng
                rank_id++;
                rank += "Top " + rank_id.ToString() + ": " + items[i].film_name + Environment.NewLine;

                //Chi tiết
                detail += $"Phim: {items[i].film_name} Số vé bán được: {items[i].sold_ticket} Số vé còn: {items[i].remain_ticket} Tổng doanh thu: {items[i].total_money}" + Environment.NewLine;
            }
            txt_detail_film.Text = detail;
            txt_display_rank.Text = rank;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;

namespace LAB_05
{
    public partial class FormBT4 : Form
    {
        public FormBT4()
        {
            InitializeComponent();
        }

        //Khai báo 
        private string url = "https://betacinemas.vn/phim.htm";
        private string filepath = "movies.html";
        private string filepath_json = "movies.json";

        //
        private List<string> CreateSeats(string pre)
        {
            List<string> list = new List<string>();
            for(int i = 0; i < 20 ; i++)
            {
                list.Add(pre + i.ToString());
            }
            return list;
        }

        //DownLoad file html
        private void DownLoad()
        {
            string html = GetHTML(url);

            WebClient myClient = new WebClient();
            myClient.DownloadFile(url, filepath);
        }

        private string GetHTML(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(dataStream);
            string html = sr.ReadToEnd();
            response.Close();
            return html;
        }

        //Lấy thông tin từ file html
        private List<Movie> GetFilm(IHtmlDocument document)
        {
            List<Movie> list = new List<Movie>();

            var rowTags = document.QuerySelectorAll("div.row");

            foreach (var rowTag in rowTags)
            {
                var nameTag = rowTag.QuerySelector("h3 > a");
                var imgTag = rowTag.QuerySelector("img");

                if (nameTag != null && imgTag != null)
                {
                    string movieName = nameTag.TextContent.Trim();
                    string movieUrl = $"https://betacinemas.vn/{nameTag.GetAttribute("href")}";
                    string movieImg = imgTag.GetAttribute("src");

                    List<List<string>> seat_temp = new List<List<string>>();
                    seat_temp.Add(CreateSeats("A"));
                    seat_temp.Add(CreateSeats("B"));
                    seat_temp.Add(CreateSeats("C"));
                    seat_temp.Add(CreateSeats("D"));
                    seat_temp.Add(CreateSeats("E"));

                    List<Room> room_temp = new List<Room>();
                    for (int i = 0; i < 2; i++)
                    {
                        Room room = new Room()
                        {
                            name = "C"+i.ToString(),
                            available_seats = seat_temp,
                            bought_seats = new List<string>()
                        };
                        room_temp.Add(room);
                    }
                    

                    Movie movie = new Movie()
                    {
                        MovieName = movieName,
                        MovieUrl = movieUrl,
                        MovieImg = movieImg,
                        Rooms = room_temp
                    };

                    list.Add(movie);
                }
            }

            return list;
        }

        //Ghi thông tin vào file Json
        private void WriteToJson(List<Movie> list)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
                string jsonString = JsonSerializer.Serialize(list, options);

                // Ghi chuỗi JSON vào tệp với encoding UTF-8
                using (StreamWriter sw = new StreamWriter(filepath_json, false, Encoding.UTF8))
                {
                    sw.Write(jsonString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Truy cập vào file html đã download và ghi vào file Json
        private void InitialLoad()
        {
            string htmlContent = File.ReadAllText(filepath);

            var parser = new HtmlParser();
            var document = parser.ParseDocument(htmlContent);

            List<Movie> movies = GetFilm(document);

            WriteToJson(movies);

            DisplayFilm(movies);
        }

        //Hiểm thị danh sách phim
        private void DisplayFilm(List<Movie> list)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Danh sách rỗng!");
            }
            else
            {
                foreach (Movie movie in list)
                {
                    //Tạo Panel
                    Panel panel = new Panel();
                    panel.Size = new System.Drawing.Size(658, 164);
                    panel.Anchor = AnchorStyles.Right;
                    panel.Anchor = AnchorStyles.Left;
                    panel.Anchor = AnchorStyles.Top;


                    //Xác định vị trí mặc định của panel
                    if (panel_listfilm.Controls.Count > 0)
                    {
                        Panel lastPanel = (Panel)panel_listfilm.Controls[panel_listfilm.Controls.Count - 1];
                        panel.Top = lastPanel.Bottom + 10; // Vị trí Y của panel mới là vị trí dưới cùng của panel trước đó cộng với một khoảng trống (10 pixel)
                    }

                    //Thêm panel vào panel_listfilm
                    panel_listfilm.Controls.Add(panel);

                    //Nội dung Panel
                    FormBT4_Display form = new FormBT4_Display(movie.MovieName, movie.MovieUrl, movie.MovieImg);
                    form.Dock = DockStyle.Fill;
                    panel.Controls.Add(form);
                    panel.Tag = form;
                    form.BringToFront();
                    form.Show();

                    //Hiệu ứng di chuột vào panel
                    panel.MouseEnter += (sender, e) =>
                    {
                        panel.BackColor = Color.Blue;
                    };
                }
            }
        }

        private void FormBT4_Load(object sender, EventArgs e)
        {
            DownLoad();
            InitialLoad();
        }
    }
}

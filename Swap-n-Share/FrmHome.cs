using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;

namespace Swap_n_Share
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FrmCommunity sd = new FrmCommunity();
            this.Hide();
            sd.Show();
        }



        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmProduct sd = new FrmProduct();
            this.Hide();
            sd.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FrmSetting sd = new FrmSetting();
            this.Hide();
            sd.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            FrmProfile sd = new FrmProfile();
            this.Hide();
            sd.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            FrmActivity sd = new FrmActivity();
            this.Hide();
            sd.Show();
        }



        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private async void FrmHome_Load(object sender, EventArgs e)
        {
            string apiKey = "9f9dba458f464bf3adbcb82e001604c6";
            string url = $"http://newsapi.org/v2/everything?q=reuse+OR+circular+economy&language=en&pageSize=1&sortBy=totalResults&apiKey={apiKey}";

            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);

            try
            {
                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    var newsResponse = JsonConvert.DeserializeObject<NewsApiResponse>(response.Content);
                    var article = newsResponse?.Articles?.FirstOrDefault();
                    if (article != null)
                    {
                        lblArticleTitle.Text = article.Title;
                        lblSource.Text = "Source: " + article.Source?.Name;
                        lblDescription.Text = "Brief Description: " + article.Description;
                        linkReadMore.Text = "Read More ➔";
                        linkReadMore.LinkClicked += (s, args) => System.Diagnostics.Process.Start(new ProcessStartInfo(article.Url) { UseShellExecute = true });
                    }
                }
                else
                {
                    // Log the response details
                    MessageBox.Show($"Failed to retrieve data. Status: {response.StatusCode}, Message: {response.ErrorMessage}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void linkReadMore_Click(object sender, EventArgs e)
        {

        }
    }
}

public class NewsApiResponse
{
    public string Status { get; set; }
    public int TotalResults { get; set; }
    public List<Article> Articles { get; set; }
}

public class Article
{
    public Source Source { get; set; }
    public string Author { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Url { get; set; }
    public string UrlToImage { get; set; }
    public DateTime PublishedAt { get; set; }
    public string Content { get; set; }
}

public class Source
{
    public string Id { get; set; }
    public string Name { get; set; }
}
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

        private void btnCommunity_Click(object sender, EventArgs e)
        {
            FrmCommunity sd = new FrmCommunity();
            this.Hide();
            sd.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmProductSwap sd = new FrmProductSwap();
            this.Hide();
            sd.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FrmSetting sd = new FrmSetting();
            this.Hide();
            sd.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            FrmProfileSwap sd = new FrmProfileSwap();
            this.Hide();
            sd.Show();
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            FrmActivitySwap sd = new FrmActivitySwap();
            this.Hide();
            sd.Show();
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
    }
}

public class NewsApiResponse
{
    public List<Article> Articles { get; set; }
}

public class Article
{
    public Source Source { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public string Url { get; set; }
}

public class Source
{
    public string Name { get; set; }
}
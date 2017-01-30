using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAnimeListSharp;
using MyAnimeListSharp.Core;
using MyAnimeListSharp.Auth;
using MyAnimeListSharp.Util;
using MyAnimeListSharp.Facade;
using MyAnimeListSharp.Parameters;
using MyAnimeListSharp.Facade.Async;
using MyAnimeListSharp.Extensions.Core;

namespace AnimeSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // Create Listview Columns
            lvAnimeResult.View = View.Details;

            lvAnimeResult.Columns.Add("Anime", 382);
            lvAnimeResult.Columns.Add("Type", 50);
            lvAnimeResult.Columns.Add("Episodes", 70);
            lvAnimeResult.Columns.Add("Rating", 70);
        }

        private async void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            ICredentialContext credential = new CredentialContext
            {
                UserName = tbUserID.Text,
                Password = tbPass.Text
            };

            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbSearch.Text))
                {
                    MessageBox.Show("Nothing to Search for.....");
                }
                else
                {
                    string response;

                    var asyncAnimeSearch = new AnimeSearchMethodsAsync(credential);
                    response = await asyncAnimeSearch.SearchAsync(tbSearch.Text);

                    if (string.IsNullOrEmpty(tbUserID.Text) &&  string.IsNullOrEmpty(tbPass.Text))
                    {
                        MessageBox.Show("Add account");
                    }
                    else if (string.IsNullOrWhiteSpace(response))
                    {
                        MessageBox.Show("No such anime");
                    }
                    else
                    {
                        lvAnimeResult.BeginUpdate();
                        lvAnimeResult.Items.Clear();

                        XmlDocument doc = new XmlDocument();

                        doc.LoadXml(response);

                        XmlNodeList list = doc.SelectNodes("/anime/entry");

                        foreach (XmlNode node in list)
                        {
                            string series_id = node["id"].InnerText;
                            string series_title = node["title"].InnerText;
                            string series_title_english = node["english"].InnerText;
                            string series_episodes = node["episodes"].InnerText;
                            string series_score = node["score"].InnerText;
                            string series_type = node["type"].InnerText;
                            string series_status = node["status"].InnerText;
                            string series_start_date = node["start_date"].InnerText;
                            string series_end_date = node["end_date"].InnerText;
                            string series_image = node["image"].InnerText;

                            string[] lvElements = new string[11];
                            ListViewItem items;

                            lvElements[0] = series_title;
                            lvElements[1] = series_type;
                            lvElements[2] = series_episodes;
                            lvElements[3] = series_score;
                            lvElements[4] = series_id;
                            lvElements[5] = series_title_english;
                            lvElements[6] = series_status;
                            lvElements[7] = series_start_date;
                            lvElements[8] = series_end_date;
                            lvElements[9] = series_image;

                            items = new ListViewItem(lvElements);
                            lvAnimeResult.Items.Add(items);
                            lvAnimeResult.EndUpdate();
                        }
                    }
                }
            }
        }        
    }
}

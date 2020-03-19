// /*
// * PROJECT:    Downloader
// * NAME:        Form1.cs
// */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace Downloader
{
    public partial class Form1 : Form
    {
        #region Constructors

        public Form1() { InitializeComponent(); }

        #endregion

        private void btnDownload_Click(object sender, EventArgs e)
        {
            List<string> urlList = new List<string>(
                                                    txtFiles.Text.Split(new[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries));

              WebClient webClient = new WebClient();
 int counter = 0;
            foreach (string url in urlList)
            {
             
                string filename = System.IO.Path.GetFileName(url);

                counter += 1;
                lblStatus.Text = $"Downloading {counter} of {urlList.Count} ... {url}";

                Application.DoEvents();

                // Download the Web resource and save it into the current filesystem folder.
                webClient.DownloadFile(url,System.IO.Path.Combine( txtDestination.Text,filename ));
            }

            MessageBox.Show("Finished");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
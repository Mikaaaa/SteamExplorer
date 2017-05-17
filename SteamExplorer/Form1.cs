using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SteamKit2;
using System.Collections.ObjectModel;

namespace SteamExplorer
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lbltitle.Text = "Loading...";
            LblContent.Text = "";
            System.Threading.Timer timer = null;
            timer = new System.Threading.Timer((obj) =>
            {
                init();
                CbxInit();
                timer.Dispose();
            },
                null, 1000,500);
            

        }
        public void init()
        {
            
            dynamic steamNews = WebAPI.GetInterface("ISteamNews");
            KeyValue kvNews = steamNews.GetNewsForApp(appid: 730); // get news for csgo
                                                                   // the return of every WebAPI call is a KeyValue class that contains the result data

            // for this example we'll iterate the results and display the title
            foreach (KeyValue news in kvNews["newsitems"]["newsitem"].Children)
            {

                Lbltitle.Invoke (new Action(() => Lbltitle.Text = news["title"].AsString()));
                WbContent.Invoke(new Action(() => WbContent.DocumentText = "0"));
                WbContent.Invoke(new Action(() => WbContent.Document.OpenNew(true)));
                WbContent.Invoke(new Action(() => WbContent.DocumentText = news["contents"].AsString()));
                //LblContent.Text = @Html.Raw(news["contents"].AsString());
            }
        }
        public void CbxInit()
        {
            SteamApps.AppChangesCallback steamApps =null;
            /*ReadOnlyCollection<uint> RdOnly = new ReadOnlyCollection<uint>(steamApps.AppIDs);
            for (int i =0;i <= RdOnly.Count;i++) {
                CbxUpdate.Items.Add(RdOnly);
            }*/
        }
    }
}

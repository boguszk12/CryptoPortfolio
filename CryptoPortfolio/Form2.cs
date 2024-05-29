using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CryptoPortfolio
{
    public partial class Form2 : Form
    {
        public Form2()
        {
             
            InitializeComponent();
            populateCoins();
        }
        private void getCoinImage(string url,string id)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile(url, $"coinImages/{id}.png");
            }

        }

        private void populateCoins()
        {
            string apiKey = ConfigurationManager.AppSettings["apiKey"];
            string coinsImagePath = ConfigurationManager.AppSettings["coinsImagePath"];

            CoinGeckoClient client = new CoinGeckoClient();
            client._apiKey = apiKey;

            List<Coin> coins = client.getTopCoins();

            //ListItem[] listItems = new ListItem[20];

            string subPath = "coinImages"; // Your code goes here

            bool exists = System.IO.Directory.Exists(subPath);

            if (!exists)
                System.IO.Directory.CreateDirectory(subPath);

            foreach (Coin coin in coins)
            {
                CoinControl newItem = new CoinControl();

                

                string imagePath = $"{coinsImagePath}/{coin.id}.png";

                if (File.Exists(imagePath))
                {
                    newItem.cImage = System.Drawing.Image.FromFile(imagePath);
                }
                else
                {
                    getCoinImage(coin.image, coin.id);
                    newItem.cImage = System.Drawing.Image.FromFile(imagePath);

                }

                string x = "0.##########################################################################################################################################################################################################################################################";

                newItem.cName = coin.name;
                newItem.cPrice = coin.current_price.ToString(x);
                newItem.cId = coin.id;
                coinLayoutPanel.Controls.Add(newItem);
                
            }


            


        }


    }
}

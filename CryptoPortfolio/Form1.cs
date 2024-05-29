using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.IO;

namespace CryptoPortfolio
{
    public partial class Form1 : Form
    {

        class PortfolioItem
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string ImageUrl { get; set; }
            public decimal Amount { get; set; }
            public string Type { get; set; }
            public decimal Price { get; set; }
            public decimal BsPrice { get; set; }
        }
        static void ReadAllSettings()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (appSettings.Count == 0)
                {
                    Console.WriteLine("AppSettings is empty.");
                }
                else
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        Console.WriteLine("Key: {0} Value: {1}", key, appSettings[key]);
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }
        static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                ConfigurationManager.RefreshSection("appSettings");

            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }

        private CoinGeckoClient CheckGetApiKey()
        {
            string apiKey = ConfigurationManager.AppSettings["apiKey"];

            object value;


            CoinGeckoClient client = new CoinGeckoClient();

            while (apiKey == "")
            {
                value = Interaction.InputBox("Please input your CoinGecko api key.", "Settings", "api_key");
                Debug.WriteLine(value.ToString());

                if ((string) value == "")
                {
                    Environment.Exit(1);

                }

                client._apiKey = value.ToString();


                bool response = client.Authenticate();

                if (response == true)
                {
                    apiKey = value.ToString();
                    AddUpdateAppSettings("apiKey", apiKey);

                }

            }


            client._apiKey = apiKey.ToString();

            Debug.WriteLine(apiKey);
            ReadAllSettings();
            ConfigurationManager.RefreshSection("appSettings");
            return client;


        }
        public Form1()
        {
            InitializeComponent();

            CoinGeckoClient client = CheckGetApiKey();
            refreshView();


        }



        private void addCoin_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private decimal addElement(PortfolioItem item)
        {

            string coinsImagePath = ConfigurationManager.AppSettings["coinsImagePath"];

            PortfolioViewControl newItem = new PortfolioViewControl();



            string imagePath = $"{coinsImagePath}/{item.Id}.png";

 
            newItem.cImage = System.Drawing.Image.FromFile(imagePath);

            string x = "0.##########################################################################################################################################################################################################################################################";

            newItem.cName = item.Name;

            decimal PNL;

            if (item.Type == "BUY")
            {
                PNL = (item.Price - item.BsPrice) * item.Amount;
                newItem.cPercent = Math.Round((100-((item.BsPrice*100)/ item.Price)),1).ToString(x) + "%";
            }
            else
            {
                PNL = (item.BsPrice - item.Price) * item.Amount;
                newItem.cPercent = Math.Round((100 - ((item.Price * 100) / item.BsPrice)), 1).ToString(x) + "%";
            }
            newItem.cPNL = Math.Round(PNL,1).ToString(x);
            newItem.cAmount = Math.Round(item.Amount, 10).ToString(x);
            newItem.cBSPrice = Math.Round(item.BsPrice, 10).ToString(x);
            newItem.cPrice = Math.Round(item.Price, 10).ToString(x);
            newItem.cType = item.Type;
            coinLayoutPanel.Controls.Add(newItem);

            return PNL;
        }


        private void refreshView()
        {


            string connectionString;

            connectionString = ConfigurationManager.ConnectionStrings["CryptoPortfolio.Properties.Settings.mainDatabaseConnectionString"].ConnectionString;


            string query = "SELECT * from portfolio";

            List<PortfolioItem> portfolioItems = new List<PortfolioItem>();


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    DataTable dataTable = new DataTable();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    coinLayoutPanel.Controls.Clear();



                    foreach (DataRow row in dataTable.Rows)
                    {
                        PortfolioItem item = new PortfolioItem
                        {
                            Id = row["Id"].ToString(),
                            Name = row["Name"].ToString(),
                            ImageUrl = row["Image_url"].ToString(),
                            Amount = Convert.ToDecimal(row["Amount"]),
                            Type = row["Type"].ToString(),
                            Price = Convert.ToDecimal(row["Price"]),
                            BsPrice = Convert.ToDecimal(row["BS_price"])
                        };

                        portfolioItems.Add(item);


                        Debug.WriteLine($"ID: {item.Id}, {item.Price}, {item.Type}, {item.Amount}");
                    }
                }





            }

            List<string> ids = portfolioItems.Select(coin => coin.Id).ToList();


            string apiKey = ConfigurationManager.AppSettings["apiKey"];

            CoinGeckoClient client = new CoinGeckoClient();
            client._apiKey = apiKey;

            Dictionary<string, Dictionary<string, decimal>> coins = client.getPrices(ids);

            decimal totalValue = 0;
            decimal tPNL = 0;

            foreach (PortfolioItem item in portfolioItems)
            {
                totalValue += item.Amount*item.Price;
                
                item.Price = coins[item.Id]["usd"];
                if (item.Amount != 0)
                {
                    tPNL += addElement(item);
                }

            }

            portfolioValue.Text = Math.Round(totalValue,0).ToString()+" $";
            totalPNL.Text = Math.Round(tPNL, 0).ToString() + " $";


        }

        private void refreshPortfolio_Click(object sender, EventArgs e)
        {
            refreshView();
        }
    }
}

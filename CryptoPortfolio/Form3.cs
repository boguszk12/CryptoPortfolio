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
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;


namespace CryptoPortfolio
{

    class ExistingItem
    {
        public bool Exists { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
        public decimal BsPrice { get; set; }
    }

    public partial class Form3 : Form
    {

        public string coinId;
        public string imagePath;
        public string coinName;
        public string coinPrice;

        public Form3(string coinId,string coinName, string coinPrice)
        {
            InitializeComponent();

            this.coinId = coinId;
            this.coinName = coinName;
            this.coinPrice = coinPrice.Replace(',', '.');
            string coinsImagePath = ConfigurationManager.AppSettings["coinsImagePath"];
            string imagePath = $"{coinsImagePath}/{coinId}.png";
            this.imagePath = imagePath;

            coinPicture2.Image = System.Drawing.Image.FromFile(imagePath);
            priceBox.Text = this.coinPrice;

        }

        private ExistingItem ifCoinExists()
        {
            string connectionString;

            connectionString = ConfigurationManager.ConnectionStrings["CryptoPortfolio.Properties.Settings.mainDatabaseConnectionString"].ConnectionString;


            string query = "SELECT Amount,Type,BS_price from portfolio WHERE Id = @coinId ";

            ExistingItem item = new ExistingItem
            {
                Exists = false,
                Amount = 0,
                Type = "",
                BsPrice = 0
            };

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@coinId", this.coinId);

                    DataTable dataTable = new DataTable();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }



                    foreach (DataRow row in dataTable.Rows)
                    {
                        item.Exists = true;
                        item.Amount = Convert.ToDecimal(row["Amount"]);
                        item.Type = row["Type"].ToString();
                        item.BsPrice = Convert.ToDecimal(row["BS_price"]);
                       
                        Debug.WriteLine($"{item.Type}, {item.Amount}");

                        


                    }
                }


            }
            return item;

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            
            string amount = amountBox.Text.Replace(',', '.');
            string price = priceBox.Text.Replace(',', '.');
            bool buy = checkBuy.Checked;
            bool sell = checkSell.Checked;
            ExistingItem item = ifCoinExists();




            if (buy == sell)
            {
                MessageBox.Show("You can only select one checkbox, buy or sell.");
            }
            else if (item.Exists == false)
            {
                string transType;

                if (buy == true)
                {
                    transType = "BUY";
                }
                else
                {
                    transType = "SELL";
                }


                string connectionString;

                connectionString = ConfigurationManager.ConnectionStrings["CryptoPortfolio.Properties.Settings.mainDatabaseConnectionString"].ConnectionString;


                string query = "INSERT INTO portfolio VALUES (@coinId, @coinName, @imagePath, @amount, @transType, @price, @coinPrice);";


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        Debug.WriteLine($"{this.coinName}, {amount}, {price}, {this.coinPrice}");

                        try
                        {
                            connection.Open();

                            command.Parameters.AddWithValue("@coinId", this.coinId);
                            command.Parameters.AddWithValue("@coinName", this.coinName);
                            command.Parameters.AddWithValue("@imagePath", this.imagePath);
                            command.Parameters.AddWithValue("@amount", amount);
                            command.Parameters.AddWithValue("@transType", transType);
                            command.Parameters.AddWithValue("@price", this.coinPrice);
                            command.Parameters.AddWithValue("@coinPrice", price);
                            int rowsAffected = command.ExecuteNonQuery();

                            Console.WriteLine("Rows affected: " + rowsAffected);
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine("An error occurred: " + ex.Message);
                        }

                    }

                    


                }

               
                

                this.Close();
            }
            else
            {
                
                

                




                string transType;
                decimal remaining;
                decimal averageBuyValue;

                if (buy == true)
                {
                    if (item.Type == "BUY"){
                        decimal totalAmount = item.Amount + decimal.Parse(amount);
                        decimal totalCost = item.BsPrice + decimal.Parse(price);
                        averageBuyValue = totalCost / totalAmount;
                        remaining = totalAmount;

                    }
                    else
                    {
                        remaining = item.Amount - decimal.Parse(amount);
                        decimal costpercoin = item.BsPrice / item.Amount;

                        decimal remainingcost = item.BsPrice - (costpercoin * decimal.Parse(amount));
                        averageBuyValue = remainingcost / remaining;

                    }
                    

                }
                else
                {
                    if (item.Type == "BUY")
                    {

                        remaining = item.Amount - decimal.Parse(amount);

                        averageBuyValue = item.BsPrice;

                    }
                    else
                    {
                        decimal totalAmount = item.Amount + decimal.Parse(amount);
                        decimal totalCost = item.BsPrice + decimal.Parse(price);
                        averageBuyValue = totalCost / totalAmount;
                        remaining = totalAmount;

                    }


                }

                if (item.Type == "SELL" && buy == false)
                {
                    transType = "SELL";
                }
                else if (item.Type == "BUY" && buy == true)
                {
                    transType = "BUY";
                }
                else if (item.Type == "BUY" && buy == false)
                {
                    if (item.Amount >= decimal.Parse(amount))
                    {
                        transType = "BUY";
                    }
                    else
                    {
                        transType = "SELL";
                    }

                }
                else 
                {
                    if (item.Amount >= decimal.Parse(amount))
                    {
                        transType = "SELL";

                    }
                    else
                    {
                        transType = "BUY";
                    }

                }

                string connectionString;

                connectionString = ConfigurationManager.ConnectionStrings["CryptoPortfolio.Properties.Settings.mainDatabaseConnectionString"].ConnectionString;


                string query = "UPDATE portfolio SET Amount = @amount, Type = @transType, Price = @price, BS_price = @coinPrice WHERE Id = @coinId;";


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        Debug.WriteLine($"{this.coinName}, {amount}, {price}, {this.coinPrice}");

                        try
                        {
                            connection.Open();

                            command.Parameters.AddWithValue("@coinId", this.coinId);
                            command.Parameters.AddWithValue("@amount", remaining);
                            command.Parameters.AddWithValue("@transType", transType);
                            command.Parameters.AddWithValue("@price", this.coinPrice);
                            command.Parameters.AddWithValue("@coinPrice", averageBuyValue);
                            int rowsAffected = command.ExecuteNonQuery();

                            Console.WriteLine("Rows affected: " + rowsAffected);
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine("An error occurred: " + ex.Message);
                        }

                    }




                }




                this.Close();
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoPortfolio
{
    public partial class CoinControl : UserControl
    {

        public CoinControl()
        {
            InitializeComponent();
        }


        #region Properties

        private string _name;
        private string _price;
        private string _id;
        private Image _image;

        [Category("Coin Props")]
        public string cId
        {
            get { return _id; }
            set { _id = value; coinId.Text = value; }
        }

        [Category("Coin Props")]
        public string cName
        {
            get { return _name;  }
            set { _name = value; coinName.Text = value; }
        }

        [Category("Coin Props")]
        public string cPrice
        {
            get { return _price; }
            set { _price = value; coinPrice.Text = value; }
        }

        [Category("Coin Props")]
        public Image cImage
        {
            get { return _image; }
            set { _image = value; coinPicture.Image = value; }
        }

        #endregion

        private void controlSelectBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                Debug.WriteLine(button);

                UserControl parentControl = button.Parent as UserControl;

                Label coinIdLabel = parentControl.Controls.Find("coinId", true).FirstOrDefault() as Label;
                Label coinNameLabel = parentControl.Controls.Find("coinName", true).FirstOrDefault() as Label;
                Label coinPriceLabel = parentControl.Controls.Find("coinPrice", true).FirstOrDefault() as Label;

                string coinId = coinIdLabel.Text;
                string coinName = coinNameLabel.Text;
                string coinPrice = coinPriceLabel.Text;
                parentControl.BackColor = Color.LightBlue;


                Debug.WriteLine(coinId);

                
                parentControl.BackColor = Color.LightBlue;
                Form3 f3 = new Form3(coinId, coinName, coinPrice);
                f3.ShowDialog();
                
                parentControl.BackColor = SystemColors.Control;


                



            }
        }
    }
}

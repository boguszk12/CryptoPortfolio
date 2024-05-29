using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoPortfolio
{
    public partial class PortfolioViewControl : UserControl
    {
        public PortfolioViewControl()
        {
            InitializeComponent();
        }

        #region Properties

        private string _name;
        private string _price;
        private Image _image;
        private string _type;
        private string _bsprice;
        private string _amount;
        private string _pnl;
        private string _percent;

        [Category("Coin Props")]
        public string cName
        {
            get { return _name; }
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

        [Category("Coin Props")]
        public string cType
        {
            get { return _type; }
            set { _type = value; coinType.Text = value; }
        }

        [Category("Coin Props")]
        public string cBSPrice
        {
            get { return _bsprice; }
            set { _bsprice = value; coinBSPrice.Text = value; }
        }

        [Category("Coin Props")]
        public string cAmount
        {
            get { return _amount; }
            set { _amount = value; coinAmount.Text = value; }
        }

        [Category("Coin Props")]
        public string cPNL
        {
            get { return _pnl; }
            set { _pnl = value; coinPNL.Text = value; }
        }

        [Category("Coin Props")]
        public string cPercent
        {
            get { return _percent; }
            set { _percent = value; coinPercent.Text = value; }
        }


        #endregion
    }
}

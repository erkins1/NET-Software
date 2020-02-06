using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MegaDesk_Rogers
{
    public partial class ViewQuotes : Form
    {
        public ViewQuotes()
        {
            InitializeComponent();
            loadGrid();
            
        }

        private void loadGrid()
        {

            var quotesFile = "quotes.json";

            string json = File.ReadAllText(@quotesFile);

            List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);

            dtblViewQuotes.DataSource = deskQuotes.Select(d => new
                {
                    Date = d.Date,
                    Customer = d.CustomerName,
                    Depth = d.Depth,
                    Width = d.Width,
                    Drawers = d.NumDrawers,
                    SurfaceMaterial = d.MaterialType,
                    DeliveryType = d.ShippingDays,
                    QuoteAmount = d.GetQuotePrice().ToString("c")
                }).ToList();
            }

        private void ViewQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }
    }
    }

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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();

            //Puts the desktop material types in the combo box
            List<Desk.DesktopMaterial> materialTypes =
                Enum.GetValues(typeof(Desk.DesktopMaterial))
                    .Cast<Desk.DesktopMaterial>().ToList();
            cmbSearchMaterial.DataSource = materialTypes;
            cmbSearchMaterial.SelectedIndex = -1;

            loadGrid();
        }

        private void cmbSearchMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

              ComboBox search = (ComboBox)sender;

              if (search.SelectedIndex < 0)
              {
                  // Renew Grid
                  loadGrid();
              }
              else
              {
                  // Use value to search
                  loadGrid((Desk.DesktopMaterial)search.SelectedValue);
              }
          }

        private void loadGrid()
        {

            var quotesFile = "quotes.json";

            string json = File.ReadAllText(@quotesFile);

            List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);

            dtblSearchQuotes.DataSource = deskQuotes.Select(d => new
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

        private void loadGrid(Desk.DesktopMaterial desktopMaterial)
        {

            var quotesFile = "quotes.json";

            string json = File.ReadAllText(@quotesFile);

            List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);

            dtblSearchQuotes.DataSource = deskQuotes.Select(d => new
            {
                Date = d.Date,
                Customer = d.CustomerName,
                Depth = d.Depth,
                Width = d.Width,
                Drawers = d.NumDrawers,
                SurfaceMaterial = d.MaterialType,
                DeliveryType = d.ShippingDays,
                QuoteAmount = d.GetQuotePrice().ToString("c")
            }).Where(q => q.SurfaceMaterial == desktopMaterial).ToList();
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)Tag).Show();
        }

        private void clearSearch_Click(object sender, EventArgs e)
        {
            cmbSearchMaterial.SelectedIndex = -1;
        }
    }
    }

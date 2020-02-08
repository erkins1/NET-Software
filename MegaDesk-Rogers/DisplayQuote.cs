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
using Newtonsoft.Json;

namespace MegaDesk_Rogers
{
    public partial class DisplayQuote : Form
    {
        public DeskQuote currQuote = new DeskQuote();
        private Form MainMenuTag;

        public DisplayQuote(Form pForm)
        {
            InitializeComponent();

            this.MainMenuTag = pForm;

            //Puts the desktop material types in the combo box
            List<Desk.DesktopMaterial> materialTypes =
                Enum.GetValues(typeof(Desk.DesktopMaterial))
                    .Cast<Desk.DesktopMaterial>().ToList();
            cmbMaterialType.DataSource = materialTypes;
            cmbMaterialType.SelectedIndex = -1;

            //Puts the available shipping speeds in the combo box
            List<DeskQuote.ShippingDay> shippingSpeeds =
                Enum.GetValues(typeof(DeskQuote.ShippingDay))
                    .Cast<DeskQuote.ShippingDay>().ToList();
            cmbShipping.DataSource = shippingSpeeds;
            cmbShipping.SelectedIndex = -1;
        }

        private void DisplayQuote_Shown(object sender, EventArgs e)
        {
            fillForm();
        }
        private void fillForm()
        {
            txtCustName.Text = currQuote.CustomerName;
            numWidth.Value = currQuote.Width;
            numDepth.Value = currQuote.Depth;
            numDrawers.Value = currQuote.NumDrawers;
            cmbMaterialType.SelectedItem = (DeskQuote.DesktopMaterial)currQuote.MaterialType;
            cmbShipping.SelectedItem = (DeskQuote.ShippingDay)currQuote.ShippingDays;
            lblQuote.Text = currQuote.GetQuotePrice().ToString("c");
            //Console.WriteLine(currQuote.CustomerName);
        }

        private void saveQuote()
        {
            try
            {
                //Add the date to the currQuote object
                currQuote.Date = DateTime.Now;

                string path = "quotes.json";
                //create variable for the list of DeskQuotes
                var quotes = new List<DeskQuote>();
                if (File.Exists(@path))         //Loads the file
                {
                    //read the file into a variable
                    string json = File.ReadAllText(@path);
                    //deserialize the json into a list of DeskQuotes
                    quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
                }

                //add the new quote to the list of DeskQuotes
                quotes.Add(currQuote);
                //serialize the list of DeskQuotes to a JObject
                string jsonQuotes = JsonConvert.SerializeObject(quotes);
                //save the JObject to the quotes.json file
                File.WriteAllText(@path, jsonQuotes);

                closeToMain();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("There was an error loading or saving this quote", "Error", MessageBoxButtons.OK);
            }
        }

        //Click and close events
        private void btnSaveQuote_Click(object sender, EventArgs e)
        {
            saveQuote();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeToMain()
        {
            Close();
            ((Form)Tag).Close();
            MainMenuTag.Show();
        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)Tag).Show();
        }
    }
}

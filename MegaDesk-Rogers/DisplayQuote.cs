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
         
        
        public DisplayQuote()
        {
            InitializeComponent();
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
            //Add the date to the currQuote object
            currQuote.Date = DateTime.Now;

            string path = "quotes.json";
            //create variable for the list of DeskQuotes
            var quotes = new List<DeskQuote>();
            if (!File.Exists(@path))
            {
                //create file? If I don't need any code here, then this is just a single if to load the file into the list if it exists
            }
            else    //Loads the file
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

            closeThisForm();
        }

        //This will either be called from save quote or everytime a value changes
        /*
        private void updateQuote()  
        {
            currQuote.CustomerName = txtCustName.Text;
            currQuote.Width = numWidth.Value;
            currQuote.Depth = numDepth.Value;
            currQuote.NumDrawers = numDrawers.Value;
            currQuote.MaterialType = (DeskQuote.DesktopMaterial)cmbMaterialType.SelectedItem;
            currQuote.ShippingDays = (DeskQuote.ShippingDay)cmbShipping.SelectedItem;
        }*/

        private void btnSaveQuote_Click(object sender, EventArgs e)
        {
            saveQuote();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            closeThisForm();
        }

        private void DisplayQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeThisForm();
        }

        private void closeThisForm()
        {
            var mainMenuForm = new MainMenu();
            mainMenuForm.Show();
            Hide();
        }
    }
}

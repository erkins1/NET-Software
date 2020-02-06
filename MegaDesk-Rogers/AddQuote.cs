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
    public partial class AddQuote : Form
    {
          

        public AddQuote()
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

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            closeThisForm();
        }
        
        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeThisForm();
        }
        private void closeThisForm()
        {
            var mainMenuForm = new MainMenu();
            mainMenuForm.Show();
            Hide();
        }

        //public DeskQuote newQuote = new DeskQuote();

        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            //try
            //{
                //Get all the variables from the form and add to the DeskQuote object
                DeskQuote newQuote = new DeskQuote();
                newQuote.CustomerName = txtCustName.Text;
                newQuote.Width = numWidth.Value;
                newQuote.Depth = numDepth.Value;
                newQuote.NumDrawers = numDrawers.Value;
                newQuote.MaterialType = (DeskQuote.DesktopMaterial)cmbMaterialType.SelectedItem;
                newQuote.ShippingDays = (DeskQuote.ShippingDay)cmbShipping.SelectedItem;

                //call the saveQuotes method and pass the new deskQuote object
                //saveQuote(newQuote);
                //Open the display quote form? Or is this supposed to be saved as a result of viewing the quote?
                
                var displayQuoteForm = new DisplayQuote();
                displayQuoteForm.currQuote = newQuote;
                displayQuoteForm.Show();
                Hide();
            
            /*
            }
            catch (Exception ex)
            {
                //catch to make sure that all the fields are filled in
                Console.WriteLine("ERROR");
                Console.WriteLine(ex.Message);
            }*/
            

        }

        


        private void enableAddQuote()
        {   //Enables the Add Quote button only when all the fields are filled out correctly
            if (txtCustName.Text != "" && cmbMaterialType.SelectedIndex >= 0 && cmbShipping.SelectedIndex >= 0)
            {
                btnAddQuote.Enabled = true;
            }
        }
        private void txtCustName_TextChanged(object sender, EventArgs e)
        {
            enableAddQuote();
        }

        private void cmbMaterialType_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableAddQuote();
        }

        private void cmbShipping_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableAddQuote();
        }
    }
}

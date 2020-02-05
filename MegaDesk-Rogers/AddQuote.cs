using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnAddQuote_Click(object sender, EventArgs e)
        {

        }

        private void SaveQuote(List<DeskQuote> quotes)
        {

        }
    }
}

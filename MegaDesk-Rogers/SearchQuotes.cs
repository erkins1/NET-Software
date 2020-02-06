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
        }
        
        private void cmbSearchMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          /*  ComboBox search = (ComboBox)sender;

            if (search.SelectedIndex < 0)
            {
                // Renew Grid
                loadGrid();
            }
            else
            {
                // Use value to search
 //               loadGrid((Desk.DesktopMaterial)search.SelectedValue);
            }
        } 
        */
        
    }
}

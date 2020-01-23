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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }


        private void btnOpenAddQuote_Click(object sender, EventArgs e)
        {
            //This opens the new form
            var addNewQuoteForm = new AddQuote();
            //Tag this object so that it can open when another window is opened
            addNewQuoteForm.Show();
            Hide();
        }
    }
}

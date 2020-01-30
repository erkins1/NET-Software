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
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show();
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            Application.Exit();
        }

        private void btnOpenViewQuotes_Click(object sender, EventArgs e)
        {
            //This opens the new form
            var viewQuotesForm = new ViewQuotes();
            //Tag this object so that it can open when another window is opened
            viewQuotesForm.Tag = this;
            viewQuotesForm.Show();
            Hide();
        }

        private void btnOpenSearchQuotes_Click(object sender, EventArgs e)
        {
            //This opens the new form
            var searchQuotesForm = new SearchQuotes();
            //Tag this object so that it can open when another window is opened
            searchQuotesForm.Tag = this;
            searchQuotesForm.Show();
            Hide();
        }
    }
}

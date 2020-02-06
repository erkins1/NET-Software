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
    public partial class DisplayQuote : Form
    {
        public DisplayQuote newQuote;
        public AddQuote addQuoteFrm;
        public DisplayQuote()
        {
            InitializeComponent();
            fillForm();
        }

        private void fillForm()
        {

            lblQuote.Text = ((AddQuote)addQuoteFrm).newQuote.GetQuotePrice().ToString("c");
        }
        
        


    }
}

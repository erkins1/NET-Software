using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;



namespace sandbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fillViewQuotes();
            fileToArray();
        }
        
        private void fillViewQuotes()
        {

            string json = File.ReadAllText("C:\\Users\\Geoffrey\\OneDrive\\BYU-I\\CIT 365 .NET Software\\NET-Software\\sandbox\\bin\\Debug\\Example.JSON");
            //Console.WriteLine(json);

            JArray exampleJS = JArray.Parse(json);

            dtblViewQuotes.DataSource = exampleJS.Select(js => new
            {
                Color = (string)js["color"],
                Category = (string)js["category"],
                RGBA = (string)js["code"]["rgba"],
                Hex = (string)js["code"]["hex"]
            }).ToList();
        }


        private void fileToArray()
        {

            //int[,] prices = new int[2, 2];
            /*int [][] readArray = File.ReadAllLines("C:\\Users\\Geoffrey\\OneDrive\\BYU-I\\CIT 365 .NET Software\\NET-Software\\sandbox\\bin\\Debug\\rushOrderPrices.txt")
                .Select(l => l.Split(' ').Select(i => int.Parse(i)).ToArray())
                   .ToArray();
                   */

            string[] file = File.ReadLines("C:\\Users\\Geoffrey\\OneDrive\\BYU-I\\CIT 365 .NET Software\\NET-Software\\sandbox\\bin\\Debug\\rushOrderPrices.txt").ToArray();

            decimal[,] prices = new decimal[3,3];
            int x = 0;
            int y = 0;
            for (int z = 0; z < file.Length; z++)
            {
                prices[y,x] = Convert.ToDecimal(file[z]);

                x++;
                if (x == 3)
                {
                    x = 0;
                    y++;
                }
                    
            }


            Console.WriteLine(prices.ToString());

        }




        private void fillCMB()
        {
            List<CMBFill.testList> materialTypes =
                Enum.GetValues(typeof(CMBFill.testList))
                    .Cast<CMBFill.testList>().ToList();
            //List<string> materialTypes = new CMBFill.testList;
            cmbTest.DataSource = materialTypes;
            cmbTest.SelectedIndex = -1;
        }

        public class CMBFill
        {
            public enum testList
            {
                aOak,
                aLaminate,
                aPine,
                aRosewood,
                aVeneer
            }

            public List<string> testLst = new List<string>
        {
            "carrot",
            "fox",
            "explorer"
        };


        }



    }
}

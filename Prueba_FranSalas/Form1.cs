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


namespace Prueba_FranSalas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("C:/Users/franc/PROGRAMACION/Test.txt.txt");
                //Write a line of text
                sw.WriteLine(DateTime.UtcNow + " " + hola1.Text);
                //Close the file
                sw.Close();
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
            













using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassesAndObjectProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //contstructor for LaptopSpecification class.

            LaptopSpecification MyLaptop = new LaptopSpecification();
            MessageBox.Show(MyLaptop.Summary("Acer", "Nvidia 2GB", "Cross 2GB", true, "LCD",
                "Dolby Digital", "Quad Core 2.3 GHZ"));
        }
    }
}

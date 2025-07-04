using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plate_weight
{
    public partial class Form1 : Form
    {
        double PlateThickness { get; set; }
        double PlateWidth { get; set; }
        double PlateLength { get; set; }
        double PlateWeight { get; set; }
        string IsInches { get; set; }
        double PlateDensity { get; set; }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsInches = "yes";
            button2.BackColor = Color.FromArgb(0, 122, 204);
            PlateDensity = .2836;
        }

        private void Button3_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Button2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void TextBox1_Enter(object sender, EventArgs e) //thickness textbox
        {
            textBox1.Text = "";
        }

        private void TextBox2_Enter(object sender, EventArgs e) //width textbox
        {
            textBox2.Text = "";
        }

        private void TextBox3_Enter(object sender, EventArgs e) //length textbox
        {
            textBox3.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e) //inches button click
        {
            IsInches = "yes";
            button2.BackColor = Color.FromArgb(0, 122, 204);
            button1.BackColor = Color.FromArgb(0, 64, 64);
        }

        private void Button1_Click(object sender, EventArgs e) //mm button click
        {
            IsInches = "no";
            button1.BackColor = Color.FromArgb(0, 122, 204);
            button2.BackColor = Color.FromArgb(0, 64, 64);
        }

        private void Button3_Click(object sender, EventArgs e) //calculate button click
        {
            if (textBox1.Text == "" || textBox2.Text =="" || textBox3.Text =="")
            {
                MessageBox.Show("Cannot calculate.  Missing data.");
            }
            else
            {
                if(IsInches == "yes")
                {
                    PlateThickness = Convert.ToDouble(textBox1.Text);
                    PlateWidth = Convert.ToDouble(textBox2.Text);
                    PlateLength = Convert.ToDouble(textBox3.Text);
                    PlateWeight = Convert.ToInt32(PlateThickness * PlateWidth * PlateLength * PlateDensity);
                    textBox4.Text = PlateWeight.ToString();
                }
                else if (IsInches == "no")
                {
                    PlateThickness = Convert.ToDouble(textBox1.Text)/25.4;
                    PlateWidth = Convert.ToDouble(textBox2.Text);
                    PlateLength = Convert.ToDouble(textBox3.Text);
                    PlateWeight = Convert.ToInt32(PlateThickness * PlateWidth * PlateLength * PlateDensity);
                    textBox4.Text = PlateWeight.ToString();
                }
            }
        }
    }
}

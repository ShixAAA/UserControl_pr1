using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UserControl_pr1.FolderforModel;

namespace UserControl_pr1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public void Fill(Table_Motorbike Motorbike) 
        {
            labellDData.Text = Motorbike.ID.ToString();
            labelModelData.Text = Motorbike.Model;
            labelBrandData.Text= Motorbike.Brand;
            labelPriceData.Text= Motorbike.Price.ToString();
            labelHorsepowerData.Text = Motorbike.Hersepower.ToString();
            labelMileageData.Text = Motorbike.Mileage.ToString();
            pictureBoxMotorbike.Image = Image.FromFile($@"Pictures\{Motorbike.Picture}");
        }    
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}

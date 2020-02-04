using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;
namespace USTA
{
    public partial class Form1 : Form
    {
        readonly FlightControl temp;
        readonly List<Flight> flightList;
        public Form1()
        {
            InitializeComponent();

            String filename = "";

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

               
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               filename  = openFileDialog1.FileName;
            }





            temp = new FlightControl();

            gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new GMap.NET.PointLatLng(37.0902, -95.7129 );
            gmap.ShowCenter = false;


              flightList = temp.ReadDataBase(filename);
            

            dgvAirView.DataSource = flightList;
           
   
    }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gmap_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            String result = comboBox1.Text;
            switch (result)
            {
                case "Origin City":
                    dgvAirView.DataSource = temp.SearchByOrigin(flightList, txbAnswer.Text);
                break;

                case "Destination City":
                    dgvAirView.DataSource = temp.SearchByDestination(flightList, txbAnswer.Text);
                    break;

                case "Airplane ID":
                    dgvAirView.DataSource = temp.SearchByTailNum(flightList, txbAnswer.Text);
                    break;

                case "Flight Duration":
                    double answer = Convert.ToDouble(txbAnswer.Text);
                    dgvAirView.DataSource = temp.SearchByDuration(flightList, answer);
                    break;

                case "Flight Distance":
                    double answer1 = Convert.ToDouble(txbAnswer.Text);
                    dgvAirView.DataSource = temp.SearchByDistance(flightList, answer1);
                    break;
                   
            }
        }
    }
}

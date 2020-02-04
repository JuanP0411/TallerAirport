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
        public Form1()
        {
            InitializeComponent();
             

            gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new GMap.NET.PointLatLng(37.0902, -95.7129 );
            gmap.ShowCenter = false;


           List<Flight> flightList = new List<Flight>();
            flightList.Add(new Flight("Dimelo","Socio",69,420,"Treyway"));
            dgvAirView.DataSource = flightList;
    }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}

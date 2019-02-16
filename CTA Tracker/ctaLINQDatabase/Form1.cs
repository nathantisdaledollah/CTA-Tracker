using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ctaLINQDatabase
{
    public partial class Form1 : Form
    {
        private CTADataContext m_CTA;
        string msg;

        public Form1()
        {
            InitializeComponent();

            m_CTA = new CTADataContext();

            //station list
            var stationListQuery = from colors in m_CTA.Lines 
                        join id in m_CTA.StopDetails on colors.LineID equals id.LineID 
                        join names in m_CTA.Stops on id.StopID equals names.StopID
                        join station in m_CTA.Stations on names.StationID equals station.StationID
                        orderby names.Name ascending
                        select new {Name = station.Name };

            foreach (var colors in stationListQuery)
            {
                msg = String.Format("{0}", colors.Name);
                stationListBox.Items.Add(msg);
            }
        }

        private void ridershipBox_Click(object sender, EventArgs e)
        {

        }

        private void stationStopsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            accessLabel2.Text = "";
            travelLabel2.Text = "";
            locationLabel2.Text = "";

            //station stops
            string station = stationListBox.SelectedItem.ToString();

            //Handicap accessible
            var accessibleQuery = from stats in m_CTA.Stations
                                  join access in m_CTA.Stops on stats.StationID equals access.StationID
                                  where String.Equals(stats.Name, station)
                                  select new { accessState = access.ADA };

            foreach (var stats in accessibleQuery)
            {
                if (stats.accessState == true)
                {
                    accessLabel2.Text = "Yes";
                }
                else if (stats.accessState == false)
                {
                    accessLabel2.Text = "No";
                }
            }

            //direction of travel
            var travelQuery = from stops in m_CTA.Stations
                              join access in m_CTA.Stops on stops.StationID equals access.StationID
                              where String.Equals(stops.Name, station)
                              select new { Direction = access.Direction };

            foreach (var stops in travelQuery)
            {
                travelLabel2.Text = stops.Direction.ToString();
            }

            //location of station
            var locationQuery = from stations in m_CTA.Stations
                                join access in m_CTA.Stops on stations.StationID equals access.StationID
                                where String.Equals(stations.Name, station)
                                select new { Lat = access.Latitude, Long = access.Longitude };

            foreach (var stations in locationQuery)
            {
                msg = String.Format("({0}, {1})", stations.Lat, stations.Long);
                locationLabel2.Text = msg;
            }

        }

        private void stationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            stationStopsBox.Items.Clear();
            ridershipNumberLabel.Text = "";
            accessLabel2.Text = "";
            travelLabel2.Text = "";
            locationLabel2.Text = "";

            //station stops
            string station = stationListBox.SelectedItem.ToString();

            var stationStopQuery = from stationName in m_CTA.Stations
                                   join stops in m_CTA.Stops on stationName.StationID equals stops.StationID
                                   where String.Equals(stationName.Name, station)
                                   orderby stops.Name ascending
                                   select new { stopNames = stops.Name};

            foreach (var stationName in stationStopQuery)
            {
                msg = String.Format("{0}", stationName.stopNames);
                stationStopsBox.Items.Add(msg);
            }


            //ridership total
            var ridershipQuery = from stations in m_CTA.Stations
                                 join riderships in m_CTA.Riderships on stations.StationID equals riderships.StationID
                                 where String.Equals(stations.Name, station)
                                 select new { RidershipNumber = riderships.DailyTotal };

            int ridershipTotal = 0;

            foreach (var stations in ridershipQuery)
            {
                ridershipTotal += stations.RidershipNumber;
            }

            msg = String.Format("{0:#,##0.##}", ridershipTotal);
            ridershipNumberLabel.Text = msg;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                int station = System.Convert.ToInt32(stationTextBox.Text);

                var searchQuery = from stations in m_CTA.Stops
                                  join stat in m_CTA.Stations on stations.StationID equals stat.StationID
                                  where stations.StationID == station
                                  select new { nameGiven = stat.Name, station = stations.StationID };

                int inside = 0;

                foreach (var stations in searchQuery)
                {
                    inside++;
                }

                if (inside > 0)
                {
                    MessageBox.Show("Station found!");
                }
                else
                {
                    MessageBox.Show("Station not found.");
                }
            }
            catch
            {
                MessageBox.Show("Station not found.");
            }
        }
    }
}

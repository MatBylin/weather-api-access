using Newtonsoft.Json;
using RestSharp;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WeatherRestApi;

namespace UserInterface
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeFields();
            GetCurrentWeather();
            ShowCurrentWeather();
            ShowImage();
        }

        /////////////////////////////////
        //       Current Weather       //
        /////////////////////////////////
        #region CurrentWeather

        CurrentWeatherData data;

        private void GetCurrentWeather()
        {
            string weather_request =
                "http://api.openweathermap.org/data/2.5/weather?q="
                + ComboCity.Text
                + "&units=metric&APPID=ea476663b316d6c0007c1bcce2703954";

            data = GetWeatherData.GetCurrentWeatherData(weather_request);
        }
        
        private void ShowCurrentWeather()
        {
            LabelTemp.Text = (Math.Round(data.main.temp, 0)) + "˚C";
            LabelCity.Text = data.name;
            LabelWind.Text = ConvertClass.MPerSecToKmPerHour(data.wind.speed) + "km/h";

        }

        private void ShowImage()
        {
            string iconUrl = WeatherIcons.GetCurrentIcon(data.weather[0].icon);
            PictureWeather.ImageLocation = iconUrl;
        }

        private void FillListView()
        {
            ListData.Items.Add(new ListViewItem(new[] { "1", "2", "3", "4", "5" }));
            ListData.Items.Add(new ListViewItem(new[] { "1", "2", "3", "4", "5" }));
            ListData.Items.Add(new ListViewItem(new[] { "1", "2", "3", "4", "5" }));
            ListData.Items.Add(new ListViewItem(new[] { "1", "2", "3", "4", "5" }));

        }
        #endregion

        /////////////////////////////////
        //     Initialize Fields       //
        /////////////////////////////////
        #region InitializeFields
        private void InitializeFields()
        {
            ComboCity.SelectedItem = "Gdańsk";
        }
        #endregion

        /////////////////////////////////
        //   Moving window by dragging //
        //   top panel MainPanel       //
        /////////////////////////////////
        #region MainPanel
        Point lastPoint;

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        #endregion

        //////////////////////////////////
        //  Handling MainPanel buttons  //
        //////////////////////////////////
        #region MainPanelButtons
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void ComboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCurrentWeather();
            ShowCurrentWeather();
            ShowImage();
        }


        #region comments
        //public PointF WorldToTilePos(double lon, double lat, int zoom)
        //{
        //    PointF p = new Point();
        //    p.X = (float)((lon + 180.0) / 360.0 * (1 << zoom));
        //    p.Y = (float)((1.0 - Math.Log(Math.Tan(lat * Math.PI / 180.0) +
        //        1.0 / Math.Cos(lat * Math.PI / 180.0)) / Math.PI) / 2.0 * (1 << zoom));

        //    return p;
        //}

        //private void LoadCurrentWeatherMap(CurrentWeatherData data)
        //{
        //    double lon = data.coord.lon;
        //    double lat = data.coord.lat;
        //    PointF p = WorldToTilePos(lon, lat, 5);
        //    double x = p.X;
        //    double y = p.Y;
        //    string map_request =
        //        "https://tile.openweathermap.org/map/temp_new/1/1.5/1.png?appid=ea476663b316d6c0007c1bcce2703954";
        //        //+ "30/30/30.png"
        //        //+ "&units=metric&APPID=ea476663b316d6c0007c1bcce2703954";

        //    PictureMap.ImageLocation = map_request;
        //}
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            FillListView();
        }
    }
}

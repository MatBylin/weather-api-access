using System;
using System.Drawing;
using System.Windows.Forms;
using WeatherRestApi;
using WeatherRestApi.FiveDayWeather;

namespace UserInterface
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeFields();
        }

        /////////////////////////////////
        //       Current Weather       //
        /////////////////////////////////
        #region CurrentWeather

        CurrentWeatherData currentData;

        private void GetCurrentWeather()
        {
            string weather_request =
                "http://api.openweathermap.org/data/2.5/weather?q="
                + ComboCity.Text
                + "&units=metric&APPID=ea476663b316d6c0007c1bcce2703954";

            currentData = GetWeatherData.GetCurrentWeatherData(weather_request);
        }
        
        private void ShowCurrentWeather()
        {
            LabelTemp.Text = (Math.Round(currentData.main.temp, 0)) + "˚C";
            LabelCity.Text = currentData.name;
            LabelWind.Text = ConvertClass.MPerSecToKmPerHour(currentData.wind.speed) + "km/h";
        }

        private void ShowImage()
        {
            string iconUrl = WeatherIcons.GetCurrentIcon(currentData.weather[0].icon);
            PictureWeather.ImageLocation = iconUrl;
        }
        #endregion

        /////////////////////////////////
        //      Five  Day Weather      //
        /////////////////////////////////
        #region FiveDayWeather
        FiveDayWeatherData fiveDayData;

        private void GetThreeDayWeather()
        {
            string weather_request =
                "http://api.openweathermap.org/data/2.5/forecast?q="
                + ComboCity.Text
                + "&mode=json&units=metric&APPID=ea476663b316d6c0007c1bcce2703954";

            fiveDayData = GetWeatherData.GetFiveDayWeatherData(weather_request);
        }

        private void FillListView()
        {
            foreach (var i in fiveDayData.list)
            {
                ListData.Items.Add(new ListViewItem(new[] {
                    i.dt_txt,
                    i.main.temp.ToString("0.0"),
                    i.wind.speed.ToString("0.0"),
                    i.main.pressure.ToString("0.0"),
                    i.weather[0].description}));
            }
        }

        private void ClearListView()
        {
            ListData.Items.Clear();
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

        //////////////////////////////////
        //  Main ComboBox with Cities   //
        //////////////////////////////////
        private void ComboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetCurrentWeather();
                ShowCurrentWeather();
                ShowImage();
                GetThreeDayWeather();
                ClearListView();
                FillListView();
            }
            catch
            {
                MessageBox.Show("Nastąpił niespodziewany wyjątek aplikacji!", "Błąd");
            }
            
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
    }
}

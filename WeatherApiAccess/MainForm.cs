using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Windows.Forms;
using WeatherRestApi;

namespace UserInterface
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            GetCurrentWeather();
        }


        private void GetCurrentWeather()
        {
            string weather_request =
                "http://api.openweathermap.org/data/2.5/weather?q="
                + "Radom"
                + "&units=metric&APPID=ea476663b316d6c0007c1bcce2703954";

            string result = WeatherRestApi.Request.GetResponse(weather_request);

            CurrentWeatherData data = JsonConvert.DeserializeObject<CurrentWeatherData>(result);

            LabelTemp.Text = (Math.Round(data.main.temp, 0)) + "˚C";
            LabelCity.Text = data.name;
        }



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
    }
}

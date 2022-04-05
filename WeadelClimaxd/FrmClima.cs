using Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WeadelClimaxd
{
    public partial class FrmClima : Form
    {
        public FrmClima()
        {
            InitializeComponent();
        }

        string APIKey = "498e4fc3fddeb027b3363fcfc0b77921";
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                getWeather();
            }
            catch
            {
                if (txtClima.Text == String.Empty)
                {
                    MessageBox.Show("Escriba una ciudad");
                }
            }
        }
        public void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", txtClima.Text, APIKey);
                var json = web.DownloadString(url);
                root Info = JsonConvert.DeserializeObject<root>(json);
                picWeather.ImageLocation = "https://openweathermap.org/img/w/"+ Info.weather[0].icon+".png";
                labelCd.Text = Info.weather[0].main;
                laberDt.Text = Info.weather[0].description;
                labelSun.Text = Info.sys.sunset.ToString();
                labelSn.Text = Info.sys.sunrise.ToString();
                labelWn.Text = Info.wind.speed.ToString();
                labelPress.Text = Info.main.pressure.ToString();

            }

        }

        private void FrmClima_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void TxtClima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No puede agregar numeros");
            }
        }
    }
}

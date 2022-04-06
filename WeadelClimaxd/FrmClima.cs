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
using System.Runtime.InteropServices;
using Infraestructure.Transparencia;

namespace WeadelClimaxd
{
    public partial class FrmClima : Form
    {
        public FrmClima()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //BackColor = Color.Azure;
            
            //TransparencyKey = Color.Azure;
            InitializeComponent();

        }
     
       
        string APIKey = "498e4fc3fddeb027b3363fcfc0b77921";
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                getWeather();
                txtClima.Text = String.Empty;
            }
            catch
            {
                if (txtClima.Text == String.Empty)
                {
                    MessageBox.Show("Escriba una ciudad");
                }else if (labelWn.Text == "N/A" )
                {
                    MessageBox.Show("No se pudo encontrar la ciudad");
                    txtClima.Text = String.Empty;
                }
                
                
            }
        }
     

        public class WindowExtension
        {
            [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
            private extern static void ReleaseCapture();
          
            

       

        }
        public void getWeather()
        {
            try
            {
                using (WebClient web = new WebClient())
                {

                    string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", txtClima.Text, APIKey);
                    var json = web.DownloadString(url);
                   
                    root Info = JsonConvert.DeserializeObject<root>(json);
                    string sunset = ConvertDateTime(Info.sys.sunset).ToShortTimeString();
                    string sunrise = ConvertDateTime(Info.sys.sunrise).ToShortTimeString();
                    double temp = Info.main.temp;
                    double unu = temp - 273.15;
                    unu = (int)unu;
                    picWeather.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                    labelCd.Text = Info.weather[0].main;
                    laberDt.Text = Info.weather[0].description;
                    labelSun.Text = sunset.ToString();
                    labelSn.Text = sunrise.ToString();
                    labelWn.Text = Info.wind.speed.ToString();
                    labelPress.Text = Info.main.pressure.ToString();
                    labelTemp.Text = unu.ToString() + "°";

                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("No se pudo encontrar la ciudad");
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
        DateTime ConvertDateTime(long Milisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();

            day = day.AddSeconds(Milisec).ToLocalTime();

            return day;
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmClima_Load(object sender, EventArgs e)
        {

            (new LayeredWindowHelper(this)).BackColor = Color.FromArgb(128, Win7Style.GetThemeColor());



            Win7Style.EnableBlurBehindWindow(this.Handle);
            Win10Style.EnableBlur(this.Handle);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
          private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
                                      
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }

      

    }



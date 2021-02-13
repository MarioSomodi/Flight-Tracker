using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightTrackerClassLib;

namespace FlightTracker
{
    public partial class FlightTracker : Form
    {
        //Code needed for the form to be draggable on the specific points.
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        //Needed variable to know if a in the parent panel that shows is it open.
        private Form activeForm = null;
        //Generating object of needed repository for CRUD operations on the DB and gathering info from API.
        private CountryRepository cR = new CountryRepository();
        //Contructor for FlightTracker form that refreshes country list on start of program.
        public FlightTracker()
        {
            InitializeComponent();
            cR.WriteToOrUpdateCountriesInDB();
            clearImageFolder();
        }
        //Opens a form inside a panel in the program.
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //Closes sub panels on any button click.
        private void CloseSubPanel()
        {
            if (panelFlightSubMenu.Visible == true)
            {
                panelFlightSubMenu.Visible = false;
                labelSeparator7.Visible = true;
            }
            if (panelStatisticsSubMenu.Visible == true)
            {
                panelStatisticsSubMenu.Visible = false;
                lblSeperator11.Visible = true;
            }
        }
        //Opens an instance of the Countries form.
        private void buttonShowCountries_Click(object sender, EventArgs e)
        {
            CloseSubPanel();
            openChildFormInPanel(new Countries());
        }
        //Button that contains a submenu and it's logic for opening.
        private void btnShowFlightsSubmenu_Click(object sender, EventArgs e)
        {
            if (panelStatisticsSubMenu.Visible == true)
            {
                panelStatisticsSubMenu.Visible = false;
                lblSeperator11.Visible = true;
            }
            if (panelFlightSubMenu.Visible == true)
            {
                panelFlightSubMenu.Visible = false;
                labelSeparator7.Visible = true;
            }
            else 
            {
                panelFlightSubMenu.Visible = true;
                labelSeparator7.Visible = false;
            }
        }
        //Clears all flight png from the folder on program start
        private void clearImageFolder()
        {
            DirectoryInfo di = new DirectoryInfo(@"D:\Faks\Druga godina\Treci Semestar\Programiranje_u_NET_okolini\Konstrukcijska_Vjezba\FlightTracker\FlightTracker\Resources\imagesOfPlanes");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }
        //Opens an instance of the Positions form.
        private void btnShowFlightPositions_Click(object sender, EventArgs e)
        {
            CloseSubPanel();
            openChildFormInPanel(new Positions());
        }
        //Opens an instance of the Map form.
        private void btnShowMap_Click(object sender, EventArgs e)
        {
            CloseSubPanel();
            openChildFormInPanel(new Map());
        }
        //Opens an instance of the Flights form.
        private void buttonBasicFlightInfo_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Flights());
        }
        //Opens an instance of the FlightDetails form.
        private void buttonFlightDetails_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FlightDetailsForm());
        }
        //Close the form on picture box click.
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Minimize the form on picture box click.
        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Maximize or return to normal state the form on picture box click.
        private void pictureBoxMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else 
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        //Function that is linked to all top elements of the main form so it is draggable. Checks if the left mouse button is clicked and held.
        private void panelTopContent_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        //On mouse hover leave change back to black
        private void pictureBoxClose_MouseLeave(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(@"D:\Faks\Druga godina\Treci Semestar\Programiranje_u_NET_okolini\Konstrukcijska_Vjezba\FlightTracker\FlightTracker\Resources\close.png");
            pictureBoxClose.Image = bmp;
        }
        //On mouse hover leave change back to black
        private void pictureBoxMaximize_MouseLeave(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(@"D:\Faks\Druga godina\Treci Semestar\Programiranje_u_NET_okolini\Konstrukcijska_Vjezba\FlightTracker\FlightTracker\Resources\maximize.png");
            pictureBoxMaximize.Image = bmp;
        }
        //On mouse hover leave change back to black
        private void pictureBoxMinimize_MouseLeave(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(@"D:\Faks\Druga godina\Treci Semestar\Programiranje_u_NET_okolini\Konstrukcijska_Vjezba\FlightTracker\FlightTracker\Resources\minimize.png");
            pictureBoxMinimize.Image = bmp;
        }
        //On mouse hover change to green picture.
        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(@"D:\Faks\Druga godina\Treci Semestar\Programiranje_u_NET_okolini\Konstrukcijska_Vjezba\FlightTracker\FlightTracker\Resources\minimize_hover.png");
            pictureBoxMinimize.Image = bmp;
        }
        //On mouse hover change to green picture.
        private void pictureBoxMaximize_MouseHover(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(@"D:\Faks\Druga godina\Treci Semestar\Programiranje_u_NET_okolini\Konstrukcijska_Vjezba\FlightTracker\FlightTracker\Resources\maximize_hover.png");
            pictureBoxMaximize.Image = bmp;
        }
        //On mouse hover change to green picture.
        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(@"D:\Faks\Druga godina\Treci Semestar\Programiranje_u_NET_okolini\Konstrukcijska_Vjezba\FlightTracker\FlightTracker\Resources\close_hover.png");
            pictureBoxClose.Image = bmp;
        }
        //Button that contains the submenu and it's logic for opening.
        private void btnStaticstics_Click(object sender, EventArgs e)
        {
            if (panelFlightSubMenu.Visible == true) 
            {
                panelFlightSubMenu.Visible = false;
                labelSeparator7.Visible = true;
            }
            if (panelStatisticsSubMenu.Visible == true)
            {
                panelStatisticsSubMenu.Visible = false;
                lblSeperator11.Visible = true;
            }
            else
            {
                panelStatisticsSubMenu.Visible = true;
                lblSeperator11.Visible = false;
            }
        }
        //Opens an instance of the Statistics form.
        private void btnOverallStatistics_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Statistics());
        }
        //Opens an instance of the Flight details statistics form.
        private void btnFlightDetailsStatistics_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FlightDetailsStatistics());
        }
    }
}

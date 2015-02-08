using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AXISMEDIACONTROLLib;

namespace axisCamera2
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        
       
        public Form1()
        {
            InitializeComponent();

            amc.StretchToFit = true;
            amc2.StretchToFit = true;
            amc.VideoRenderer = (int)AMC_VIDEO_RENDERER.AMC_VIDEO_RENDERER_VMR9;
            amc2.VideoRenderer = (int)AMC_VIDEO_RENDERER.AMC_VIDEO_RENDERER_VMR9;
        }
        private string CompleteURL(string theMediaURL, string theMediaType)
        {
            string anURL = theMediaURL;
            anURL += "/axis-cgi/mjpg/video.cgi";     
            anURL = CompleteProtocol(anURL, theMediaType);
            return anURL;
        }
        private string CompleteProtocol(string theMediaURL, string theMediaType)
        {
            if (theMediaURL.IndexOf("://") >= 0) return theMediaURL;

            string anURL = theMediaURL;
            anURL = "http://" + anURL;
            return anURL;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string media = "mjpeg";
            amc.Stop();
            amc.MediaUsername = "FRC";
            amc.MediaPassword = "FRC";
            amc.MediaURL = CompleteURL(ipAdress.Text, media);
            amc.Play();         
        }
        private void button2_Click(object sender, EventArgs e) 
        {
            string media = "mjpeg";
            amc2.Stop();
            amc2.MediaUsername = "FRC";
            amc2.MediaPassword = "FRC";
            amc2.MediaURL = CompleteURL(ipAdress2.Text, media);
            amc2.Play();
        }
        
    }
}

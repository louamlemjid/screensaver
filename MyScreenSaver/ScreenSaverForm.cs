using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
//using Microsoft.Web.WebView2.Core;
//using Microsoft.Web.WebView2.WinForms;
using System.Reflection.Metadata;

namespace MyScreenSaver
{
    public class ScreenSaverForm : Form
    {
        //private WebView2 webView;

        //private GlobalUserEventHandler userEventHandler;


        public ScreenSaverForm(string websiteURL)
        {
            //userEventHandler = new GlobalUserEventHandler();

            Rectangle screenBounds = Screen.PrimaryScreen.Bounds;

            // Initialize the form
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;


            //this.Bounds = screenBounds; // Set the form size to the screen size

            // Initialize the WebView2 control
            /*webView = new WebView2
            {
                Dock = DockStyle.Fill
            };

            webView.NavigationCompleted += WebView_NavigationCompleted;
            //webView.MouseMove += HandleMouseMove;
            this.Controls.Add(webView);*/

            //InitializeWebViewAsync(websiteURL);
               // Add click handler for the WebView2 control

            // Navigate to the specified website URL




        }
        private void HandleMouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Hide();
            Application.Exit();
        }

        private void HandleMouseClick(object sender, EventArgs e)
        {
            Cursor.Hide();
            Application.Exit();
        }

        private async void InitializeWebViewAsync(string websiteURL)
        {
            //Application.RemoveMessageFilter(userEventHandler);
            try
            {  
                //await webView.EnsureCoreWebView2Async(null);
                //webView.CoreWebView2.Navigate(websiteURL);
                await Task.Delay(6000); // Wait for 10 seconds
                //webView.MouseMove += HandleMouseMove; // Add mouse move handler for the WebView2 control
              

            }
            catch
            {
                // This can happen if IE pops up a window that isn't closed before the next call to Navigate()
            }
          
            //Application.AddMessageFilter(userEventHandler);
        }
        /*private void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            // Handle navigation completed event if needed

        }*/

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // ScreenSaverForm
            // 
            ClientSize = new Size(284, 261);
            Name = "ScreenSaverForm";
            Load += ScreenSaverForm_Load;
            Click += ScreenSaverForm_Click;
            MouseMove += ScreenSaverForm_MouseMove;
            ResumeLayout(false);
            
        }

      

        protected override void OnLoad(EventArgs e)
        {

        }
        private void ScreenSaverForm_MouseMove(object sender, MouseEventArgs e)
        {
            Console.WriteLine("ggg");
            Cursor.Hide();
        }

        private void ScreenSaverForm_Click(object sender, EventArgs e)
        {
            Cursor.Hide();

        }

        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
        }
    }
    /*public class GlobalUserEventHandler : IMessageFilter
    {
        public delegate void UserEvent();

        private const int WM_MOUSEMOVE = 0x0200;
        private const int WM_MBUTTONDBLCLK = 0x209;
        private const int WM_KEYDOWN = 0x100;
        private const int WM_KEYUP = 0x101;

        public event UserEvent Event;

        public bool PreFilterMessage(ref Message m)
        {
            if ((m.Msg >= WM_MOUSEMOVE && m.Msg <= WM_MBUTTONDBLCLK)
                || m.Msg == WM_KEYDOWN
                || m.Msg == WM_KEYUP)
            {
                if (Event != null)
                {
                    Event();
                }
            }
            // Always allow message to continue to the next filter control
            return false;
        }
    }*/
}

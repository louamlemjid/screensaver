using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json;
using System.Diagnostics.Metrics;
using System.IO;
namespace MyScreenSaver
{
    public partial class Form1 : Form
    {
        private WebView2 webView;
        public int counter = 0;
        public Form1()
        {

            InitializeComponent();
        }
        public struct JsonObject
        {
            public string Key;
            public string Value;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            Rectangle screenBounds = Screen.PrimaryScreen.Bounds;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;


            this.Bounds = screenBounds; // Set the form size to the screen size
            InitBrowser();
            
        }

        private void HandleMouseMove(object sender, MouseEventArgs e)
        {


        }
        private async void InitializeWebViewAsync(string websiteURL)
        {

            try
            {
                await webView.EnsureCoreWebView2Async(null);
                webView.CoreWebView2.Navigate(websiteURL);
                //await Task.Delay(6000); // Wait for 10 seconds
                //webView.MouseMove += HandleMouseMove; // Add mouse move handler for the WebView2 control


            }
            catch
            {
                // This can happen if IE pops up a window that isn't closed before the next call to Navigate()
            }


        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void webView21_Click(object sender, EventArgs e)
        {
            Cursor.Hide();
        }
        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://www.youtube.com");
        }

        private void webView21_MouseMove(object sender, MouseEventArgs e)
        {

            //MessageBox.Show(e.ToString());
            //counter += 1;
            //if(counter>6) Cursor.Hide();
            
        }

        private void webView21_MouseClick(object sender, MouseEventArgs e)
        {
            //Cursor.Hide();
        }

        private void webView21_MouseHover(object sender, EventArgs e)
        {
            //Cursor.Hide();
        }

        private void webView21_MouseLeave(object sender, EventArgs e)
        {
            //Cursor.Hide();
        }

        private void webView21_Resize(object sender, EventArgs e)
        {

        }

        private void webView21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void webView21_KeyDown(object sender, KeyEventArgs e)
        {

            //String a = Convert.ToString((char)e.KeyCode);

            //Console.WriteLine(Test2);
        }

        private void webView21_KeyPress(object sender, KeyPressEventArgs e)
        {
            //String b = Convert.ToString((char)e.KeyChar);
        }

        private async void webView21_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            string script = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Mouse.js"));
            await webView21.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(script);
            //await webView21.CoreWebView2.ExecuteScriptAsync(script);
        }

        private void webView21_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            JsonObject jsonObject = JsonConvert.DeserializeObject<JsonObject>(e.WebMessageAsJson);
            switch (jsonObject.Key)
            {
                case "mousemove":
                    //MessageBox.Show(jsonObject.Value);
                    //Cursor.Hide();
                    Application.Exit();
                    break;
            }
        }

        private void webView21_MouseEnter(object sender, EventArgs e)
        {
            //Cursor.Hide();
        }
    }
}

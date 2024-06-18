namespace MyScreenSaver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AccessibleRole = AccessibleRole.Cursor;
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(2, 0);
            webView21.Name = "webView21";
            webView21.Size = new Size(1366, 768);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            webView21.CoreWebView2InitializationCompleted += webView21_CoreWebView2InitializationCompleted;
            webView21.WebMessageReceived += webView21_WebMessageReceived;
            webView21.Click += webView21_Click;
            webView21.Paint += webView21_Paint;
            webView21.KeyDown += webView21_KeyDown;
            webView21.KeyPress += webView21_KeyPress;
            webView21.MouseClick += webView21_MouseClick;
            webView21.MouseEnter += webView21_MouseEnter;
            webView21.MouseLeave += webView21_MouseLeave;
            webView21.MouseHover += webView21_MouseHover;
            webView21.MouseMove += webView21_MouseMove;
            webView21.Resize += webView21_Resize;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(webView21);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseMove += Form1_MouseMove;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}

using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace OpenLiveWriter.CNBlogs.SourceCode
{
    /// <summary>
    /// This is the main plugin form for authoring source code.
    /// </summary>
    public partial class CodeForm : Form
    {
        private PluginConfigurationRepository _configDb = new PluginConfigurationRepository();
        private string _code;

        private const string prePrefix = "<pre class=\"";
        private const string preSuffix = "\">";
        private const string preClose = "</pre>";

        /// <summary>
        /// Gets or sets the source code. Setter will recognize if the selection contains surrounding <code>PRE</code>
        /// element and will parse the configuration and the source code correctly.
        /// </summary>
        /// <value>The source code.</value>
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeForm"/> class.
        /// </summary>
        /// <param name="code">The source code. It will recognize if the selection contains surrounding <code>PRE</code>
        /// element and will parse the configuration and the source code correctly.</param>
        public CodeForm(string code)
        {
            this._configDb = new PluginConfigurationRepository();
            this._configDb.LoadPluginConfigurationData();
            this.Code = code;
            this.InitializeComponent();
            this.LoadBrushes();
            this.comboBrush.Text = this._configDb.Config.Brush;
            this.textCode.Text = this._code;
            this.textCode.Font = new Font(this._configDb.Config.CodeFontFamily, this._configDb.Config.CodeFontSize);
            if ((this._configDb.Config.MainFormHeight > 0) && (this._configDb.Config.MainFormWidth > 0))
            {
                base.Left = this._configDb.Config.MainFormX;
                base.Top = this._configDb.Config.MainFormY;
                base.Width = this._configDb.Config.MainFormWidth;
                base.Height = this._configDb.Config.MainFormHeight;
                base.StartPosition = FormStartPosition.Manual;
            }
        }

        private void LoadBrushes()
        {
            this.comboBrush.Items.Clear();
            this.comboBrush.Items.Add("ABAP");
            this.comboBrush.Items.Add("ActionScript");
            this.comboBrush.Items.Add("Assembly");
            this.comboBrush.Items.Add("BASH");
            this.comboBrush.Items.Add("BatchFile");
            this.comboBrush.Items.Add("C");
            this.comboBrush.Items.Add("C#");
            this.comboBrush.Items.Add("Go");
            this.comboBrush.Items.Add("C++");
            this.comboBrush.Items.Add("CSS");
            this.comboBrush.Items.Add("Delphi");
            this.comboBrush.Items.Add("Erlang");
            this.comboBrush.Items.Add("F#");
            this.comboBrush.Items.Add("HTML");
            this.comboBrush.Items.Add("INIFile");
            this.comboBrush.Items.Add("Java");
            this.comboBrush.Items.Add("JavaScript");
            this.comboBrush.Items.Add("Lua");
            this.comboBrush.Items.Add("MSIL");
            this.comboBrush.Items.Add("Objective-C");
            this.comboBrush.Items.Add("Pascal");
            this.comboBrush.Items.Add("Perl");
            this.comboBrush.Items.Add("PHP");
            this.comboBrush.Items.Add("PowerShell");
            this.comboBrush.Items.Add("Python");
            this.comboBrush.Items.Add("SQL");
            this.comboBrush.Items.Add("VB.NET");
            this.comboBrush.Items.Add("Verilog");
            this.comboBrush.Items.Add("VHDL");
            this.comboBrush.Items.Add("XAML");
            this.comboBrush.Items.Add("XML");
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            using (AboutForm form = new AboutForm())
            {
                form.ShowDialog();
            }
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            using (OptionsForm form = new OptionsForm(_configDb.Config))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _configDb.Config = form.PluginConfigurationData;
                    _configDb.SavePluginConfigurationData();
                    textCode.Font = new Font(_configDb.Config.CodeFontFamily, _configDb.Config.CodeFontSize);
                    textCode.Update();
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this._configDb.Config.Brush = this.comboBrush.Text;
            this._configDb.Config.MainFormX = base.Left;
            this._configDb.Config.MainFormY = base.Top;
            this._configDb.Config.MainFormWidth = base.Width;
            this._configDb.Config.MainFormHeight = base.Height;
            this._configDb.SavePluginConfigurationData();
            try
            {
                this._code = this.RemoteCodeHighlight();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            base.DialogResult = DialogResult.OK;
            base.Close();
        }

        private string RemoteCodeHighlight()
        {
            string requestUriString = "http://util.cnblogs.com/CodeHighlight/LiveWriterHightlight";
            HttpWebRequest httpWebRequest = WebRequest.Create(requestUriString) as HttpWebRequest;
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/x-www-form-urlencoded";
            string value = string.Format("language={0}&code={1}", HttpUtility.UrlEncode(this.comboBrush.Text.Trim()), HttpUtility.UrlEncode(this.textCode.Text.Trim()));
            using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(value);
            }
            string result;
            using (WebResponse response = httpWebRequest.GetResponse())
            {
                using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
            }
            return result;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
            base.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textCode.Text = "";
        }
    }
}
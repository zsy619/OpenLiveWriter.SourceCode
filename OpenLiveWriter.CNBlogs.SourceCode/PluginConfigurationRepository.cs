using System;
using System.IO;
using System.Security;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OpenLiveWriter.CNBlogs.SourceCode
{
    internal class PluginConfigurationRepository
    {
        // Fields
        private PluginConfigurationData _config;

        private readonly string _configurationFilePath;
        private const string ConfigFile = "OpenLiveWriter.CNBlogs.CodeHighlighter.config";

        // Methods
        public PluginConfigurationRepository() : this(new PluginConfigurationData())
        {
        }

        public PluginConfigurationRepository(PluginConfigurationData config)
        {
            string str = string.Format(@"{0}\Local\OpenLiveWriter\app-0.6.0.0", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            this._configurationFilePath = string.Format(@"{0}\{1}", str, "OpenLiveWriter.CNBlogs.CodeHighlighter.config");
            if (!Directory.Exists(str))
            {
                Directory.CreateDirectory(str);
            }
            this._config = config;
        }

        private bool GetBoolean(string text, bool defaultValue)
        {
            bool result = false;
            if (!bool.TryParse(text, out result))
            {
                result = defaultValue;
            }
            return result;
        }

        private int GetInt(string text, int defaultValue)
        {
            int result = 0;
            if (!int.TryParse(text, out result))
            {
                result = defaultValue;
            }
            return result;
        }

        private string GetString(string text)
        {
            return text;
        }

        public void LoadFromParameters(string parameters)
        {
            string str = ":";
            string str2 = ";";
            string str3 = parameters.Trim();
            if (!str3.EndsWith(";"))
            {
                str3 = str3 + ";";
            }
            int length = 0;
            int index = 0;
            bool flag = false;
            while (!flag)
            {
                length = str3.IndexOf(str);
                index = str3.IndexOf(str2);
                if ((0 < length) && (length < index))
                {
                    string variable = str3.Substring(0, length).Trim();
                    string str5 = str3.Substring(length + 1, (index - length) - 1).Trim();
                    this.UpdateConfig(this._config, variable, str5);
                    str3 = str3.Substring(index + 1).TrimStart(new char[0]);
                }
                else
                {
                    flag = true;
                }
            }
        }

        public void LoadPluginConfigurationData()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(PluginConfigurationData));
                if (File.Exists(this._configurationFilePath))
                {
                    using (FileStream stream = new FileStream(this._configurationFilePath, FileMode.Open))
                    {
                        this._config = (PluginConfigurationData)serializer.Deserialize(stream);
                        return;
                    }
                }
                this._config = new PluginConfigurationData();
                using (FileStream stream2 = new FileStream(this._configurationFilePath, FileMode.Create))
                {
                    serializer.Serialize((Stream)stream2, this._config);
                }
            }
            catch (Exception exception)
            {
                if (((!(exception is DirectoryNotFoundException) && !(exception is PathTooLongException)) && (!(exception is FileNotFoundException) && !(exception is IOException))) && ((!(exception is SecurityException) && !(exception is NotSupportedException)) && !(exception is ArgumentOutOfRangeException)))
                {
                    throw;
                }
                MessageBox.Show(string.Format("Can't load configuration from '{0}' file.\n\nDetails: {1}", this._configurationFilePath, exception.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void SavePluginConfigurationData()
        {
            XmlSerializer serializer = null;
            TextWriter textWriter = null;
            try
            {
                serializer = new XmlSerializer(typeof(PluginConfigurationData));
                textWriter = new StreamWriter(this._configurationFilePath);
                serializer.Serialize(textWriter, this._config);
                textWriter.Close();
                textWriter = null;
            }
            catch (Exception exception)
            {
                if ((!(exception is DirectoryNotFoundException) && !(exception is PathTooLongException)) && ((!(exception is IOException) && !(exception is UnauthorizedAccessException)) && !(exception is SecurityException)))
                {
                    throw;
                }
                MessageBox.Show(string.Format("Can't save configuration into '{0}' file.\n\nDetails: {1}", this._configurationFilePath, exception.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                if (textWriter != null)
                {
                    textWriter.Close();
                }
            }
        }

        public string SaveToParameters()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("{0}: {1}; ", "brush", this._config.Brush);
            if (!string.IsNullOrEmpty(this._config.Highlight))
            {
                builder.AppendFormat("{0}: [{1}]; ", "highlight", this._config.Highlight);
            }
            if (!this._config.UseServerDefaults)
            {
                builder.AppendFormat("{0}: {1}; ", "auto-links", this._config.AutoLinks.ToString());
                if (!string.IsNullOrEmpty(this._config.ClassName))
                {
                    builder.AppendFormat("{0}: {1}; ", "class-name", this._config.ClassName);
                }
                builder.AppendFormat("{0}: {1}; ", "collapse", this._config.Collapse.ToString());
                builder.AppendFormat("{0}: {1}; ", "first-line", this._config.FirstLine);
                builder.AppendFormat("{0}: {1}; ", "gutter", this._config.Gutter);
                builder.AppendFormat("{0}: {1}; ", "html-script", this._config.HtmlScript.ToString());
                builder.AppendFormat("{0}: {1}; ", "light", this._config.Light.ToString());
                builder.AppendFormat("{0}: {1}; ", "ruler", this._config.Ruler.ToString());
                builder.AppendFormat("{0}: {1}; ", "smart-tabs", this._config.SmartTabs.ToString());
                builder.AppendFormat("{0}: {1}; ", "tab-size", this._config.TabSize.ToString());
                builder.AppendFormat("{0}: {1}; ", "toolbar", this._config.Toolbar.ToString());
            }
            return builder.ToString().ToLower().Trim();
        }

        private void UpdateConfig(PluginConfigurationData config, string variable, string value)
        {
            switch (variable)
            {
                case "brush":
                    config.Brush = this.GetString(value);
                    return;

                case "auto-links":
                    config.AutoLinks = this.GetBoolean(value, config.AutoLinks);
                    return;

                case "class-name":
                    config.ClassName = this.GetString(value);
                    return;

                case "collapse":
                    config.Collapse = this.GetBoolean(value, config.Collapse);
                    return;

                case "first-line":
                    config.FirstLine = this.GetInt(value, config.FirstLine);
                    return;

                case "gutter":
                    config.Gutter = this.GetBoolean(value, config.Gutter);
                    return;

                case "highlight":
                    {
                        int index = value.IndexOf("[");
                        int num2 = value.LastIndexOf("]");
                        if ((0 > index) || (index >= num2))
                        {
                            break;
                        }
                        config.Highlight = this.GetString(value.Substring(index + 1, (num2 - index) - 1));
                        return;
                    }
                case "html-script":
                    config.HtmlScript = this.GetBoolean(value, config.HtmlScript);
                    return;

                case "light":
                    config.Light = this.GetBoolean(value, config.Light);
                    return;

                case "ruler":
                    config.Ruler = this.GetBoolean(value, config.Ruler);
                    return;

                case "smart-tabs":
                    config.SmartTabs = this.GetBoolean(value, config.SmartTabs);
                    return;

                case "tab-size":
                    config.TabSize = this.GetInt(value, config.TabSize);
                    return;

                case "toolbar":
                    config.Toolbar = this.GetBoolean(value, config.Toolbar);
                    break;

                default:
                    return;
            }
        }

        // Properties
        public PluginConfigurationData Config
        {
            get
            {
                return this._config;
            }
            set
            {
                this._config = value;
            }
        }
    }
}
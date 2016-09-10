using System;
using System.Drawing;
using System.Windows.Forms;

namespace OpenLiveWriter.CNBlogs.SourceCode
{
    /// <summary>
    /// Options form used to set plugin configuration
    /// </summary>
    public partial class OptionsForm : Form
    {
        /// <summary>
        /// Gets or sets the plugin configuration data.
        /// </summary>
        /// <value>The plugin configuration data.</value>
        public PluginConfigurationData PluginConfigurationData { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsForm"/> class.
        /// </summary>
        /// <param name="config">The config.</param>
        public OptionsForm(PluginConfigurationData config)
        {
            InitializeComponent();
            PluginConfigurationData = config;

            checkServerDefaults.Checked = PluginConfigurationData.UseServerDefaults;
            checkBoxAutoLinks.Checked = PluginConfigurationData.AutoLinks;
            checkBoxCollapse.Checked = PluginConfigurationData.Collapse;
            checkBoxGutter.Checked = PluginConfigurationData.Gutter;
            checkBoxHtmlScript.Checked = PluginConfigurationData.HtmlScript;
            checkBoxLight.Checked = PluginConfigurationData.Light;
            checkBoxRuler.Checked = PluginConfigurationData.Ruler;
            checkBoxSmartTabs.Checked = PluginConfigurationData.SmartTabs;
            checkBoxToolbar.Checked = PluginConfigurationData.Toolbar;
            checkLoadFromClipboard.Checked = PluginConfigurationData.LoadFromClipboard;
            numericTabSize.Value = PluginConfigurationData.TabSize;
            textBoxClassName.Text = (PluginConfigurationData.ClassName ?? string.Empty);
            labelFamily.Text = PluginConfigurationData.CodeFontFamily;
            labelSize.Text = PluginConfigurationData.CodeFontSize.ToString();
            this.UpdateCodeFont();
        }

        private void UpdateCodeFont()
        {
            labelCodeFont.Text = string.Format("{0}, {1}pt", labelFamily.Text, labelSize.Text);
        }

        private void buttonOK_Click(object sender, System.EventArgs e)
        {
            PluginConfigurationData.UseServerDefaults = checkServerDefaults.Checked;
            PluginConfigurationData.AutoLinks = checkBoxAutoLinks.Checked;
            PluginConfigurationData.Collapse = checkBoxCollapse.Checked;
            PluginConfigurationData.Gutter = checkBoxGutter.Checked;
            PluginConfigurationData.HtmlScript = checkBoxHtmlScript.Checked;
            PluginConfigurationData.Light = checkBoxLight.Checked;
            PluginConfigurationData.Ruler = checkBoxRuler.Checked;
            PluginConfigurationData.SmartTabs = checkBoxSmartTabs.Checked;
            PluginConfigurationData.Toolbar = checkBoxToolbar.Checked;
            PluginConfigurationData.LoadFromClipboard = checkLoadFromClipboard.Checked;
            PluginConfigurationData.TabSize = (int)numericTabSize.Value;
            PluginConfigurationData.ClassName = textBoxClassName.Text;
            PluginConfigurationData.CodeFontFamily = labelFamily.Text;
            PluginConfigurationData.CodeFontSize = float.Parse(labelSize.Text);

            base.DialogResult = DialogResult.OK;
            base.Close();
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
            base.Close();
        }

        private void checkServerDefaults_CheckedChanged(object sender, System.EventArgs e)
        {
            this.EnableOverrides(!checkServerDefaults.Checked);
        }

        private void EnableOverrides(bool enable)
        {
            checkBoxAutoLinks.Enabled = enable;
            checkBoxCollapse.Enabled = enable;
            checkBoxGutter.Enabled = enable;
            checkBoxHtmlScript.Enabled = enable;
            checkBoxLight.Enabled = enable;
            checkBoxRuler.Enabled = enable;
            checkBoxSmartTabs.Enabled = enable;
            checkBoxToolbar.Enabled = enable;
            numericTabSize.Enabled = enable;
            textBoxClassName.Enabled = enable;
        }

        private void buttonChangeCodeFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            Font font = new Font(labelFamily.Text, float.Parse(labelSize.Text));
            fontDialog.Font = font;

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                labelFamily.Text = fontDialog.Font.FontFamily.Name;
                labelSize.Text = fontDialog.Font.SizeInPoints.ToString();
                UpdateCodeFont();
            }
        }
    }
}
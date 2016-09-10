using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace OpenLiveWriter.CNBlogs.SourceCode
{
    /// <summary>
    /// About form.
    /// </summary>
    public partial class AboutForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AboutForm"/> class.
        /// </summary>
        public AboutForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.OK;
            base.Close();
        }

        private void linkDavidPokluda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkDavidPokluda.Text);
        }

        private void linkHighlighter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkHighlighter.Text);
        }
    }
}
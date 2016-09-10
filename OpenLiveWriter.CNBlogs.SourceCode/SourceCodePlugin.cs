using OpenLiveWriter.Api;
using System.Windows.Forms;

namespace OpenLiveWriter.CNBlogs.SourceCode
{
    /// <summary>
    /// </summary>
    [InsertableContentSource("CNBlogs插入代码", SidebarText = "CNBlogs插入代码"), WriterPlugin("34F366A6-2824-4920-9EC6-AE1FBCBFA535", "CNBlogs插入代码", ImagePath = "Resources.code.png", Description = "插入代码并进行着色", PublisherUrl = "http://zsy.cnblogs.com")]
    public class SourceCodePlugin : ContentSource
    {
        /// <summary>
        /// Create content using an Insert dialog box.
        /// </summary>
        /// <param name="dialogOwner">Owner for any dialog boxes shown.</param>
        /// <param name="content">Newly created content. If there is an existing contiguous selection within the editor when CreateContent is called,
        /// the parameter will contain the contents of the selection by default.</param>
        /// <returns><see cref="DialogResult.OK"/> if content was successfully created, <see cref="DialogResult.Cancel"/> if the user cancels the Insert dialog.</returns>
        public override DialogResult CreateContent(IWin32Window dialogOwner, ref string content)
        {
            DialogResult cancel = DialogResult.Cancel;
            using (CodeForm form = new CodeForm(content))
            {
                cancel = form.ShowDialog(dialogOwner);
                if (cancel == DialogResult.OK)
                {
                    content = form.Code;
                }
            }
            return cancel;
        }
    }
}
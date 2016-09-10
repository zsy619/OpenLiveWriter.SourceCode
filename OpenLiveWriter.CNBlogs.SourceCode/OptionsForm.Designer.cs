namespace OpenLiveWriter.CNBlogs.SourceCode
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxAutoLinks = new System.Windows.Forms.CheckBox();
            this.checkBoxCollapse = new System.Windows.Forms.CheckBox();
            this.checkBoxGutter = new System.Windows.Forms.CheckBox();
            this.checkBoxHtmlScript = new System.Windows.Forms.CheckBox();
            this.checkBoxLight = new System.Windows.Forms.CheckBox();
            this.checkBoxRuler = new System.Windows.Forms.CheckBox();
            this.checkBoxSmartTabs = new System.Windows.Forms.CheckBox();
            this.checkBoxToolbar = new System.Windows.Forms.CheckBox();
            this.numericTabSize = new System.Windows.Forms.NumericUpDown();
            this.labelTabSize = new System.Windows.Forms.Label();
            this.labelClassName = new System.Windows.Forms.Label();
            this.textBoxClassName = new System.Windows.Forms.TextBox();
            this.checkLoadFromClipboard = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkServerDefaults = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelCodeFont = new System.Windows.Forms.Label();
            this.buttonChangeCodeFont = new System.Windows.Forms.Button();
            this.labelFamily = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericTabSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(435, 13);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 13;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(434, 43);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkBoxAutoLinks
            // 
            this.checkBoxAutoLinks.AutoSize = true;
            this.checkBoxAutoLinks.Location = new System.Drawing.Point(19, 30);
            this.checkBoxAutoLinks.Name = "checkBoxAutoLinks";
            this.checkBoxAutoLinks.Size = new System.Drawing.Size(269, 17);
            this.checkBoxAutoLinks.TabIndex = 0;
            this.checkBoxAutoLinks.Text = "Turn on detection of &links in the highlighted element";
            this.checkBoxAutoLinks.UseVisualStyleBackColor = true;
            // 
            // checkBoxCollapse
            // 
            this.checkBoxCollapse.AutoSize = true;
            this.checkBoxCollapse.Location = new System.Drawing.Point(19, 54);
            this.checkBoxCollapse.Name = "checkBoxCollapse";
            this.checkBoxCollapse.Size = new System.Drawing.Size(336, 17);
            this.checkBoxCollapse.TabIndex = 1;
            this.checkBoxCollapse.Text = "Force &highlighted elements on the page to be collapsed by default";
            this.checkBoxCollapse.UseVisualStyleBackColor = true;
            // 
            // checkBoxGutter
            // 
            this.checkBoxGutter.AutoSize = true;
            this.checkBoxGutter.Location = new System.Drawing.Point(19, 78);
            this.checkBoxGutter.Name = "checkBoxGutter";
            this.checkBoxGutter.Size = new System.Drawing.Size(177, 17);
            this.checkBoxGutter.TabIndex = 2;
            this.checkBoxGutter.Text = "Turn on &gutter with line numbers";
            this.checkBoxGutter.UseVisualStyleBackColor = true;
            // 
            // checkBoxHtmlScript
            // 
            this.checkBoxHtmlScript.AutoSize = true;
            this.checkBoxHtmlScript.Location = new System.Drawing.Point(19, 102);
            this.checkBoxHtmlScript.Name = "checkBoxHtmlScript";
            this.checkBoxHtmlScript.Size = new System.Drawing.Size(265, 17);
            this.checkBoxHtmlScript.TabIndex = 3;
            this.checkBoxHtmlScript.Text = "Highlight a mixture of HTML/&XML code and scripts";
            this.checkBoxHtmlScript.UseVisualStyleBackColor = true;
            // 
            // checkBoxLight
            // 
            this.checkBoxLight.AutoSize = true;
            this.checkBoxLight.Location = new System.Drawing.Point(19, 126);
            this.checkBoxLight.Name = "checkBoxLight";
            this.checkBoxLight.Size = new System.Drawing.Size(236, 17);
            this.checkBoxLight.TabIndex = 4;
            this.checkBoxLight.Text = "&Light version with disabled toolbar and gutter";
            this.checkBoxLight.UseVisualStyleBackColor = true;
            // 
            // checkBoxRuler
            // 
            this.checkBoxRuler.AutoSize = true;
            this.checkBoxRuler.Location = new System.Drawing.Point(19, 150);
            this.checkBoxRuler.Name = "checkBoxRuler";
            this.checkBoxRuler.Size = new System.Drawing.Size(146, 17);
            this.checkBoxRuler.TabIndex = 5;
            this.checkBoxRuler.Text = "Show column &ruler on top";
            this.checkBoxRuler.UseVisualStyleBackColor = true;
            // 
            // checkBoxSmartTabs
            // 
            this.checkBoxSmartTabs.AutoSize = true;
            this.checkBoxSmartTabs.Location = new System.Drawing.Point(19, 174);
            this.checkBoxSmartTabs.Name = "checkBoxSmartTabs";
            this.checkBoxSmartTabs.Size = new System.Drawing.Size(150, 17);
            this.checkBoxSmartTabs.TabIndex = 6;
            this.checkBoxSmartTabs.Text = "Turn on smart ta&bs feature";
            this.checkBoxSmartTabs.UseVisualStyleBackColor = true;
            // 
            // checkBoxToolbar
            // 
            this.checkBoxToolbar.AutoSize = true;
            this.checkBoxToolbar.Location = new System.Drawing.Point(19, 198);
            this.checkBoxToolbar.Name = "checkBoxToolbar";
            this.checkBoxToolbar.Size = new System.Drawing.Size(307, 17);
            this.checkBoxToolbar.TabIndex = 7;
            this.checkBoxToolbar.Text = "Shows &toolbar in the upper/right corner of the code element";
            this.checkBoxToolbar.UseVisualStyleBackColor = true;
            // 
            // numericTabSize
            // 
            this.numericTabSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericTabSize.Location = new System.Drawing.Point(16, 254);
            this.numericTabSize.Name = "numericTabSize";
            this.numericTabSize.Size = new System.Drawing.Size(50, 20);
            this.numericTabSize.TabIndex = 10;
            // 
            // labelTabSize
            // 
            this.labelTabSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTabSize.AutoSize = true;
            this.labelTabSize.Location = new System.Drawing.Point(16, 235);
            this.labelTabSize.Name = "labelTabSize";
            this.labelTabSize.Size = new System.Drawing.Size(50, 13);
            this.labelTabSize.TabIndex = 9;
            this.labelTabSize.Text = "&Tab size:";
            // 
            // labelClassName
            // 
            this.labelClassName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelClassName.AutoSize = true;
            this.labelClassName.Location = new System.Drawing.Point(90, 236);
            this.labelClassName.Name = "labelClassName";
            this.labelClassName.Size = new System.Drawing.Size(101, 13);
            this.labelClassName.TabIndex = 11;
            this.labelClassName.Text = "Custom class &name:";
            // 
            // textBoxClassName
            // 
            this.textBoxClassName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClassName.Location = new System.Drawing.Point(93, 254);
            this.textBoxClassName.Name = "textBoxClassName";
            this.textBoxClassName.Size = new System.Drawing.Size(292, 20);
            this.textBoxClassName.TabIndex = 12;
            // 
            // checkLoadFromClipboard
            // 
            this.checkLoadFromClipboard.AutoSize = true;
            this.checkLoadFromClipboard.Location = new System.Drawing.Point(21, 16);
            this.checkLoadFromClipboard.Name = "checkLoadFromClipboard";
            this.checkLoadFromClipboard.Size = new System.Drawing.Size(255, 17);
            this.checkLoadFromClipboard.TabIndex = 8;
            this.checkLoadFromClipboard.Text = "T&ake text from clipboard when selection is empty";
            this.checkLoadFromClipboard.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkServerDefaults);
            this.groupBox1.Controls.Add(this.textBoxClassName);
            this.groupBox1.Controls.Add(this.checkBoxAutoLinks);
            this.groupBox1.Controls.Add(this.labelClassName);
            this.groupBox1.Controls.Add(this.checkBoxCollapse);
            this.groupBox1.Controls.Add(this.labelTabSize);
            this.groupBox1.Controls.Add(this.checkBoxGutter);
            this.groupBox1.Controls.Add(this.numericTabSize);
            this.groupBox1.Controls.Add(this.checkBoxHtmlScript);
            this.groupBox1.Controls.Add(this.checkBoxLight);
            this.groupBox1.Controls.Add(this.checkBoxToolbar);
            this.groupBox1.Controls.Add(this.checkBoxRuler);
            this.groupBox1.Controls.Add(this.checkBoxSmartTabs);
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 289);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // checkServerDefaults
            // 
            this.checkServerDefaults.AutoSize = true;
            this.checkServerDefaults.Location = new System.Drawing.Point(8, 0);
            this.checkServerDefaults.Name = "checkServerDefaults";
            this.checkServerDefaults.Size = new System.Drawing.Size(286, 17);
            this.checkServerDefaults.TabIndex = 13;
            this.checkServerDefaults.Text = "Use server &defaults for rendering code in your blog post";
            this.checkServerDefaults.UseVisualStyleBackColor = true;
            this.checkServerDefaults.CheckedChanged += new System.EventHandler(this.checkServerDefaults_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelSize);
            this.groupBox2.Controls.Add(this.labelFamily);
            this.groupBox2.Controls.Add(this.labelCodeFont);
            this.groupBox2.Controls.Add(this.buttonChangeCodeFont);
            this.groupBox2.Location = new System.Drawing.Point(12, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 56);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font used for code editing";
            // 
            // labelCodeFont
            // 
            this.labelCodeFont.AutoSize = true;
            this.labelCodeFont.Location = new System.Drawing.Point(20, 26);
            this.labelCodeFont.Name = "labelCodeFont";
            this.labelCodeFont.Size = new System.Drawing.Size(62, 13);
            this.labelCodeFont.TabIndex = 1;
            this.labelCodeFont.Text = "CurrentFont";
            // 
            // buttonChangeCodeFont
            // 
            this.buttonChangeCodeFont.Location = new System.Drawing.Point(310, 19);
            this.buttonChangeCodeFont.Name = "buttonChangeCodeFont";
            this.buttonChangeCodeFont.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeCodeFont.TabIndex = 0;
            this.buttonChangeCodeFont.Text = "Chan&ge";
            this.buttonChangeCodeFont.UseVisualStyleBackColor = true;
            this.buttonChangeCodeFont.Click += new System.EventHandler(this.buttonChangeCodeFont_Click);
            // 
            // labelFamily
            // 
            this.labelFamily.AutoSize = true;
            this.labelFamily.Location = new System.Drawing.Point(60, 42);
            this.labelFamily.Name = "labelFamily";
            this.labelFamily.Size = new System.Drawing.Size(36, 13);
            this.labelFamily.TabIndex = 2;
            this.labelFamily.Text = "Family";
            this.labelFamily.Visible = false;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(137, 42);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(27, 13);
            this.labelSize.TabIndex = 3;
            this.labelSize.Text = "Size";
            this.labelSize.Visible = false;
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(522, 409);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkLoadFromClipboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsForm";
            this.Text = "Code Options";
            ((System.ComponentModel.ISupportInitialize)(this.numericTabSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxAutoLinks;
        private System.Windows.Forms.CheckBox checkBoxCollapse;
        private System.Windows.Forms.CheckBox checkBoxGutter;
        private System.Windows.Forms.CheckBox checkBoxHtmlScript;
        private System.Windows.Forms.CheckBox checkBoxLight;
        private System.Windows.Forms.CheckBox checkBoxRuler;
        private System.Windows.Forms.CheckBox checkBoxSmartTabs;
        private System.Windows.Forms.CheckBox checkBoxToolbar;
        private System.Windows.Forms.NumericUpDown numericTabSize;
        private System.Windows.Forms.Label labelTabSize;
        private System.Windows.Forms.Label labelClassName;
        private System.Windows.Forms.TextBox textBoxClassName;
        private System.Windows.Forms.CheckBox checkLoadFromClipboard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkServerDefaults;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelCodeFont;
        private System.Windows.Forms.Button buttonChangeCodeFont;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelFamily;
    }
}
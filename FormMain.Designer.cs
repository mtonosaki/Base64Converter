namespace Base64Converter
{
    partial class FormMain
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxTips = new System.Windows.Forms.TextBox();
            this.labelWarning = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(138, 15);
            label1.TabIndex = 1;
            label1.Text = "Input File Full Path name";
            label1.DragDrop += new System.Windows.Forms.DragEventHandler(this.picture_DragDrop);
            label1.DragEnter += new System.Windows.Forms.DragEventHandler(this.picture_DragEnter);
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(174, 15);
            label2.TabIndex = 3;
            label2.Text = "Output : Base64 of the input file";
            label2.DragDrop += new System.Windows.Forms.DragEventHandler(this.picture_DragDrop);
            label2.DragEnter += new System.Windows.Forms.DragEventHandler(this.picture_DragEnter);
            // 
            // textBoxOut
            // 
            this.textBoxOut.AllowDrop = true;
            this.textBoxOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOut.CausesValidation = false;
            this.textBoxOut.Location = new System.Drawing.Point(12, 75);
            this.textBoxOut.MaxLength = 1000000;
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut.Size = new System.Drawing.Size(557, 198);
            this.textBoxOut.TabIndex = 4;
            this.textBoxOut.TextChanged += new System.EventHandler(this.textBoxOut_TextChanged);
            this.textBoxOut.DragDrop += new System.Windows.Forms.DragEventHandler(this.picture_DragDrop);
            this.textBoxOut.DragEnter += new System.Windows.Forms.DragEventHandler(this.picture_DragEnter);
            // 
            // textBoxIn
            // 
            this.textBoxIn.AllowDrop = true;
            this.textBoxIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIn.Location = new System.Drawing.Point(12, 27);
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(557, 23);
            this.textBoxIn.TabIndex = 2;
            this.textBoxIn.DragDrop += new System.Windows.Forms.DragEventHandler(this.picture_DragDrop);
            this.textBoxIn.DragEnter += new System.Windows.Forms.DragEventHandler(this.picture_DragEnter);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPreview.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBoxPreview.Location = new System.Drawing.Point(575, 12);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(295, 282);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 3;
            this.pictureBoxPreview.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 297);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(882, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(183, 17);
            this.toolStripStatusLabel1.Text = "To start, drag a file and drop here.";
            // 
            // textBoxTips
            // 
            this.textBoxTips.AllowDrop = true;
            this.textBoxTips.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTips.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTips.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTips.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTips.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxTips.Location = new System.Drawing.Point(12, 279);
            this.textBoxTips.MaxLength = 1000000;
            this.textBoxTips.Name = "textBoxTips";
            this.textBoxTips.ReadOnly = true;
            this.textBoxTips.Size = new System.Drawing.Size(557, 15);
            this.textBoxTips.TabIndex = 5;
            this.textBoxTips.Text = "data:image/png;base64,<BASE64 Here>";
            this.textBoxTips.DragDrop += new System.Windows.Forms.DragEventHandler(this.picture_DragDrop);
            this.textBoxTips.DragEnter += new System.Windows.Forms.DragEventHandler(this.picture_DragEnter);
            // 
            // labelWarning
            // 
            this.labelWarning.AllowDrop = true;
            this.labelWarning.AutoSize = true;
            this.labelWarning.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelWarning.ForeColor = System.Drawing.Color.Red;
            this.labelWarning.Location = new System.Drawing.Point(192, 53);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(12, 17);
            this.labelWarning.TabIndex = 3;
            this.labelWarning.Text = "!";
            this.labelWarning.Visible = false;
            this.labelWarning.DragDrop += new System.Windows.Forms.DragEventHandler(this.picture_DragDrop);
            this.labelWarning.DragEnter += new System.Windows.Forms.DragEventHandler(this.picture_DragEnter);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 319);
            this.Controls.Add(this.textBoxTips);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(label2);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBoxIn);
            this.Controls.Add(this.textBoxOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Base64 Converter";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.picture_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.picture_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox textBoxTips;
        private System.Windows.Forms.Label labelWarning;
    }
}


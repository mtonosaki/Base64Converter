// (c) 2020 Manabu Tonosaki
// Licensed under the MIT license.

using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Base64Converter
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void picture_DragEnter(object sender, DragEventArgs e)
        {
            textBoxIn.Text = "";
            textBoxOut.Text = "";
            pictureBoxPreview.Image = null;

            if (e.Data.GetDataPresent("FileName"))
            {
                if (e.Data.GetData(DataFormats.FileDrop) is string[] fnames)
                {
                    if (fnames.Length == 1)
                    {
                        e.Effect = DragDropEffects.Copy;
                        SetStatus("Drop file to convert.");
                        return;
                    }
                }
            }
            SetStatus($"The dragging files are not supported.");
            e.Effect = DragDropEffects.None;
        }

        private async void picture_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(DataFormats.FileDrop) is string[] fnames)
            {
                var fname = fnames.FirstOrDefault();
                if (fname == default) return;

                textBoxIn.Text = fname;

                try
                {
                    var buf = await File.ReadAllBytesAsync(fname, CancellationToken.None);
                    var base64 = Convert.ToBase64String(buf);
                    textBoxOut.Text = base64.Substring(0, Math.Min(base64.Length, 32760)) + (base64.Length > 32760 ? "..." : "");
                    if (base64.Length > 32760)
                    {
                        SetStatus("Copy base64 text to clipboard. Output text is clipped.");
                    }
                    else
                    {
                        SetStatus("Copy base64 text to clipboard.");
                    }
                    Clipboard.SetText(base64);
                }
                catch (Exception ex)
                {
                    textBoxOut.Text = ex.Message;
                }
            }
            else
            {
                SetStatus($"Support to open ONE file only.");
            }
        }

        private void SetStatus(string mes)
        {
            toolStripStatusLabel1.Text = mes;
        }

        private void textBoxOut_TextChanged(object sender, EventArgs e)
        {
            pictureBoxPreview.Image = null;
            try
            {
                var base64 = textBoxOut.Text;
                var buf = Convert.FromBase64String(base64);
                pictureBoxPreview.Image = Image.FromStream(new MemoryStream(buf));
            }
            catch (Exception ex)
            {
                SetStatus($"{ex.Message}");
            }
        }
    }
}

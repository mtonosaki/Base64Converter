// (c) 2020 Manabu Tonosaki
// Licensed under the MIT license.

using System;
using System.Collections.Generic;
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
            textBoxTips.Text = "data:image/png;base64,<BASE64 Here>";
            pictureBoxPreview.Image = null;
            labelWarning.Visible = false;

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

        private static readonly Dictionary<string, string> ImageExts = new Dictionary<string, string>
        {
            [".jpg"] = "image/jpeg",
            [".jpeg"] = "image/jpeg",
            [".gif"] = "image/gif",
            [".png"] = "image/png",
        };

        private void picture_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(DataFormats.FileDrop) is string[] fnames)
            {
                var fname = fnames.FirstOrDefault();
                if (fname == default) return;

                textBoxIn.Text = fname;
                var ext = Path.GetExtension(fname);

                try
                {
                    SuspendLayout();
                    var buf = File.ReadAllBytesAsync(fname, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
                    var base64 = Convert.ToBase64String(buf);
                    var trimmed = base64.Substring(0, Math.Min(base64.Length, textBoxOut.MaxLength - 32)) + (base64.Length > textBoxOut.MaxLength - 32 ? "..." : "");
                    textBoxOut.Text = trimmed;
                    if (ImageExts.TryGetValue(ext.ToLower(), out var mime))
                    {
                        textBoxTips.Text = $"<img src='data:{mime};base64,{trimmed}' />";
                    }
                    if (base64.Length > textBoxOut.MaxLength - 32)
                    {
                        SetStatus("Copy base64 text to clipboard. Output text is clipped.");
                        labelWarning.Visible = true;
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
                finally
                {
                    ResumeLayout();
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

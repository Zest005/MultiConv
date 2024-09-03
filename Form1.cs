using ImageMagick;
using System.Diagnostics;
using Xabe.FFmpeg;

namespace MyConverter
{
    public partial class Form1 : Form
    {
        string selectedRadioButton = "";

        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;

            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
        }

        private void UpdateConvertButtonState()
        {
            if (textBox1 != null)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void UpdateChooseButtonState()
        {
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void InitializeComboBox()
        {
            comboBox1.Items.AddRange(new string[] { "Empty" });
            comboBox2.Items.AddRange(new string[] { "Empty" });
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                UpdateChooseButtonState();

                selectedRadioButton = "Photo";

                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(new string[] { "JPG", "PNG", "JPEG", "BMP", "GIF", "WEBP", "HEIC" });

                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(new string[] { "JPG", "PNG", "JPEG", "BMP", "GIF", "WEBP" });
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                UpdateChooseButtonState();

                selectedRadioButton = "Video";

                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(new string[] { "MP4", "AVI", "WEBM" });

                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(new string[] { "MP4", "AVI", "WEBM" });
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                UpdateChooseButtonState();

                selectedRadioButton = "Audio";

                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(new string[] { "MP3", "AC3" });

                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(new string[] { "MP3", "AC3" });
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.Items.Contains("Empty"))
            {
                MessageBox.Show("First you need to choose type of file");
                comboBox1.SelectedIndex = -1;
            }
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox2.Items.Contains("Empty"))
            {
                MessageBox.Show("First you need to choose type of file");
                comboBox2.SelectedIndex = -1;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChooseButtonState();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChooseButtonState();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string selectedOriginalFormat = "";

                selectedOriginalFormat = comboBox1.SelectedItem.ToString();

                openFileDialog.Filter = $"{selectedOriginalFormat} files (*.{selectedOriginalFormat.ToLower()})|*.{selectedOriginalFormat.ToLower()}";
                openFileDialog.Title = $"Choose file in a {selectedOriginalFormat} format";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = openFileDialog.FileName;
                }

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show($"Please select a {selectedOriginalFormat} file.");
                    return;
                }

                UpdateConvertButtonState();
            }
        }

        private string GetRootPath()
        {
            var directory = AppContext.BaseDirectory;
            return Path.GetFullPath(Path.Combine(directory, "ffmpeg", "bin"));
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string ffmpegPath = GetRootPath();

            FFmpeg.SetExecutablesPath(ffmpegPath);

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                string selectedConvertFormat = comboBox2.SelectedItem.ToString().ToLower();
                saveFileDialog.Filter = $"{selectedConvertFormat} files (*.{selectedConvertFormat})|*.{selectedConvertFormat}";
                saveFileDialog.Title = $"Save file in a {selectedConvertFormat.ToUpper()} format";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string outputFileName = saveFileDialog.FileName;
                        string inputFileName = textBox1.Text;

                        if (radioButton2.Checked || radioButton3.Checked) // Video or Audio
                        {
                            IMediaInfo mediaInfo = await FFmpeg.GetMediaInfo(inputFileName);
                            IConversion conversion = FFmpeg.Conversions.New()
                                .AddStream(mediaInfo.Streams)
                                .SetOutput(outputFileName);

                            switch (selectedConvertFormat)
                            {
                                case "mp4":
                                    conversion.SetOutputFormat(Format.mp4);
                                    break;
                                case "avi":
                                    conversion.SetOutputFormat(Format.avi);
                                    break;
                                case "mp3":
                                    conversion.SetOutputFormat(Format.mp3);
                                    break;
                                case "ac3":
                                    conversion.SetOutputFormat(Format.ac3);
                                    break;
                                case "webm":
                                    conversion.SetOutputFormat(Format.webm);
                                    break;
                                default:
                                    MessageBox.Show("Unsupported format selected.");
                                    return;
                            }

                            progressBar1.Style = ProgressBarStyle.Marquee;
                            progressBar1.Visible = true;

                            Cursor = Cursors.AppStarting;

                            await Task.Run(() => conversion.Start());

                            progressBar1.Visible = false;

                            Cursor = Cursors.Default;

                            MessageBox.Show($"File succesfully converted to {selectedConvertFormat}");
                        }
                        else if (radioButton1.Checked)
                        {
                            using (MagickImage image = new MagickImage(inputFileName))
                            {
                                switch (selectedConvertFormat)
                                {
                                    case "png":
                                        image.Format = MagickFormat.Png;
                                        break;
                                    case "jpg":
                                        image.Format = MagickFormat.Jpg;
                                        break;
                                    case "jpeg":
                                        image.Format = MagickFormat.Jpeg;
                                        break;
                                    case "bmp":
                                        image.Format = MagickFormat.Bmp;
                                        break;
                                    case "gif":
                                        image.Format = MagickFormat.Gif;
                                        break;
                                    case "webp":
                                        image.Format = MagickFormat.WebP;
                                        break;
                                    default:
                                        MessageBox.Show("Unsupported format selected.");
                                        return;
                                }

                                progressBar1.Style = ProgressBarStyle.Marquee;
                                progressBar1.Visible = true;

                                Cursor = Cursors.AppStarting;

                                await Task.Run(() => image.Write(outputFileName));

                                progressBar1.Visible = false;

                                Cursor = Cursors.Default;

                                MessageBox.Show($"File succesfully converted to {selectedConvertFormat}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        progressBar1.Visible = false;
                    }
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.linkedin.com/in/zest-konovalenko/";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("This link can't be opened: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/Zest005";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("This link can't be opened: " + ex.Message);
            }
        }
    }
}

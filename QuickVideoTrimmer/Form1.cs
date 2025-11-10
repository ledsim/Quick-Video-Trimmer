using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Trimmer
{
    public partial class Trimmer : Form
    {
        string OGFilePath = string.Empty;
        string NewFilePath = string.Empty;
        string ContentType = string.Empty;
        string OGFileName = string.Empty;
        string NewFileName = string.Empty;
        int Parts = 2;
        bool isVideoBeingProcessed = false;
        Thread generator;

        public Trimmer()
        {
            InitializeComponent();
            Console.WriteLine(Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(Directory.GetCurrentDirectory())));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Path.Combine("ffmpeg", "ffmpeg.exe")))
            {
                MessageBox.Show("FFmpeg not found in this directory. Check README and put it here: " + Directory.GetCurrentDirectory() + "\\ffmpeg\\ffmpeg.exe", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    OGFilePath = openFileDialog.FileName ?? "";
                }
            }
            textBoxOGFile.Text = OGFilePath;

            if (SamePathCheckBox.Checked)
            {
                NewPathButton.Enabled = false;
                NewFileLocation.Enabled = false;
                NewFilePath = OGFilePath == null || OGFilePath == "" ? "" : Path.GetDirectoryName(OGFilePath) ?? "";
                NewFileLocation.Text = NewFilePath;
            }
            else
            {
                NewPathButton.Enabled = true;
                NewFileLocation.Enabled = true;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog openDirDialog = new FolderBrowserDialog())
            {

                if (openDirDialog.ShowDialog() == DialogResult.OK)
                {
                    NewFilePath = openDirDialog.SelectedPath;
                }
            }
            NewFileLocation.Text = NewFilePath;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxChange();
        }

        private void NewFileLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOGFile_TextChanged(object sender, EventArgs e)
        {
            OGFilePath = textBoxOGFile.Text;
            CheckboxChange();

            OGFileName = Path.GetFileName(OGFilePath == "" ? "D:\\" : OGFilePath).Split('.')[0];
            ContentType = Path.GetFileName(OGFilePath == "" ? "D:\\" : OGFilePath).Split('.').Last();

            if (OGFileName != "" && NewFileNameInput.Text == "")
            {
                NewFileName = OGFileName + "_part";
                NewFileNameInput.Text = NewFileName;
            }


        }

        private void CheckboxChange()
        {
            if (SamePathCheckBox.Checked)
            {
                NewPathButton.Enabled = false;
                NewFileLocation.Enabled = false;
                NewFilePath = Path.GetDirectoryName(OGFilePath == "" ? "D:\\" : OGFilePath);
                NewFileLocation.Text = NewFilePath;
            }
            else
            {
                NewPathButton.Enabled = true;
                NewFileLocation.Enabled = true;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (OGFilePath != "" && NewFilePath != "" && NewFileName != "")
            {
                generator = new Thread(new ThreadStart(generateVideo));

                if (isVideoBeingProcessed == false)
                {
                    isVideoBeingProcessed = false;
                    progressBar.Visible = true;
                    NewVideoPathGroup.Enabled = false;
                    textBoxOGFile.Enabled = false;
                    OGFileDialog.Enabled = false;
                    NewFileNameInput.Enabled = false;
                    videoPartsInput.Enabled = false;
                    StartProcessButton.Text = "Stop";

                    
                    generator.Start();
                    isVideoBeingProcessed = true;

                    while (isVideoBeingProcessed)
                    {
                        await Task.Run(() => Thread.Sleep(1000));
                    }

                    StartProcessButton.Text = "Start";
                    videoPartsInput.Enabled = true;
                    NewFileNameInput.Enabled = true;
                    OGFileDialog.Enabled = true;
                    textBoxOGFile.Enabled = true;
                    NewVideoPathGroup.Enabled = true;
                    progressBar.Visible = false;
                    
                
                } else
                {

                    isVideoBeingProcessed = false;

                    StartProcessButton.Text = "Start";
                    videoPartsInput.Enabled = true;
                    NewFileNameInput.Enabled = true;
                    OGFileDialog.Enabled = true;
                    textBoxOGFile.Enabled = true;
                    NewVideoPathGroup.Enabled = true;
                    progressBar.Visible = false;

                    generator.Abort();




                }
                

            }

        }

        private async void generateVideo()
        {
            isVideoBeingProcessed = true;
            TimeSpan OGVideoDuration;
            TimeSpan NewVideoDuration;

            using (var shell = ShellObject.FromParsingName(OGFilePath))
            {
                IShellProperty prop = shell.Properties.System.Media.Duration;
                var t = (ulong)prop.ValueAsObject;
                OGVideoDuration = TimeSpan.FromTicks((long)t);

            }

            NewVideoDuration = TimeSpan.FromSeconds(Math.Round(OGVideoDuration.TotalSeconds / Parts) + 2);

            string parameters = "-i \"" + OGFilePath + "\" -c copy -f segment -segment_time " + NewVideoDuration.ToString() + " -reset_timestamps 1 -map_metadata 0 \"" + NewFilePath + "\\" + NewFileName + "_%03d." + ContentType + "\"";

            Console.WriteLine(parameters);

            ProcessStartInfo p = new ProcessStartInfo();
            p.FileName = Path.Combine("ffmpeg", "ffmpeg.exe");
            p.CreateNoWindow = true;
            p.Arguments = parameters;
            p.UseShellExecute = false;
            p.RedirectStandardError = true;
            p.RedirectStandardOutput = true;

            Process proc = Process.Start(p);

            var err = proc.StandardError.ReadToEnd();
            var msg = proc.StandardOutput.ReadToEnd();

            Console.WriteLine(err);
            Console.WriteLine(msg);

            try
            {
                proc.WaitForExit();

                Console.WriteLine("Done");
                
                isVideoBeingProcessed = false;
                MessageBox.Show("The process has been completed.");
                return;

            } catch(ThreadAbortException e)
            {
                proc.CloseMainWindow();
                proc.Close();
                MessageBox.Show("There was an unexpected error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isVideoBeingProcessed = false;
                return;
            }

        }

        private void NewFileNameInput_TextChanged(object sender, EventArgs e)
        {
            NewFileName = NewFileNameInput.Text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Parts = Convert.ToInt32(videoPartsInput.Value);
        }
    }
}

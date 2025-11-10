
namespace Video_Trimmer
{
    partial class Trimmer
    {
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trimmer));
            this.StartProcessButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.videoPartsInput = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.NewFileNameInput = new System.Windows.Forms.TextBox();
            this.NewVideoPathGroup = new System.Windows.Forms.GroupBox();
            this.SamePathCheckBox = new System.Windows.Forms.CheckBox();
            this.NewFileLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewPathButton = new System.Windows.Forms.Button();
            this.OGFileDialog = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOGFile = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoPartsInput)).BeginInit();
            this.NewVideoPathGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartProcessButton
            // 
            resources.ApplyResources(this.StartProcessButton, "StartProcessButton");
            this.StartProcessButton.Name = "StartProcessButton";
            this.StartProcessButton.UseVisualStyleBackColor = true;
            this.StartProcessButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.videoPartsInput);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.NewFileNameInput);
            this.panel1.Controls.Add(this.NewVideoPathGroup);
            this.panel1.Controls.Add(this.OGFileDialog);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxOGFile);
            this.panel1.Name = "panel1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // videoPartsInput
            // 
            resources.ApplyResources(this.videoPartsInput, "videoPartsInput");
            this.videoPartsInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.videoPartsInput.Name = "videoPartsInput";
            this.videoPartsInput.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.videoPartsInput.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // NewFileNameInput
            // 
            resources.ApplyResources(this.NewFileNameInput, "NewFileNameInput");
            this.NewFileNameInput.Name = "NewFileNameInput";
            this.NewFileNameInput.TextChanged += new System.EventHandler(this.NewFileNameInput_TextChanged);
            // 
            // NewVideoPathGroup
            // 
            resources.ApplyResources(this.NewVideoPathGroup, "NewVideoPathGroup");
            this.NewVideoPathGroup.Controls.Add(this.SamePathCheckBox);
            this.NewVideoPathGroup.Controls.Add(this.NewFileLocation);
            this.NewVideoPathGroup.Controls.Add(this.label2);
            this.NewVideoPathGroup.Controls.Add(this.NewPathButton);
            this.NewVideoPathGroup.Name = "NewVideoPathGroup";
            this.NewVideoPathGroup.TabStop = false;
            // 
            // SamePathCheckBox
            // 
            resources.ApplyResources(this.SamePathCheckBox, "SamePathCheckBox");
            this.SamePathCheckBox.Checked = true;
            this.SamePathCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SamePathCheckBox.Name = "SamePathCheckBox";
            this.SamePathCheckBox.UseVisualStyleBackColor = true;
            this.SamePathCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // NewFileLocation
            // 
            resources.ApplyResources(this.NewFileLocation, "NewFileLocation");
            this.NewFileLocation.Name = "NewFileLocation";
            this.NewFileLocation.TextChanged += new System.EventHandler(this.NewFileLocation_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NewPathButton
            // 
            resources.ApplyResources(this.NewPathButton, "NewPathButton");
            this.NewPathButton.Name = "NewPathButton";
            this.NewPathButton.UseVisualStyleBackColor = true;
            this.NewPathButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // OGFileDialog
            // 
            resources.ApplyResources(this.OGFileDialog, "OGFileDialog");
            this.OGFileDialog.Name = "OGFileDialog";
            this.OGFileDialog.UseVisualStyleBackColor = true;
            this.OGFileDialog.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBoxOGFile
            // 
            resources.ApplyResources(this.textBoxOGFile, "textBoxOGFile");
            this.textBoxOGFile.Name = "textBoxOGFile";
            this.textBoxOGFile.TextChanged += new System.EventHandler(this.textBoxOGFile_TextChanged);
            // 
            // progressBar
            // 
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Strihac
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StartProcessButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Strihac";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoPartsInput)).EndInit();
            this.NewVideoPathGroup.ResumeLayout(false);
            this.NewVideoPathGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartProcessButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOGFile;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button OGFileDialog;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.GroupBox NewVideoPathGroup;
        private System.Windows.Forms.CheckBox SamePathCheckBox;
        private System.Windows.Forms.TextBox NewFileLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NewPathButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown videoPartsInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NewFileNameInput;
        private System.Windows.Forms.Label label3;
    }
}


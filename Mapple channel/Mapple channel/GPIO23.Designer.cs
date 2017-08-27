namespace Mapple_channel
{
    partial class GPIO23
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GPIO23));
            this.richTextBoxResultsCommands = new System.Windows.Forms.RichTextBox();
            this.labelConnectionUser = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.comboBoxFiles = new System.Windows.Forms.ComboBox();
            this.numericUpDownTimer = new System.Windows.Forms.NumericUpDown();
            this.labelFile = new System.Windows.Forms.Label();
            this.checkBoxTimer = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxResultsCommands
            // 
            this.richTextBoxResultsCommands.Location = new System.Drawing.Point(434, 299);
            this.richTextBoxResultsCommands.Name = "richTextBoxResultsCommands";
            this.richTextBoxResultsCommands.Size = new System.Drawing.Size(490, 360);
            this.richTextBoxResultsCommands.TabIndex = 0;
            this.richTextBoxResultsCommands.Text = "";
            // 
            // labelConnectionUser
            // 
            this.labelConnectionUser.AutoSize = true;
            this.labelConnectionUser.Location = new System.Drawing.Point(33, 31);
            this.labelConnectionUser.Name = "labelConnectionUser";
            this.labelConnectionUser.Size = new System.Drawing.Size(0, 17);
            this.labelConnectionUser.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(434, 62);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(200, 200);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Red;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonStop.Location = new System.Drawing.Point(686, 62);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(200, 200);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // comboBoxFiles
            // 
            this.comboBoxFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxFiles.FormattingEnabled = true;
            this.comboBoxFiles.Items.AddRange(new object[] {
            "Open_Mapple_Channels_0",
            "Open_Mapple_Channels_15",
            "Open_Mapple_Channels_30",
            "Open_Mapple_Channels_45",
            "Open_Mapple_Channels_60",
            "Open_Mapple_Channels_90",
            "Open_Mapple_Channels_120",
            "Open_Mapple_Channels_150",
            "Open_Mapple_Channels_180",
            "Open_Mapple_Channels_210",
            "Open_Mapple_Channels_240",
            "Open_Mapple_Channels_270",
            "Open_Mapple_Channels_300",
            "Open_Mapple_Channels_360",
            "Open_Mapple_Channels_420",
            "Open_Mapple_Channels_480",
            "Open_Mapple_Channels_540",
            "Open_Mapple_Channels_600",
            ""});
            this.comboBoxFiles.Location = new System.Drawing.Point(24, 103);
            this.comboBoxFiles.Name = "comboBoxFiles";
            this.comboBoxFiles.Size = new System.Drawing.Size(388, 33);
            this.comboBoxFiles.TabIndex = 9;
            // 
            // numericUpDownTimer
            // 
            this.numericUpDownTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.numericUpDownTimer.Location = new System.Drawing.Point(122, 287);
            this.numericUpDownTimer.Name = "numericUpDownTimer";
            this.numericUpDownTimer.Size = new System.Drawing.Size(182, 38);
            this.numericUpDownTimer.TabIndex = 10;
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.BackColor = System.Drawing.Color.Transparent;
            this.labelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelFile.ForeColor = System.Drawing.Color.White;
            this.labelFile.Location = new System.Drawing.Point(161, 31);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(90, 39);
            this.labelFile.TabIndex = 11;
            this.labelFile.Text = "Files";
            // 
            // checkBoxTimer
            // 
            this.checkBoxTimer.AutoSize = true;
            this.checkBoxTimer.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.checkBoxTimer.ForeColor = System.Drawing.Color.White;
            this.checkBoxTimer.Location = new System.Drawing.Point(146, 219);
            this.checkBoxTimer.Name = "checkBoxTimer";
            this.checkBoxTimer.Size = new System.Drawing.Size(126, 43);
            this.checkBoxTimer.TabIndex = 13;
            this.checkBoxTimer.Text = "Timer";
            this.checkBoxTimer.UseVisualStyleBackColor = false;
            this.checkBoxTimer.CheckedChanged += new System.EventHandler(this.checkBoxTimer_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Blue;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(85, 473);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(246, 100);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click_1);
            // 
            // Tableau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(949, 703);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.checkBoxTimer);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.numericUpDownTimer);
            this.Controls.Add(this.comboBoxFiles);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelConnectionUser);
            this.Controls.Add(this.richTextBoxResultsCommands);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Tableau";
            this.Text = "Tableau";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxResultsCommands;
        private System.Windows.Forms.Label labelConnectionUser;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ComboBox comboBoxFiles;
        private System.Windows.Forms.NumericUpDown numericUpDownTimer;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.CheckBox checkBoxTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonReset;
    }
}
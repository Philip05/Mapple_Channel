namespace Mapple_channel
{
    partial class GPIO24
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GPIO24));
            this.buttonReset = new System.Windows.Forms.Button();
            this.checkBoxTimer = new System.Windows.Forms.CheckBox();
            this.numericUpDownTimer = new System.Windows.Forms.NumericUpDown();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.richTextBoxResultsCommands = new System.Windows.Forms.RichTextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Blue;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.Red;
            this.buttonReset.Location = new System.Drawing.Point(67, 353);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(246, 100);
            this.buttonReset.TabIndex = 22;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // checkBoxTimer
            // 
            this.checkBoxTimer.AutoSize = true;
            this.checkBoxTimer.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.checkBoxTimer.ForeColor = System.Drawing.Color.White;
            this.checkBoxTimer.Location = new System.Drawing.Point(116, 155);
            this.checkBoxTimer.Name = "checkBoxTimer";
            this.checkBoxTimer.Size = new System.Drawing.Size(126, 43);
            this.checkBoxTimer.TabIndex = 21;
            this.checkBoxTimer.Text = "Timer";
            this.checkBoxTimer.UseVisualStyleBackColor = false;
            this.checkBoxTimer.CheckedChanged += new System.EventHandler(this.checkBoxTimer_CheckedChanged);
            // 
            // numericUpDownTimer
            // 
            this.numericUpDownTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.numericUpDownTimer.Location = new System.Drawing.Point(92, 223);
            this.numericUpDownTimer.Name = "numericUpDownTimer";
            this.numericUpDownTimer.Size = new System.Drawing.Size(182, 38);
            this.numericUpDownTimer.TabIndex = 19;
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Red;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonStop.Location = new System.Drawing.Point(670, 44);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(200, 200);
            this.buttonStop.TabIndex = 17;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.Red;
            this.buttonStart.Location = new System.Drawing.Point(418, 44);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(200, 200);
            this.buttonStart.TabIndex = 16;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // richTextBoxResultsCommands
            // 
            this.richTextBoxResultsCommands.Location = new System.Drawing.Point(418, 281);
            this.richTextBoxResultsCommands.Name = "richTextBoxResultsCommands";
            this.richTextBoxResultsCommands.Size = new System.Drawing.Size(490, 360);
            this.richTextBoxResultsCommands.TabIndex = 15;
            this.richTextBoxResultsCommands.Text = "";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // GPIO24
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(916, 711);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.checkBoxTimer);
            this.Controls.Add(this.numericUpDownTimer);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.richTextBoxResultsCommands);
            this.Name = "GPIO24";
            this.Text = "GPIO24";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.CheckBox checkBoxTimer;
        private System.Windows.Forms.NumericUpDown numericUpDownTimer;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.RichTextBox richTextBoxResultsCommands;
        private System.Windows.Forms.Timer timer;
    }
}
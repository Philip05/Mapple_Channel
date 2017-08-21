namespace Mapple_channel
{
    partial class Tableau
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
            this.richTextBoxResultsCommands = new System.Windows.Forms.RichTextBox();
            this.labelConnectionUser = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxResultsCommands
            // 
            this.richTextBoxResultsCommands.Location = new System.Drawing.Point(118, 303);
            this.richTextBoxResultsCommands.Name = "richTextBoxResultsCommands";
            this.richTextBoxResultsCommands.Size = new System.Drawing.Size(755, 360);
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
            this.buttonStart.Location = new System.Drawing.Point(249, 70);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(200, 200);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Red;
            this.buttonStop.Location = new System.Drawing.Point(501, 70);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(200, 200);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = false;
            // 
            // Tableau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 703);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelConnectionUser);
            this.Controls.Add(this.richTextBoxResultsCommands);
            this.Name = "Tableau";
            this.Text = "Tableau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxResultsCommands;
        private System.Windows.Forms.Label labelConnectionUser;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
    }
}
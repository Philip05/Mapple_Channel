namespace Mapple_channel
{
    partial class ChoixGPIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoixGPIO));
            this.labelGPIO = new System.Windows.Forms.Label();
            this.buttonGPIO23 = new System.Windows.Forms.Button();
            this.GPIO18 = new System.Windows.Forms.Button();
            this.GPIO9 = new System.Windows.Forms.Button();
            this.GPIO8 = new System.Windows.Forms.Button();
            this.GPIO24 = new System.Windows.Forms.Button();
            this.GPIO2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGPIO
            // 
            this.labelGPIO.AutoSize = true;
            this.labelGPIO.BackColor = System.Drawing.Color.Transparent;
            this.labelGPIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelGPIO.ForeColor = System.Drawing.Color.White;
            this.labelGPIO.Location = new System.Drawing.Point(302, 52);
            this.labelGPIO.Name = "labelGPIO";
            this.labelGPIO.Size = new System.Drawing.Size(102, 39);
            this.labelGPIO.TabIndex = 0;
            this.labelGPIO.Text = "GPIO";
            // 
            // buttonGPIO23
            // 
            this.buttonGPIO23.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonGPIO23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonGPIO23.ForeColor = System.Drawing.Color.White;
            this.buttonGPIO23.Location = new System.Drawing.Point(56, 138);
            this.buttonGPIO23.Name = "buttonGPIO23";
            this.buttonGPIO23.Size = new System.Drawing.Size(192, 86);
            this.buttonGPIO23.TabIndex = 1;
            this.buttonGPIO23.Text = "GPIO 23";
            this.buttonGPIO23.UseVisualStyleBackColor = false;
            this.buttonGPIO23.Click += new System.EventHandler(this.buttonGPIO23_Click);
            // 
            // GPIO18
            // 
            this.GPIO18.BackColor = System.Drawing.Color.DarkBlue;
            this.GPIO18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.GPIO18.ForeColor = System.Drawing.Color.White;
            this.GPIO18.Location = new System.Drawing.Point(508, 261);
            this.GPIO18.Name = "GPIO18";
            this.GPIO18.Size = new System.Drawing.Size(192, 86);
            this.GPIO18.TabIndex = 2;
            this.GPIO18.Text = "GPIO 18";
            this.GPIO18.UseVisualStyleBackColor = false;
            // 
            // GPIO9
            // 
            this.GPIO9.BackColor = System.Drawing.Color.DarkBlue;
            this.GPIO9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.GPIO9.ForeColor = System.Drawing.Color.White;
            this.GPIO9.Location = new System.Drawing.Point(56, 261);
            this.GPIO9.Name = "GPIO9";
            this.GPIO9.Size = new System.Drawing.Size(192, 81);
            this.GPIO9.TabIndex = 3;
            this.GPIO9.Text = "GPIO 9";
            this.GPIO9.UseVisualStyleBackColor = false;
            // 
            // GPIO8
            // 
            this.GPIO8.BackColor = System.Drawing.Color.DarkBlue;
            this.GPIO8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.GPIO8.ForeColor = System.Drawing.Color.White;
            this.GPIO8.Location = new System.Drawing.Point(508, 138);
            this.GPIO8.Name = "GPIO8";
            this.GPIO8.Size = new System.Drawing.Size(192, 86);
            this.GPIO8.TabIndex = 4;
            this.GPIO8.Text = "GPIO 8";
            this.GPIO8.UseVisualStyleBackColor = false;
            // 
            // GPIO24
            // 
            this.GPIO24.BackColor = System.Drawing.Color.DarkBlue;
            this.GPIO24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.GPIO24.ForeColor = System.Drawing.Color.White;
            this.GPIO24.Location = new System.Drawing.Point(281, 138);
            this.GPIO24.Name = "GPIO24";
            this.GPIO24.Size = new System.Drawing.Size(192, 86);
            this.GPIO24.TabIndex = 5;
            this.GPIO24.Text = "GPIO 24";
            this.GPIO24.UseVisualStyleBackColor = false;
            this.GPIO24.Click += new System.EventHandler(this.GPIO24_Click);
            // 
            // GPIO2
            // 
            this.GPIO2.BackColor = System.Drawing.Color.DarkBlue;
            this.GPIO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.GPIO2.ForeColor = System.Drawing.Color.White;
            this.GPIO2.Location = new System.Drawing.Point(281, 258);
            this.GPIO2.Name = "GPIO2";
            this.GPIO2.Size = new System.Drawing.Size(192, 86);
            this.GPIO2.TabIndex = 6;
            this.GPIO2.Text = "GPIO 2";
            this.GPIO2.UseVisualStyleBackColor = false;
            // 
            // ChoixGPIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(775, 419);
            this.Controls.Add(this.GPIO2);
            this.Controls.Add(this.GPIO24);
            this.Controls.Add(this.GPIO8);
            this.Controls.Add(this.GPIO9);
            this.Controls.Add(this.GPIO18);
            this.Controls.Add(this.buttonGPIO23);
            this.Controls.Add(this.labelGPIO);
            this.Name = "ChoixGPIO";
            this.Text = "ChoixGPIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGPIO;
        private System.Windows.Forms.Button buttonGPIO23;
        private System.Windows.Forms.Button GPIO18;
        private System.Windows.Forms.Button GPIO9;
        private System.Windows.Forms.Button GPIO8;
        private System.Windows.Forms.Button GPIO24;
        private System.Windows.Forms.Button GPIO2;
    }
}
namespace Mapple_channel
{
    partial class Connection
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection));
            this.button1 = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.richTextBoxConnectionResult = new System.Windows.Forms.RichTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buttonTestConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(286, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 103);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(190, 115);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(64, 25);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "User :";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(190, 182);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(109, 25);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password :";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.BackColor = System.Drawing.Color.Transparent;
            this.labelIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIP.ForeColor = System.Drawing.Color.White;
            this.labelIP.Location = new System.Drawing.Point(190, 52);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(63, 25);
            this.labelIP.TabIndex = 3;
            this.labelIP.Text = "Host :";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.Location = new System.Drawing.Point(316, 115);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(258, 30);
            this.textBoxUser.TabIndex = 4;
            // 
            // textBoxIP
            // 
            this.textBoxIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIP.Location = new System.Drawing.Point(316, 52);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(258, 30);
            this.textBoxIP.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(316, 182);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(258, 30);
            this.textBoxPassword.TabIndex = 6;
            // 
            // richTextBoxConnectionResult
            // 
            this.richTextBoxConnectionResult.Location = new System.Drawing.Point(47, 461);
            this.richTextBoxConnectionResult.Name = "richTextBoxConnectionResult";
            this.richTextBoxConnectionResult.Size = new System.Drawing.Size(684, 197);
            this.richTextBoxConnectionResult.TabIndex = 7;
            this.richTextBoxConnectionResult.Text = "";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(751, 289);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 9;
            // 
            // buttonTestConnection
            // 
            this.buttonTestConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonTestConnection.Location = new System.Drawing.Point(44, 310);
            this.buttonTestConnection.Name = "buttonTestConnection";
            this.buttonTestConnection.Size = new System.Drawing.Size(141, 83);
            this.buttonTestConnection.TabIndex = 10;
            this.buttonTestConnection.Text = "Test de Connection";
            this.buttonTestConnection.UseVisualStyleBackColor = true;
            this.buttonTestConnection.Click += new System.EventHandler(this.buttonTestConnection_Click);
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(765, 720);
            this.Controls.Add(this.buttonTestConnection);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.richTextBoxConnectionResult);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.button1);
            this.Name = "Connection";
            this.Text = "Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.RichTextBox richTextBoxConnectionResult;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button buttonTestConnection;
    }
}


namespace UserInterface
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelCity = new System.Windows.Forms.Label();
            this.LabelTemp = new System.Windows.Forms.Label();
            this.PictureWeather = new System.Windows.Forms.PictureBox();
            this.ComboCity = new System.Windows.Forms.ComboBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.MainPanel.Controls.Add(this.ButtonMinimize);
            this.MainPanel.Controls.Add(this.ButtonClose);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(565, 32);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonMinimize.FlatAppearance.BorderSize = 0;
            this.ButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonMinimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonMinimize.Location = new System.Drawing.Point(497, 0);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(34, 32);
            this.ButtonMinimize.TabIndex = 3;
            this.ButtonMinimize.Text = "_";
            this.ButtonMinimize.UseVisualStyleBackColor = true;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonClose.Location = new System.Drawing.Point(531, 0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(34, 32);
            this.ButtonClose.TabIndex = 2;
            this.ButtonClose.Text = "X";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Access Weather API";
            // 
            // LabelCity
            // 
            this.LabelCity.AutoSize = true;
            this.LabelCity.BackColor = System.Drawing.Color.Transparent;
            this.LabelCity.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.LabelCity.Location = new System.Drawing.Point(61, 92);
            this.LabelCity.Name = "LabelCity";
            this.LabelCity.Size = new System.Drawing.Size(137, 39);
            this.LabelCity.TabIndex = 4;
            this.LabelCity.Text = "Gdańsk";
            // 
            // LabelTemp
            // 
            this.LabelTemp.AutoSize = true;
            this.LabelTemp.BackColor = System.Drawing.Color.Transparent;
            this.LabelTemp.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.LabelTemp.Location = new System.Drawing.Point(66, 132);
            this.LabelTemp.Name = "LabelTemp";
            this.LabelTemp.Size = new System.Drawing.Size(126, 44);
            this.LabelTemp.TabIndex = 5;
            this.LabelTemp.Text = "-2.2˚C";
            // 
            // PictureWeather
            // 
            this.PictureWeather.BackColor = System.Drawing.Color.Transparent;
            this.PictureWeather.Image = ((System.Drawing.Image)(resources.GetObject("PictureWeather.Image")));
            this.PictureWeather.Location = new System.Drawing.Point(78, 179);
            this.PictureWeather.Name = "PictureWeather";
            this.PictureWeather.Size = new System.Drawing.Size(100, 94);
            this.PictureWeather.TabIndex = 6;
            this.PictureWeather.TabStop = false;
            // 
            // ComboCity
            // 
            this.ComboCity.AllowDrop = true;
            this.ComboCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboCity.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComboCity.FormattingEnabled = true;
            this.ComboCity.Items.AddRange(new object[] {
            "Gdańsk",
            "Warszawa",
            "Olsztyn",
            "Radom"});
            this.ComboCity.Location = new System.Drawing.Point(393, 53);
            this.ComboCity.Name = "ComboCity";
            this.ComboCity.Size = new System.Drawing.Size(150, 28);
            this.ComboCity.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(565, 358);
            this.Controls.Add(this.ComboCity);
            this.Controls.Add(this.PictureWeather);
            this.Controls.Add(this.LabelTemp);
            this.Controls.Add(this.LabelCity);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureWeather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonMinimize;
        private System.Windows.Forms.Label LabelCity;
        private System.Windows.Forms.Label LabelTemp;
        private System.Windows.Forms.PictureBox PictureWeather;
        private System.Windows.Forms.ComboBox ComboCity;
    }
}


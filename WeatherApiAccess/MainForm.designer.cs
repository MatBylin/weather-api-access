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
            this.ComboCity = new System.Windows.Forms.ComboBox();
            this.ListData = new System.Windows.Forms.ListView();
            this.Dt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Temp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Wind = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TempMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PictureWeather = new System.Windows.Forms.PictureBox();
            this.LabelWind = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.MainPanel.Controls.Add(this.ButtonMinimize);
            this.MainPanel.Controls.Add(this.ButtonClose);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(700, 32);
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
            this.ButtonMinimize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonMinimize.Location = new System.Drawing.Point(632, 0);
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
            this.ButtonClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonClose.Location = new System.Drawing.Point(666, 0);
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
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Access Weather API";
            // 
            // LabelCity
            // 
            this.LabelCity.BackColor = System.Drawing.Color.Transparent;
            this.LabelCity.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCity.ForeColor = System.Drawing.Color.Black;
            this.LabelCity.Location = new System.Drawing.Point(0, 53);
            this.LabelCity.Margin = new System.Windows.Forms.Padding(3);
            this.LabelCity.Name = "LabelCity";
            this.LabelCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelCity.Size = new System.Drawing.Size(204, 39);
            this.LabelCity.TabIndex = 4;
            this.LabelCity.Text = "Gdańsk";
            this.LabelCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTemp
            // 
            this.LabelTemp.BackColor = System.Drawing.Color.Transparent;
            this.LabelTemp.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.LabelTemp.Location = new System.Drawing.Point(83, 95);
            this.LabelTemp.Margin = new System.Windows.Forms.Padding(5);
            this.LabelTemp.Name = "LabelTemp";
            this.LabelTemp.Size = new System.Drawing.Size(108, 50);
            this.LabelTemp.TabIndex = 5;
            this.LabelTemp.Text = "2˚C";
            this.LabelTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboCity
            // 
            this.ComboCity.AllowDrop = true;
            this.ComboCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboCity.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComboCity.FormattingEnabled = true;
            this.ComboCity.Items.AddRange(new object[] {
            "Białystok",
            "Bydgoszcz",
            "Gdańsk",
            "Gorzów Wielkopolski",
            "Katowice",
            "Kielce",
            "Lublin",
            "Łódź",
            "Olsztyn",
            "Opole",
            "Poznań",
            "Rzeszów",
            "Szczecin",
            "Toruń",
            "Warszawa",
            "Wrocław",
            "Barcelona"});
            this.ComboCity.Location = new System.Drawing.Point(479, 64);
            this.ComboCity.Name = "ComboCity";
            this.ComboCity.Size = new System.Drawing.Size(209, 28);
            this.ComboCity.TabIndex = 7;
            this.ComboCity.SelectedIndexChanged += new System.EventHandler(this.ComboCity_SelectedIndexChanged);
            // 
            // ListData
            // 
            this.ListData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Dt,
            this.Temp,
            this.Wind,
            this.TempMax,
            this.Description});
            this.ListData.Location = new System.Drawing.Point(212, 119);
            this.ListData.Name = "ListData";
            this.ListData.Size = new System.Drawing.Size(476, 219);
            this.ListData.TabIndex = 9;
            this.ListData.UseCompatibleStateImageBehavior = false;
            this.ListData.View = System.Windows.Forms.View.Details;
            // 
            // Dt
            // 
            this.Dt.Text = "Date / Time:";
            this.Dt.Width = 123;
            // 
            // Temp
            // 
            this.Temp.Text = "Temp (˚C):";
            this.Temp.Width = 67;
            // 
            // Wind
            // 
            this.Wind.Text = "Wind (m/s):";
            this.Wind.Width = 70;
            // 
            // TempMax
            // 
            this.TempMax.Text = "Pressure (hPa):";
            this.TempMax.Width = 91;
            // 
            // Description
            // 
            this.Description.Text = "Description :";
            this.Description.Width = 103;
            // 
            // PictureWeather
            // 
            this.PictureWeather.BackColor = System.Drawing.Color.Transparent;
            this.PictureWeather.Image = ((System.Drawing.Image)(resources.GetObject("PictureWeather.Image")));
            this.PictureWeather.Location = new System.Drawing.Point(23, 90);
            this.PictureWeather.Name = "PictureWeather";
            this.PictureWeather.Size = new System.Drawing.Size(60, 60);
            this.PictureWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureWeather.TabIndex = 6;
            this.PictureWeather.TabStop = false;
            // 
            // LabelWind
            // 
            this.LabelWind.BackColor = System.Drawing.Color.Transparent;
            this.LabelWind.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelWind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.LabelWind.Location = new System.Drawing.Point(40, 147);
            this.LabelWind.Margin = new System.Windows.Forms.Padding(5);
            this.LabelWind.Name = "LabelWind";
            this.LabelWind.Size = new System.Drawing.Size(129, 33);
            this.LabelWind.TabIndex = 10;
            this.LabelWind.Text = "2 km/h";
            this.LabelWind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 350);
            this.Controls.Add(this.LabelWind);
            this.Controls.Add(this.LabelTemp);
            this.Controls.Add(this.PictureWeather);
            this.Controls.Add(this.LabelCity);
            this.Controls.Add(this.ListData);
            this.Controls.Add(this.ComboCity);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureWeather)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonMinimize;
        private System.Windows.Forms.Label LabelCity;
        private System.Windows.Forms.Label LabelTemp;
        private System.Windows.Forms.ComboBox ComboCity;
        private System.Windows.Forms.ListView ListData;
        private System.Windows.Forms.ColumnHeader Dt;
        private System.Windows.Forms.ColumnHeader Temp;
        private System.Windows.Forms.ColumnHeader TempMax;
        private System.Windows.Forms.ColumnHeader Wind;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.PictureBox PictureWeather;
        private System.Windows.Forms.Label LabelWind;
    }
}


namespace ctaLINQDatabase
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ctaLabel = new System.Windows.Forms.PictureBox();
            this.findStationLabel = new System.Windows.Forms.Label();
            this.stationBox = new System.Windows.Forms.PictureBox();
            this.stationTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.ridershipLabel = new System.Windows.Forms.Label();
            this.ridershipBox = new System.Windows.Forms.PictureBox();
            this.ridershipNumberLabel = new System.Windows.Forms.Label();
            this.stationListBox = new System.Windows.Forms.ListBox();
            this.stationListLabel = new System.Windows.Forms.Label();
            this.stationStopsBox = new System.Windows.Forms.ListBox();
            this.stationStopsLabel = new System.Windows.Forms.Label();
            this.accessLabel = new System.Windows.Forms.Label();
            this.travelLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationBox = new System.Windows.Forms.PictureBox();
            this.accessBox2 = new System.Windows.Forms.PictureBox();
            this.travelBox = new System.Windows.Forms.PictureBox();
            this.accessLabel2 = new System.Windows.Forms.Label();
            this.travelLabel2 = new System.Windows.Forms.Label();
            this.locationLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ctaLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridershipBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ctaLabel
            // 
            this.ctaLabel.Image = ((System.Drawing.Image)(resources.GetObject("ctaLabel.Image")));
            this.ctaLabel.Location = new System.Drawing.Point(0, 0);
            this.ctaLabel.Name = "ctaLabel";
            this.ctaLabel.Size = new System.Drawing.Size(322, 76);
            this.ctaLabel.TabIndex = 0;
            this.ctaLabel.TabStop = false;
            // 
            // findStationLabel
            // 
            this.findStationLabel.AutoSize = true;
            this.findStationLabel.BackColor = System.Drawing.Color.Black;
            this.findStationLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findStationLabel.ForeColor = System.Drawing.Color.White;
            this.findStationLabel.Location = new System.Drawing.Point(646, 24);
            this.findStationLabel.Name = "findStationLabel";
            this.findStationLabel.Size = new System.Drawing.Size(126, 19);
            this.findStationLabel.TabIndex = 1;
            this.findStationLabel.Text = "Find Station(s):";
            // 
            // stationBox
            // 
            this.stationBox.BackColor = System.Drawing.Color.Black;
            this.stationBox.Location = new System.Drawing.Point(630, 12);
            this.stationBox.Name = "stationBox";
            this.stationBox.Size = new System.Drawing.Size(247, 117);
            this.stationBox.TabIndex = 2;
            this.stationBox.TabStop = false;
            // 
            // stationTextBox
            // 
            this.stationTextBox.Location = new System.Drawing.Point(650, 56);
            this.stationTextBox.Name = "stationTextBox";
            this.stationTextBox.Size = new System.Drawing.Size(219, 20);
            this.stationTextBox.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(704, 91);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(101, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ridershipLabel
            // 
            this.ridershipLabel.AutoSize = true;
            this.ridershipLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ridershipLabel.ForeColor = System.Drawing.Color.White;
            this.ridershipLabel.Location = new System.Drawing.Point(337, 24);
            this.ridershipLabel.Name = "ridershipLabel";
            this.ridershipLabel.Size = new System.Drawing.Size(134, 19);
            this.ridershipLabel.TabIndex = 5;
            this.ridershipLabel.Text = "Total Ridership: ";
            // 
            // ridershipBox
            // 
            this.ridershipBox.BackColor = System.Drawing.Color.Silver;
            this.ridershipBox.Location = new System.Drawing.Point(477, 24);
            this.ridershipBox.Name = "ridershipBox";
            this.ridershipBox.Size = new System.Drawing.Size(126, 27);
            this.ridershipBox.TabIndex = 6;
            this.ridershipBox.TabStop = false;
            this.ridershipBox.Click += new System.EventHandler(this.ridershipBox_Click);
            // 
            // ridershipNumberLabel
            // 
            this.ridershipNumberLabel.AutoSize = true;
            this.ridershipNumberLabel.BackColor = System.Drawing.Color.Silver;
            this.ridershipNumberLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ridershipNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.ridershipNumberLabel.Location = new System.Drawing.Point(480, 28);
            this.ridershipNumberLabel.Name = "ridershipNumberLabel";
            this.ridershipNumberLabel.Size = new System.Drawing.Size(0, 20);
            this.ridershipNumberLabel.TabIndex = 7;
            // 
            // stationListBox
            // 
            this.stationListBox.FormattingEnabled = true;
            this.stationListBox.Location = new System.Drawing.Point(12, 117);
            this.stationListBox.Name = "stationListBox";
            this.stationListBox.Size = new System.Drawing.Size(251, 368);
            this.stationListBox.TabIndex = 11;
            this.stationListBox.SelectedIndexChanged += new System.EventHandler(this.stationListBox_SelectedIndexChanged);
            // 
            // stationListLabel
            // 
            this.stationListLabel.AutoSize = true;
            this.stationListLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationListLabel.ForeColor = System.Drawing.Color.White;
            this.stationListLabel.Location = new System.Drawing.Point(75, 91);
            this.stationListLabel.Name = "stationListLabel";
            this.stationListLabel.Size = new System.Drawing.Size(109, 19);
            this.stationListLabel.TabIndex = 12;
            this.stationListLabel.Text = "Station List:  ";
            // 
            // stationStopsBox
            // 
            this.stationStopsBox.FormattingEnabled = true;
            this.stationStopsBox.Location = new System.Drawing.Point(332, 234);
            this.stationStopsBox.Name = "stationStopsBox";
            this.stationStopsBox.Size = new System.Drawing.Size(251, 251);
            this.stationStopsBox.TabIndex = 13;
            this.stationStopsBox.SelectedIndexChanged += new System.EventHandler(this.stationStopsBox_SelectedIndexChanged);
            // 
            // stationStopsLabel
            // 
            this.stationStopsLabel.AutoSize = true;
            this.stationStopsLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationStopsLabel.ForeColor = System.Drawing.Color.White;
            this.stationStopsLabel.Location = new System.Drawing.Point(337, 203);
            this.stationStopsLabel.Name = "stationStopsLabel";
            this.stationStopsLabel.Size = new System.Drawing.Size(174, 19);
            this.stationStopsLabel.TabIndex = 14;
            this.stationStopsLabel.Text = "Stops at this station:  ";
            // 
            // accessLabel
            // 
            this.accessLabel.AutoSize = true;
            this.accessLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessLabel.ForeColor = System.Drawing.Color.White;
            this.accessLabel.Location = new System.Drawing.Point(626, 343);
            this.accessLabel.Name = "accessLabel";
            this.accessLabel.Size = new System.Drawing.Size(177, 19);
            this.accessLabel.TabIndex = 15;
            this.accessLabel.Text = "Handicap accessible?";
            // 
            // travelLabel
            // 
            this.travelLabel.AutoSize = true;
            this.travelLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travelLabel.ForeColor = System.Drawing.Color.White;
            this.travelLabel.Location = new System.Drawing.Point(626, 386);
            this.travelLabel.Name = "travelLabel";
            this.travelLabel.Size = new System.Drawing.Size(153, 19);
            this.travelLabel.TabIndex = 16;
            this.travelLabel.Text = "Direction of travel: ";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.ForeColor = System.Drawing.Color.White;
            this.locationLabel.Location = new System.Drawing.Point(626, 436);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(86, 19);
            this.locationLabel.TabIndex = 17;
            this.locationLabel.Text = "Location: ";
            // 
            // locationBox
            // 
            this.locationBox.BackColor = System.Drawing.Color.Silver;
            this.locationBox.Location = new System.Drawing.Point(630, 458);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(239, 27);
            this.locationBox.TabIndex = 18;
            this.locationBox.TabStop = false;
            // 
            // accessBox2
            // 
            this.accessBox2.BackColor = System.Drawing.Color.Silver;
            this.accessBox2.Location = new System.Drawing.Point(809, 339);
            this.accessBox2.Name = "accessBox2";
            this.accessBox2.Size = new System.Drawing.Size(60, 27);
            this.accessBox2.TabIndex = 20;
            this.accessBox2.TabStop = false;
            // 
            // travelBox
            // 
            this.travelBox.BackColor = System.Drawing.Color.Silver;
            this.travelBox.Location = new System.Drawing.Point(809, 381);
            this.travelBox.Name = "travelBox";
            this.travelBox.Size = new System.Drawing.Size(60, 27);
            this.travelBox.TabIndex = 21;
            this.travelBox.TabStop = false;
            // 
            // accessLabel2
            // 
            this.accessLabel2.AutoSize = true;
            this.accessLabel2.BackColor = System.Drawing.Color.Silver;
            this.accessLabel2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessLabel2.ForeColor = System.Drawing.Color.Black;
            this.accessLabel2.Location = new System.Drawing.Point(809, 342);
            this.accessLabel2.Name = "accessLabel2";
            this.accessLabel2.Size = new System.Drawing.Size(0, 20);
            this.accessLabel2.TabIndex = 22;
            // 
            // travelLabel2
            // 
            this.travelLabel2.AutoSize = true;
            this.travelLabel2.BackColor = System.Drawing.Color.Silver;
            this.travelLabel2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travelLabel2.ForeColor = System.Drawing.Color.Black;
            this.travelLabel2.Location = new System.Drawing.Point(809, 385);
            this.travelLabel2.Name = "travelLabel2";
            this.travelLabel2.Size = new System.Drawing.Size(0, 20);
            this.travelLabel2.TabIndex = 23;
            // 
            // locationLabel2
            // 
            this.locationLabel2.AutoSize = true;
            this.locationLabel2.BackColor = System.Drawing.Color.Silver;
            this.locationLabel2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel2.ForeColor = System.Drawing.Color.Black;
            this.locationLabel2.Location = new System.Drawing.Point(634, 462);
            this.locationLabel2.Name = "locationLabel2";
            this.locationLabel2.Size = new System.Drawing.Size(0, 20);
            this.locationLabel2.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(882, 505);
            this.Controls.Add(this.locationLabel2);
            this.Controls.Add(this.travelLabel2);
            this.Controls.Add(this.accessLabel2);
            this.Controls.Add(this.travelBox);
            this.Controls.Add(this.accessBox2);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.travelLabel);
            this.Controls.Add(this.accessLabel);
            this.Controls.Add(this.stationStopsLabel);
            this.Controls.Add(this.stationStopsBox);
            this.Controls.Add(this.stationListLabel);
            this.Controls.Add(this.stationListBox);
            this.Controls.Add(this.ridershipNumberLabel);
            this.Controls.Add(this.ridershipBox);
            this.Controls.Add(this.ridershipLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.stationTextBox);
            this.Controls.Add(this.findStationLabel);
            this.Controls.Add(this.ctaLabel);
            this.Controls.Add(this.stationBox);
            this.Name = "Form1";
            this.Text = "Chicago Transit Authority Database";
            ((System.ComponentModel.ISupportInitialize)(this.ctaLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridershipBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ctaLabel;
        private System.Windows.Forms.Label findStationLabel;
        private System.Windows.Forms.PictureBox stationBox;
        private System.Windows.Forms.TextBox stationTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label ridershipLabel;
        private System.Windows.Forms.PictureBox ridershipBox;
        private System.Windows.Forms.Label ridershipNumberLabel;
        private System.Windows.Forms.ListBox stationListBox;
        private System.Windows.Forms.Label stationListLabel;
        private System.Windows.Forms.ListBox stationStopsBox;
        private System.Windows.Forms.Label stationStopsLabel;
        private System.Windows.Forms.Label accessLabel;
        private System.Windows.Forms.Label travelLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.PictureBox locationBox;
        private System.Windows.Forms.PictureBox accessBox2;
        private System.Windows.Forms.PictureBox travelBox;
        private System.Windows.Forms.Label accessLabel2;
        private System.Windows.Forms.Label travelLabel2;
        private System.Windows.Forms.Label locationLabel2;
    }
}


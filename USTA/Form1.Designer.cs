namespace USTA
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
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.btAirport = new System.Windows.Forms.Button();
            this.btFlights = new System.Windows.Forms.Button();
            this.dgvAirView = new System.Windows.Forms.DataGridView();
            this.btMaxPopular = new System.Windows.Forms.Button();
            this.btLeastPopular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirView)).BeginInit();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(47, 12);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(699, 670);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 4D;
            this.gmap.Load += new System.EventHandler(this.gmap_Load);
            // 
            // btAirport
            // 
            this.btAirport.Location = new System.Drawing.Point(814, 12);
            this.btAirport.Name = "btAirport";
            this.btAirport.Size = new System.Drawing.Size(110, 35);
            this.btAirport.TabIndex = 1;
            this.btAirport.Text = "Airport";
            this.btAirport.UseVisualStyleBackColor = true;
            this.btAirport.Click += new System.EventHandler(this.button1_Click);
            // 
            // btFlights
            // 
            this.btFlights.Location = new System.Drawing.Point(1097, 13);
            this.btFlights.Name = "btFlights";
            this.btFlights.Size = new System.Drawing.Size(106, 35);
            this.btFlights.TabIndex = 2;
            this.btFlights.Text = "Flights";
            this.btFlights.UseVisualStyleBackColor = true;
            // 
            // dgvAirView
            // 
            this.dgvAirView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirView.Location = new System.Drawing.Point(795, 135);
            this.dgvAirView.Name = "dgvAirView";
            this.dgvAirView.RowHeadersWidth = 51;
            this.dgvAirView.RowTemplate.Height = 24;
            this.dgvAirView.Size = new System.Drawing.Size(501, 548);
            this.dgvAirView.TabIndex = 3;
            this.dgvAirView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btMaxPopular
            // 
            this.btMaxPopular.Location = new System.Drawing.Point(814, 73);
            this.btMaxPopular.Name = "btMaxPopular";
            this.btMaxPopular.Size = new System.Drawing.Size(110, 36);
            this.btMaxPopular.TabIndex = 4;
            this.btMaxPopular.Text = "Most Popular";
            this.btMaxPopular.UseVisualStyleBackColor = true;
            // 
            // btLeastPopular
            // 
            this.btLeastPopular.Location = new System.Drawing.Point(1097, 74);
            this.btLeastPopular.Name = "btLeastPopular";
            this.btLeastPopular.Size = new System.Drawing.Size(106, 35);
            this.btLeastPopular.TabIndex = 5;
            this.btLeastPopular.Text = "Least Popular";
            this.btLeastPopular.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 767);
            this.Controls.Add(this.btLeastPopular);
            this.Controls.Add(this.btMaxPopular);
            this.Controls.Add(this.dgvAirView);
            this.Controls.Add(this.btFlights);
            this.Controls.Add(this.btAirport);
            this.Controls.Add(this.gmap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Button btAirport;
        private System.Windows.Forms.Button btFlights;
        private System.Windows.Forms.DataGridView dgvAirView;
        private System.Windows.Forms.Button btMaxPopular;
        private System.Windows.Forms.Button btLeastPopular;
    }
}


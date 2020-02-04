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
            this.dgvAirView = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbAnswer = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
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
            this.gmap.Location = new System.Drawing.Point(35, 10);
            this.gmap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.gmap.Size = new System.Drawing.Size(524, 544);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 4D;
            this.gmap.Load += new System.EventHandler(this.gmap_Load);
            // 
            // dgvAirView
            // 
            this.dgvAirView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirView.Location = new System.Drawing.Point(596, 110);
            this.dgvAirView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAirView.Name = "dgvAirView";
            this.dgvAirView.RowHeadersWidth = 51;
            this.dgvAirView.RowTemplate.Height = 24;
            this.dgvAirView.Size = new System.Drawing.Size(376, 445);
            this.dgvAirView.TabIndex = 3;
            this.dgvAirView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Origin City",
            "Destination City",
            "Airplane Tail ID",
            "Flight Duration",
            "Flight Distance"});
            this.comboBox1.Location = new System.Drawing.Point(596, 48);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(616, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sort By :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbAnswer
            // 
            this.txbAnswer.Location = new System.Drawing.Point(748, 48);
            this.txbAnswer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbAnswer.Name = "txbAnswer";
            this.txbAnswer.Size = new System.Drawing.Size(102, 20);
            this.txbAnswer.TabIndex = 6;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(883, 31);
            this.btSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(68, 52);
            this.btSearch.TabIndex = 7;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.txbAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvAirView);
            this.Controls.Add(this.gmap);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.DataGridView dgvAirView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAnswer;
        private System.Windows.Forms.Button btSearch;
    }
}


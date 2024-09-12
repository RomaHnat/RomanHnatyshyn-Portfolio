namespace EquipmentSYS
{
    partial class frmYearlyRevenueAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYearlyRevenueAnalysis));
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.grpYearlyRevenue = new System.Windows.Forms.GroupBox();
            this.btnOkYearlyRevenueAnalysis = new System.Windows.Forms.Button();
            this.chrRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpYearlyRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(9, 10);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 27);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "╳ Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Year:";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(139, 72);
            this.comboBoxYear.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(92, 30);
            this.comboBoxYear.TabIndex = 11;
            this.comboBoxYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxYear_SelectedIndexChanged);
            // 
            // grpYearlyRevenue
            // 
            this.grpYearlyRevenue.Controls.Add(this.chrRevenue);
            this.grpYearlyRevenue.Controls.Add(this.btnOkYearlyRevenueAnalysis);
            this.grpYearlyRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpYearlyRevenue.ForeColor = System.Drawing.Color.White;
            this.grpYearlyRevenue.Location = new System.Drawing.Point(11, 121);
            this.grpYearlyRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.grpYearlyRevenue.Name = "grpYearlyRevenue";
            this.grpYearlyRevenue.Padding = new System.Windows.Forms.Padding(2);
            this.grpYearlyRevenue.Size = new System.Drawing.Size(471, 453);
            this.grpYearlyRevenue.TabIndex = 12;
            this.grpYearlyRevenue.TabStop = false;
            this.grpYearlyRevenue.Text = "Yearly Revenue";
            this.grpYearlyRevenue.Visible = false;
            // 
            // btnOkYearlyRevenueAnalysis
            // 
            this.btnOkYearlyRevenueAnalysis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnOkYearlyRevenueAnalysis.Location = new System.Drawing.Point(201, 398);
            this.btnOkYearlyRevenueAnalysis.Margin = new System.Windows.Forms.Padding(2);
            this.btnOkYearlyRevenueAnalysis.Name = "btnOkYearlyRevenueAnalysis";
            this.btnOkYearlyRevenueAnalysis.Size = new System.Drawing.Size(69, 36);
            this.btnOkYearlyRevenueAnalysis.TabIndex = 13;
            this.btnOkYearlyRevenueAnalysis.Text = "OK";
            this.btnOkYearlyRevenueAnalysis.UseVisualStyleBackColor = true;
            this.btnOkYearlyRevenueAnalysis.Click += new System.EventHandler(this.btnOkYearlyRevenueAnalysis_Click);
            // 
            // chrRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chrRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrRevenue.Legends.Add(legend1);
            this.chrRevenue.Location = new System.Drawing.Point(5, 26);
            this.chrRevenue.Name = "chrRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrRevenue.Series.Add(series1);
            this.chrRevenue.Size = new System.Drawing.Size(461, 350);
            this.chrRevenue.TabIndex = 14;
            this.chrRevenue.Text = "chart1";
            // 
            // frmYearlyRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(493, 596);
            this.Controls.Add(this.grpYearlyRevenue);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmYearlyRevenueAnalysis";
            this.Text = "Yearly Revenue Analysis";
            this.Load += new System.EventHandler(this.frmYearlyRevenueAnalysis_Load);
            this.grpYearlyRevenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.GroupBox grpYearlyRevenue;
        private System.Windows.Forms.Button btnOkYearlyRevenueAnalysis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrRevenue;
    }
}
namespace EquipmentSYS
{
    partial class frmAnalyseCategoryProfit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalyseCategoryProfit));
            this.btnExit = new System.Windows.Forms.Button();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEquipmentProfit = new System.Windows.Forms.GroupBox();
            this.txtReport = new System.Windows.Forms.RichTextBox();
            this.btnOkYearlyRevenueAnalysis = new System.Windows.Forms.Button();
            this.grpEquipmentProfit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(9, 10);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 27);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "╳ Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(146, 74);
            this.comboBoxYear.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(92, 30);
            this.comboBoxYear.TabIndex = 16;
            this.comboBoxYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxYear_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Year:";
            // 
            // grpEquipmentProfit
            // 
            this.grpEquipmentProfit.Controls.Add(this.txtReport);
            this.grpEquipmentProfit.Controls.Add(this.btnOkYearlyRevenueAnalysis);
            this.grpEquipmentProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEquipmentProfit.ForeColor = System.Drawing.Color.White;
            this.grpEquipmentProfit.Location = new System.Drawing.Point(24, 134);
            this.grpEquipmentProfit.Margin = new System.Windows.Forms.Padding(2);
            this.grpEquipmentProfit.Name = "grpEquipmentProfit";
            this.grpEquipmentProfit.Padding = new System.Windows.Forms.Padding(2);
            this.grpEquipmentProfit.Size = new System.Drawing.Size(237, 313);
            this.grpEquipmentProfit.TabIndex = 17;
            this.grpEquipmentProfit.TabStop = false;
            this.grpEquipmentProfit.Text = "Categories Profit";
            this.grpEquipmentProfit.Visible = false;
            // 
            // txtReport
            // 
            this.txtReport.BackColor = System.Drawing.Color.White;
            this.txtReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReport.Enabled = false;
            this.txtReport.ForeColor = System.Drawing.Color.Black;
            this.txtReport.Location = new System.Drawing.Point(4, 37);
            this.txtReport.Margin = new System.Windows.Forms.Padding(2);
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(229, 214);
            this.txtReport.TabIndex = 15;
            this.txtReport.Text = "";
            // 
            // btnOkYearlyRevenueAnalysis
            // 
            this.btnOkYearlyRevenueAnalysis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnOkYearlyRevenueAnalysis.Location = new System.Drawing.Point(84, 264);
            this.btnOkYearlyRevenueAnalysis.Margin = new System.Windows.Forms.Padding(2);
            this.btnOkYearlyRevenueAnalysis.Name = "btnOkYearlyRevenueAnalysis";
            this.btnOkYearlyRevenueAnalysis.Size = new System.Drawing.Size(69, 36);
            this.btnOkYearlyRevenueAnalysis.TabIndex = 14;
            this.btnOkYearlyRevenueAnalysis.Text = "OK";
            this.btnOkYearlyRevenueAnalysis.UseVisualStyleBackColor = true;
            this.btnOkYearlyRevenueAnalysis.Click += new System.EventHandler(this.btnOkYearlyRevenueAnalysis_Click);
            // 
            // frmAnalyseCategoryProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(285, 471);
            this.Controls.Add(this.grpEquipmentProfit);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAnalyseCategoryProfit";
            this.Text = "Analyse Category Profit";
            this.Load += new System.EventHandler(this.frmAnalyseCategoryProfit_Load);
            this.grpEquipmentProfit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpEquipmentProfit;
        private System.Windows.Forms.Button btnOkYearlyRevenueAnalysis;
        private System.Windows.Forms.RichTextBox txtReport;
    }
}
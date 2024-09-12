namespace EquipmentSYS
{
    partial class frmRecordReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecordReturn));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpRentalDetails = new System.Windows.Forms.GroupBox();
            this.comboBoxEquipmentInRental = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDateRange = new System.Windows.Forms.TextBox();
            this.btnRecordReturn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRentalID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpRentalDetails.SuspendLayout();
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
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "╳ Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(286, 77);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(26, 28);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "⌕";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpRentalDetails
            // 
            this.grpRentalDetails.Controls.Add(this.comboBoxEquipmentInRental);
            this.grpRentalDetails.Controls.Add(this.txtPrice);
            this.grpRentalDetails.Controls.Add(this.txtDateRange);
            this.grpRentalDetails.Controls.Add(this.btnRecordReturn);
            this.grpRentalDetails.Controls.Add(this.label4);
            this.grpRentalDetails.Controls.Add(this.label3);
            this.grpRentalDetails.Controls.Add(this.label2);
            this.grpRentalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRentalDetails.ForeColor = System.Drawing.Color.White;
            this.grpRentalDetails.Location = new System.Drawing.Point(28, 133);
            this.grpRentalDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpRentalDetails.Name = "grpRentalDetails";
            this.grpRentalDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpRentalDetails.Size = new System.Drawing.Size(374, 372);
            this.grpRentalDetails.TabIndex = 18;
            this.grpRentalDetails.TabStop = false;
            this.grpRentalDetails.Text = "Rental Details";
            this.grpRentalDetails.Visible = false;
            // 
            // comboBoxEquipmentInRental
            // 
            this.comboBoxEquipmentInRental.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEquipmentInRental.FormattingEnabled = true;
            this.comboBoxEquipmentInRental.Location = new System.Drawing.Point(8, 161);
            this.comboBoxEquipmentInRental.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxEquipmentInRental.Name = "comboBoxEquipmentInRental";
            this.comboBoxEquipmentInRental.Size = new System.Drawing.Size(354, 30);
            this.comboBoxEquipmentInRental.TabIndex = 21;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(248, 79);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(114, 28);
            this.txtPrice.TabIndex = 20;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDateRange
            // 
            this.txtDateRange.Enabled = false;
            this.txtDateRange.Location = new System.Drawing.Point(132, 41);
            this.txtDateRange.Margin = new System.Windows.Forms.Padding(2);
            this.txtDateRange.Name = "txtDateRange";
            this.txtDateRange.Size = new System.Drawing.Size(230, 28);
            this.txtDateRange.TabIndex = 19;
            this.txtDateRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRecordReturn
            // 
            this.btnRecordReturn.ForeColor = System.Drawing.Color.Black;
            this.btnRecordReturn.Location = new System.Drawing.Point(98, 310);
            this.btnRecordReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecordReturn.Name = "btnRecordReturn";
            this.btnRecordReturn.Size = new System.Drawing.Size(195, 41);
            this.btnRecordReturn.TabIndex = 18;
            this.btnRecordReturn.Text = "Record Return";
            this.btnRecordReturn.UseVisualStyleBackColor = true;
            this.btnRecordReturn.Click += new System.EventHandler(this.btnRecordReturn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(82, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Equipment in the Rental: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Price: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Date Range: ";
            // 
            // txtRentalID
            // 
            this.txtRentalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentalID.Location = new System.Drawing.Point(169, 77);
            this.txtRentalID.Margin = new System.Windows.Forms.Padding(2);
            this.txtRentalID.MaxLength = 6;
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.Size = new System.Drawing.Size(114, 28);
            this.txtRentalID.TabIndex = 17;
            this.txtRentalID.TextChanged += new System.EventHandler(this.txtRentalID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "RentalID: ";
            // 
            // frmRecordReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(434, 538);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpRentalDetails);
            this.Controls.Add(this.txtRentalID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRecordReturn";
            this.Text = "Record Return";
            this.Load += new System.EventHandler(this.frmRecordReturn_Load);
            this.grpRentalDetails.ResumeLayout(false);
            this.grpRentalDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpRentalDetails;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDateRange;
        private System.Windows.Forms.Button btnRecordReturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRentalID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEquipmentInRental;
    }
}
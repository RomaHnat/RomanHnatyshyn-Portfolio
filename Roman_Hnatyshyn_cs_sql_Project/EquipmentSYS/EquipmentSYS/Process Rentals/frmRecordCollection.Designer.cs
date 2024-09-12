namespace EquipmentSYS
{
    partial class frmRecordCollection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecordCollection));
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRentalID = new System.Windows.Forms.TextBox();
            this.grpRentalDetails = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDateRange = new System.Windows.Forms.TextBox();
            this.btnRecordCollection = new System.Windows.Forms.Button();
            this.txtEquipmentInRental = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpRentalDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 33);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "╳ Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "RentalID: ";
            // 
            // txtRentalID
            // 
            this.txtRentalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentalID.Location = new System.Drawing.Point(232, 89);
            this.txtRentalID.MaxLength = 6;
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.Size = new System.Drawing.Size(151, 34);
            this.txtRentalID.TabIndex = 13;
            this.txtRentalID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grpRentalDetails
            // 
            this.grpRentalDetails.Controls.Add(this.txtPrice);
            this.grpRentalDetails.Controls.Add(this.txtDateRange);
            this.grpRentalDetails.Controls.Add(this.btnRecordCollection);
            this.grpRentalDetails.Controls.Add(this.txtEquipmentInRental);
            this.grpRentalDetails.Controls.Add(this.label4);
            this.grpRentalDetails.Controls.Add(this.label3);
            this.grpRentalDetails.Controls.Add(this.label2);
            this.grpRentalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRentalDetails.ForeColor = System.Drawing.Color.White;
            this.grpRentalDetails.Location = new System.Drawing.Point(45, 158);
            this.grpRentalDetails.Name = "grpRentalDetails";
            this.grpRentalDetails.Size = new System.Drawing.Size(499, 458);
            this.grpRentalDetails.TabIndex = 14;
            this.grpRentalDetails.TabStop = false;
            this.grpRentalDetails.Text = "Rental Details";
            this.grpRentalDetails.Visible = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(331, 97);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(151, 34);
            this.txtPrice.TabIndex = 20;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDateRange
            // 
            this.txtDateRange.Enabled = false;
            this.txtDateRange.Location = new System.Drawing.Point(176, 50);
            this.txtDateRange.Name = "txtDateRange";
            this.txtDateRange.Size = new System.Drawing.Size(306, 34);
            this.txtDateRange.TabIndex = 19;
            this.txtDateRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRecordCollection
            // 
            this.btnRecordCollection.ForeColor = System.Drawing.Color.Black;
            this.btnRecordCollection.Location = new System.Drawing.Point(130, 382);
            this.btnRecordCollection.Name = "btnRecordCollection";
            this.btnRecordCollection.Size = new System.Drawing.Size(260, 50);
            this.btnRecordCollection.TabIndex = 18;
            this.btnRecordCollection.Text = "Record Collection";
            this.btnRecordCollection.UseVisualStyleBackColor = true;
            this.btnRecordCollection.Click += new System.EventHandler(this.btnRecordCollection_Click);
            // 
            // txtEquipmentInRental
            // 
            this.txtEquipmentInRental.Enabled = false;
            this.txtEquipmentInRental.Location = new System.Drawing.Point(11, 193);
            this.txtEquipmentInRental.Name = "txtEquipmentInRental";
            this.txtEquipmentInRental.Size = new System.Drawing.Size(471, 158);
            this.txtEquipmentInRental.TabIndex = 16;
            this.txtEquipmentInRental.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(110, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Equipment in the Rental: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Price: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Date Range: ";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(389, 89);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 34);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "⌕";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmRecordCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(587, 639);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpRentalDetails);
            this.Controls.Add(this.txtRentalID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecordCollection";
            this.Text = "Record Collection";
            this.grpRentalDetails.ResumeLayout(false);
            this.grpRentalDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRentalID;
        private System.Windows.Forms.GroupBox grpRentalDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRecordCollection;
        private System.Windows.Forms.RichTextBox txtEquipmentInRental;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDateRange;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPrice;
    }
}
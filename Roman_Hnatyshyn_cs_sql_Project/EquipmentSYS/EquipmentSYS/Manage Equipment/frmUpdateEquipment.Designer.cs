namespace EquipmentSYS
{
    partial class frmUpdateEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateEquipment));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEquipment = new System.Windows.Forms.ComboBox();
            this.grpEquipment = new System.Windows.Forms.GroupBox();
            this.btnUpdateEquipment = new System.Windows.Forms.Button();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEquipmentRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEquipmentDescription = new System.Windows.Forms.RichTextBox();
            this.txtEquipmentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxNewCategories = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpEquipment.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category:";
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(404, 77);
            this.comboBoxCategories.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(157, 32);
            this.comboBoxCategories.TabIndex = 5;
            this.comboBoxCategories.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategories_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Equipment:";
            this.label2.Visible = false;
            // 
            // comboBoxEquipment
            // 
            this.comboBoxEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEquipment.FormattingEnabled = true;
            this.comboBoxEquipment.Location = new System.Drawing.Point(222, 134);
            this.comboBoxEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxEquipment.Name = "comboBoxEquipment";
            this.comboBoxEquipment.Size = new System.Drawing.Size(339, 32);
            this.comboBoxEquipment.TabIndex = 7;
            this.comboBoxEquipment.Visible = false;
            this.comboBoxEquipment.SelectedIndexChanged += new System.EventHandler(this.comboBoxEquipment_SelectedIndexChanged);
            // 
            // grpEquipment
            // 
            this.grpEquipment.Controls.Add(this.btnUpdateEquipment);
            this.grpEquipment.Controls.Add(this.txtSerialNumber);
            this.grpEquipment.Controls.Add(this.label5);
            this.grpEquipment.Controls.Add(this.txtEquipmentRate);
            this.grpEquipment.Controls.Add(this.label4);
            this.grpEquipment.Controls.Add(this.txtEquipmentDescription);
            this.grpEquipment.Controls.Add(this.txtEquipmentName);
            this.grpEquipment.Controls.Add(this.label3);
            this.grpEquipment.Controls.Add(this.label6);
            this.grpEquipment.Controls.Add(this.comboBoxNewCategories);
            this.grpEquipment.Controls.Add(this.label7);
            this.grpEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEquipment.ForeColor = System.Drawing.Color.White;
            this.grpEquipment.Location = new System.Drawing.Point(38, 193);
            this.grpEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.grpEquipment.Name = "grpEquipment";
            this.grpEquipment.Padding = new System.Windows.Forms.Padding(2);
            this.grpEquipment.Size = new System.Drawing.Size(523, 384);
            this.grpEquipment.TabIndex = 8;
            this.grpEquipment.TabStop = false;
            this.grpEquipment.Text = "Update Equipment";
            this.grpEquipment.Visible = false;
            // 
            // btnUpdateEquipment
            // 
            this.btnUpdateEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEquipment.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateEquipment.Location = new System.Drawing.Point(184, 305);
            this.btnUpdateEquipment.Name = "btnUpdateEquipment";
            this.btnUpdateEquipment.Size = new System.Drawing.Size(146, 56);
            this.btnUpdateEquipment.TabIndex = 31;
            this.btnUpdateEquipment.Text = "Update Equipment";
            this.btnUpdateEquipment.UseVisualStyleBackColor = true;
            this.btnUpdateEquipment.Click += new System.EventHandler(this.btnUpdateEquipment_Click);
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNumber.Location = new System.Drawing.Point(333, 136);
            this.txtSerialNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtSerialNumber.MaxLength = 10;
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(157, 29);
            this.txtSerialNumber.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Serial Number:";
            // 
            // txtEquipmentRate
            // 
            this.txtEquipmentRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipmentRate.Location = new System.Drawing.Point(407, 246);
            this.txtEquipmentRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtEquipmentRate.MaxLength = 8;
            this.txtEquipmentRate.Name = "txtEquipmentRate";
            this.txtEquipmentRate.Size = new System.Drawing.Size(83, 29);
            this.txtEquipmentRate.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Rate:";
            // 
            // txtEquipmentDescription
            // 
            this.txtEquipmentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipmentDescription.Location = new System.Drawing.Point(333, 182);
            this.txtEquipmentDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtEquipmentDescription.MaxLength = 30;
            this.txtEquipmentDescription.Name = "txtEquipmentDescription";
            this.txtEquipmentDescription.Size = new System.Drawing.Size(157, 45);
            this.txtEquipmentDescription.TabIndex = 26;
            this.txtEquipmentDescription.Text = "";
            // 
            // txtEquipmentName
            // 
            this.txtEquipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipmentName.Location = new System.Drawing.Point(333, 89);
            this.txtEquipmentName.Margin = new System.Windows.Forms.Padding(2);
            this.txtEquipmentName.MaxLength = 15;
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.Size = new System.Drawing.Size(157, 29);
            this.txtEquipmentName.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(29, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Description:";
            // 
            // comboBoxNewCategories
            // 
            this.comboBoxNewCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNewCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNewCategories.FormattingEnabled = true;
            this.comboBoxNewCategories.Location = new System.Drawing.Point(333, 41);
            this.comboBoxNewCategories.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxNewCategories.Name = "comboBoxNewCategories";
            this.comboBoxNewCategories.Size = new System.Drawing.Size(157, 32);
            this.comboBoxNewCategories.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(29, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "Category:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(9, 10);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 27);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "╳ Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmUpdateEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpEquipment);
            this.Controls.Add(this.comboBoxEquipment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUpdateEquipment";
            this.Text = "Update Equipment";
            this.Load += new System.EventHandler(this.frmUpdateEquipment_Load);
            this.grpEquipment.ResumeLayout(false);
            this.grpEquipment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEquipment;
        private System.Windows.Forms.GroupBox grpEquipment;
        private System.Windows.Forms.Button btnUpdateEquipment;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEquipmentRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtEquipmentDescription;
        private System.Windows.Forms.TextBox txtEquipmentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxNewCategories;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExit;
    }
}
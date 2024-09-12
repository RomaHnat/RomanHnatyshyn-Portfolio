namespace EquipmentSYS
{
    partial class frmDeregisterClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeregisterClient));
            this.btnExit = new System.Windows.Forms.Button();
            this.grpClientDetails = new System.Windows.Forms.GroupBox();
            this.btnDeRegisterClient = new System.Windows.Forms.Button();
            this.txtNewEmailAddress = new System.Windows.Forms.TextBox();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpClientDetails.SuspendLayout();
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
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "╳ Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpClientDetails
            // 
            this.grpClientDetails.Controls.Add(this.btnDeRegisterClient);
            this.grpClientDetails.Controls.Add(this.txtNewEmailAddress);
            this.grpClientDetails.Controls.Add(this.txtMobileNumber);
            this.grpClientDetails.Controls.Add(this.txtSecondName);
            this.grpClientDetails.Controls.Add(this.txtFirstName);
            this.grpClientDetails.Controls.Add(this.label4);
            this.grpClientDetails.Controls.Add(this.label3);
            this.grpClientDetails.Controls.Add(this.label2);
            this.grpClientDetails.Controls.Add(this.label1);
            this.grpClientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpClientDetails.ForeColor = System.Drawing.Color.White;
            this.grpClientDetails.Location = new System.Drawing.Point(22, 122);
            this.grpClientDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpClientDetails.Name = "grpClientDetails";
            this.grpClientDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpClientDetails.Size = new System.Drawing.Size(401, 302);
            this.grpClientDetails.TabIndex = 30;
            this.grpClientDetails.TabStop = false;
            this.grpClientDetails.Text = "Update Client";
            this.grpClientDetails.Visible = false;
            // 
            // btnDeRegisterClient
            // 
            this.btnDeRegisterClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeRegisterClient.ForeColor = System.Drawing.Color.Black;
            this.btnDeRegisterClient.Location = new System.Drawing.Point(103, 219);
            this.btnDeRegisterClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeRegisterClient.Name = "btnDeRegisterClient";
            this.btnDeRegisterClient.Size = new System.Drawing.Size(196, 65);
            this.btnDeRegisterClient.TabIndex = 10;
            this.btnDeRegisterClient.Text = "De-Register/Restore Client";
            this.btnDeRegisterClient.UseVisualStyleBackColor = true;
            this.btnDeRegisterClient.Click += new System.EventHandler(this.btnDeRegisterClient_Click);
            // 
            // txtNewEmailAddress
            // 
            this.txtNewEmailAddress.Enabled = false;
            this.txtNewEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewEmailAddress.Location = new System.Drawing.Point(256, 162);
            this.txtNewEmailAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewEmailAddress.MaxLength = 50;
            this.txtNewEmailAddress.Name = "txtNewEmailAddress";
            this.txtNewEmailAddress.Size = new System.Drawing.Size(131, 28);
            this.txtNewEmailAddress.TabIndex = 6;
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Enabled = false;
            this.txtMobileNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNumber.Location = new System.Drawing.Point(256, 120);
            this.txtMobileNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtMobileNumber.MaxLength = 13;
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(131, 28);
            this.txtMobileNumber.TabIndex = 7;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Enabled = false;
            this.txtSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondName.Location = new System.Drawing.Point(256, 80);
            this.txtSecondName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSecondName.MaxLength = 20;
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(131, 28);
            this.txtSecondName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(256, 37);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(131, 28);
            this.txtFirstName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mobile Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Second Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(324, 72);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(26, 28);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "⌕";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAddress.Location = new System.Drawing.Point(190, 72);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailAddress.MaxLength = 50;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(131, 28);
            this.txtEmailAddress.TabIndex = 28;
            this.txtEmailAddress.TextChanged += new System.EventHandler(this.txtEmailAddress_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Email Address:";
            // 
            // frmDeregisterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(446, 447);
            this.Controls.Add(this.grpClientDetails);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDeregisterClient";
            this.Text = "De-Register/Restore Client";
            this.grpClientDetails.ResumeLayout(false);
            this.grpClientDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpClientDetails;
        private System.Windows.Forms.Button btnDeRegisterClient;
        private System.Windows.Forms.TextBox txtNewEmailAddress;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label label5;
    }
}
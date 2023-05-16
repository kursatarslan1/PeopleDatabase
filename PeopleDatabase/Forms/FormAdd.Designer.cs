namespace PeopleDatabase.Forms
{
    partial class FormAdd
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
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxMiddleName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxWeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxHeight = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbGetImage = new System.Windows.Forms.PictureBox();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.btnCleanFields = new System.Windows.Forms.Button();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbGetImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(358, 110);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(146, 20);
            this.txtBoxName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname :";
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Location = new System.Drawing.Point(358, 195);
            this.txtBoxSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(146, 20);
            this.txtBoxSurname.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Id :";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(358, 74);
            this.txtBoxId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(146, 20);
            this.txtBoxId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Middle Name :";
            // 
            // txtBoxMiddleName
            // 
            this.txtBoxMiddleName.Location = new System.Drawing.Point(358, 156);
            this.txtBoxMiddleName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxMiddleName.Name = "txtBoxMiddleName";
            this.txtBoxMiddleName.Size = new System.Drawing.Size(146, 20);
            this.txtBoxMiddleName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Birthday :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Address :";
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(358, 258);
            this.txtBoxAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxAddress.Multiline = true;
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(431, 93);
            this.txtBoxAddress.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(550, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Phone Number :";
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(640, 113);
            this.txtBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(183, 20);
            this.txtBoxPhoneNumber.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(589, 161);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Weight :";
            // 
            // txtBoxWeight
            // 
            this.txtBoxWeight.Location = new System.Drawing.Point(640, 158);
            this.txtBoxWeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxWeight.Name = "txtBoxWeight";
            this.txtBoxWeight.Size = new System.Drawing.Size(183, 20);
            this.txtBoxWeight.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(589, 197);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Height :";
            // 
            // txtBoxHeight
            // 
            this.txtBoxHeight.Location = new System.Drawing.Point(640, 195);
            this.txtBoxHeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxHeight.Name = "txtBoxHeight";
            this.txtBoxHeight.Size = new System.Drawing.Size(183, 20);
            this.txtBoxHeight.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbGetImage
            // 
            this.pbGetImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbGetImage.Location = new System.Drawing.Point(9, 63);
            this.pbGetImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbGetImage.Name = "pbGetImage";
            this.pbGetImage.Size = new System.Drawing.Size(258, 269);
            this.pbGetImage.TabIndex = 0;
            this.pbGetImage.TabStop = false;
            this.pbGetImage.Click += new System.EventHandler(this.pbGetImage_Click);
            this.pbGetImage.MouseLeave += new System.EventHandler(this.pbGetImage_MouseLeave);
            this.pbGetImage.MouseHover += new System.EventHandler(this.pbGetImage_MouseHover);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(435, 372);
            this.btnAddRecord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(95, 42);
            this.btnAddRecord.TabIndex = 19;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // btnCleanFields
            // 
            this.btnCleanFields.Location = new System.Drawing.Point(564, 372);
            this.btnCleanFields.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCleanFields.Name = "btnCleanFields";
            this.btnCleanFields.Size = new System.Drawing.Size(95, 42);
            this.btnCleanFields.TabIndex = 20;
            this.btnCleanFields.Text = "Clear Fields";
            this.btnCleanFields.UseVisualStyleBackColor = true;
            this.btnCleanFields.Click += new System.EventHandler(this.btnCleanFields_Click);
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(640, 74);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(183, 20);
            this.dtpBirthday.TabIndex = 21;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 571);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.btnCleanFields);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.pbGetImage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxHeight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxWeight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxPhoneNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxMiddleName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAdd";
            this.Text = "Add People";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGetImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxMiddleName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxPhoneNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxWeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxHeight;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbGetImage;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnCleanFields;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
    }
}
namespace ProjetClient_Rafael.UI
{
    partial class Form_Client
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
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.Label_TeoudateZeoute = new System.Windows.Forms.Label();
            this.textBox_TeoudateZeoute = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.PostalCode = new System.Windows.Forms.Label();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.textBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listBox_Client = new System.Windows.Forms.ListBox();
            this.label_IDH = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_FilterId = new System.Windows.Forms.TextBox();
            this.textBox_FilterLastName = new System.Windows.Forms.TextBox();
            this.textBox_FilterPhoneNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label_city = new System.Windows.Forms.Label();
            this.comboBox_city = new System.Windows.Forms.ComboBox();
            this.button_add_city = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FirstName.Location = new System.Drawing.Point(7, 123);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(157, 31);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LastName.Location = new System.Drawing.Point(12, 188);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(154, 31);
            this.LastName.TabIndex = 3;
            this.LastName.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxLastName.Location = new System.Drawing.Point(189, 191);
            this.textBoxLastName.Multiline = true;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(342, 33);
            this.textBoxLastName.TabIndex = 2;
            this.textBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Let_KeyPress);
            this.textBoxLastName.Leave += new System.EventHandler(this.textBox_Name_Leave);
            // 
            // Label_TeoudateZeoute
            // 
            this.Label_TeoudateZeoute.AutoSize = true;
            this.Label_TeoudateZeoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Label_TeoudateZeoute.Location = new System.Drawing.Point(7, 252);
            this.Label_TeoudateZeoute.Name = "Label_TeoudateZeoute";
            this.Label_TeoudateZeoute.Size = new System.Drawing.Size(236, 31);
            this.Label_TeoudateZeoute.TabIndex = 5;
            this.Label_TeoudateZeoute.Text = "Teoudate Zeoute";
            // 
            // textBox_TeoudateZeoute
            // 
            this.textBox_TeoudateZeoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_TeoudateZeoute.Location = new System.Drawing.Point(296, 252);
            this.textBox_TeoudateZeoute.Multiline = true;
            this.textBox_TeoudateZeoute.Name = "textBox_TeoudateZeoute";
            this.textBox_TeoudateZeoute.Size = new System.Drawing.Size(282, 31);
            this.textBox_TeoudateZeoute.TabIndex = 3;
            this.textBox_TeoudateZeoute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            this.textBox_TeoudateZeoute.Leave += new System.EventHandler(this.textBox_Name_Leave);
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Age.Location = new System.Drawing.Point(12, 443);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(65, 31);
            this.Age.TabIndex = 11;
            this.Age.Text = "Age";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxAge.Location = new System.Drawing.Point(296, 443);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(300, 35);
            this.textBoxAge.TabIndex = 6;
            this.textBoxAge.TextChanged += new System.EventHandler(this.textBoxAge_TextChanged);
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            this.textBoxAge.Leave += new System.EventHandler(this.textBox_Name_Leave);
            // 
            // PostalCode
            // 
            this.PostalCode.AutoSize = true;
            this.PostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PostalCode.Location = new System.Drawing.Point(12, 385);
            this.PostalCode.Name = "PostalCode";
            this.PostalCode.Size = new System.Drawing.Size(173, 31);
            this.PostalCode.TabIndex = 9;
            this.PostalCode.Text = "Postal Code";
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxPostalCode.Location = new System.Drawing.Point(296, 388);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(300, 35);
            this.textBoxPostalCode.TabIndex = 5;
            this.textBoxPostalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            this.textBoxPostalCode.Leave += new System.EventHandler(this.textBox_Name_Leave);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PhoneNumber.Location = new System.Drawing.Point(12, 319);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(207, 31);
            this.PhoneNumber.TabIndex = 7;
            this.PhoneNumber.Text = "Phone Number";
            // 
            // textBoxPhoneNum
            // 
            this.textBoxPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxPhoneNum.Location = new System.Drawing.Point(296, 322);
            this.textBoxPhoneNum.Name = "textBoxPhoneNum";
            this.textBoxPhoneNum.Size = new System.Drawing.Size(300, 35);
            this.textBoxPhoneNum.TabIndex = 4;
            this.textBoxPhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            this.textBoxPhoneNum.Leave += new System.EventHandler(this.textBox_Name_Leave);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Green;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSave.Location = new System.Drawing.Point(80, 658);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(184, 114);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // listBox_Client
            // 
            this.listBox_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBox_Client.FormattingEnabled = true;
            this.listBox_Client.ItemHeight = 31;
            this.listBox_Client.Location = new System.Drawing.Point(644, 306);
            this.listBox_Client.Name = "listBox_Client";
            this.listBox_Client.Size = new System.Drawing.Size(954, 469);
            this.listBox_Client.TabIndex = 13;
            this.listBox_Client.DoubleClick += new System.EventHandler(this.listBox_Client_DoubleClick);
            // 
            // label_IDH
            // 
            this.label_IDH.AutoSize = true;
            this.label_IDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_IDH.Location = new System.Drawing.Point(101, 59);
            this.label_IDH.Name = "label_IDH";
            this.label_IDH.Size = new System.Drawing.Size(50, 37);
            this.label_IDH.TabIndex = 14;
            this.label_IDH.Text = "ID";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_ID.Location = new System.Drawing.Point(183, 59);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(36, 37);
            this.label_ID.TabIndex = 15;
            this.label_ID.Text = "0";
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Red;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Delete.Location = new System.Drawing.Point(296, 658);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(190, 114);
            this.button_Delete.TabIndex = 16;
            this.button_Delete.Text = "DELETE";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_FilterId);
            this.groupBox1.Controls.Add(this.textBox_FilterLastName);
            this.groupBox1.Controls.Add(this.textBox_FilterPhoneNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(644, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 271);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // textBox_FilterId
            // 
            this.textBox_FilterId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_FilterId.Location = new System.Drawing.Point(145, 74);
            this.textBox_FilterId.Name = "textBox_FilterId";
            this.textBox_FilterId.Size = new System.Drawing.Size(465, 35);
            this.textBox_FilterId.TabIndex = 5;
            this.textBox_FilterId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // textBox_FilterLastName
            // 
            this.textBox_FilterLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_FilterLastName.Location = new System.Drawing.Point(166, 130);
            this.textBox_FilterLastName.Name = "textBox_FilterLastName";
            this.textBox_FilterLastName.Size = new System.Drawing.Size(453, 35);
            this.textBox_FilterLastName.TabIndex = 4;
            this.textBox_FilterLastName.TextChanged += new System.EventHandler(this.textBox_FilterLastName_TextChanged);
            this.textBox_FilterLastName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // textBox_FilterPhoneNum
            // 
            this.textBox_FilterPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_FilterPhoneNum.Location = new System.Drawing.Point(242, 187);
            this.textBox_FilterPhoneNum.Name = "textBox_FilterPhoneNum";
            this.textBox_FilterPhoneNum.Size = new System.Drawing.Size(377, 35);
            this.textBox_FilterPhoneNum.TabIndex = 3;
            this.textBox_FilterPhoneNum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(6, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(6, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.Color.White;
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxFirstName.Location = new System.Drawing.Point(190, 120);
            this.textBoxFirstName.Multiline = true;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(341, 34);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Let_KeyPress);
            this.textBoxFirstName.Leave += new System.EventHandler(this.textBox_Name_Leave);
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_city.Location = new System.Drawing.Point(13, 513);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(66, 31);
            this.label_city.TabIndex = 18;
            this.label_city.Text = "City";
            // 
            // comboBox_city
            // 
            this.comboBox_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBox_city.FormattingEnabled = true;
            this.comboBox_city.Location = new System.Drawing.Point(108, 505);
            this.comboBox_city.Name = "comboBox_city";
            this.comboBox_city.Size = new System.Drawing.Size(230, 39);
            this.comboBox_city.TabIndex = 7;
            // 
            // button_add_city
            // 
            this.button_add_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_add_city.Location = new System.Drawing.Point(386, 505);
            this.button_add_city.Name = "button_add_city";
            this.button_add_city.Size = new System.Drawing.Size(63, 55);
            this.button_add_city.TabIndex = 20;
            this.button_add_city.Text = "+";
            this.button_add_city.UseVisualStyleBackColor = true;
            this.button_add_city.Click += new System.EventHandler(this.button_add_city_Click);
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 850);
            this.Controls.Add(this.button_add_city);
            this.Controls.Add(this.comboBox_city);
            this.Controls.Add(this.label_city);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label_IDH);
            this.Controls.Add(this.listBox_Client);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.PostalCode);
            this.Controls.Add(this.textBoxPostalCode);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.textBoxPhoneNum);
            this.Controls.Add(this.Label_TeoudateZeoute);
            this.Controls.Add(this.textBox_TeoudateZeoute);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "Form_Client";
            this.Text = "Form_Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label Label_TeoudateZeoute;
        private System.Windows.Forms.TextBox textBox_TeoudateZeoute;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label PostalCode;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.TextBox textBoxPhoneNum;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListBox listBox_Client;
        private System.Windows.Forms.Label label_IDH;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_FilterPhoneNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_FilterId;
        private System.Windows.Forms.TextBox textBox_FilterLastName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.ComboBox comboBox_city;
        private System.Windows.Forms.Button button_add_city;
    }
}


namespace ProjetClient_Rafael.UI
{
    partial class Form_City
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_cityname = new System.Windows.Forms.Label();
            this.textBox_cityname = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.listBox_City = new System.Windows.Forms.ListBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_deleteCity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(67, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label_cityname
            // 
            this.label_cityname.AutoSize = true;
            this.label_cityname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_cityname.Location = new System.Drawing.Point(51, 350);
            this.label_cityname.Name = "label_cityname";
            this.label_cityname.Size = new System.Drawing.Size(200, 42);
            this.label_cityname.TabIndex = 1;
            this.label_cityname.Text = "City Name";
            // 
            // textBox_cityname
            // 
            this.textBox_cityname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_cityname.Location = new System.Drawing.Point(273, 348);
            this.textBox_cityname.Name = "textBox_cityname";
            this.textBox_cityname.Size = new System.Drawing.Size(244, 44);
            this.textBox_cityname.TabIndex = 2;
            this.textBox_cityname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Let_KeyPress);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_ID.Location = new System.Drawing.Point(220, 210);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(40, 42);
            this.label_ID.TabIndex = 3;
            this.label_ID.Text = "0";
            // 
            // listBox_City
            // 
            this.listBox_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBox_City.FormattingEnabled = true;
            this.listBox_City.ItemHeight = 31;
            this.listBox_City.Location = new System.Drawing.Point(673, 149);
            this.listBox_City.Name = "listBox_City";
            this.listBox_City.Size = new System.Drawing.Size(592, 748);
            this.listBox_City.TabIndex = 4;
            this.listBox_City.DoubleClick += new System.EventHandler(this.listBox_City_DoubleClick);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.Green;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_save.Location = new System.Drawing.Point(43, 580);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(217, 112);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "SAVE";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_deleteCity
            // 
            this.button_deleteCity.BackColor = System.Drawing.Color.Red;
            this.button_deleteCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_deleteCity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_deleteCity.Location = new System.Drawing.Point(324, 580);
            this.button_deleteCity.Name = "button_deleteCity";
            this.button_deleteCity.Size = new System.Drawing.Size(213, 112);
            this.button_deleteCity.TabIndex = 6;
            this.button_deleteCity.Text = "DELETE";
            this.button_deleteCity.UseVisualStyleBackColor = false;
            this.button_deleteCity.Click += new System.EventHandler(this.button_deleteCity_Click);
            // 
            // Form_City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 978);
            this.Controls.Add(this.button_deleteCity);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.listBox_City);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.textBox_cityname);
            this.Controls.Add(this.label_cityname);
            this.Controls.Add(this.label1);
            this.Name = "Form_City";
            this.Text = "Form_City";
            this.Load += new System.EventHandler(this.Form_City_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_cityname;
        private System.Windows.Forms.TextBox textBox_cityname;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.ListBox listBox_City;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_deleteCity;
    }
}
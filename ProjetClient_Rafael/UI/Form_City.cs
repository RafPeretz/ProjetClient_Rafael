using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetClient_Rafael.BL;
using ProjetClient_Rafael.DAL;
using ProjetClient_Rafael.Properties;




namespace ProjetClient_Rafael.UI
{




    public partial class Form_City : Form
    {
        public Form_City()
        {
            InitializeComponent();
            CityArrToForm();
            CapsLockChek();
            
        }


        public bool CheckForm()
        {
            bool flag = true;
            if (textBox_cityname.Text.Length < 2)
            {
                flag = false;
                textBox_cityname.BackColor = Color.Red;
            }

            return flag;

        }

        private bool IsEnglishLetter(char c)
        {
            return (c >= 'a' && c <= 'z');
        }

        private void textBox_Let_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsEnglishLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.KeyChar = char.MinValue;
        }

        private bool CapsLockChek()
        {
            return (Control.IsKeyLocked(Keys.CapsLock));
        }

        private void Form_Client_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            InputLanguage myCurrentLang = InputLanguage.CurrentInputLanguage;
            if (myCurrentLang.Culture.Name.ToLower() != "en-us" || myCurrentLang.Culture.Name.ToLower() != "en-uk")
                MessageBox.Show("Language not english");


        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (!CheckForm())

                MessageBox.Show("Fill all the mandatory fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                City city = FormToCity();
                if (city.ID == 0)
                {
                    CityArr oldCityArr = new CityArr();
                    oldCityArr.Fill();
                    if (!oldCityArr.IsContain(city.CityName))
                    {



                        if (city.Insert())
                        {
                            MessageBox.Show("Thank you for you registration!");
                            CityArrToForm();
                        }

                        else
                            MessageBox.Show("Couldn't add the city", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                        MessageBox.Show("City already existing");

                }

                else
                {
                    if (city.Update())
                    {
                        MessageBox.Show("Update succesfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CityArrToForm();
                    }

                    else
                        MessageBox.Show("Couldn't update the city", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }


            }
        }

        private City FormToCity()
        {
            City city = new City();
            city.ID = int.Parse(label_ID.Text);
            city.CityName = textBox_cityname.Text;

            return city;
        }

        private void CityArrToForm()
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            CityArr cityArr = new CityArr();
            cityArr.Fill();
            listBox_City.DataSource = cityArr;

        }

        private void CityToForm(City city)
        {
            if (city != null)
            {
                //ממירה את המידע בטנ"מ לקוח לטופס
                label_ID.Text = city.ID.ToString();
                textBox_cityname.Text = city.CityName;
            }

            else
            {
                label_ID.Text = "0";            
                textBox_cityname.Text = "";

            }

        }

      
        private void listBox_City_DoubleClick(object sender, EventArgs e)
        {
            CityToForm(listBox_City.SelectedItem as City);
        }

        private void button_deleteCity_Click(object sender, EventArgs e)
        {
            City city = FormToCity();
            if (city.ID == 0)
                MessageBox.Show("You must select a city");
            else
            {
                if (MessageBox.Show("Warning", "Are you sure you want to delete?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign |
                MessageBoxOptions.RtlReading) == DialogResult.Yes)
                {

                    //לפני המחיקה - בדיקה שהישוב לא בשימוש בישויות אחרות
                    //בדיקה עבור לקוחות

                    ClientArr clientArr = new ClientArr();
                    clientArr.Fill();
                    if (clientArr.DoesExist(city))
                        MessageBox.Show("You can’t delete a city that is related to a client");
                    else
                    if (city.Delete())
                    {
                        MessageBox.Show("Deleted");
                        CityToForm(null);
                        CityArrToForm();
                    }
                    else
                        MessageBox.Show("Error");
                }
            }
        }

    
        private void Form_City_Load(object sender, EventArgs e)
        {

        }
    }
}


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



namespace ProjetClient_Rafael
{
    public partial class Form_Client : Form
    {
        public Form_Client()
        {
            InitializeComponent();
            ClientArrToForm();
          //Form_Client_InputLanguageChanged(null, null);
            CityArrToForm();
        }

        private bool IsEnglishLetter(char c)
        {
            return (c >= 'a' && c <= 'z');
        }

        private void textBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = char.MinValue;
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

        private void textBox_Name_Leave(object sender, EventArgs e)
        {

        }


        private bool CheckForm()
        {

            //מחזירה האם הטופס תקין - שדות חובה ורשות

            bool flag = true;

            //first name
            if (textBoxFirstName.Text.Length != 0)
            {


                if (textBoxFirstName.Text.Length < 2)
                {
                    flag = false;
                    textBoxFirstName.BackColor = Color.Red;
                }
                else
                    textBoxFirstName.BackColor = Color.White;

            }


            //last name 
            if (textBoxLastName.Text.Length != 0)
            {


                if (textBoxLastName.Text.Length < 2)
                {
                    flag = false;
                    textBoxLastName.BackColor = Color.Red;
                }
                else
                    textBoxLastName.BackColor = Color.White;
            }

            //teoudateZeoute
            if (textBox_TeoudateZeoute.Text.Length != 0)
            {
                if (textBox_TeoudateZeoute.Text.Length != 9)
                {
                    flag = false;
                    textBox_TeoudateZeoute.BackColor = Color.Red;
                }
                else
                    textBox_TeoudateZeoute.BackColor = Color.White;
            }

            //phone num
            if (textBoxLastName.Text.Length != 0)
            {
                if (textBoxPhoneNum.Text.Length != 10)
                {
                    flag = false;
                    textBoxPhoneNum.BackColor = Color.Red;
                }
                else
                    textBoxPhoneNum.BackColor = Color.White;
            }



            //age
            if (textBoxAge.Text.Length != 0)
            {
                if (textBoxAge.Text.Length > 3 || textBoxAge.Text.Length == 0)
                {
                    flag = false;
                    textBoxAge.BackColor = Color.Red;
                }
                else
                    textBoxAge.BackColor = Color.White;
            }

            //city 
            if (comboBox_city.Text.Length != 0)
            {

                if (comboBox_city.Text.Length < 2)
                {
                    flag = false;
                    comboBox_city.BackColor = Color.Red;
                }

            }

            return flag;
        }

        private void button_Save_Click(object sender, EventArgs e)

        {
            if (!CheckForm())

                MessageBox.Show("Fill all the mandatory fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {

                Client client = FormToClient();

                if (client.ID == 0)
                {
                    if (client.Insert())
                    {
                        MessageBox.Show("Thank you for you registration!");
                        ClientArrToForm();
                    }

                    else
                        MessageBox.Show("Couldn't add the client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (client.Update())
                    {
                        MessageBox.Show("Update succesfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClientArrToForm();
                    }
                    else
                        MessageBox.Show("Couldn't update the client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }


        }

        private Client FormToClient()
        {
            Client client = new Client();

            client.ID = int.Parse(label_ID.Text);
            client.FirstName = textBoxFirstName.Text;
            client.LastName = textBoxLastName.Text;
            client.PostalCode = textBoxPostalCode.Text;
            client.City = (comboBox_city.SelectedItem as City);

            return client;
        }

        private void ClientArrToForm()
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            listBox_Client.DataSource = clientArr;

        }

        private void ClientToForm(Client client)
        {
            if (client != null)
            {
                //ממירה את המידע בטנ"מ לקוח לטופס
                label_ID.Text = client.ID.ToString();
                textBoxFirstName.Text = client.FirstName;
                textBoxLastName.Text = client.LastName;
                textBoxPhoneNum.Text = client.PhoneNum.ToString();
                textBox_TeoudateZeoute.Text = client.TeoudateZeoute.ToString();
                textBoxPostalCode.Text = client.PostalCode;
                textBoxAge.Text = client.Age.ToString();
                comboBox_city.SelectedValue = client.City.ID;
            }

            else
            {
                label_ID.Text = "0";
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhoneNum.Text = "";
                textBox_TeoudateZeoute.Text = "";
                textBoxPostalCode.Text = "";
                textBoxAge.Text = "";


            }

        }

        private void listBox_Client_DoubleClick(object sender, EventArgs e)
        {
            ClientToForm(listBox_Client.SelectedItem as Client);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            Client client = FormToClient();

            if (client.ID == 0)
            {
                MessageBox.Show("There is no selected client");
            }

            else
            {
                if (MessageBox.Show("Are sur you want to delete this client", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    ;
                    ClientArrToForm();
                }
            }
        }

        private void textBox_FilterLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה

            if (textBox_FilterId.Text != "")
                id = int.Parse(textBox_FilterId.Text);

            //מייצרים אוסף של כלל הלקוחות

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            clientArr = clientArr.Filter(id, textBox_FilterLastName.Text,
            textBox_FilterPhoneNum.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            listBox_Client.DataSource = clientArr;
        }

        public void CityArrToForm()
        {

            //ממירה את הטנ "מ אוסף ישובים לטופס

            CityArr cityArr = new CityArr();
            cityArr.Fill();

            comboBox_city.DataSource = cityArr;
            comboBox_city.ValueMember = "Id";
            comboBox_city.DisplayMember = "CityName";
        } 
    }
}

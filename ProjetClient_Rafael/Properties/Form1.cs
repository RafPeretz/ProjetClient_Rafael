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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClientArrToForm();
        }
        private bool IsLetter(char c)
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
            if (!IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.KeyChar = char.MinValue;
        }

        private bool CheckForm()
        {

            //מחזירה האם הטופס תקין - שדות חובה ורשות

            bool flag = true;
            //first name
            if (textBoxFirstName.Text.Length < 2)
            {
                flag = false;
                textBoxFirstName.BackColor = Color.Red;
            }
            else
                textBoxFirstName.BackColor = Color.White;
            //last name 
            if (textBoxLastName.Text.Length < 2)
            {
                flag = false;
                textBoxLastName.BackColor = Color.Red;
            }
            else
                textBoxLastName.BackColor = Color.White;
            //id
            if (textBoxID.Text.Length != 9)
            {
                flag = false;
                textBoxID.BackColor = Color.Red;
            }
            else
                textBoxID.BackColor = Color.White;
            //phone num
            if (textBoxPhoneNum.Text.Length != 0)
            {
                if (textBoxPhoneNum.Text.Length != 10)
                {
                    flag = false;
                    textBoxPhoneNum.BackColor = Color.Red;
                }
                else
                    textBoxPhoneNum.BackColor = Color.White;
            }
            //postal code
            if (textBoxPostalCode.Text.Length != 0)
            {
                if (textBoxPostalCode.Text.Length != 7)
                {
                    flag = false;
                    textBoxPostalCode.BackColor = Color.Red;
                }
                else
                    textBoxPostalCode.BackColor = Color.White;
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
                return flag;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
            {
                MessageBox.Show("Fill all the mandatory fields!", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
               
            }
            else
            {
                Client client = FormToClient();
               
                if (client.GetM_ID() == 0)
                {
                    if (client.Insert())
                    {
                        MessageBox.Show("Added Successfully");
                    }

                    else
                        MessageBox.Show("Error Adding");

                }

                else
                {

                    //עדכון לקוח קיים

                    if (client.Update())
                    {
                        MessageBox.Show("Updated successfully ");
                    }
                    else
                        MessageBox.Show("Error updating");
                }


            }

           


        }

        private Client FormToClient()
        {
            Client client = new Client();
            client.SetM_FirstName(textBoxFirstName.Text);
            client.SetM_LastName( textBoxLastName.Text);
            client.SetM_ID( int.Parse(textBoxID.Text));
           

            //בדיקה האם יש ערך בשדה להמרה

            if (textBoxPhoneNum.Text != "")
                client.SetM_PhoneNum(int.Parse(textBoxPhoneNum.Text));

            if (textBoxPostalCode.Text != "")
                client.SetM_PostalCode(textBoxPostalCode.Text);

            if (textBoxAge.Text != "")
                client.SetM_Age(int.Parse(textBoxAge.Text));

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

            //ממירה את המידע בטנ"מ לקוח לטופס

            Label_Id.Text = client.ID.ToString();
            textBoxFirstName.Text = client.FirstName;
            textBoxLastName.Text = client.LastName;
            textBoxPhoneNum.Text = client.PhoneNum.ToString();
            
        }

        private void listBox_Client_DoubleClick(object sender, EventArgs e)
        {
            ClientToForm(listBox_Client.SelectedItem as Client);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using ProjetClient_Rafael.DAL;

namespace ProjetClient_Rafael.BL
{
    public class ClientArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Dal_Client.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח



            DataRow dataRow;
            Client curClient;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curClient = new Client(dataRow);
                this.Add(curClient);
            }

            
           
        }

        public ClientArr Filter(int id, string lastName, string cellNumber)
        {
            ClientArr clientArr = new ClientArr();
            Client client;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת הלקוח הנוכחי במשתנה עזר - לקוח

                client = (this[i] as Client);
                if
                (

                // מזהה 0 – כלומר, לא נבחר מזהה בסינון

                (id == 0 || client.ID == id)
                && client.LastName.StartsWith(lastName)
                && ( client.PhoneNum.ToString()).Contains(cellNumber)
                )

                    //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר

                    clientArr.Add(client);
            }
            return clientArr;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetClient_Rafael.DAL;
using ProjetClient_Rafael.BL;
using System.Data;


namespace ProjetClient_Rafael.BL
{
    public class Client
    {
        private string m_FirstName;
        private string m_LastName;
        private int m_PhoneNum;
        private int m_TeoudateZeoute;
        private string m_PostalCode;
        private int m_Age;
        private int m_ID;
        private City m_city;

        public string FirstName { get => m_FirstName; set => m_FirstName = value; }
        public string LastName { get => m_LastName; set => m_LastName = value; }
        public int TeoudateZeoute { get => m_TeoudateZeoute; set => m_TeoudateZeoute = value; }
        public int PhoneNum { get => m_PhoneNum; set => m_PhoneNum = value; }
        public string PostalCode { get => m_PostalCode; set => m_PostalCode = value; }
        public int Age { get => m_Age; set => m_Age = value; }
        public int ID { get => m_ID; set => m_ID = value; }
        public City City { get => m_city; set => m_city = value; }

        public void SetM_FirstName(string m_FirstName) { this.FirstName = m_FirstName; }


        public bool Insert()
        {
            return Dal_Client.Insert(FirstName, LastName, PhoneNum, TeoudateZeoute, PostalCode, Age, m_city.ID);
        }

        public Client() { }

        public Client(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח

            m_ID = (int)dataRow["ID"];
            m_FirstName = dataRow["FirstName"].ToString();
            m_LastName = dataRow["LastName"].ToString();
            m_PhoneNum = (int)dataRow["PhoneNum"];
            m_TeoudateZeoute = (int)dataRow["TeoudateZeoute"];
            m_PostalCode = dataRow["PostalCode"].ToString();
            m_Age = (int)dataRow["Age"];
            m_city = new City(dataRow.GetParentRow("ClientCity"));


        }
        public override string ToString()
        { return $"{m_LastName} {m_FirstName} {PostalCode} {Age} "; }




        public bool Update()
        {
            return Dal_Client.Update(ID, FirstName, LastName, PhoneNum, TeoudateZeoute, PostalCode, Age, m_city.ID);

        }

        public bool Delete()
        {
            return Dal_Client.Delete(m_ID);
        }



    }


}

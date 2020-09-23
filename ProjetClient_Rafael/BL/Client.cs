using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetClient_Rafael.DAL;
using System.Data;


namespace ProjetClient_Rafael.BL
{
   public class Client
    {
        private string m_FirstName;
        private string m_LastName;
        private int m_TeoudateZeoute;
        private int m_PhoneNum;
        private string m_PostalCode;
        private int m_Age;
        private int m_ID;

        public string FirstName { get => m_FirstName; set => m_FirstName = value; }
        public string LastName { get => m_LastName; set => m_LastName = value; }
        public int TeoudateZeoute { get => m_TeoudateZeoute; set => m_TeoudateZeoute = value; }
        public int PhoneNum { get => m_PhoneNum; set => m_PhoneNum = value; }
        public string PostalCode { get => m_PostalCode; set => m_PostalCode = value; }
        public int Age { get => m_Age; set => m_Age = value; }
        public int ID { get => m_ID; set => m_ID = value; }

        public string GetM_FirstName() { return this.FirstName; }
        public void SetM_FirstName(string m_FirstName) { this.FirstName = m_FirstName; }

        public string GetM_LastName() { return this.LastName; }
        public void SetM_LastName(string m_LastName) { this.LastName = m_LastName; }

        public int GetM_TeoudateZeoute() { return this.TeoudateZeoute; }
        public void SetM_TeoudateZeoute(int m_TeoudateZeoute) { this.TeoudateZeoute = m_TeoudateZeoute; }

        public int GetM_PhoneNum() { return this.PhoneNum; }
        public void SetM_PhoneNum(int PhoneNum) { this.PhoneNum = PhoneNum; }

        public string GetM_PostalCode() { return this.PostalCode; }
        public void SetM_PostalCode(string PostalCode) { this.PostalCode = PostalCode; }

        public int GetM_Age() { return this.Age; }
        public void SetM_Age(int Age) { this.Age = Age; }

        public int GetM_ID() { return this.ID; }

        public void SetM_ID(int ID) { this.ID = ID; }



        public bool Insert()
        {
            return Dal_Client.Insert(FirstName, LastName, PhoneNum,
            PostalCode, Age);
        }

        public Client() { }

        public Client(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח

            TeoudateZeoute = (int)dataRow["TeoudateZeoute"];
            FirstName = dataRow["FirstName"].ToString();
            LastName = dataRow["LastName"].ToString();
            PhoneNum = (int)dataRow["PhoneNum"];
            ID = (int)dataRow["ID"];

        }
            public override string ToString()
        { return $"{LastName} {FirstName}"; }


        

        public bool Update()
        {
            return Dal_Client.Update(ID, FirstName, LastName, PhoneNum,

            PostalCode, Age);

        }



    }

    
}

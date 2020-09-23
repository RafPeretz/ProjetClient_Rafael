using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Client
    {
        private string m_FirstName;
        private string m_LastName;
        private int m_ID;
        private int m_PhoneNum;
        private int m_PostalCode;
        private int m_Age;

        public string GetM_FirstName() { return this.m_FirstName; }
        public void SetM_FirstName(string m_FirstName) { this.m_FirstName = m_FirstName; }

        public string GetM_LastName() { return this.m_LastName; }
        public void SetM_LastName(string m_LastName) { this.m_LastName = m_LastName; }

        public int GetM_ID() { return this.m_ID; }
        public void SetID(int ID) { this.m_ID = ID; }

        public int GetM_PhoneNum() { return this.m_PhoneNum; }
        public void SetPhoneNum(int PhoneNum) { this.m_PhoneNum = PhoneNum; }

        public int GetM_PostalCode() { return this.m_PostalCode; }
        public void SetPostalCode(int PostalCode) { this.m_PostalCode = PostalCode; }

        public int GetM_Age() { return this.m_Age; }
        public void SetAge(int Age) { this.m_Age = Age; }
    }
}

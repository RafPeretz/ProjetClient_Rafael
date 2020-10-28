using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetClient_Rafael.BL;
using ProjetClient_Rafael.DAL;
using System.Data;

namespace ProjetClient_Rafael.BL
{
    public class City
    {

        private string m_cityName;
        public string CityName { get => m_cityName; set => m_cityName = value; }

        private int m_id;
        public int ID { get => m_id; set => m_id = value; }




        public City() { }

        public City(DataRow dataRow)
        {
            //מייצרת לקוח מתוך שורת לקוח
            m_id = (int)dataRow["ID"];
            m_cityName = dataRow["Name"].ToString();
        }

        public bool Insert()
        {
            return City_DAL.Insert(m_cityName);
        }

        public bool Update()
        {
            return City_DAL.Update(m_id, m_cityName);
        }


        public bool Delete()
        {
            return City_DAL.Delete(m_id);
        }
        public override string ToString()
        {
            return m_cityName;
        }
    }
}

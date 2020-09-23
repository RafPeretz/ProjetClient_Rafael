using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetClient_Rafael.DAL;
using ProjetClient_Rafael.BL;
using System.Data;

namespace ProjetClient_Rafael.DAL
{
    public class Dal_Client
    {
        public static bool Insert(string firstName, string lastName, int
        cellPhoneNumber, string cellPhoneAreaCode, int zipCode)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Client"
            + "("
            + "[FirstName],[LastName],[PhoneNum],[CellPhoneAreaCode],[PostalCode]"
            + ")"
            + " VALUES "
            + "("
            + $"'{firstName}''{lastName}',{cellPhoneNumber}',{cellPhoneAreaCode}',{zipCode}"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Client"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_Client", "[LastName],[FirstName]");
            //בהמשך יהיו כאן הוראות נוספות הקשורות לקשרי גומלין...

        }

        public static bool Update(int id, string firstName, string lastName, int
        cellPhoneNumber, string cellPhoneAreaCode, int zipCode)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Client SET"
            + $" [FirstName] = N'{firstName}'"
            + $",[LastName] = N'{lastName}'"
            + $",[PhoneNum] = {cellPhoneNumber}"
            + $",[PostalCode] = {zipCode}"
            + $" WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }




    }
}


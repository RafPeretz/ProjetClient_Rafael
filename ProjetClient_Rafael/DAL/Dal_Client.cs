using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetClient_Rafael.BL;
using System.Data;

namespace ProjetClient_Rafael.DAL
{
    public class Dal_Client
    {
        public static bool Insert(string firstName, string lastName, int phoneNum, int teoudateZeoute, string postalcode, int age, int city)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Client"
            + "("
            + "[FirstName], [LastName], [PhoneNum], [TeoudateZeoute], [PostalCode], [Age], [City]"
            + ")"
            + " VALUES "
            + "("
            + $" '{firstName}' , '{lastName}' , '{phoneNum}' , '{teoudateZeoute}' , '{postalcode}', '{age}', '{city}'"
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
            City_DAL.FillDataSet(dataSet);
            DataRelation dataRelation = null;
            dataRelation = new DataRelation(

            //שם קשר הגומלין

            "ClientCity"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_City"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_Client"].Columns["City"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation);



        }


        public static bool Update(int ID, string firstName, string lastName, int phoneNum, int teoudateZeoute, string postalcode, int age, int city)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Client SET"
            + $"[FirstName] = '{firstName}'"
            + $" ,[LastName] = '{lastName}'"
            + $" ,[PhoneNum] = '{phoneNum}'"
            + $" ,[TeoudateZeoute]='{teoudateZeoute}'"
            + $" ,[PostalCode] = '{postalcode}'"
            + $" ,[Age] = '{age}'"
            + $" ,[City] = '{city}'"

            + $" WHERE ID = {ID}";
            return Dal.ExecuteSql(str);

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה


        }

        public static bool Delete(int id)
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = $"DELETE FROM Table_Client WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }




    }
}


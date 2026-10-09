using System.Data;

namespace Program
{
    public class DataBase
    {
        public static void Main()
        {
            DataTable dt = new DataTable("Group");

            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Age", typeof(int));
            dt.Columns.Add("GropeName", typeof(string));

            dt.Rows.Add(1, "Петя", 15, "deb");
            dt.Rows.Add(2, "Витя Пупкин", 13, "Aboltusi");
            dt.Rows.Add(3, "Митя", 12, "Aboltusi");
            dt.Rows.Add(4, "Ритя", 16,"rpo");
            dt.Rows.Add(5, "Гитя", 111,"rpo");

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($"#{row["id"],-10} - {row["Name"],-20} - {row["Age"],-20} - {row["GropeName"],-2} ");
            }

            DataRow oldBoy = dt.Rows[0];
            foreach (DataRow row in dt.Rows)
            {
                if ((int)row["Age"] > (int)oldBoy["Age"])
                {
                    oldBoy = row;
                }
            }
            Console.WriteLine($"Старшина: {oldBoy["id"],-10} - {oldBoy["Name"],-20} - {oldBoy["Age"],-20} - {oldBoy["GropeName"],-2} шт.");

        }
    }
}
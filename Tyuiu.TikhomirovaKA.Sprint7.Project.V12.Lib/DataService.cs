using System.Data;

namespace Tyuiu.TikhomirovaKA.Sprint7.Project.V12.Lib
{
    public class DataService
    {
        public DataTable ReadCsvToDataTable(string filePath)
        {
            DataTable dataTable = new DataTable();
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                string[] header = lines[0].Split(';');
                foreach (var column in header)
                {
                    dataTable.Columns.Add(column);
                }
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] row = lines[i].Split(';');
                    dataTable.Rows.Add(row);
                }
            }
            return dataTable;
        }
    }
}

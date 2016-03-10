using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WndwsClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormStart());
        }
    }
}






//        private SqlDataAdapter adapter = new SqlDataAdapter();
//       private BindingSource bindingSource1 = new BindingSource();


//public void GetData(string selectCommand)
//{
//    try
//    {
//        SqlConnection conn = ConnectClass.GetConnection();
//        adapter = new SqlDataAdapter(selectCommand, conn);
//        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

//        DataTable table = new DataTable();
//        table.Locale = System.Globalization.CultureInfo.InvariantCulture;
//        adapter.Fill(table);
//        bindingSource1.DataSource = table;
//    }
//    catch
//    {

//    }
//}

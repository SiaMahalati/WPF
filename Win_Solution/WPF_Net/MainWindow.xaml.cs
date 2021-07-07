using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Net
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        

   
        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {

        }

        public DataSet GetEmployeesList()
        {
            DataSet dsEmployee = new DataSet();
            using (var con = new SqlConn(connectionString))
            {
                SqlCommand objSqlCommand = new SqlCommand("GetEmployeeList", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(objSqlCommand);
                try
                {
                    objSqlDataAdapter.Fill(dsEmployee);
                    dsEmployee.Tables[0].TableName = "Employees";
                    grvEmployee.DataSource = dsEmployee;
                    grvEmployee.DataBind();
                }
                catch (Exception ex)
                {
                    return dsEmployee;
                }
            }
            return dsEmployee;
        }

    }
}

using MiniExcelLibs;

namespace Mini_Excel_Example
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var employees = new List<Employee>
                {
                    new Employee { EmployeeID = 1, Name = "Alice", Department = "HR" },
                    new Employee { EmployeeID = 2, Name = "Bob", Department = "IT" },
                    new Employee { EmployeeID = 3, Name = "Charlie", Department = "Finance" }
                };
                // Write the list to an Excel file
                MiniExcel.SaveAs("Employees.xlsx", employees);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var employees = MiniExcel.Query<Employee>("Employees.xlsx").ToList();               
                if (employees.Count > 0)
                {
                    dataGridView1.DataSource = null;   // Reset the data source first
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = employees;
                    dataGridView1.Refresh();
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

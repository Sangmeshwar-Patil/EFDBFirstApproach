using DBFirstEFExxample;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirstEFExxample
{
    public partial class fromEmployeeList : Form
    {
        public fromEmployeeList()
        {
            InitializeComponent();
        }

        private void fromEmployeeList_Load(object sender, EventArgs e)
        {
            List<Employee> employees = null;
            DataSet ds = new DataSet();
            using (TestEntities testEntities = new TestEntities())
            {
                employees = (from employeeRecs in testEntities.Employees
                                            select employeeRecs).ToList();
            }

            dataGridView1.DataSource = employees;
            
        }
    }
}

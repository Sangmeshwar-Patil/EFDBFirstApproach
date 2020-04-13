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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Save.Click += new EventHandler(Save_Click);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            using (TestEntities testEntities = new TestEntities())
            {
                Employee emp = new Employee()
                {
                    Id = 1,
                    Name = "Ramesh",
                    Age = 38,
                    Gender = "Male"
                };
                try
                {
                    testEntities.Employees.Add(emp);
                    testEntities.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
               
            }
        }
    }
}

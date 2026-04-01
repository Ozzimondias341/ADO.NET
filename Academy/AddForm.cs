using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DBTools;

namespace Academy
{
    public partial class AddForm : Form
    {
        Connector connector;
        Dictionary<string, int> d_groups;
        public AddForm(Connector cnt)
        {
            InitializeComponent();

            connector = cnt;
            d_groups = connector.GetDictionary("Groups");

            cbStudentGroups.Items.AddRange(d_groups.Keys.ToArray());

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            var today = DateTime.Today;
            var birthday = dtpStudentBirthDate.Value;
            int age = today.Year - birthday.Year;

            if (age < 5)
            {
                MessageBox.Show("Студент слишком молод чтобы учиться");
                return;
            }

            if(  


                string values = " ";
                values += $"{tbStudentLastName.Text}, ";
                values += $"{tbStudentFirstName.Text}, ";

                if (tbStudentMiddleName.Text == "") values += "NULL, ";
                else values += $"{tbStudentMiddleName.Text}, ";

                values += $"{dtpStudentBirthDate.Value.ToString("yyyy-MM-dd")}, ";
                values += $"{tbStudentEmail.Text}, ";
                values += $"{tbStudentPhone.Text}, ";
                values += $"{d_groups[cbStudentGroups.Text]}, ";


            
        }
    }
}

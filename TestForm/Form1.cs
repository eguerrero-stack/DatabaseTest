using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestForm
{
    public partial class Form1 : Form
    {
        List<Legend> legends = new List<Legend>();
        public Form1()
        {
            InitializeComponent();

            updateList();
        }

        private void updateList()
        {
            legendList.DataSource = legends;
            legendList.DisplayMember = "FullLegend";
        }

        private void clearInsertBoxes()
        {
            firstNameText.Text = "";
            lastNameText.Text = "";
            weaponText.Text = "";

        }

        private void search(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

           legends = db.listLegend(searchBox.Text);

           updateList();
        }

        private void addName(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            string firstName = firstNameText.Text;
            string lastName = lastNameText.Text;
            string weapon = weaponText.Text;

            bool isInserted = db.addLegend(firstName, lastName, weapon);

            if(isInserted == true)
            {
                addButton.BackColor = Color.Green;
            }
            else
            {
                addButton.BackColor = Color.Red;
            }
            clearInsertBoxes();

        }
    }
}

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
            legendList.DisplayMember = "Name";
        }

        private void search(object sender, EventArgs e)
        {
            Data db = new Data();

           legends = db.listLegend(textBox.Text);

           updateList();
        }

        private void addName(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

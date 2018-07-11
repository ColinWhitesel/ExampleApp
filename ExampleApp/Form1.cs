using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.schoolDataSet.Person);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.personTableAdapter.Fill(this.schoolDataSet.Person);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByPersonToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.personTableAdapter.FillByPerson(this.schoolDataSet.Person, firstNameToolStripTextBox.Text, lastNameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByFirstNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.personTableAdapter.FillByFirstName(this.schoolDataSet.Person, firstNameToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByPersonToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

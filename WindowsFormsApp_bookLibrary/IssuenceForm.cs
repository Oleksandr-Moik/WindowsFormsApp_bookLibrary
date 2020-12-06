using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_bookLibrary
{
    public partial class IssuenceForm : Form
    {
        public IssuenceForm()
        {
            InitializeComponent();
        }

        private void issuanseRecordBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.issuanseRecordBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void Issuence_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.libraryDataSet.Student);
            // TODO: This line of code loads data into the 'libraryDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.libraryDataSet.Book);
            // TODO: This line of code loads data into the 'libraryDataSet.IssuanseRecord' table. You can move, or remove it, as needed.
            this.issuanseRecordTableAdapter.Fill(this.libraryDataSet.IssuanseRecord);
            // TODO: This line of code loads data into the 'libraryDataSet.Book' table. You can move, or remove it, as needed.
            //this.bookTableAdapter.Fill(this.libraryDataSet.Book);
            // TODO: This line of code loads data into the 'libraryDataSet.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.libraryDataSet.Student);
            // TODO: This line of code loads data into the 'libraryDataSet.IssuanseRecord' table. You can move, or remove it, as needed.
            //this.issuanseRecordTableAdapter.Fill(this.libraryDataSet.IssuanseRecord);

        }

        private void issuanseRecordBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.issuanseRecordBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }
    }
}

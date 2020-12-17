using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TestWinApp.Classes.DALnew;

using TestWinApp.Forms.TPROPERTYview;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace TestWinApp.Forms
{
    public partial class TPropertyForm : Form
    {
        private TestDBContext _dbContext;

        private TPROPERTYRepository _repository;

        public TPropertyForm()
        {
            InitializeComponent();
        }

        private void TPropertyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dbContext.Database.Connection.Close();
        }

        private void TPropertyForm_Load(object sender, EventArgs e)
        {
            _dbContext = SingletonConnection.GetConnection();
            _dbContext.TPROPERTY.Load();
            propertyDataGridView.DataSource = _dbContext.TPROPERTY.Local.ToBindingList();

            propertyDataGridView.Columns["TGROUP"].Visible = false;

            propertyDataGridView.Columns["ID"].ReadOnly = true;
            propertyDataGridView.Columns["ID_Group"].ReadOnly = true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.UpdateEventHandler += UpdateOnAdd;
            addForm.ShowDialog();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            _dbContext = SingletonConnection.GetConnection();
            _dbContext.TPROPERTY.Load();
            propertyDataGridView.DataSource = _dbContext.TPROPERTY.Local.ToBindingList();
            propertyDataGridView.Refresh();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteForm dltForm = new DeleteForm();
            dltForm.UpdateEventHandler += UpdateOnDelete;
            dltForm.ShowDialog();
        }
        private void UpdateOnAdd(object sender, AddForm.UpdateEventArgs args)
        {
            _dbContext = SingletonConnection.GetConnection();
            _dbContext.TPROPERTY.Load();
            propertyDataGridView.DataSource = _dbContext.TPROPERTY.Local.ToBindingList();
            propertyDataGridView.Refresh();
        }
        private void UpdateOnDelete(object sender, DeleteForm.UpdateEventArgs args)
        {
            _dbContext = SingletonConnection.GetConnection();
            _dbContext.TPROPERTY.Load();
            propertyDataGridView.DataSource = _dbContext.TPROPERTY.Local.ToBindingList();
            propertyDataGridView.Refresh();
        }

        private void propertyDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _repository = new TPROPERTYRepository();

            var id = (decimal)propertyDataGridView.Rows[e.RowIndex]
               .Cells[propertyDataGridView.Columns["ID"].Index].Value;

            //var property = _dbContext.TPROPERTY.Where(p => p.ID == id).FirstOrDefault();

            //_dbContext.Entry(property).Property(p => p.Name).CurrentValue =
            //    (string)propertyDataGridView.Rows[e.RowIndex]
            //    .Cells[propertyDataGridView.Columns["Name"].Index].Value;

            //_dbContext.Entry(property).Property(p => p.Value).CurrentValue =
            //    (string)propertyDataGridView.Rows[e.RowIndex]
            //    .Cells[propertyDataGridView.Columns["Value"].Index].Value;

            //_dbContext.Entry(property).Property(p => p.ID_Group).CurrentValue =
            //    (string)propertyDataGridView.Rows[e.RowIndex]
            //    .Cells[propertyDataGridView.Columns["ID_Group"].Index].Value;

            var property = _repository.Find(id);

            _repository.Update(property);

        }
    }
}

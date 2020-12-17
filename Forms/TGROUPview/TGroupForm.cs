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
using TestWinApp.Forms.TGROUPview;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace TestWinApp.Forms
{
    public partial class TGroupForm : Form
    {
        private TestDBContext _dbContext;

        private TGROUPRepository _repository;
        public TGroupForm()
        {
            InitializeComponent();
        }

        private void TGroupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dbContext.Database.Connection.Close();
        }

        private void TGroupForm_Load(object sender, EventArgs e)
        {
            _dbContext = SingletonConnection.GetConnection();
            _dbContext.TGROUP.Load();
            this.groupDataGridView.DataSource = _dbContext.TGROUP.Local.ToBindingList();

            groupDataGridView.Columns["TRELATION"].Visible = false;
            groupDataGridView.Columns["TRELATION1"].Visible = false;
            groupDataGridView.Columns["TPROPERTY"].Visible = false;

            groupDataGridView.Columns["ID"].ReadOnly = true;
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
            _dbContext.TGROUP.Load();
            groupDataGridView.DataSource = _dbContext.TGROUP.Local.ToBindingList();
            groupDataGridView.Refresh();
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
            _dbContext.TGROUP.Load();
            groupDataGridView.DataSource = _dbContext.TGROUP.Local.ToBindingList();
            groupDataGridView.Refresh();
        }
        private void UpdateOnDelete(object sender, DeleteForm.UpdateEventArgs args)
        {
            _dbContext = SingletonConnection.GetConnection();
            _dbContext.TGROUP.Load();
            groupDataGridView.DataSource = _dbContext.TGROUP.Local.ToBindingList();
            groupDataGridView.Refresh();
        }

        private void groupDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var name = (string)groupDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            var id = (decimal)groupDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value;

            //var group = _dbContext.TGROUP.Where(g => g.ID == getID).FirstOrDefault();
            _repository = new TGROUPRepository();
            var group = _repository.Find(id);

            _repository.Update(group);
            //_dbContext.Entry(group).Property(g => g.Name).CurrentValue = name;
            //_dbContext.SaveChanges();
        }
    }
}

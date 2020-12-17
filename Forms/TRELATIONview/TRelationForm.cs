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
using TestWinApp.Forms.TRELATIONview;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace TestWinApp.Forms
{
    public partial class TRelationForm : Form
    {
        private TestDBContext _dbContext;

        private TRELATIONRepository _repository;
        public TRelationForm()
        {
            InitializeComponent();
        }

        private void TRelationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dbContext.Database.Connection.Close();
        }
        private void TRelationForm_Load(object sender, EventArgs e)
        {
            _dbContext = SingletonConnection.GetConnection();
            _dbContext.TRELATION.Load();
            this.relationDataGridView.DataSource = _dbContext.TRELATION.Local.ToBindingList();

            relationDataGridView.Columns["TGROUP"].Visible = false;
            relationDataGridView.Columns["TGROUP1"].Visible = false;

            relationDataGridView.Columns["ID"].ReadOnly = true;
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
            _dbContext.TRELATION.Load();
            relationDataGridView.DataSource = _dbContext.TRELATION.Local.ToBindingList();
            relationDataGridView.Refresh();
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
            _dbContext.TRELATION.Load();
            relationDataGridView.DataSource = _dbContext.TRELATION.Local.ToBindingList();
            relationDataGridView.Refresh();
        }
        private void UpdateOnDelete(object sender, DeleteForm.UpdateEventArgs args)
        {
            _dbContext = SingletonConnection.GetConnection();
            _dbContext.TRELATION.Load();
            relationDataGridView.DataSource = _dbContext.TRELATION.Local.ToBindingList();
            relationDataGridView.Refresh();
        }

        private void relationDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _repository = new TRELATIONRepository();

            var id = (decimal)relationDataGridView.Rows[e.RowIndex]
                .Cells[relationDataGridView.Columns["ID"].Index].Value;

            //var relation = _dbContext.TRELATION.Where(r => r.ID == getID).FirstOrDefault();

            //_dbContext.Entry(relation).Property(r => r.ID_Parent).CurrentValue = 
            //    (decimal)relationDataGridView.Rows[e.RowIndex]
            //    .Cells[relationDataGridView.Columns["ID_Parent"].Index].Value;

            //_dbContext.Entry(relation).Property(r => r.ID_Child).CurrentValue =
            //   (decimal)relationDataGridView.Rows[e.RowIndex]
            //   .Cells[relationDataGridView.Columns["ID_Child"].Index].Value;

            //_dbContext.SaveChanges();

            //
            var relation = _repository.Find(id);

            _repository.Update(relation);

        }
    }
}

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

using System.Data.Entity;

namespace TestWinApp.Forms.TRELATIONview
{
    public partial class AddForm : Form
    {
        private TestDBContext _dbContext;

        private TRELATIONRepository _repository;
        public AddForm()
        {
            InitializeComponent();
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs e);
        public event UpdateDelegate UpdateEventHandler;
        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                _dbContext = new TestDBContext();
                _repository = new TRELATIONRepository();

                decimal id_Parent = decimal.Parse(this.textBox1.Text);
                decimal id_Child = decimal.Parse(this.textBox2.Text);

                var parent = _dbContext.TGROUP.Find(id_Parent);     // check in tgroup
                var child = _dbContext.TGROUP.Find(id_Child);       //
                                                                    //
                if (!((parent is TGROUP) && (child is TGROUP)))     //
                    return;                                         //

                var newRelation = new TRELATION
                {
                    ID_Parent = id_Parent,
                    ID_Child = id_Child
                };

                //if (_dbContext.TGROUP.Any(obj => obj.ID == id_Parent) && _dbContext.TGROUP.Any(obj => obj.ID == id_Child))
                //{
                //    _dbContext = SingletonConnection.GetConnection();
                //    _dbContext.TRELATION.Add(newRelation);
                //    _dbContext.SaveChanges();
                //}

                _repository.Create(newRelation);

                InsertRefresh();
                this.Close();

            } catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }
        private void InsertRefresh()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler?.Invoke(this, args);
        }
    }
}

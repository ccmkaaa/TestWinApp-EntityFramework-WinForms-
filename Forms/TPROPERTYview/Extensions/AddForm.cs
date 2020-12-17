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


namespace TestWinApp.Forms.TPROPERTYview
{
    public partial class AddForm : Form
    {
        private TestDBContext _dbContext;
        private TPROPERTYRepository _repository;

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
                _dbContext.TGROUP.Load();
                _repository = new TPROPERTYRepository();

                int idGroup = int.Parse(this.textBox1.Text);
                string name = _dbContext.TGROUP.Where(gr => gr.ID == idGroup)
                    .FirstOrDefault().Name;
                string value = this.textBox3.Text;

                if (_repository.FindByGroupID(idGroup) != null)
                {
                    MessageBox.Show($"Для группы с {idGroup} уже существует TPROPERTY");
                    return;
                }

                _repository.Create(new TPROPERTY
                {
                    ID_Group = idGroup,
                    Name = name,
                    Value = value
                });

                InsertRefresh();
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }
        private void InsertRefresh()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler?.Invoke(this, args);
        }
    }
}

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

namespace TestWinApp.Forms.TGROUPview
{
    public partial class AddForm : Form
    {
        //private TestDBContext _dbContext;

        private TGROUPRepository _repository;

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
                _repository = new TGROUPRepository();

                string name = this.textBox2.Text;

                var newGroup = new TGROUP
                {
                    Name = name
                };

                _repository.Create(newGroup);

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

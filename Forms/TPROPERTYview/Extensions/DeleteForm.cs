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
    public partial class DeleteForm : Form
    {
        private TPROPERTYRepository _repository;
        
        public DeleteForm()
        {
            InitializeComponent();
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs e);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }   // not using 
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                _repository = new TPROPERTYRepository();

                decimal id = decimal.Parse(this.textBox1.Text);

                _repository.Delete(id);

                DeleteRefresh();
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }
        private void DeleteRefresh()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler?.Invoke(this, args);
        }
    }
}

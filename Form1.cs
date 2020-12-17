using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;
using System.Collections.ObjectModel;

using TestWinApp.Classes.DAL;
using TestWinApp.Classes.DALnew;
using TestWinApp.Forms;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace TestWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Task.Run(() => serverFunction());
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }
        private void btn_TGroup_Click(object sender, EventArgs e)
        {
            Form tGroup = new TGroupForm();
            tGroup.ShowDialog();
        }
        private void btn_TRelation_Click(object sender, EventArgs e)
        {
            Form tRelation = new TRelationForm();
            tRelation.ShowDialog();
        }
        private void btn_TProperty_Click(object sender, EventArgs e)
        {
            Form tProperty = new TPropertyForm();
            tProperty.ShowDialog();
        }
    }
}

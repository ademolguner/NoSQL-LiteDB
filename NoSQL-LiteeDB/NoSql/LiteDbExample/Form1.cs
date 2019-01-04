using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDbExample.Entities;
using LiteDB;

namespace LiteDbExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //dgpersonellist.AutoGenerateColumns = true;
        }

        private LiteCollection<Personel> _personalList;
        private LiteDatabase _liteDatabase;
        private Personel _selectedPerson;
        private void Form1_Load(object sender, EventArgs e)
        {
            

            _liteDatabase = new LiteDatabase(@"../../AdemOlgunerNoSQL.db");
            _liteDatabase.DropCollection("Personels");
            _personalList = GetlistPersonels(_liteDatabase);
            PersonListBindDataGrid(_personalList);
        }



        private void btnkaydet_Click(object sender, EventArgs e)
        {
            var personel = new Personel
            {
                FirstName = txtfirstname.Text,
                LastName = txtlastname.Text,
                Age = Convert.ToInt32(txtage.Text)
            };
            _personalList.Insert(personel);




            DataAreaClear();
            PersonListBindDataGrid(_personalList);
        }



        public void PersonAdd(Personel addedpersonel)
        {
            _personalList.Insert(addedpersonel);
             
        }

        public LiteCollection<Personel> GetlistPersonels(LiteDatabase database)
        {
            return _personalList = database.GetCollection<Personel>("Personels");
        }




        public void PersonListBindDataGrid(LiteCollection<Personel> _personalListItemsCollection)
        {
            var personAllList = _personalListItemsCollection.FindAll().ToList();

            dgpersonellist.DataSource = personAllList;
        }

       

        public void DataAreaClear()
        {
            txtfirstname.Text = "";
            txtlastname.Text = "";
            txtage.Text = "";
        }

        private void dgpersonellist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dgpersonellist.Rows[e.RowIndex].Selected = true;
                _selectedPerson = _personalList.FindById(Convert.ToInt32(dgpersonellist.Rows[e.RowIndex].Cells[0].Value.ToString()));


                txtfirstname.Text = _selectedPerson.FirstName;
                txtlastname.Text = _selectedPerson.LastName;
                txtage.Text = _selectedPerson.Age.ToString();
                btnguncelle.Visible = true;
                btnkaydet.Visible = false;
                btnsil.Visible = true;
                btncancelselected.Visible = true;
            }
            else
            {
                btnguncelle.Visible = false;
                btnkaydet.Visible = true;
                btnsil.Visible = false;
                btncancelselected.Visible = false;
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            _personalList.Update(_selectedPerson.PersonelId,   new Personel
            {
                FirstName = txtfirstname.Text,
                LastName = txtlastname.Text,
                Age = Convert.ToInt32(txtage.Text)
            });
            _personalList = GetlistPersonels(_liteDatabase);
            PersonListBindDataGrid(_personalList);
            DataAreaClear();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            _personalList.Delete(_selectedPerson.PersonelId);




            _personalList = GetlistPersonels(_liteDatabase);
            PersonListBindDataGrid(_personalList);
            DataAreaClear();
        }

        

        private void btncancelselected_Click(object sender, EventArgs e)
        {
            btnguncelle.Visible = false;
            btnkaydet.Visible = true;
            btnsil.Visible = false;
            btncancelselected.Visible = false;
            DataAreaClear();
        }
    }
}

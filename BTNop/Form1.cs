using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTNop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetCBB();
            comboBox1.SelectedIndex = 0;
        }
        public void SetCBB()
        {
            demo db = new demo();
            comboBox1.Items.Add(new CBBItem { Val = 0, Text = "All" });
            foreach (LopSV i in db.LopSVs)
            {
                comboBox1.Items.Add(new CBBItem
                {
                    Text = i.NameLop,
                    Val = i.ID_Lop

                });



            }

        }
        public void ShowDGV()
        {
            demo db = new demo();
            var li = db.SinhViens.Select(p => p);
            dataGridView1.DataSource = li.ToList();
           
        }


        //[SEARCH]
        private void Search_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hihi");
        }
        //{
        //    demo db = new demo();
        //    int ID_Lop = ((CBBItem)comboBox1.SelectedItem).Val;
        //    string search = txtSearch.Text;
        //    if (comboBox1.SelectedIndex != 0)
        //    {
        //        var list = db.SinhViens.Where(p => p.IdLop == ID_Lop).Select(p => p.NameSV.Contains(search));
        //        dataGridView1.DataSource = list.ToList();
        //    }
        //    else
        //    {
        //        var list = db.SinhViens.Select(p => p.NameSV.Contains(search));
        //        dataGridView1.DataSource = list.ToList();
        //    }

        //}

      

        //[ADD]
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2("");
            newform.D += new Form2.Mydel(ShowDGV);
            newform.ShowDialog();
        }
        //[EDIT]
        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection data = dataGridView1.SelectedRows;
            if (data.Count == 1)
            {
                string MSSV = data[0].Cells["MSSV"].Value.ToString();
                Form2 newform = new Form2(MSSV);
                newform.D += new Form2.Mydel(ShowDGV);
                newform.ShowDialog();

            }
            else
            {
                MessageBox.Show("Hãy chọn row bạn muốn edit!!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("xyx");
            //demo db = new demo();
            //dataGridView1.DataSource = db.SinhViens.Select(p => p).OrderBy(p => p.NameSV);
            //from p in db.SinhViens
            //////where cust.city == "đà lạt"
            //orderby p.NameSV ascending
            //select p;
            //dataGridView1.DataSource = query.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("abc");
        }
    }
}

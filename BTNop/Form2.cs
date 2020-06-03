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
    public partial class Form2 : Form
    {

        private string _MSSV;
        public string MSSV { get => _MSSV; set => _MSSV = value; }
        public delegate void Mydel();
        public Mydel D { get; set; }


        public Form2(string s)
        {
            MSSV = s;
            InitializeComponent();
            //CBB();
            setview();
        }
        public void setview()
        {

            if (MSSV != "")
            {
                demo db = new demo();
                var li = db.SinhViens.Where(p => p.MSSV == MSSV).Select(p => p);
                DataTable dt = li.ToList();
                DataRow dr = dt.Rows[0];
                textMSSV.Text = dr["MSSV"].ToString();
                textName.Text = dr["NameSV"].ToString();
                textAge.Text = dr["Age"].ToString();
                int k = Convert.ToInt32(dr["IDLop"].ToString());
                foreach (CBBItem i in comboBox1.Items)

                {
                    if (i.Val == k)
                    {
                        int index = comboBox1.Items.IndexOf(i);
                        comboBox1.SelectedIndex = index;

                    }
                }
            }
        }
        //[OK]
        private void button1_Click(object sender, EventArgs e)
        {
            demo db = new demo();
            var li1 = db.LopSVs.Select(p => p);
            // string query3 = "select * from LopSV";


            string id = "";
            string lop = comboBox1.SelectedItem.ToString();
            foreach (LopSV i in db.LopSVs)
            {
                if (lop == db.LopSVs.where.LopSV.NameLop)
                {
                    id = p.IdLop;
                }
            }

            if (MSSV == "")

            {
                SinhVien sv = new SinhVien();
                // ( Convert.ToInt32)sv.Age.ToString()) = textBox1.Text;
                sv.NameSV = textName.Text;
                sv.MSSV = textMSSV.Text;
                // sv.IdLop=
                db.SinhViens.Add(sv);
                db.SaveChanges();

            }



            else
            {

                SinhVien sv = db.SinhViens.Where(p => p.MSSV == MSSV).FirstOrDefault();
                sv.NameSV = textName.Text;
               sv.Age = textAge.Text;
                sv.IdLop =;
                db.SaveChanges();

                //sv.NameSV=
                //string queryUp = "Update SinhVien set NameSV = '" + textBox1.Text + "', Age='" + textBox3.Text + "', IdLop='" + id + "'where MSSV='" + textBox2.Text + "'";
                //QLSV2.Provider.Instance.Execute(queryUp);
                //MessageBox.Show("The data has been updated ");


            }
            D();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }






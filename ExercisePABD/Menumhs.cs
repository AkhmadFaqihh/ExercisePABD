using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercisePABD
{
    public partial class Menumhs : Form
    {
        public Menumhs()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=Valerian;Initial Catalog=ExercisePABD;User ID=sa;Password=geporcity");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id_mahasiswa = int.Parse(textBox1.Text);
            string nama_mahasiswa = textBox2.Text;
            string jenis_kelamin = textBox3.Text;
            int semester = int.Parse(textBox4.Text);
            string alamat = textBox5.Text;
            SqlCommand c = new SqlCommand("exec InsertMhs '" + id_mahasiswa + "','" + nama_mahasiswa + "','" + jenis_kelamin + "','" + semester + "','" + alamat + "'", con);
            MessageBox.Show("Data Berhasil Ditambahkan!");
            TampilSemuaData();
        }

        void TampilSemuaData()
        {
            SqlCommand c = new SqlCommand("exec TampilMhs", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Menumhs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exercisePABDDataSet1.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter1.Fill(this.exercisePABDDataSet1.Mahasiswa);
            // TODO: This line of code loads data into the 'exercisePABDDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.exercisePABDDataSet.Mahasiswa);

        }
    }
}

using System;
using System.Windows.Forms;

namespace สร้างคลาส_GPACalculator__ให้สมบูรณ์
{
    public partial class Form1 : Form
    {
        private GPACalculator calculator = new GPACalculator();

        public Form1()
        {
            InitializeComponent();
            btnAdd.Click += BtnAdd_Click; // เชื่อมปุ่มกับ Event
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // รับข้อมูลจาก TextBox
                AddStudent(tbName, tbScore);
                AddStudent(tbName2, tbScore2);
                AddStudent(tbName3, tbScore3);

                // อัปเดตค่าแสดงผล
                tbKon.Text = calculator.GetCount().ToString();
                tbHighest.Text = calculator.GetMaxScore().ToString("0.00");
                tbLowest.Text = calculator.GetMinScore().ToString("0.00");
                tbGpax.Text = calculator.GetGPAx().ToString("0.00");

                // เคลียร์ช่องข้อมูลหลังจากเพิ่มข้อมูลแล้ว
                tbName.Clear();
                tbScore.Clear();
                tbName2.Clear();
                tbScore2.Clear();
                tbName3.Clear();
                tbScore3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง: " + ex.Message);
            }
        }

        private void AddStudent(TextBox nameBox, TextBox scoreBox)
        {
            if (!string.IsNullOrWhiteSpace(nameBox.Text) && !string.IsNullOrWhiteSpace(scoreBox.Text))
            {
                string name = nameBox.Text;
                double score = double.Parse(scoreBox.Text);

                calculator.AddScore(score);
                DataGridView.Rows.Add(name, calculator.GetCount(), calculator.GetMaxScore(), calculator.GetMinScore(), calculator.GetGPAx().ToString("0.00"));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

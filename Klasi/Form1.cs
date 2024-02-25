using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Хороскоп
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Lav_Click(object sender, EventArgs e)
        {
            Form2 LionForm = new Form2();

            this.Hide();

            LionForm.Show();
        }

        private void Oven_Click(object sender, EventArgs e)
        {
            Form3 OvenForm = new Form3();

            this.Hide();

            OvenForm.Show();
        }

        private void Bik_Click(object sender, EventArgs e)
        {
            Form4 BikForm = new Form4();

            this.Hide();

            BikForm.Show();
        }

        private void Vodolija_Click(object sender, EventArgs e)
        {
            Form5 VodolijaForm = new Form5();

            this.Hide();

            VodolijaForm.Show();
        }

        private void Bliznaci_Click(object sender, EventArgs e)
        {
            Form6 BliznaciForm = new Form6();

            this.Hide();

            BliznaciForm.Show();
        }

        private void Rak_Click(object sender, EventArgs e)
        {
            Form7 SkorpijaForm = new Form7();

            this.Hide();

            SkorpijaForm.Show();
        }

        private void Skorpija_Click(object sender, EventArgs e)
        {
            Form8 StrelecForm = new Form8();

            this.Hide();

            StrelecForm.Show();
        }

        private void Jarec_Click(object sender, EventArgs e)
        {
            Form9 VagaForm = new Form9();

            this.Hide();

            VagaForm.Show();
        }

        private void Strelec_Click(object sender, EventArgs e)
        {
            Form10 JarecForm = new Form10();

            this.Hide();

            JarecForm.Show();
        }


        private void Vaga_Click(object sender, EventArgs e)
        {
            Form12 VagaForm = new Form12();

            this.Hide();

            VagaForm.Show();
        }

        private void Ribi_Click(object sender, EventArgs e)
        {
            Form13 RibiForm = new Form13();

            this.Hide();

            RibiForm.Show();
        }

        private void Devica_Click(object sender, EventArgs e)
        {
            Form11 DevicaForm = new Form11();

            this.Hide();

            DevicaForm.Show();
        }
    }
}

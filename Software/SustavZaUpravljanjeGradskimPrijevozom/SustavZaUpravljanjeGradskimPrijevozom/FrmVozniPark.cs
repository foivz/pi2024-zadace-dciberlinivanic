using SustavZaUpravljanjeGradskimPrijevozom.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SustavZaUpravljanjeGradskimPrijevozom
{
    public partial class FrmVozniPark : Form
    {
        public FrmVozniPark()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBLayer.DB.SetConfiguration("PI2324_dciberlin22_DB", "PI2324_dciberlin22_User", "Edk;TP%p");
            ShowVozila();
        }

        private void ShowVozila()
        {
            var vozila = VozilaRepository.GetVozilos();
            dgvVozila.DataSource = vozila;
            dgvVozila.Columns["SerijskiBroj"].DisplayIndex = 0;
            dgvVozila.Columns["Marka"].DisplayIndex=0;
            dgvVozila.Columns["Registracija"].DisplayIndex = 0;
            dgvVozila.Columns["BrKilometara"].DisplayIndex = 0;
            dgvVozila.Columns["BrSjedala"].DisplayIndex = 0;
            dgvVozila.Columns["GarazniBroj"].DisplayIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDodavanje frmDodavanje = new FrmDodavanje();
            frmDodavanje.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

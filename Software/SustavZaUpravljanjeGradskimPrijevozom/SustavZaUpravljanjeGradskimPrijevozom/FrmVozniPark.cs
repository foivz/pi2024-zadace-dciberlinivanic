using DBLayer;
using SustavZaUpravljanjeGradskimPrijevozom.Models;
using SustavZaUpravljanjeGradskimPrijevozom.Repositories;
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
            dgvVozila.Columns["GarazniBroj"].DisplayIndex = 0;
            dgvVozila.Columns["Marka"].DisplayIndex = 1;
            dgvVozila.Columns["Tip"].DisplayIndex = 2;
            dgvVozila.Columns["Registracija"].DisplayIndex = 3;
            dgvVozila.Columns["BrKilometara"].DisplayIndex = 4;
            dgvVozila.Columns["BrSjedala"].DisplayIndex = 5;
            dgvVozila.Columns["Korime"].DisplayIndex = 6;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDodavanje frmDodavanje = new FrmDodavanje();
            frmDodavanje.ShowDialog();
            ShowVozila();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvVozila_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void txtPretrazi_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtPretrazi.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                var vozila = VozilaRepository.PretraziVozila(searchText);
                dgvVozila.DataSource = vozila;
            }
           else
            {
               ShowVozila();
            }

        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            Vozilo selectedVozilo = dgvVozila.CurrentRow.DataBoundItem as Vozilo;
            DialogResult result = MessageBox.Show("Želite li obrisati označeno vozilo?", "Brisanje autobusa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                VozilaRepository.Brisanje(selectedVozilo.GarazniBroj);
                MessageBox.Show("Autobus je uspješno obrisan!", "Uspješno brisanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowVozila();
            }
        }
        private void btnIzmjena_Click(object sender, EventArgs e)
        {
            Vozilo selectedVozilo = dgvVozila.CurrentRow.DataBoundItem as Vozilo;

            FrmAžuriranje frmažuriranje = new FrmAžuriranje(selectedVozilo);
            frmažuriranje.ShowDialog();
            ShowVozila();
        }
    }
}
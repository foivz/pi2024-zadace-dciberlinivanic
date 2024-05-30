using SustavZaUpravljanjeGradskimPrijevozom.Models;
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
    public partial class FrmAžuriranje : Form
    {
        private Vozilo selectedVozilo;
        public FrmAžuriranje(Vozilo selectedVozilo)
        {
            InitializeComponent();
            this.selectedVozilo = selectedVozilo;
        }

        private void FrmAžuriranje_Load(object sender, EventArgs e)
        {
            var tipvozila = TipVozilaRepository.GetTipVozila();
            cboTip.DataSource = tipvozila;
            cboTip.ValueMember = "Tip";


            var zaposlenik = ZaposlenikRepository.GetZapsolenik();
            cboZaposlenik.DataSource = zaposlenik;
            cboZaposlenik.ValueMember = "Korime";

            cboTip.SelectedItem= selectedVozilo.Tip;
            cboZaposlenik.SelectedItem=selectedVozilo.Korime;
            txtMarka.Text = selectedVozilo.Marka;
            txtRegistracija.Text = selectedVozilo.Registracija;
            txtKilometri.Text = selectedVozilo.BrKilometara.ToString();

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            VozilaRepository.Azuriranje(txtMarka.Text, txtRegistracija.Text, txtKilometri.Text, cboZaposlenik.SelectedValue.ToString(), cboTip.SelectedValue.ToString(),txtBrSjedala.Text,selectedVozilo.GarazniBroj);
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentTip = cboTip.SelectedItem as TipVozila;
            txtBrSjedala.Text = currentTip.BrojSjedala.ToString();
        }
    }
}

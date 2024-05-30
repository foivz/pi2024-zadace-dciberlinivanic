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
    public partial class FrmDodavanje : Form
    {
        public FrmDodavanje()
        {
            InitializeComponent();
        }

        private void FrmDodavanje_Load(object sender, EventArgs e)
        {
            var tipvozila = TipVozilaRepository.GetTipVozila();
            cboTip.DataSource = tipvozila;
            

            var zaposlenik = ZaposlenikRepository.GetZapsolenik();
            cboZaposlenik.DataSource = zaposlenik;
            cboZaposlenik.DisplayMember = "Korime";
        }

        private void cboTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentTip = cboTip.SelectedItem as TipVozila;
            txtBrSjedala.Text = currentTip.BrojSjedala.ToString();    
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
           VozilaRepository.Unos(txtMarka.Text, txtRegistracija.Text, txtKilometri.Text, txtBrSjedala.Text, cboTip.SelectedItem.ToString(), cboZaposlenik.SelectedValue.ToString());
           Close();
        }
    }
}

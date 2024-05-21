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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBLayer.DB.SetConfiguration("PI2324_dciberlin22_DB", "PI2324_dciberlin22_User", "Edk;TP%p");
        }
    }
}

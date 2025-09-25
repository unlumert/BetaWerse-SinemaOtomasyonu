using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaWerse
{
    public partial class FimListesi : UserControl
    {
        public FimListesi()
        {
            InitializeComponent();
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
           frmFilmDetay frm = new frmFilmDetay();
            frm.idNo = lblNo.Text;
           frm.ShowDialog();
        }
    }
}

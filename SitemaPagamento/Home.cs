using SitemaPagamento.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SitemaPagamento
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            Dbteste db = new Dbteste();

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}

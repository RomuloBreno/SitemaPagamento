using SitemaPagamento.Domain;
using SitemaPagamento.Viewes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SitemaPagamento
{
    public partial class Home : Form
    {
        public Home()
        {

            //Login login = new Login();
            // login.ShowDialog();



            InitializeComponent();

            Dbteste db = new Dbteste();

        }

        
    }
}

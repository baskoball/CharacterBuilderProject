using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterBuilder
{
    public partial class frmWelcomeScreen : Form
    {
        public frmWelcomeScreen()
        {
            InitializeComponent();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBeginCharacter beginingCharacter = new frmBeginCharacter();
            beginingCharacter.Show();
            beginingCharacter.FormClosed += (s, args) => this.Close();
        }
    }
}

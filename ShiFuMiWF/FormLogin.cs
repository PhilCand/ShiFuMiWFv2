using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiFuMiWF
{
    public partial class FormLogin : Form
    {
        Form1 form1;
        public string newGame { set => labelNewGame.Text = value; }

        public FormLogin(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            bool isOK;
            int result;

            if (isOK = int.TryParse(txtboxScore.Text, out result))
            {
                form1.ScoreMax = result;
                form1.ScoreIA = 0;
                form1.ScoreJoueur = 0;
                this.Close();
            }
            else MessageBox.Show("Saisie incorrecte", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

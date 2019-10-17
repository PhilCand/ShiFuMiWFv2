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
    enum choix { pierre, feuille, ciseaux};
    public partial class Form1 : Form
    {
        choix? choixJoueur = null;
        choix? choixIA = null;
        public int ScoreJoueur { get; set; } = 0;
        public int ScoreIA { get; set; } = 0;
        public int ScoreMax { get; set; }       
        Random rnd = new Random();
        Image pierreImage = Image.FromFile("pierre.png");
        Image feuilleImage = Image.FromFile("feuille.png");
        Image ciseauxImage = Image.FromFile("ciseaux.png");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            FormLogin frmlog = new FormLogin(this);
            frmlog.ShowDialog();
            LancerJeu();
        }

        private void LancerJeu()
        {            
            labelIA.Image = null;
            choixJoueur = null;
            choixIA = null;
            labelJoueur.Image = null;
            labelJoueur.Text = "Choisissez !";
            labelVicDef.Text = "";
        }

        private void btnPierre_Click(object sender, EventArgs e)
        {
            if (choixJoueur == null)
            {
                choixJoueur = choix.pierre;
                btnPierre.FlatStyle = FlatStyle.Standard;
                labelJoueur.Text = "";
                labelJoueur.Image = pierreImage;
                ChoixIA();                
            }         
        }

        private void btnFeuille_Click(object sender, EventArgs e)
        {
            if (choixJoueur == null)
            {
                choixJoueur = choix.feuille;
                btnFeuille.FlatStyle = FlatStyle.Standard;
                labelJoueur.Text = "";
                labelJoueur.Image = feuilleImage;
                ChoixIA();              
            }
        }

        private void btnCiseaux_Click(object sender, EventArgs e)
        {
            if (choixJoueur == null)
            {
                choixJoueur = choix.ciseaux;
                btnCiseaux.FlatStyle = FlatStyle.Standard;
                labelJoueur.Text = "";
                labelJoueur.Image = ciseauxImage;
                ChoixIA();                
            }
        }

        private async void ChoixIA()
        {

            {
                choixIA = ((choix)rnd.Next(0, 3));
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = "shifumi.wav";
                
                labelIA.Text = "";
                await Task.Delay(700);
                player.Play();
                labelVicDef.ForeColor = Color.BlueViolet;
                labelVicDef.Text = "SHI";
                await Task.Delay(600);
                labelVicDef.Text = "FU";
                await Task.Delay(600);
                labelVicDef.Text = "MI";
                await Task.Delay(400);
                labelVicDef.Text = "";

                if (choixIA == choix.pierre) labelIA.Image = pierreImage;
                if (choixIA == choix.feuille) labelIA.Image = feuilleImage;
                if (choixIA == choix.ciseaux) labelIA.Image = ciseauxImage;
                CalculerResultat();
                
                await Task.Delay(2500);
                if (ScoreJoueur < ScoreMax && ScoreIA < ScoreMax) LancerJeu();
                else FinDePartie();

            }
        }

        private void CalculerResultat()
        {
            if (choixJoueur == choixIA)                                          // isolation de l'egalité
            {
                labelVicDef.ForeColor = Color.LightSkyBlue;
                labelVicDef.Text = "Egalité";
            }

            else if ((choixJoueur == choix.ciseaux) && (choixIA == choix.feuille)) win(); //les cas ou le joueur gagne

            else if ((choixJoueur == choix.pierre) && (choixIA == choix.ciseaux)) win();

            else if ((choixJoueur == choix.feuille) && (choixIA == choix.pierre)) win();


            else                                                                    // sinon il perd
            {
                labelVicDef.ForeColor = Color.Red;
                labelVicDef.Text = "Perdu !";
                ScoreIA++;
                labelScoreIA.Text = ScoreIA.ToString();
            }
            ResetButtons();
        }

        private void win()
        {
            labelVicDef.ForeColor = Color.Green;
            labelVicDef.Text = "Gagné !";
            ScoreJoueur++;
            labelScoreJoueur.Text = ScoreJoueur.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Voulez vous vraiment quitter", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) e.Cancel = true;
        }

        private void FinDePartie()
        {
            if (ScoreJoueur > ScoreIA)
            {
                FormLogin frmLogin = new FormLogin(this);
                frmLogin.newGame = $"Vous avez gagné {ScoreJoueur} à {ScoreIA} \nrecommencer ?";
                frmLogin.ShowDialog();
                ResetAll();
            }

            if (ScoreJoueur < ScoreIA)
            {
                FormLogin frmLogin = new FormLogin(this);                
                frmLogin.newGame = $"Vous avez perdu {ScoreJoueur} à {ScoreIA} \nrecommencer ?";
                frmLogin.ShowDialog();
                ResetAll();
            }
        }

        private void ResetAll()
        {
            choixIA = null;
            choixJoueur = null;
            ScoreIA = 0;
            ScoreJoueur = 0;
            labelScoreJoueur.Text = ScoreJoueur.ToString();
            labelScoreIA.Text = ScoreIA.ToString();
            labelJoueur.Image = null;
            labelIA.Image = null;
            labelJoueur.Text = "Choisissez !";
            labelVicDef.Text = "";
            ResetButtons();
        }

        private void ResetButtons()
        {
            btnPierre.FlatStyle = FlatStyle.Flat;
            btnFeuille.FlatStyle = FlatStyle.Flat;
            btnCiseaux.FlatStyle = FlatStyle.Flat;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPFenetreMereFille
{
    public partial class FFille : Form
    {
        int id;
        private string monNom;
        private FMere maMere;

        public FFille(FMere maMere, int id)
        {
            InitializeComponent();
            this.maMere = maMere;
            this.id = id;
            this.Text = "Fille n°" + id;
            this.monNom = this.Text;
            this.Load +=new EventHandler(FFille_Load);
        }

        void FFille_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Evenement Load sur " + this.monNom);
        }

        private void btnMere_Click(object sender, EventArgs e)
        {
            string nom = this.Mere.NomMere;
            MessageBox.Show(nom);
        }

        private void btnChanger_Click(object sender, EventArgs e)
        {
            this.Text = tbNom.Text;
            string nom= this.Text;
            maMere.MaFilleChangeDeNom(this, nom);
        }



        private void tbNom_TextChanged(object sender, EventArgs e)
        {
            this.Text = tbNom.Text;
            string nom = this.Text;
            maMere.MaFilleChangeDeNom(this, nom);
        }

        private void lbNom_Click(object sender, EventArgs e)
        {

        }

        public FMere Mere
        {
            get
            {
                return this.maMere;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        
    }
}

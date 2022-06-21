namespace StoneScissorsPaper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Compare(Choise userChoise)
        {
            Choise compChoise = (Choise)(new Random()).Next(0, 2);
            lblOut.Text = "Компьютер показывает: " + compChoise.ToString();
            if(userChoise == compChoise)
                return;
            else if ((userChoise < compChoise) && compChoise - userChoise == 1
                || userChoise - compChoise == 2)
            {
                scoreUser++;
                lblScoreUser.Text = scoreUser.ToString();
            }
            else
            {
                scoreComp++;
                lblScoreComp.Text = scoreComp.ToString();
            }
        }

        private void btnStone_Click(object sender, EventArgs e)
        {
            Compare(Choise.Камень);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            Compare(Choise.Ножницы);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            Compare(Choise.Бумага);
        }
    }
}
namespace AtYarisi
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int sayac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            // atlar�n ilerlemesi
            at1.Left += rnd.Next(1, 6);
            at2.Left += rnd.Next(1, 6);
            at3.Left += rnd.Next(1, 6);

            // en �ndeki at�n belirlenmesi
            PictureBox ondeki = at1;
            if (at2.Left > ondeki.Left) ondeki = at2;
            if (at3.Left > ondeki.Left) ondeki = at3;

            if (sayac > 10)
                lblDurum.Text = $"{ondeki.Tag} nolu at yar��� �nde s�rd�r�yor..";

            //yar���n bitmesi
            if (ondeki.Right > pnlBitis.Left)
            {
                timer1.Stop();
                lblDurum.Text = $"Yar�� bitti. {ondeki.Tag} nolu at yar��� kazand�.";
            }
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (btnBaslat.Text == "BA�LAT")
            {
                timer1.Start();
                lblDurum.Text = "Ve yar�� ba�lad�.";
                btnBaslat.Text = "YEN� YARI�";
            }
            else
            {
                timer1.Stop();
                at1.Left = at2.Left = at3.Left = 0;
                btnBaslat.Text = "BA�LAT";
                sayac = 0;
                lblDurum.Text = "Atlar yar��a haz�r.";
            }
        }
    }
}
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
            // atlarýn ilerlemesi
            at1.Left += rnd.Next(1, 6);
            at2.Left += rnd.Next(1, 6);
            at3.Left += rnd.Next(1, 6);

            // en öndeki atýn belirlenmesi
            PictureBox ondeki = at1;
            if (at2.Left > ondeki.Left) ondeki = at2;
            if (at3.Left > ondeki.Left) ondeki = at3;

            if (sayac > 10)
                lblDurum.Text = $"{ondeki.Tag} nolu at yarýþý önde sürdürüyor..";

            //yarýþýn bitmesi
            if (ondeki.Right > pnlBitis.Left)
            {
                timer1.Stop();
                lblDurum.Text = $"Yarýþ bitti. {ondeki.Tag} nolu at yarýþý kazandý.";
            }
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (btnBaslat.Text == "BAÞLAT")
            {
                timer1.Start();
                lblDurum.Text = "Ve yarýþ baþladý.";
                btnBaslat.Text = "YENÝ YARIÞ";
            }
            else
            {
                timer1.Stop();
                at1.Left = at2.Left = at3.Left = 0;
                btnBaslat.Text = "BAÞLAT";
                sayac = 0;
                lblDurum.Text = "Atlar yarýþa hazýr.";
            }
        }
    }
}
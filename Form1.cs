namespace Switch_Case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string mevsim = textBox1.Text;
            switch(mevsim)
            {
                case "yaz": label2.Text = "Haziran - Temmuz - A�ustos"; 
                    break;
                case "sonbahar": label2.Text = "Eyl�l - Ekim - Kas�m";
                    break;
                case "k��": label2.Text = "Aral�k - Ocak - �ubat";
                    break;
                case "ilkbahar": label2.Text = "Mart - Nisan - May�s";
                    break;
                default: label2.Text = "hatal� mevsim";
                    break;
            }
        }
    }
}
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
                case "yaz": label2.Text = "Haziran - Temmuz - Aðustos"; 
                    break;
                case "sonbahar": label2.Text = "Eylül - Ekim - Kasým";
                    break;
                case "kýþ": label2.Text = "Aralýk - Ocak - Þubat";
                    break;
                case "ilkbahar": label2.Text = "Mart - Nisan - Mayýs";
                    break;
                default: label2.Text = "hatalý mevsim";
                    break;
            }
        }
    }
}
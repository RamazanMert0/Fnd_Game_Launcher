namespace Fnd_Game_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int dk;
        int sn;


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = sn.ToString();
            sn++;
            if (sn == 59)
            {
                dk++;
                sn = 0;
            }
        }
    }
}
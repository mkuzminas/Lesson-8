using GetSet.Business2;

namespace GetSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Saskaita saskaita = new Saskaita("Jonas", "Petras", 10);

            textBox1.Text = $" {saskaita.SaskaitosNumeris}, {saskaita.Gavejas}, {saskaita.Siuntejas}, {saskaita.MoketiViso}";


        }
    }
}
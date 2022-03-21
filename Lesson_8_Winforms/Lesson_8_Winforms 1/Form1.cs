namespace Lesson_8_Winforms_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BibliotekosKnyga bibliotekosKnyga = new BibliotekosKnyga(1, "Jonas", new DateTime(2022, 01, 01));
            rezultatas.Text = Convert.ToString(bibliotekosKnyga.CalculateDays()); 
        }
    }
}
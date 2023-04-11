namespace EJ25HerenciaPolimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CenasEmpresa cena = new CenasEmpresa();
            if (checkBox4.Checked == true)
            {
                cena.Constructor((int)numericUpDown2.Value, cena.CalcularCosteDecoracion(), true, 25);
            }
            else
            {
                cena.Constructor((int)numericUpDown2.Value, cena.CalcularCosteDecoracion(), false, 25);
            }

            if (checkBox3.Checked == true)
            {
                cena.EstableceOpcionSaludable();
            }
            textBox2.Text = cena.CalcularCoste().ToString() + '€';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cumpleanos cumple = new Cumpleanos();
            if (checkBox4.Checked == true)
            {
                cumple.Constructor((int)numericUpDown1.Value, cumple.CalcularCosteDecoracion(), true, 25);
            }
            else
            {
                cumple.Constructor((int)numericUpDown1.Value, cumple.CalcularCosteDecoracion(), false, 25);
            }
            cumple.textoTarta = textBox3.Text;
            textBox1.Text = cumple.CalcularCoste().ToString();
        }
    }
}
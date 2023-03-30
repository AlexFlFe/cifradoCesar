namespace CifradoCesarEx2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cifrar_Click(object sender, EventArgs e)
        {
            int posiciones = 5;
            string textoCifrado = "";
            String caja = textBox1.Text;
            for (int i = 0; i < caja.Length; i++)
            {
                int val = caja[i]; //val se iguala a la posicion del string para sumarle posiciones
                int dup = posiciones; //se duplica posiciones para mantener el valor
                if (val + posiciones > 122)
                { //compara si el caracter + las posiciones a añadir superan la z 
                    posiciones -= (122 - val);
                    posiciones = posiciones % 26;

                    textoCifrado = textoCifrado + (char)(96 + posiciones);
                }
                else
                {
                    textoCifrado = textoCifrado + (char)(val + posiciones);
                }
                posiciones = dup;
            }

            //añade texto cifrado a la segunda textbox;
            textBox2.Text = textoCifrado;
        }

        //Manera de llamar a todos los botones según el pulsado
        private void btA_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;

        }

        /*Manera simple de llamar al botón; solo al botón pulsado 
         * private void btA_Click(object sender, EventArgs e)
        {
            textBox1.Text += btA.Text;
        }
        */
        private void btS_Click(object sender, EventArgs e)
        {
            textBox1.Text += btS.Text;
        }

        private void btD_Click(object sender, EventArgs e)
        {
            textBox1.Text += btD.Text;
        }

        private void btF_Click(object sender, EventArgs e)
        {
            textBox1.Text += btF.Text;
        }

        private void btG_Click(object sender, EventArgs e)
        {
            textBox1.Text += btG.Text;
        }

        private void btH_Click(object sender, EventArgs e)
        {
            textBox1.Text += btH.Text;
        }

        private void btJ_Click(object sender, EventArgs e)
        {
            textBox1.Text += btJ.Text;
        }

        private void btK_Click(object sender, EventArgs e)
        {
            textBox1.Text += btK.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            Cifrar_Click(sender,e);
        }
    }
}
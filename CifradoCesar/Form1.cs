namespace CifradoCesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int posiciones = 5;
            string textoCifrado = "";
            String caja = textBox1.Text;
            for (int i = 0; i < caja.Length; i++)
            {
                int val = caja[i]; //val se iguala a la posicion del string para sumarle posiciones
                int dup = posiciones; //se duplica posiciones para mantener el valor
                if(val+posiciones>122){ //compara si el caracter + las posiciones a añadir superan la z 
                    posiciones -= (122 - val);
                    posiciones = posiciones % 26;

                    textoCifrado = textoCifrado +(char)(96 + posiciones);
                }
                else
                {
                    textoCifrado = textoCifrado + (char)(val+posiciones);
                }
                posiciones = dup;
            }
           
            //añade texto cifrado a la segunda textbox;
            label3.Text = textoCifrado;
        }
    }
}
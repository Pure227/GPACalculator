namespace GPACalculator
{
    public partial class Form1 : Form
    {          
        GPACalculator oGPACal = new GPACalculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = this.textBoxGPA_input.Text;
            string name = this.textBoxname_input.Text;

            double dinput = Convert.ToDouble(input);
            oGPACal.addGPA(dinput, name);

            double gpax = oGPACal.getGPA();
            this.textBoxGPAx.Text = gpax.ToString();

            double max = oGPACal.getmax();
            textBoxmaxname.Text = oGPACal.getmaxname().ToString();
            textBoxmax.Text = oGPACal.getmax().ToString();

            this.textBoxGPA_input.Text = "";
            textBoxname_input.Text = string.Empty;
            textBoxalldata.Text = oGPACal.getalldata();

            double min = oGPACal.getmin();
            textBoxminname.Text = oGPACal.getminname().ToString();
            textBoxmin.Text = min.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxGPA_input.Text = "";
            textBoxGPAx.Text = "";
            textBoxmax.Text = "";
            textBoxmin.Text = "";
            textBoxmaxname.Text = "";
            textBoxminname.Text = "";
            textBoxalldata.Text = "";

        }
    }
}
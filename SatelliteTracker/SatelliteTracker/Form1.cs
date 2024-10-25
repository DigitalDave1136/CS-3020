namespace SatelliteTracker
{
    public partial class Form1 : Form
    {
        private UDLChecker udlChecker = new UDLChecker();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            udlChecker.SetMaxResults(Int32.Parse(comboBox1.Text));
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetAllTextBoxes();
            udlChecker.SetSatelliteNumber(comboBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            udlChecker.UDL_Get(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            udlChecker.SelectSpecificSatelliteToDisplay();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ResetAllTextBoxes();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        public void ResetAllTextBoxes()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }
        public void ComboBox2Update(string newValue)
        {
            comboBox2.Items.Add(newValue);
        }
        public void UpdateTextBox(string newValue, TextBox textBoxToUpdate)
        {
            textBoxToUpdate.AppendText(newValue);
            textBoxToUpdate.AppendText(Environment.NewLine);
            textBoxToUpdate.Refresh();
        }
    }
}

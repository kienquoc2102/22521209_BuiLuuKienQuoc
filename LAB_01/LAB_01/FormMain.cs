namespace LAB_01
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        List<Form> open_forms = new List<Form>();

        private void OpenForm(Form open_form)
        {
            open_form.Show();
            open_forms.Add(open_form);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT2());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT3());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT4());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT5());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT6());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT7());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT8());
        }

        private void FormMain_Leave(object sender, EventArgs e)
        {
            foreach (Form form in open_forms)
            {
                form.Close();
            }
            open_forms.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT3_1());
        }
    }
}

namespace LAB_02
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        List<Form> openForms = new List<Form>();
        private void openForm(Form form)
        {
            form.Show();
            openForms.Add(form);
        }

        private void buttonBT1_Click(object sender, EventArgs e)
        {
            openForm(new FormBT1());
        }

        private void buttonBT2_Click(object sender, EventArgs e)
        {
            openForm(new FormBT2());
        }

        private void buttonBT3_Click(object sender, EventArgs e)
        {
            openForm(new FormBT3());
        }

        private void buttonBT4_Click(object sender, EventArgs e)
        {
            openForm(new FormBT4());
        }

        private void buttonBT5_Click(object sender, EventArgs e)
        {
            openForm(new FormBT5());
        }

        private void buttonBT6_Click(object sender, EventArgs e)
        {
            openForm(new FormBT6());
        }

        private void buttonBT7_Click(object sender, EventArgs e)
        {
            openForm(new FormBT7());
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form form in openForms)
                form.Close();
        }

        private void FormMain_Leave(object sender, EventArgs e)
        {
            foreach (Form form in openForms)
                form.Close();
        }
    }
}

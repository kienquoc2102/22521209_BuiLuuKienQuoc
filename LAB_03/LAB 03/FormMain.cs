namespace LAB_03
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        List<Form> opened_form = new List<Form>();

        private void OpenForm(Form form)
        {
            form.Show();
            opened_form.Add(form);
        }

        private void CloseAllForm()
        {
            foreach (Form form in opened_form)
            {
                form.Close();
            }
        }

        private void btn_Form1_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT1());
        }

        private void btn_Form2_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT2());
        }

        private void btn_Form3_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT3());
        }

        private void btn_Form4_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT4());
        }

        private void btn_Form5_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT5());
        }

        private void btn_Form6_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT6());
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            this.Close();
        }

        private void FormMain_Leave(object sender, EventArgs e)
        {
            CloseAllForm();
            this.Close();
        }
    }
}

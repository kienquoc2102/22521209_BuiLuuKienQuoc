namespace LAB_05
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void OpenForm(Form form)
        {
            form.Show();
        }

        private void btn_OpenFormBT1_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT1());
        }

        private void btn_OpenFormBT2_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT2_BT3());
        }

        private void btn_OpenFormBT4_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT4());
        }

        private void btn_OpenFormBT5_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT5());
        }

        private void btn_OpenFormBT6_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT6());
        }
    }
}

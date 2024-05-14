namespace LAB_04
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

        private void btn_OpenBT1_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT1());
        }

        private void btn_OpenBT2_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT2());
        }

        private void btn_OpenBT3_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT3());
        }

        private void btn_OpenBT4_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT4());
        }

        private void btn_OpenBT5_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT5_BT6());
        }

        private void btn_OpenBT7_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBT7_Login());
        }
    }
}

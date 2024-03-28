using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_01
{
    public partial class FormSubBT7 : Form
    {
        private FormBT7 ParrentForm { get; set; }
        public FormSubBT7(FormBT7 ParrentForm)
        {
            InitializeComponent();
            this.ParrentForm = ParrentForm;
            LoadInfo();
        }

        private void LoadInfo()
        {
            txt_Name.Text = ParrentForm.OutputName();
            txt_Score.Text = ParrentForm.OutputScore();
            txt_AvgScore.Text = ParrentForm.OutputAvg();
            txt_Max.Text = ParrentForm.OutputMax();
            txt_Min.Text = ParrentForm.OutputMin();
            txt_Type.Text = ParrentForm.OutputType();
            ParrentForm.Reset();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

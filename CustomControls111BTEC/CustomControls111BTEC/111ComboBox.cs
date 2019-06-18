using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls111BTEC
{
    public partial class _111ComboBox : UserControl 
    {
        public _111ComboBox()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.Height == 30)
                this.Height = 200;
            else
                this.Height = 30;
        }
    }
}

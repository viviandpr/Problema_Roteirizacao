using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema_Roteirizacao
{
    public partial class Cost : Form
    {
        public int m_nCost;
        public Cost()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (textCost.Text == string.Empty){
                //    errorProvider1.SetError(textCost, "please enter value");
            }
            else
            {
                m_nCost = int.Parse(textCost.Text);
                this.Close();
            }
        }
    }
}

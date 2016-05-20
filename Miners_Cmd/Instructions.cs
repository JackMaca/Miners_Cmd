using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miners_Cmd
{
    public partial class Instructions : UserControl
    {
        public Instructions()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            MenuScreen ms = new MenuScreen();
            f.Controls.Add(ms);
            f.Controls.Remove(this);
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }
    }
}

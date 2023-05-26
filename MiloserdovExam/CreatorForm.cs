using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiloserdovExam
{
    public partial class CreatorForm : Form
    {
        public CreatorForm()
        {
            InitializeComponent();
        }

        private void CreatorForm_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}

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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void DocumentationButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:\\Users\\Public\\Documents\\Help+Manual\\NewProject\\CarDealerShip.chm");
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            var creatorForm = new CreatorForm();
            creatorForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

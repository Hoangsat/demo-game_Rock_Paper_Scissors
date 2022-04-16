using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rock_paper_scissors
{
    public partial class Form1 : Form
    {
        string user_figure = "";
        string comp_figure = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void show_user_figure(string figure)
        {
            picture_rock.Visible = figure == "rock";
            picture_scissors.Visible = figure == "scissors";
            picture_paper.Visible = figure == "paper";
        }
        private void show_conp_figure(string figure)
        {
            picture_rock_comp.Visible = figure == "rock";
            picture_scissors_comp.Visible = figure == "scissors";
            picture_paper_comp.Visible = figure == "paper";
        }
        private void user_panel_paper_MouseEnter(object sender, EventArgs e)
        {
            show_user_figure("paper");
        }

        private void user_panel_rock_MouseEnter(object sender, EventArgs e)
        {
            show_user_figure("rock");
        }

        private void user_panel_scissors_MouseEnter(object sender, EventArgs e)
        {
            show_user_figure("scissors");
        }
    }
}

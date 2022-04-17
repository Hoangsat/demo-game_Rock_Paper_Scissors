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
        Random rand = new Random();
        int score_win = 0;
        int score_lose = 0;
        int score_draw = 0;
        string mode = "show";
        int win = 0;
        int lose = 0;
        int draw = 0;
        public Form1()
        {
         
            InitializeComponent();
            show_score();
        }
        private void start_game()
        {
            if (mode != "game")
            {
                mode = "game";
                label_message.Text = "Take Your Figure";
                picture_visible.Visible =true;
            }

        }

        private void show_user_figure(string figure)
        {
            start_game();
            picture_rock.Visible = figure == "rock";
            picture_scissors.Visible = figure == "scissors";
            picture_paper.Visible = figure == "paper";
            user_figure = figure;
        }
       
         private void show_comp_figure(string figure)
        {
          
            picture_rock_comp.Visible = figure == "rock";
            picture_scissors_comp.Visible = figure == "scissors";
            picture_paper_comp.Visible = figure == "paper";
            comp_figure = figure;
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

        private void picture_rock_MouseClick(object sender, MouseEventArgs e)
        {
            check_result();
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mode == "game")
            {
                comp_random_figure();
                
            }

            }
            private void comp_random_figure()
        {
            int f = rand.Next(1, 4);
            if (f == 1)
                show_comp_figure("rock");
            if (f == 2)
                show_comp_figure("paper");
            if (f == 3)
                show_comp_figure("scissors"); 
        }
        void show_score()
        {
          
                label_score.Text = "Win: " + score_win.ToString() +
                            "  Lose: " + score_lose.ToString() +
                            "  Draw: " + score_draw.ToString();
            
        }
        public void check_result()
        {
            mode = "show";

            picture_visible.Visible = false;
            
            if (comp_figure == user_figure)
                draw = 1;
            else
            {
                if (user_figure == "rock")
                    if (comp_figure == "scissors")
                        win = 1;
                    else
                        lose = 1;
                if (user_figure == "scissors")
                    if (comp_figure == "paper")
                        win = 1;
                    else
                        lose = 1;
                if (user_figure == "paper")
                    if (comp_figure == "rock")
                        win = 1;
                    else
                        lose = 1;
            }          
            if (win >0)
                label_message.Text = "Win! :";
            if (lose >0)
                label_message.Text = "Lose... :";
            if (draw >0)
                label_message.Text = "Draw :";
            score_win += win;
            score_draw += draw;
            score_lose += lose;
            show_score();
          
          

        }
      
    }
}

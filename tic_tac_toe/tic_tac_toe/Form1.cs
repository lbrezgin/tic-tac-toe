using System;
using System.Linq;
using System.Media;
using System.Collections.Generic;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        SoundPlayer music = new SoundPlayer();
        bool multiplayer = false;
        int player = 1;
        string[] roles = { "X", "O" };
        bool win = false;
        List<string> options = new List<string> { "but1", "but2", "but3", "but4", "but5", "but6", "but7", "but8", "but9" };
        public Form1()
        {
            InitializeComponent();
            EnableAll("disable");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            music.SoundLocation = "C:\\users\\lbrezgin\\tic_tac_toe_song.wav";
            music.Play();
        }
        private void ComputerMove()
        {
            if (multiplayer == true && player == 2 && win == false && options.Count > 0)
            {
                Random random = new Random();
                int i = random.Next(1, options.Count);
                string buttonName = options[i];

                Button button = Controls.Find(buttonName, true).FirstOrDefault() as Button;
                if (button.Text == "" )
                {
                    Move(button);
                    CheckWin(roles);
                }
            }
        }

        private void EnableAll(string todo)
        {
            if (todo == "enable")
            {
                but1.Enabled = true;
                but2.Enabled = true;
                but3.Enabled = true;
                but4.Enabled = true;
                but5.Enabled = true;
                but6.Enabled = true;
                but7.Enabled = true;
                but8.Enabled = true;
                but9.Enabled = true;
            }
           else
            {
                if (todo == "disable")
                {
                    but1.Enabled = false;
                    but2.Enabled = false;
                    but3.Enabled = false;
                    but4.Enabled = false;
                    but5.Enabled = false;
                    but6.Enabled = false;
                    but7.Enabled = false;
                    but8.Enabled = false;
                    but9.Enabled = false;
                }
            }
        }
        private void Move(Button but)
        {
            if (player == 1)
            {
                but.Text = roles[0];
                player = 2;
            }
            else
            {
                but.Text = roles[1];
                player = 1;
            }
            options.Remove(but.Name);
            but.Enabled = false;
        }

        private void CheckWin(string[] array)
        {
            for (int i = 0; i < 2; i++)
            {
                if (but1.Text == array[i] && but2.Text == array[i] && but3.Text == array[i])
                {
                    Win(array[i]);
                }
                else
                {
                    if (but4.Text == array[i] && but5.Text == array[i] && but6.Text == array[i])
                    {
                        Win(array[i]);
                    }
                    else
                    {
                        if (but7.Text == array[i] && but8.Text == array[i] && but9.Text == array[i])
                        {
                            Win(array[i]);
                        }
                        else
                        {
                            if (but1.Text == array[i] && but5.Text == array[i] && but9.Text == array[i])
                            {
                                Win(array[i]);
                            }
                            else
                            {
                                if (but3.Text == array[i] && but5.Text == array[i] && but7.Text == array[i])
                                {
                                    Win(array[i]);
                                }
                                else
                                {
                                    if (but1.Text == array[i] && but4.Text == array[i] && but7.Text == array[i])
                                    {
                                        Win(array[i]);
                                    }
                                    else
                                    {
                                        if (but2.Text == array[i] && but5.Text == array[i] && but8.Text == array[i])
                                        {
                                            Win(array[i]);
                                        }
                                        else
                                        {
                                            if (but3.Text == array[i] && but6.Text == array[i] && but9.Text == array[i])
                                            {
                                                Win(array[i]);
                                            }
                                            else
                                            {
                                                if (options.Count == 0 && win == false)
                                                {
                                                    Draw();
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        } 
        private void Draw()
        {
            EnableAll("disable");
            butNewGame.Visible = true;
            MessageBox.Show("Draw!");
        }
        private void Win(string who)
        {
            win = true;
            EnableAll("disable");
            butNewGame.Visible = true;
            MessageBox.Show(who + " win!");

        }

        private void but1_Click(object sender, EventArgs e)
        {
            Move(but1);
            CheckWin(roles);
            ComputerMove();
        }

        private void but2_Click(object sender, EventArgs e)
        {
            Move(but2);
            CheckWin(roles);
            ComputerMove();
        }

        private void but3_Click(object sender, EventArgs e)
        {
            Move(but3);
            CheckWin(roles);
            ComputerMove();
        }

        private void but4_Click(object sender, EventArgs e)
        {
            Move(but4);
            CheckWin(roles);
            ComputerMove();
        }

        private void but5_Click(object sender, EventArgs e)
        {
            Move(but5);
            CheckWin(roles);
            ComputerMove();
        }

        private void but6_Click(object sender, EventArgs e)
        {
            Move(but6);
            CheckWin(roles);
            ComputerMove();
        }

        private void but7_Click(object sender, EventArgs e)
        {
            Move(but7);
            CheckWin(roles);
            ComputerMove();
        }

        private void but8_Click(object sender, EventArgs e)
        {
            Move(but8);
            CheckWin(roles);
            ComputerMove();
        }

        private void but9_Click(object sender, EventArgs e)
        {
           Move(but9);
           CheckWin(roles);
           ComputerMove();
        }

        private void butNewGame_Click(object sender, EventArgs e)
        {
            but1.Text = "";
            but2.Text = "";
            but3.Text = "";
            but4.Text = "";
            but5.Text = "";
            but6.Text = "";
            but7.Text = "";
            but8.Text = "";
            but9.Text = "";
            butNewGame.Visible = false;
            but1Player.Visible = true;
            but2Players.Visible = true;
            multiplayer = false;
            player = 1;
            roles = new string[] { "X", "O" };
            win = false;
            options = new List<string> { "but1", "but2", "but3", "but4", "but5", "but6", "but7", "but8", "but9" };
        }

        private void but1Player_Click(object sender, EventArgs e)
        {
            EnableAll("enable");
            but1Player.Visible = false;
            but2Players.Visible = false;
            multiplayer = true;
        }
        private void but2Players_Click(object sender, EventArgs e)
        {
            EnableAll("enable");
            but1Player.Visible = false;
            but2Players.Visible = false;
        }
    }
}

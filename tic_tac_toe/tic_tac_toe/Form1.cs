using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        int player = 1;
        string[] roles = { "X", "O" };
        bool win = false;
        int moves = 9;
        public Form1()
        {
            InitializeComponent();
            EnableAll("disable");
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
            moves--;
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
                                                if (moves == 0 && win == false)
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
        }

        private void but2_Click(object sender, EventArgs e)
        {
            Move(but2);
            CheckWin(roles);
        }

        private void but3_Click(object sender, EventArgs e)
        {
            Move(but3);
            CheckWin(roles);
        }

        private void but4_Click(object sender, EventArgs e)
        {
            Move(but4);
            CheckWin(roles);
        }

        private void but5_Click(object sender, EventArgs e)
        {
            Move(but5);
            CheckWin(roles);
        }

        private void but6_Click(object sender, EventArgs e)
        {
            Move(but6);
            CheckWin(roles);
        }

        private void but7_Click(object sender, EventArgs e)
        {
            Move(but7);
            CheckWin(roles);
        }

        private void but8_Click(object sender, EventArgs e)
        {
            Move(but8);
            CheckWin(roles);
        }

        private void but9_Click(object sender, EventArgs e)
        {
           Move(but9);
           CheckWin(roles);
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            EnableAll("enable");
            butStart.Visible = false;
        }

        private void butNewGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newForm = new Form1();
            newForm.ShowDialog();
        }
    }
}

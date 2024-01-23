using System.Security.Cryptography.Pkcs;

namespace PingPongSpiel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool player1Up, player2Up, player1Down, player2Down;
        bool bounce;
        bool bouncbypllayer = false;
        bool start = true;
        bool top, bottom, p1, p2, left, right;

        int speed = 6;
        int ballSpeed = 2;
        int Count;
        int randmzahl = new Random().Next(1, 5);
        int count1 = 0;
        int p1Points = 0, p2Points = 0;
        int maxPoints = 0;

        string positivnegativ;

        private void ballMovement()
        {
            if (bounce)
            {
                if (top)
                {
                    Ball.Top += ballSpeed;
                }
                else if (bottom)
                {
                    Ball.Top -= ballSpeed;
                }
                if (left)
                {
                    p2Points++;
                    label2.Text = p2Points.ToString();

                    ResetPositions();
                    left = false;
                }
                if (right)
                {
                    p1Points++;
                    label1.Text = p1Points.ToString();

                    ResetPositions();
                    right = false;
                }

            }
        }

        private void TimerTick(object sender, EventArgs e)
        {
            Count++;

            if (Count == count1 + 700)
            {
                ballSpeed += 2;
                count1 += 700;
            }

            while (start)
            {
                if (randmzahl == 2 || randmzahl == 4)
                {
                    positivnegativ = "+";
                }
                else
                {
                    positivnegativ = "-";
                }
                start = false;
            }

            if (Ball.Top <= 0)
            {
                top = true;
                bottom = false;
                p1 = false;
                p2 = false;
                bounce = true;
                bouncbypllayer = false;

            }
            if (Ball.Top >= 728)
            {
                bottom = true;
                top = false;
                p1 = false;
                p2 = false;
                bounce = true;
                bouncbypllayer = false;

            }
            if (Ball.Top > Player1.Top - 5 && Ball.Top < Player1.Top + 95 && Ball.Left >= 1299)
            {
                p1 = true;
                bottom = false;
                top = false;
                p2 = false;
                bounce = false;
                bouncbypllayer = true;
                positivnegativ = "-";


            }
            if (Ball.Top > Player2.Top - 5 && Ball.Top < Player2.Top + 95 && Ball.Left <= 40)
            {
                p2 = true;
                bottom = false;
                p1 = false;
                top = false;
                bounce = false;
                bouncbypllayer = true;
                positivnegativ = "+";

            }
            if (Ball.Left >= 1340)
            {
                right = true;
            }
            if (Ball.Left <= 0)
            {
                left = true;
            }

            switch (randmzahl)
            {
                case 1:
                    // unten recht
                    ballMovement();

                    if (positivnegativ == "-")
                    {
                        Ball.Left -= ballSpeed;
                    }
                    if (positivnegativ == "+")
                    {
                        Ball.Left += ballSpeed;
                    }


                    if (!bounce)
                    {
                        Ball.Top += ballSpeed;
                        bounce = false;
                    }

                    break;
                case 2:
                    //unten links
                    ballMovement();

                    if (positivnegativ == "-")
                    {
                        Ball.Left -= ballSpeed;
                    }
                    if (positivnegativ == "+")
                    {
                        Ball.Left += ballSpeed;
                    }


                    if (!bounce)
                    {
                        Ball.Top += ballSpeed;
                        bounce = false;
                    }

                    break;
                case 3:
                    //oben links
                    ballMovement();
                    if (positivnegativ == "-")
                    {
                        Ball.Left -= ballSpeed;
                    }
                    if (positivnegativ == "+")
                    {
                        Ball.Left += ballSpeed;
                    }

                    if (!bounce)
                    {
                        Ball.Top -= ballSpeed;
                        bounce = false;
                    }

                    break;
                case 4:
                    // oben rechts
                    ballMovement();
                    if (positivnegativ == "-")
                    {
                        Ball.Left -= ballSpeed;
                    }
                    if (positivnegativ == "+")
                    {
                        Ball.Left += ballSpeed;
                    }

                    if (!bounce)
                    {
                        Ball.Top -= ballSpeed;
                        bounce = false;
                    }

                    break;
            }

            PlayerMovement();

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && Player1.Top > 0)
            {
                player1Up = true;
            }
            if (e.KeyCode == Keys.Down && Player1.Top < 605)
            {
                player1Down = true;
            }
            if (e.KeyCode == Keys.W && Player2.Top > 0)
            {
                player2Up = true;
            }
            if (e.KeyCode == Keys.S && Player2.Top < 605)
            {
                player2Down = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            player1Up = false;
            player2Up = false;
            player1Down = false;
            player2Down = false;
        }

        void PlayerMovement()
        {

            if (player1Up)
            {
                Player1.Top -= speed;
            }
            if (player2Up)
            {
                Player2.Top -= speed;
            }
            if (player1Down)
            {
                Player1.Top += speed;
            }
            if (player2Down)
            {
                Player2.Top += speed;
            }
        }
        void ResetPositions()
        {
            Ball.Location = new Point(697, 345);
            Player1.Location = new Point(1311, 273);
            Player2.Location = new Point(21, 273);
            start = true;
        }

       
    }
}
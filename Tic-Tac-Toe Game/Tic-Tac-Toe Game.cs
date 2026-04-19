using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game_Project.Properties;

namespace Tic_Tac_Toe_Game_Project
{
    public partial class Tic_Tac_Toe_Game : Form
    {
        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;

        enum enPlayer
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            InProgress = 0,
            Player1 = 1, 
            Player2 = 2,
            Draw = 3
        }
        
        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public byte PlayCount;
        }

        private void Tic_Tac_Toe_Game_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;
            Pen Pen = new Pen(White);
            Pen.Width = 10;

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen, 340, 295, 850, 295);
            e.Graphics.DrawLine(Pen, 340, 425, 850, 425);
            e.Graphics.DrawLine(Pen, 500, 130, 500, 580);
            e.Graphics.DrawLine(Pen, 690, 130, 690, 580);
        }

        bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag == btn2.Tag
                && btn2.Tag == btn3.Tag)
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if(btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
            }

            GameStatus.GameOver = false;
            return false;
        }

        void EndGame()
        {
            lblGameStatus.Text = "Game Over";
            switch(GameStatus.Winner)
            {
                case enWinner.Player1:
                    lblWinner.Text = "Player 1";
                    break;
                case enWinner.Player2:
                    lblWinner.Text = "Player 2";
                    break;
                default:
                    lblWinner.Text = "Draw";
                    break;
            }
            MessageBox.Show("GameOver", "GameStatu",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void CheckWinner()
        {
            // Check Rows.
            // Check Row1.
            if (CheckValues(button1, button2, button3))
                return;

            // Check Row2.
            if (CheckValues(button4, button5, button6))
                return;

            // Check Row3.
            if(CheckValues(button7, button8, button9))
                return;

            //Check Colums.
            //Check Col1.
            if (CheckValues(button1, button4, button7))
                return;

            //Check Col2.
            if (CheckValues(button2, button5, button8))
                return;

            //Check Col3.
            if (CheckValues(button3, button6, button9))
                return;

            // Check Diagonals
            // Check Diagonal1
            if (CheckValues(button1, button5, button9))  
                return; 

            // Check Diagonal2
            if (CheckValues(button3, button5, button7))
                return;
        }

        void ChangeIcon(Button btn)
        {
            if (GameStatus.GameOver)
            {
                return;
            }

            if(btn.Tag.ToString() == "?")
            {
                switch(PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.Image = Resources.X;
                        PlayerTurn = enPlayer.Player2;
                        lblGameStatus.Text = "Player 2";
                        GameStatus.PlayCount++;
                        btn.Tag = "X";
                        CheckWinner();
                        break;
                    case enPlayer.Player2:
                        btn.Image = Resources.O;
                        PlayerTurn = enPlayer.Player1;
                        lblGameStatus.Text = "Player 1";
                        GameStatus.PlayCount++;
                        btn.Tag = "O";
                        CheckWinner();
                        break;

                }
            }
            else
            {
                MessageBox.Show("Place is already played", "Wrong",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(GameStatus.PlayCount == 9 && !GameStatus.GameOver)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }
        }

        public Tic_Tac_Toe_Game()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            ChangeIcon((Button) sender);
        }

        void ResetButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            ResetButton(button1);
            ResetButton(button2);
            ResetButton(button3);
            ResetButton(button4);
            ResetButton(button5);
            ResetButton(button6);
            ResetButton(button7);
            ResetButton(button8);
            ResetButton(button9);

            PlayerTurn = enPlayer.Player1;
            lblGameStatus.Text = "Player 1";
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.InProgress;
            lblWinner.Text = "In Progress";

        }
    }
}

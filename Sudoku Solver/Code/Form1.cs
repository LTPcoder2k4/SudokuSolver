using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        const int n = 9;
        const int btnSize = 45;
        RJButton[,] btnMap = new RJButton[n, n];
        public Form1()
        {
            InitializeComponent();
            GenerateMap();
        }
        private void GenerateMap()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    btnMap[i, j] = new RJButton();
                    btnMap[i, j].Size = new Size(btnSize, btnSize);
                    btnMap[i, j].TextColor = Color.Cyan;
                    btnMap[i, j].Text = "";
                    btnMap[i, j].Location = new Point(j * btnSize + 100, i * btnSize + 15);
                    if (((2 < j && j < 6) && (i < 3 || i > 5)) || ((2 < i && i < 6) && (j < 3 || j > 5)))
                    {
                        btnMap[i, j].BackColor = Color.RoyalBlue;
                    }
                    btnMap[i, j].Click += new EventHandler(btnClick);
                    sudokuBox.Controls.Add(btnMap[i, j]);
                }
            }
        }

        private void Clear()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    btnMap[i, j].Text = "";
                    btnMap[i, j].Click += new EventHandler(btnClick);
                    btnMap[i, j].TextColor = Color.Cyan;
                }
            }
        }

        private bool checkInput()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (btnMap[i, j].Text != "")
                    {
                        for (int k = i + 1; k < 9; ++k)  // kiem tra theo hang
                        {
                            if (btnMap[i, j].Text != "")
                            {
                                if (btnMap[i, j].Text == btnMap[k, j].Text)
                                    return false;
                            }
                        }
                        for (int k = 0; k < i; ++k)  // kiem tra theo hang
                        {
                            if (btnMap[i, j].Text != "")
                            {
                                if (btnMap[i, j].Text == btnMap[k, j].Text)
                                    return false;
                            }
                        }
                        for (int k = j + 1; k < 9; ++k)  // kiem tra theo hang
                        {
                            if (btnMap[i, j].Text != "")
                            {
                                if (btnMap[i, j].Text == btnMap[i, k].Text)
                                    return false;
                            }
                        }
                        for (int k = 0; k < j; ++k)  // kiem tra theo hang
                        {
                            if (btnMap[i, j].Text != "")
                            {
                                if (btnMap[i, j].Text == btnMap[i, k].Text)
                                    return false;
                            }
                        }
                        int boxRowOffset = (i / 3) * 3;
                        int boxColOffset = (j / 3) * 3;

                        for (int k = 0; k < 3; ++k) //kiem tra trong 9 ô nhỏ
                            for (int m = 0; m < 3; ++m)
                                if ((boxRowOffset + k) != i && boxColOffset + m != j)
                                {
                                    if (btnMap[boxRowOffset + k, boxColOffset + m].Text != "")
                                    {
                                        if (btnMap[i, j].Text == btnMap[boxRowOffset + k, boxColOffset + m].Text)
                                            return false;
                                    }
                                }
                    }
                }
            }
            return true;
        }

        private static bool solve(RJButton[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j].Text == "")
                    {
                        for (char c = '1'; c <= '9'; c++)
                        {
                            if (isValid(board, i, j, c))
                            {
                                board[i, j].Text = c.ToString();

                                if (solve(board))
                                    return true;
                                else
                                {
                                    board[i, j].Text = "";
                                }
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        private static bool isValid(RJButton[,] board, int row, int col, char c)
        {
            for (int i = 0; i < 9; i++)
            {
                //check row  
                if (board[i, col].Text != "" && board[i, col].Text == c.ToString())
                    return false;
                //check column  
                if (board[row, i].Text != "" && board[row, i].Text == c.ToString())
                    return false;
                //check 3*3 block  
                if (board[3 * (row / 3) + i / 3, 3 * (col / 3) + i % 3].Text != "" && board[3 * (row / 3) + i / 3, 3 * (col / 3) + i % 3].Text == c.ToString())
                    return false;
            }
            return true;
        }

        private void btnClick(object sender, EventArgs e)
        {
            int num;
            RJButton btn = (RJButton)sender;
            int y = (btn.Location.X - 100) / btnSize;
            int x = (btn.Location.Y - 15) / btnSize;
            if (btnMap[x, y].Text == "") num = 0;
            else num = int.Parse(btnMap[x, y].Text);

            num = (num + 1) % 10;
            if (num == 0) btnMap[x, y].Text = "";
            else btnMap[x, y].Text = num.ToString();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void solveBtn_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (btnMap[i, j].Text == "")
                            btnMap[i, j].TextColor = Color.Red;
                    }
                }
                if (!solve(btnMap)) MessageBox.Show("Can't solve");
            }
            else
            {
                MessageBox.Show("Please check the input!");
            }
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "txt file|*.txt";
            if (op.ShowDialog() == DialogResult.OK)
            {
                Clear();
                string filename = op.FileName;
                string[] filelines = File.ReadAllLines(filename);
                if (filelines.Length == 9)
                {
                    for (int j = 0; j < filelines.Length; j++)
                    {
                        string[] splitLines = filelines[j].Split(' ');
                        if (splitLines.Length == 9)
                        {
                            for (int i = 0; i < splitLines.Length; i++)
                            {
                                if (int.Parse(splitLines[i]) >= 0 && int.Parse(splitLines[i]) <= 9)
                                {
                                    if (int.Parse(splitLines[i]) == 0)
                                    {
                                        btnMap[j, i].Text = "";
                                    }
                                    else
                                    {
                                        btnMap[j, i].Text = splitLines[i];
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Error Reading File");
                                    Clear();
                                    return;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error Reading File");
                            Clear();
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error Reading File");
                    Clear();
                    return;
                }
            }
        }
    }
}

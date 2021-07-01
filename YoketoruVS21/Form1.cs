using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace YoketoruVS21
{
    public partial class Form1 : Form
    {
        const bool isDebug = true;

        const int PlayerMax = 1;
        const int EnemyMax = 3;
        const int ItemMax = 3;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;

        Label[] chrs = new Label[ChrMax];

        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerMax;
        const int ItemIndex = EnemyIndex + EnemyMax;

        const string PlayerText = "(・▽・)";
        const string EnemyText = "(^^)";
        const string ItemText = "☆";

        static Random rand = new Random();

        enum State
        {
            None=-1, //無効
            Title,　//タイトル
            Game,   //ゲーム画面
            Gameover, //ゲームオーバー画面
            Clear,    //クリア画面
        }
        State currentState=State.None;
        State nextState = State.Title;

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        public Form1()
        {
            InitializeComponent();

            for(int i=0;i<ChrMax;i++)
            {
                chrs[i] = new Label();
                chrs[i].AutoSize = true;
                if(i==PlayerIndex)
                {
                    chrs[i].Text = PlayerText;
                }
                else if (i>ItemIndex)
                {
                    chrs[i].Text = EnemyText;
                }
                else
                {
                    chrs[i].Text = ItemText;
                }
                Controls.Add(chrs[i]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isDebug)
            {
                if (GetAsyncKeyState((int)Keys.O) < 0)
                {
                    nextState = State.Gameover;
                }
                else if (GetAsyncKeyState((int)Keys.C) < 0)
                {
                    nextState = State.Clear;
                }
            }

            if (nextState != State.None)
            {
                initProc();
            }

            if (currentState == State.Game)
            {
                UpdateGame();
            }

        }


        void initProc()
        {
            currentState = nextState;
            nextState = State.None;

            switch(currentState)
            {
                case State.Title:
                    Titlelabel.Visible = true;
                    startbutton.Visible = true;
                    copyrightlabel.Visible = true;
                    Highlabel.Visible = true;
                    Gameoverlabel.Visible = false;
                    titlebutton.Visible = false;
                    Clearlabel.Visible = false;
                    break;

                case State.Game:
                    Titlelabel.Visible = false;
                    startbutton.Visible = false;
                    copyrightlabel.Visible = false;
                    Highlabel.Visible = false;

                    for(int i=EnemyIndex;i<ChrMax;i++)
                    {
                        chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                        chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);
                    }
                    break;

                case State.Gameover:
                    Gameoverlabel.Visible = true;
                    titlebutton.Visible = true;
                    break;

                case State.Clear:
                    titlebutton.Visible = true;
                    Clearlabel.Visible = true;


                    break;

            }
        }

        void UpdateGame()

        {
            Point mp = PointToClient(MousePosition);


            //TODO: mpがプレイヤーラベルの中心になるように設定
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void titlebutton_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }

        private void Gameoverlabel_Click(object sender, EventArgs e)
        {

        }
    }
}

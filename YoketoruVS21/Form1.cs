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

        private void startbutton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void titlebutton_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }
    }
}

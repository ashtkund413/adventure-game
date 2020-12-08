using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace adventure_game
{
    public partial class Form1 : Form
    {
        int scene = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.M)      //red button press
            {
                if (scene == 0)
                {

                    scene = 1;
                }
                else if (scene == 1)
                {

                    scene = 2;
                }

                else if (scene == 2)
                {
                    scene = 33;
                }
                else if (scene == 3)
                {
                    scene = 5;
                }
                else if (scene == 5)
                {
                    scene = 7;
                }
                else if (scene == 7)
                {
                    scene = 9;
                }
                else if (scene == 9)
                {
                    scene = 13;
                }
                else if (scene == 13)
                {
                    scene = 33;
                }
                else if (scene == 14)
                {
                    scene = 22;
                }
                else if (scene == 22)
                {
                    scene = 33;
                }
                else if (scene == 23)
                {
                    scene = 33;
                }
                else if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 10)
                {
                    scene = 15;
                }
                else if (scene == 15)
                {
                    scene = 27;
                }
                else if (scene == 16)
                {
                    scene = 18;
                }
                else if (scene == 18)
                {
                    scene = 33;
                }
                else if (scene == 19)
                {
                    scene = 31;
                }
                else if (scene == 31)
                {
                    scene = 32;
                }


            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0)
                {

                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 3;
                }
                else if (scene == 3)
                {
                    scene = 6;
                }
                else if (scene == 6)
                {
                    scene = 10;
                }
                else if (scene == 10)
                {
                    scene = 16;
                }
                else if (scene == 16)
                {
                    scene = 19;
                }
                else if (scene == 19)
                {
                    scene = 26;
                }
                else if (scene == 26)
                {
                    scene = 32;
                }
                else if (scene == 7)
                {
                    scene = 10;
                }
                else if (scene == 9)
                {
                    scene = 14;
                }
                else if (scene == 14)
                {
                    scene = 23;
                }
                else if (scene == 23)
                {
                    scene = 33;
                }
                else if (scene == 15)
                {
                    scene = 24;
                }
                else if (scene == 24)
                {
                    scene = 33;
                }
                else if (scene == 27)
                {
                    scene = 31;
                }
                else if (scene == 31)
                {
                    scene = 32;
                }
                else if (scene == 9)
                {
                    scene = 13;
                }
                else if (scene == 9)
                {
                    scene = 13;
                }
            }

            switch (scene)
            {
                case 0:


                case 1:

                    outputLabel.Text = "You are on a plane with your wife and son";
                    redLabel.Text = "";
                    blueLabel.Text = "";

                    this.Refresh();
                    Thread.Sleep(2000);
                    outputLabel.Text = "a goose fly's into the wing and the plane starts to crash who you going to save";
                    redLabel.Text = "wife";
                    blueLabel.Text = "son";
                    break;

                case 2:
                    outputLabel.Text = "you go to save your wife but the window shatters and you and your wife shoot out of the plane and fall to your death ";
                    redLabel.Text = "next";
                    blueLabel.Text = "";
                    break;
                case 3:
                    outputLabel.Text = "you pick your son up well your wife gets sucked out of the plane";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    this.Refresh();
                    Thread.Sleep(2000);
                    redLabel.Text = "front";
                    blueLabel.Text = "back";
                    outputLabel.Text = "where you going to go";
                    break;
                case 6:
                    outputLabel.Text = " hide in the washroom";
                    redLabel.Text = "";
                    blueLabel.Text = "Next";

                    break;
                case 7:
                    outputLabel.Text = "there are no parashot's and no polite";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    this.Refresh();
                    Thread.Sleep(2000);
                    redLabel.Text = "fly";
                    blueLabel.Text = "hope";
                    outputLabel.Text = "try and fly the plane or hope for the best ";
                    break;
                case 9:
                    outputLabel.Text = "you gain control and crash in a river";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    this.Refresh();
                    Thread.Sleep(2000);
                    redLabel.Text = "call for help";
                    blueLabel.Text = "look around";
                    outputLabel.Text = "what do you do now ";
                    break;
                case 13:
                    outputLabel.Text = "you stay and wait for help but you didn't crash in water it was quicksand and you all died ";
                    redLabel.Text = "next";
                    blueLabel.Text = "";

                    break;
                case 14:
                    outputLabel.Text = "you see you crashed in quicksand and you get out but no one else could in time";
                    redLabel.Text = "yes";
                    blueLabel.Text = "no";
                    this.Refresh();
                    Thread.Sleep(2000);
                    outputLabel.Text = "do you make a fire";
                    break;
                case 23:
                    outputLabel.Text = "you froze to death";
                    redLabel.Text = "";
                    blueLabel.Text = "next";

                    break;
                case 10:
                    outputLabel.Text = "you crash in a forest but its just you who survived  ";
                    redLabel.Text = "shelter";
                    blueLabel.Text = "look for help";
                    this.Refresh();
                    Thread.Sleep(10000);
                    outputLabel.Text = "look for help or try to find shelter ";
                    break;
                case 15:
                    outputLabel.Text = "you find a old house with no power and holes in the roof  ";
                    redLabel.Text = "sleep";
                    blueLabel.Text = "weapon";
                    this.Refresh();
                    Thread.Sleep(2000);
                    outputLabel.Text = "try to sleep or look for a weapon";
                    break;
                case 27:
                    outputLabel.Text = "you are trying to sleep and a car comes pulls up to the front of the house ";
                    redLabel.Text = "run";
                    blueLabel.Text = "Ask for help";
                    this.Refresh();
                    Thread.Sleep(2000);
                    outputLabel.Text = "run or ask for help ";
                    break;
                case 30:
                    outputLabel.Text = "you run out the back and hit a are trap and bleed out ";
                    redLabel.Text = "next";
                    blueLabel.Text = "";

                    break;
                case 31:
                    outputLabel.Text = "you tell him what happened and he takes you to the nearest city to get help ";
                    redLabel.Text = "";
                    blueLabel.Text = "next";

                    break;
                case 32:
                    outputLabel.Text = "you win";

                    break;
                case 33:
                    outputLabel.Text = "the end of you ";

                    break;
                case 24:
                    outputLabel.Text = "you don't find a weapon and your sleep deprived and you fall asleep ";
                    redLabel.Text = "";
                    blueLabel.Text = "next";

                    break;

                case 16:
                    outputLabel.Text = "you look for help but find nothing but a cave ";
                    redLabel.Text = "yes";
                    blueLabel.Text = "no";
                    this.Refresh();
                    Thread.Sleep(2000);
                    outputLabel.Text = "do you go in the cave or no ";
                    break;
                case 18:
                    outputLabel.Text = "you go in the cave and see a family of bares they attack and kill you";
                    redLabel.Text = "next";


                    break;
                case 19:
                    outputLabel.Text = "you keep going and find a road";
                    redLabel.Text = "north";
                    blueLabel.Text = "south";
                    this.Refresh();
                    Thread.Sleep(2000);
                    outputLabel.Text = "witch way do you go north or south ";
                    break;
                case 26:
                    outputLabel.Text = "you keep walk till you pass out and wake up in the hospital ";
                    redLabel.Text = "";
                    blueLabel.Text = "next";

                    break;



                default:
                    break;
            }
        }
    }


}



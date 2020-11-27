using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public delegate void Tooutput(string s,bool t =false);
        Lottery_C lot;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  OutPutBox.Clear();
            string[] prices = InputProces.Lines;
            string[] inputlines = InputNumbersBox.Lines;
            int PairMax= getMax(inputlines);
            int PairMin= getMin(inputlines, PairMax);

            int lotteryPairs = inputlines.Length;
            int money;
            int.TryParse(this.MoneyInputBox.Text, out money);
            int rounds;
            int.TryParse(this.RoundsInputBox.Text, out rounds);
       
          
            playit(AddToOutputBox, inputlines, prices, lotteryPairs, money, rounds, PairMax, PairMin);

            OutPutBox.SelectionStart = OutPutBox.Text.Length;
            // scroll it automatically
            OutPutBox.ScrollToCaret();
            Roll_Button.Text = "Roll Again";
             
        }

        public int getMax(string[] lines)
        {
            int Max = 0;
            int counter = 0;
            for(int index = 0; index < lines.Length; index++)
            {
                 
                if (int.TryParse(lines[index], out counter))
                {
                    if (counter > Max)
                    {
                        Max = counter;
                       // AddToOutputBox("min: " + Max + "counter: " + counter);
                    }
                }

            }

            return Max;
        }

        public int getMin(string[] lines,int max)
        {
            int Min = max;
            int counter = 0;
            Array.Sort(lines);
            for (int index = 0; index < lines.Length; index++)
            {
                 
                if (int.TryParse(lines[index], out counter))
                {
                    if (counter < Min)
                    {
                        Min = counter;
                        //AddToOutputBox("min: " + Min + "counter: " + counter);
                    }
                }

            }
            return Min;
        }
        public void AddToOutputBox(string text, bool clear= false)
        {

            if (clear)
            {
                List<string> foo = OutPutBox.Lines.ToList();

                foo.Clear();

                this.OutPutBox.Lines = foo.ToArray();
            }
            else
            {
                List<string> foo = OutPutBox.Lines.ToList();

                foo.Add(text);

                this.OutPutBox.Lines = foo.ToArray();

                //  for(int index; index < OutPutBox.Lines )

                // OutPutBox.Lines
            }
        }

        public void playit(Tooutput toputput, string[] inputlines, string[] prices, int lotteryPairs, int money, int rounds, int PairMax, int PairMin)
        {
            if (lot == null)
            {

                AddToOutputBox("enter lottery size: " + lotteryPairs);

                AddToOutputBox("enter money size: " + money);

                AddToOutputBox("enter rounds size: " + rounds);

                AddToOutputBox("enter lotery number PairMax limit: " + PairMax);

                AddToOutputBox("enter lotery number PairMin limit: " + PairMin);

                lot = new Lottery_C(toputput, inputlines, prices, lotteryPairs, money, rounds, PairMax, PairMin);

                AddToOutputBox("do you want to play again?");
                //playagain
                //   wannaplayagain = (GetSettingInput() > 0 ? true : false);

            }
            else 
            {
                this.Roll_Button.Text = "Roll Again";
               if (!lot.CanRollAgain(toputput, inputlines, prices,lotteryPairs,  PairMax, PairMin))
                {

                    lot = null;
                    AddToOutputBox("", true);
                    AddToOutputBox("the game has ended");
                }

            };

        }
      

        public class Lottery_C
        {

            // todo: fix the buggies

            

            // todo: set prices?
            int money;//money you start with
            int PairSize;//how long is the lottery
            int rounds;//tries
            int PairRandonMax;
            int PairRandonMin;
            public Tooutput AddToOutputBox;
            //---------------------------------------
            private int matches = 0;//number of matches reusable

            int[] inputS;
            int[] numbers;
            int[] prices;

            public Lottery_C(Tooutput tooutput, string[] inputs, string[] prices, int lotSize, int money, int rounds, int PairRandonMax, int PairRandonMin = 1)
            {
                AddToOutputBox = tooutput;
                this.PairSize = lotSize;//lotery size
                this.money = money;//money
                this.rounds = rounds;//tries
                this.PairRandonMax = PairRandonMax;
                this.PairRandonMin = PairRandonMin;

                AddToOutputBox("Welcome to a Lottery Game");

                //engine
                if (rounds > 0 && money > 0)
                {


                    AddToOutputBox("Round : " + rounds.ToString());
                    AddToOutputBox("you have " + money + "$ left");

                    PairSize = lotSize;


                    //gets the input
                    GetsInput(inputs);

                    // sets the randon numbers
                    RollTheNumbers();

                    // testsformatches
                    TestForMatches();

                    //sets prices
                    SetPrices(prices);
                    //takes one round
                    this.rounds--;
                }
                else
                {

                    if (money <= 0)
                    {
                        AddToOutputBox("you lost all your money");
                        // Console.ReadKey();
                        // Environment.Exit(0);
                    }
                    else
                    {
                        if (rounds <= 0)
                        {
                            AddToOutputBox("ran out of rounds");
                            // Console.ReadKey();
                            // Environment.Exit(0);
                        }
                    }
                }

            }
            public bool CanRollAgain(Tooutput tooutput, string[] inputs,string[] prices, int lotSize,  int PairRandonMax, int PairRandonMin = 1)
            {
                bool canroll = true;
                AddToOutputBox = tooutput;
                this.PairSize = lotSize;//lotery size
               
                this.PairRandonMax = PairRandonMax;
                this.PairRandonMin = PairRandonMin;



                //engine
                if (rounds > 0 && money > 0)
                {


                    AddToOutputBox("Round : " + rounds.ToString());
                    AddToOutputBox("you have " + money + "$ left");

                    PairSize = lotSize;


                    //gets the input
                    GetsInput(inputs);

                    // sets the randon numbers
                    RollTheNumbers();

                    // testsformatches
                    TestForMatches();

                    //sets prices
                    SetPrices(prices);
                    //takes one round
                    this.rounds--;
                }
                else
                {
                    if (money <= 0)
                    {
                        AddToOutputBox("you lost all your money");
                        // Console.ReadKey();
                        // Environment.Exit(0);
                        canroll = false;

                    }
                    else
                    {
                        if (rounds <= 0)
                        {
                            AddToOutputBox("ran out of rounds");
                            // Console.ReadKey();
                            // Environment.Exit(0);
                            canroll = false;
                        }
                    }
                }
                return canroll;
            }

            private void SetPrices(string[] pricesT)
            {
                prices = new int[pricesT.Length];
                for (int index = 0; index < prices.Length; index++)
                {
                    prices[index] = int.Parse(pricesT[index]);
                }
                //-=----------------------------------------------
                for (int index = 0; index < prices.Length; index++)
                {
                    if (index == matches)
                    {
                        pricesnotifier("you matched: "+ matches +" numbers and gained:", prices[index]);
                        AddToOutputBox("index: " + index);
                        break;
                    }
                }
            }

            private void pricesnotifier(string message, int price)
            {
                money += price;
                AddToOutputBox(message + price+"$");
                AddToOutputBox("your current money: " + money + "$ left");
                AddToOutputBox("you current rounds: " + rounds + " left");


            }


            private void TestForMatches()
            {
                matches = 0;
                for (int x = 0; x < inputS.Length; x++)
                {
                    if (numbers[x] == inputS[x])
                    {
                        matches++;
                    }

                }

            }

            private void RollTheNumbers()
            {
                Random Ran = new Random();
                numbers = new int[PairSize];//resets numbers
                for (int i = 0; i < numbers.Length; i++)
                {

                    numbers[i] = Ran.Next(PairRandonMin, PairRandonMax);
                    AddToOutputBox("------------------------------");
                    AddToOutputBox("the next rolled number is " + numbers[i]);
                    AddToOutputBox("your input was " + inputS[i]);
                    AddToOutputBox("------------------------------");
                }

            }

            // sets inputS
            private void GetsInput(string[] inputST)
            {
                inputS = new int[inputST.Length];//resets inputs

                for (int index = 0; index < inputS.Length; index++)
                {
                    string inputX = inputST[index];
                    int X = 0;
                    if ((int.TryParse(inputX, out X) == true))
                    {
                        if ((X > PairRandonMax) || (X < PairRandonMin))
                        {
                            AddToOutputBox("wrong input!!: " + inputX);
                            AddToOutputBox("out side of bouds");
                        }
                        else
                        {

                            inputS[index] = X;
                            // number was added to inputS int array
                            AddToOutputBox("number entered: " + inputS[index] + " from  " + PairRandonMax + "to " + PairRandonMin);

                        }
                    }
                    else
                    {


                        AddToOutputBox("wrong input!!: " + inputX);

                    }

                }
            }
        }





















        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void OutPutBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void InputProces_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Money_label_Click(object sender, EventArgs e)
        {

        }

        private void Rouds_Label_Click(object sender, EventArgs e)
        {

        }
    }
}

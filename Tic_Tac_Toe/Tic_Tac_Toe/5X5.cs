using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form3 : Form
    {

        bool X_Turn;
        bool O_Turn;

        char[,] array = new char[5,5];

        
   
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            X_Turn = true;
        }

        //I create a function for control Win conditions
        public void Win()
        {


            //I want to see all array in the terminal why I write
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }



            bool control = RawControl(array);
            bool control2 = ColumnControl(array);
            bool control3 = DiagnoselControl(array);
            bool control4 = SlideControl(array);

            if (control)
            {
                Console.WriteLine("RAW --- TRUE");
                MessageBox.Show("RAW Kazandınız");
            }
            else if (control2)
            {

                MessageBox.Show("CL-- KAZANDINIZ");

            }

            else if (control3)
            {
                MessageBox.Show("ÇAPRAZ KAZANDINIZ");
            }


            if (control4)
            {
                MessageBox.Show("SLİDE Kazandı");
            }




        }

      

        private void Total_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Console.WriteLine(b.Name);

            int i = 0, j = 0;

            switch (b.Name)
            {
                case "button1":
                    i = 0;
                    j = 0;
                    break;
                case "button2":
                    i = 0;
                    j = 1;
                    break;
                case "button3":
                    i = 0;
                    j = 2;
                    break;
                case "button4":
                    i = 0;
                    j = 3;
                    break;
                case "button5":
                    i = 0;
                    j = 4;
                    break;

                case "button6":
                    i = 1;
                    j = 0;
                    break;
                case "button7":
                    i = 1;
                    j = 1;
                    break;
                case "button8":
                    i = 1;
                    j = 2;
                    break;
                case "button9":
                    i = 1;
                    j = 3;
                    break;
                case "button10":
                    i = 1;
                    j = 4;
                    break;

                case "button11":
                    i = 2;
                    j = 0;
                    break;
                case "button12":
                    i = 2;
                    j = 1;
                    break;
                case "button13":
                    i = 2;
                    j = 2;
                    break;
                case "button14":
                    i = 2;
                    j = 3;
                    break;
                case "button15":
                    i = 2;
                    j = 4;
                    break;

                case "button16":
                    i = 3;
                    j = 0;
                    break;
                case "button17":
                    i = 3;
                    j = 1;
                    break;
                case "button18":
                    i = 3;
                    j = 2;
                    break;
                case "button19":
                    i = 3;
                    j = 3;
                    break;
                case "button20":
                    i = 3;
                    j = 4;
                    break;

                case "button21":
                    i = 4;
                    j = 0;
                    break;
                case "button22":
                    i = 4;
                    j = 1;
                    break;
                case "button23":
                    i = 4;
                    j = 2;
                    break;
                case "button24":
                    i = 4;
                    j = 3;
                    break;
                case "button25":
                    i = 4;
                    j = 4;
                    break;


            }


            if (X_Turn)
            {

                array[i, j] = 'X';
                X_Turn = false;
                O_Turn = true;

                b.Text = "X";
                b.Enabled = false;
                Win();
            }


            else if (O_Turn)
            {
                array[i, j] = 'O';
                X_Turn = true;
                O_Turn = false;

                b.Text = "O";
                b.Enabled = false;
                Win();
            }
        }






        //We create a function for column control

        public static bool ColumnControl(char[,] array)
        {
            char prev = ' ';
            char current = ' ';
            int counter = 0;

            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (i == 0)
                    {
                        current = array[i, j];
                        counter = 0;
                    }
                    else
                    {
                        prev = array[i - 1, j];
                        Console.WriteLine("CL--PREV: " + prev);
                        current = array[i, j];
                        Console.WriteLine("CL--CURRENT: " + current);
                        if (prev != 'A' && current != 'A' && prev == current)
                        {
                            counter++;
                            Console.WriteLine("CL--COUNTER: " + counter);
                            if (counter == 2)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }



        //We create a function for RawControl
        public static bool RawControl(char[,] array)
        {

            char prev = ' ';
            char current = ' ';
            int counter = 0;
            //We create loop for control
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 0)
                    {
                        current = array[i, j];
                        counter = 0;
                    }
                    else
                    {
                        prev = array[i, j - 1];
                        Console.WriteLine("PREV: " + prev);
                        current = array[i, j];
                        Console.WriteLine("CURRENT: " + current);
                        if (prev != 'A' && current != 'A' && prev == current)
                        {
                            counter++;
                            Console.WriteLine("COUNTER: " + counter);
                            if (counter == 2)
                            {
                                return true;
                            }
                        }

                    }
                }
            }
            return false;
        }



        public static bool DiagnoselControl(char[,] array)
        {
            char prev = ' ';
            char current = ' ';
            int counter = 0;


            Console.WriteLine(array.GetLength(0));
            int n = array.GetLength(0);
            //int slide_count = n - 3;
            //diagnosel control
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    counter = 0;
                }

                else
                {
                    //[0,0]
                    prev = array[i - 1, i - 1];
                    //1,1
                    current = array[i, i];
                    if (prev != 'A' && current != 'A' && prev == current)
                    {
                        Console.WriteLine("Diagnosel Control");
                        counter++;
                        if (counter == 2)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }


        public static bool SlideControl(char[,] array)
        {
            char prev = ' ';
            char current = ' ';

            int n = array.GetLength(0);
            int counter = 0;

            //[0,2]
            prev = array[0, n - 1];

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    counter = 0;

                }

                //[1,1]
                current = array[i, n - i - 1];
                if (prev != 'A' && current != 'A' && prev == current)
                {
                    Console.WriteLine("Diagnosel Control COUNTERRRR: " + counter);
                    counter++;
                    if (counter == 3)
                    {
                        return true;
                    }
                }

                //Update prev
                prev = current;

            }
            return false;

        }

     
    }
}

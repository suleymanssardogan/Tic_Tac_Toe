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
    public partial class Form5 : Form
    {
       
        bool X_Turn;
        bool O_Turn;

        char[,] array = new char[7, 7];

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
            X_Turn = true;
            Console.WriteLine("FORMLOAD");
            array = ArrayCall(array);
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }
        public static char[,] ArrayCall(char[,] array)
        {
            int n = array.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = 'A';
                }
            }
            return array;
        }
        public void Win()
        {
            Form1 form1 = new Form1();


            //I want to see all array in the terminal why I write
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {

                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            bool control = RawControl(array);
            bool control2 = ColumnControl(array);
            bool control3 = DiagnoselControl(array);
            bool control4 = SlideControl(array);

            
            for(int i = 0; i < 7; i++)
            {
                for(int j = 0; i < 7; j++)
                {
                    if (array[i, j] != 'A')
                    {
                        MessageBox.Show("Berabere");
                    }
                }
            }
            if (control)
            {
                if (X_Turn)
                {
                    MessageBox.Show("O KAZANDI");
                }
                else
                {
                    MessageBox.Show("X KAZANDI");
                   
                }
                form1.Show();  // Form1'i tekrar göster
                this.Close();  // Form5'i kapat

            }
            else if (control2)
            {
                if (X_Turn)
                {
                    MessageBox.Show("O KAZANDI");
                   
                }
                else
                {
                    MessageBox.Show("X KAZANDI");
                    
                }

                form1.Show();  // Form1'i tekrar göster
                this.Close();  // Form5'i kapat
            }

            else if (control3)
            {
                if (X_Turn)
                {
                    MessageBox.Show("O KAZANDI");
                    
                }
                else
                {
                    MessageBox.Show("X KAZANDI");
                    
                }

                form1.Show();  // Form1'i tekrar göster
                this.Close();  // Form5'i kapat
            }

            else if (control4)
            {
                if (X_Turn)
                {
                    MessageBox.Show("O KAZANDI");
                   
                }
                else
                {
                    MessageBox.Show("X KAZANDI");
                   
                }
                form1.Show();  // Form1'i tekrar göster
                this.Close();  // Form5'i kapat
            }
            else if (IsBoardFull()) // Eğer tahta dolduysa ve kazanan yoksa
            {
                MessageBox.Show("Beraberlik!");
                form1.Show();  // Form1'i tekrar göster
                this.Close();  // Form5'i kapat
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
                    i = 1;
                    j = 0;
                    break;
                case "button3":
                    i = 2;
                    j = 0;
                    break;
                case "button4":
                    i = 3;
                    j = 0;
                    break;
                case "button5":
                    i = 4;
                    j = 0;
                    break;
                case "button6":
                    i = 5;
                    j = 0;
                    break;
                case "button7":
                    i = 6;
                    j = 0;
                    break;
                case "button8":
                    i = 0;
                    j = 1;
                    break;
                case "button9":
                    i = 1;
                    j = 1;
                    break;
                case "button10":
                    i = 2;
                    j = 1;
                    break;
                case "button11":
                    i = 3;
                    j = 1;
                    break;
                case "button12":
                    i = 4;
                    j = 1;
                    break;
                case "button13":
                    i = 5;
                    j = 1;
                    break;
                case "button14":
                    i = 6;
                    j = 1;
                    break;
                case "button15":
                    i = 0;
                    j = 2;
                    break;
                case "button16":
                    i = 1;
                    j = 2;
                    break;
                case "button17":
                    i = 2;
                    j = 2;
                    break;
                case "button18":
                    i = 3;
                    j = 2;
                    break;
                case "button19":
                    i = 4;
                    j = 2;
                    break;
                case "button20":
                    i = 5;
                    j = 2;
                    break;
                case "button21":
                    i = 6;
                    j = 2;
                    break;
                case "button22":
                    i = 0;
                    j = 3;
                    break;
                case "button23":
                    i = 1;
                    j = 3;
                    break;
                case "button24":
                    i = 2;
                    j = 3;
                    break;
                case "button25":
                    i = 3;
                    j = 3;
                    break;
                case "button26":
                    i = 4;
                    j = 3;
                    break;
                case "button27":
                    i = 5;
                    j = 3;
                    break;
                case "button28":
                    i = 6;
                    j = 3;
                    break;
                case "button29":
                    i = 0;
                    j = 4;
                    break;

                case "button30":
                    i = 1;
                    j = 4;
                    break;

                case "button31":
                    i = 2;
                    j = 4;
                    break;

                case "button32":
                    i = 3;
                    j = 4;
                    break;

                case "button33":
                    i = 4;
                    j = 4;
                    break;

                case "button34":
                    i = 5;
                    j = 4;
                    break;

                case "button35":
                    i = 6;
                    j = 4;
                    break;

                case "button36":
                    i = 0;
                    j = 5;
                    break;
                case "button37":
                    i = 1;
                    j = 5;
                    break;
                case "button38":
                    i = 2;
                    j = 5;
                    break;
                case "button39":
                    i = 3;
                    j = 5;
                    break;
                case "button40":
                    i = 4;
                    j = 5;
                    break;
                case "button41":
                    i = 5;
                    j = 5;
                    break;
                case "button42":
                    i = 6;
                    j = 5;
                    break;

                case "button43":
                    i = 0;
                    j = 6;
                    break;
                case "button44":
                    i = 1;
                    j = 6;
                    break;
                case "button45":
                    i = 2;
                    j = 6;
                    break;
                case "button46":
                    i = 3;
                    j = 6;
                    break;
                case "button47":
                    i = 4;
                    j = 6;
                    break;
                case "button48":
                    i = 5;
                    j = 6;
                    break;
                case "button49":
                    i = 6;
                    j = 6;
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

        //This funciton controls draw sitiuaiton
        public bool IsBoardFull()
        {
            int n = array.GetLength(0);

            // Tahtada boş alan olup olmadığını kontrol et
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (array[i, j] == 'A') // Eğer 'A' (boş alan) varsa
                    {
                        return false; // Boş alan var, bu yüzden tahta dolmamış demektir
                    }
                }
            }
            return true; // Tüm alanlar dolmuş, geri true döndür
        }
        public static bool ColumnControl(char[,] array)
        {
            char prev = ' ';
            char current = ' ';
            int counter = 0;
            int n = array.GetLength(0);

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
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
                            if (counter == 6)
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
            int n = array.GetLength(0);
            //We create loop for control
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
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
                            if (counter == 6)
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
                        if (counter == 6)
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
                    if (counter == 7)
                    {
                        return true;
                    }
                }

                //Update prev
                prev = current;

            }
            return false;
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if user press close button form1 reshow
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}

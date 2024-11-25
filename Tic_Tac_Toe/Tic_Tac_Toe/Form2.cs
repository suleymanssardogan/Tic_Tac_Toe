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
    public partial class Form2 : Form
    {

        /*
         * Giriş: Oyun, iki oyuncu (X ve O) arasında sırayla oynanır. Oyuncular sırasıyla seçtikleri bir hücreye kendi sembollerini koyar. 
         * Her oyuncu, kazanan kombinasyonu elde etmek amacıyla hamle yapar.

           Çıkış: Oyunculardan biri yatay, dikey veya çapraz sırada üçlü bir dizi oluşturduğunda oyun sona erer ve o oyuncu kazanır. 
           Eğer tüm hücreler dolmuş fakat kazanan yoksa oyun berabere biter.

           Kontrol: Her hamleden sonra oyunun durumu kontrol edilir. Bu kontrol, sırayla her satır, sütun ve iki çaprazın, 
           aynı sembolle doldurulup doldurulmadığını test eder. Eğer herhangi birinde üçlü dizi sağlanmışsa, o oyuncunun kazandığı ilan edilir.

           Matematik: Her hücre bir koordinat çifti (satır ve sütun) ile temsil edilir. 
           3x3'lük bir ızgarada, bir hücrenin bulunduğu satır, sütun veya çapraz, aynı sembolle doldurulduğunda oyunun kazananı belirlenir. 
           İlgili kontrol için döngüler ve eşitlik koşulları kullanılır.
*/
       





            // Initialize variables to keep track of player turns
            bool X_Turn;
            bool O_Turn;

            // Initialize a 3x3 character array for storing player moves (X, O, or empty 'A')
            char[,] array =
            {
            { 'A','A','A' },
            { 'A','A','A' },
            { 'A','A','A' },
            };

            // Constructor for Form2
            public Form2()
            {
                InitializeComponent();
            }



            // Method to check win conditions after each move
            public void Win()
            {
                  Form1 form1 = new Form1(); 
                // Display the game board in the console for debugging
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }


                // Check each win condition
                bool control = RowControl(array);       // Check rows
                bool control2 = ColumnControl(array);   // Check columns
                bool control3 = DiagnoselControl(array); // Check main diagonal
                bool control4 = SlideControl(array);    // Check secondary diagonal


            // Display a message if a winning condition is met
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
            if (control4)
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

            else if (IsBoardFull())
            {
                MessageBox.Show("Beraebere");
                form1.Show();
                this.Close();
            }
        }


            // Event triggered when the form loads
            private void Form2_Load(object sender, EventArgs e)
            {
                // X starts first by default
                X_Turn = true;
            }


            // Event triggered when a cell button is clicked
            private void Total_Click(object sender, EventArgs e)
            {
                // Cast sender to Button to identify which button was clicked
                Button b = (Button)sender;
                Console.WriteLine(b.Name);

                int i = 0, j = 0;

                // Determine the coordinates (i, j) based on button name
                switch (b.Name)
                {
                    case "button1":
                        i = 0; j = 0;
                        break;
                    case "button2":
                        i = 1; j = 0;
                        break;
                    case "button3":
                        i = 2; j = 0;
                        break;
                    case "button4":
                        i = 0; j = 1;
                        break;
                    case "button5":
                        i = 1; j = 1;
                        break;
                    case "button6":
                        i = 2; j = 1;
                        break;
                    case "button7":
                        i = 0; j = 2;
                        break;
                    case "button8":
                        i = 1; j = 2;
                        break;
                    case "button9":
                        i = 2; j = 2;
                        break;
                }

                // Alternate turns between X and O
                if (X_Turn)
                {
                    array[i, j] = 'X'; // Store 'X' in array
                    X_Turn = false;
                    O_Turn = true;

                    b.Text = "X"; // Update button text
                    b.Enabled = false; // Disable button
                    Win(); // Check for win
                }
                else if (O_Turn)
                {
                    array[i, j] = 'O'; // Store 'O' in array
                    X_Turn = true;
                    O_Turn = false;

                    b.Text = "O"; // Update button text
                    b.Enabled = false; // Disable button
                    Win(); // Check for win
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



        // Method to check for column win condition
        public static bool ColumnControl(char[,] array)
            {

            // Variables to store the previous and current cell values
            char prev = ' ';
            char current = ' ';

            // Counter to track consecutive matching symbols in a column
            int counter = 0;

            // Outer loop iterates over each column (j represents the column index)
            for (int j = 0; j < 3; j++)
            {
                // Inner loop iterates over each row in the current column (i represents the row index)
                for (int i = 0; i < 3; i++)
                {
                    // If we're at the first row of the column, initialize the current symbol and reset the counter
                    if (i == 0)
                    {
                        current = array[i, j]; // Set current to the first cell in the column
                        counter = 0;           // Reset the counter at the start of a new column
                    }
                    else
                    {
                        // Set previous cell value to the cell in the row above the current cell in the column
                        prev = array[i - 1, j];
                        Console.WriteLine("CL--PREV: " + prev);

                        // Set current cell value to the current row in the column
                        current = array[i, j];
                        Console.WriteLine("CL--CURRENT: " + current); 

                        // Check if both prev and current are not empty (represented by 'A') and they match
                        if (prev != 'A' && current != 'A' && prev == current)
                        {
                            counter++;
                            Console.WriteLine("CL--COUNTER: " + counter); 

                            // If there are 2 consecutive matches, the column has three identical symbols
                            if (counter == 2)
                            {
                                return true; // Winning condition met, return true
                            }
                        }
                    }
                }
            }
            return false; 
        }

        // Method to check for row win condition
        public static bool RowControl(char[,] array)
        {
            char prev = ' ';      
            char current = ' ';   
            int counter = 0;      

            // Outer loop iterates over each row (i represents the row index)
            for (int i = 0; i < 3; i++)
            {
                // Inner loop iterates over each column in the current row (j represents the column index)
                for (int j = 0; j < 3; j++)
                {
                    // If we're at the first column of the row, initialize the current symbol and reset the counter
                    if (j == 0)
                    {
                        current = array[i, j]; // Set current to the first cell in the row
                        counter = 0;           
                    }
                    else
                    {
                        // Set previous cell value to the cell in the column to the left of the current cell
                        prev = array[i, j - 1];

                        // Set current cell value to the current column in the row
                        current = array[i, j];

                        // Check if both prev and current are not empty (represented by 'A') and they match
                        if (prev != 'A' && current != 'A' && prev == current)
                        {
                            counter++; 

                            
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

            // Method to check for main diagonal win condition
            public static bool DiagnoselControl(char[,] array)
            {
                char prev = ' ';
                char current = ' ';
                int counter = 0;

                int n = array.GetLength(0);

                // Check main diagonal for matching characters
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
                        //[1,1]
                        current = array[i, i];
                        if (prev != 'A' && current != 'A' && prev == current)
                        {
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

            // Method to check for secondary diagonal win condition
            public static bool SlideControl(char[,] array)
            {
                char prev = ' ';
                char current = ' ';
                int counter = 0;

                int n = array.GetLength(0);

                // Check secondary diagonal for matching characters[0,2]
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
                        counter++;
                        if (counter == 3)
                        {
                            return true;
                        }
                    }
                    prev = current;
                }
                return false;
            }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if user press close button form1 reshow
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}

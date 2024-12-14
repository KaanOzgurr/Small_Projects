using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2nd_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] words = new[] { "driver" , "signature" , "history" , "response" , "president" , "highway" , "computer" ,
         "apartment" , "forest" , "chocolat" , "lawyer" , "mercedes" , "audi" , "renault" , "volvo"};

        int index = 0 , score=0;
        Random random = new Random();

        private void button2_begin_Click(object sender, EventArgs e)
        {
            index = 0;
            score = 0;
            label2_result.Text = "Result";
            label2_result.BackColor = Color.Chocolate;
            label1_score.Text = "00";
            displayWord();
            button1_Next.Enabled = true;
            button2_begin.Enabled = false;
        }

        private void button1_Next_Click(object sender, EventArgs e)
        {


            checkWord();
            if(index < words.Length -1 )
            {
                index++;
                displayWord();
            }

        }

        //create a function to display the words
        public void displayWord()
        {
            int pos1 = random.Next(words[index].Length);
            int pos2 = random.Next(words[index].Length);
            int pos3 = random.Next(words[index].Length);


            string word = words[index];

            word = word.Remove(pos1, 1).Insert(pos1, "_");
            word = word.Remove(pos2, 1).Insert(pos2, "_");
            word = word.Remove(pos3, 1).Insert(pos3, "_");


            label_word.Text = word;
        }



        // create a function to check if the guessed word is correct

        public void checkWord() 
            {

            if (textBox1_guess.Text.ToLower().Equals(words[index]))
            {
                label2_result.Text = "Correct";
                label2_result.BackColor = Color.Green;
                score++;
            }
             else
            {
                label2_result.Text = "Wrong";
                label2_result.BackColor = Color.Red;
            }
            if (index == words.Length-1)
            {
                button2_begin.Enabled = true;
                button1_Next.Enabled = false;
            }
            textBox1_guess.Text = "";
            label1_score.Text = score.ToString() + " / " + words.Length.ToString();
        }

        private void textBox1_guess_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}

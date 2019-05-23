using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Drawing;

namespace Project1
{
    class Window
    {
        

        public void OpenWindow()
        {//Create Window
            Form mainW = new Form();
            mainW.Text = "Multiplication Window";
            //Buttons 
            Button button1 = new Button();
            button1.Location = new Point(20,20);
            Button button2 = new Button();
            button2.Location = new Point(button1.Right ,20);
            button1.Text = "Enter";
            button2.Text = "Multiply";
            TextBox textBox1 = new TextBox();
            TextBox textBox2 = new TextBox();
            TextBox textBox3 = new TextBox();
            textBox1.Location = new Point(10);
            textBox2.Location = new Point(textBox1.Right);
            textBox3.Location = new Point(textBox2.Right);
            //Button methods
            button1.Click += new System.EventHandler(onClickbutton1);
            void onClickbutton1(object sender, EventArgs e)
            {//Clear text
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
              
            }
            button2.Click += new System.EventHandler(onClickbutton2);
            void onClickbutton2(object sender, EventArgs e)
            {//Variables
                double num = 0, num1 = 0,num2=0;
                //Convert string to double and int
                 num = double.Parse(textBox1.Text);
                num1 = Convert.ToInt16(textBox2.Text);
                //Multiplication
                num2 = num * num1;
                //Append to textbox 3
                textBox3.AppendText(num2.ToString());
              
                         
            }
            //Add buttons to window
            mainW.Controls.Add(textBox1);
            mainW.Controls.Add(textBox2);
            mainW.Controls.Add(textBox3);
            mainW.Controls.Add(button1);
            mainW.Controls.Add(button2);
            //Show window
            mainW.ShowDialog();
        }


    }
}

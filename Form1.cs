using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Net;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1() //im here
        {
            InitializeComponent(); //start it and put the hashes in the console ok     opening discord rn
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            
                //string serverlink;
                //serverlink = Console.ReadLine();
                //WebRequest request = WebRequest.Create("http://www.nitrxgen.net/md5db/" + serverlink);
                //WebResponse response = request.GetResponse();
                //System.IO.StreamReader reader = new System.IO.StreamReader(response.GetResponseStream());
                //richTextBox1.Text = serverlink + " = " + reader.ReadToEnd(); //how about now ? none
                ////Console.WriteLine(serverlink + " = " + reader.ReadToEnd());
                
                timer1.Start();
                MessageBox.Show("Hashes have been Unhashed!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hashes have been Imported!");
        }
        
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        } 

        private void richTextBox1_TextChanged_2(object sender, EventArgs e)
        {
            //this is it  //what ios the name //you got any errors ??? one where cuz i can see them idk why
            //Line 31
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            You're so good lol
             btw you got to add that hash at the end of your list c8034a9882c2d012bf887d12f57219b5 for now cuz 
             im finding a method, I see. So it wil read the list I provide it and always look for "c8034a9882c2d012bf887d12f57219b5" correct?
             just put the hash at the end of the list
             then copy and past in console ..
             Okay, I gotta practice C# more like wayyy more
             anyway im gonna put the console in c++ it will be easier 
             Okay, I gotta learn C# fully before moving into C++ lol,
             c++ its easy to
             ok, I am happy I kind of helped you with the ui             lol
             Lemme test it out
            */
            if (richTextBox1.Text.Contains("<END>"))
            {
                timer1.Stop();
            }
            else
            {
                string serverlink;
                serverlink = Console.ReadLine();
                WebRequest request = WebRequest.Create("http://www.nitrxgen.net/md5db/" + serverlink);
                WebResponse response = request.GetResponse();
                System.IO.StreamReader reader = new System.IO.StreamReader(response.GetResponseStream());
                richTextBox1.AppendText(reader.ReadToEnd() + "\n");
            }
        }
    }
}
/*
Discord crashed gimme 1s


*/
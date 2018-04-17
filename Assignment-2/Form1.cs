using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Here we create some public strings and integers
        //which are used throughout the programme. This also
        //includes the array "mediaLibrary"
        public string MediaPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        public int NumberofGenre;
        ListBox[] mediaLibrary;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            //Honestly, I have simply no clue how to code in the WMP
            //and how to get it to work. I tried to hide it during the course of
            //me trying to work it out and it simply just left a hole which
            //froze whatever was behind it.
        }

        private void Gnre_lst_bx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Show_form(object sender, EventArgs e)
        {
            Load_default_data();
        }

        private void Load_default_data()
        {
            //Here we create a string and some integers which we reuse
            //throughout the program.
            string lineOfText;
            int total_number_of_genrea;
            int total_number_of_tracks;
            // This gets us the location where the Application is being
            // executed from and thus a place where we created our files
            string applicationPath = Directory.GetCurrentDirectory() + "\\Media\\";

            // Creates a file on the HDD at the Application_Path location called, "MyFile.txt"
            StreamReader myInputStream = File.OpenText(applicationPath + "Media.txt");
            // Get a line of text from the file
            total_number_of_genrea = Convert.ToInt32( myInputStream.ReadLine());
            mediaLibrary = new ListBox[total_number_of_genrea];
            for (int g = 0; g < total_number_of_genrea; g++ )
            {
                mediaLibrary[g] = new ListBox();
                total_number_of_tracks = Convert.ToInt32(myInputStream.ReadLine());
                for (int t =0; t <= total_number_of_tracks; t++)
                {
                    mediaLibrary[g].Items.Add( myInputStream.ReadLine());
                }
                
            }
            // Close the file
            myInputStream.Close();
            //This sets the interface we want viewed when we load up 
            //the programme. This can be modified but I just left it at 2
            //just by chance.
            Update_interface(2);
        }

        private void Update_interface(int index)
        {
            //These two lines clear both the Gnre_list_box of any items
            //and the Genre_title text box of any text.
            Gnre_lst_bx.Items.Clear();
            Genre_title.Text = "" ;

            //Here we have a for loop which inserts the title of
            //the genre from the array into the text box.
            Genre_title.Text = mediaLibrary[index].Items[0].ToString();
            for (int i = 1; i < mediaLibrary[index].Items.Count; i++)
            {
                Gnre_lst_bx.Items.Add(mediaLibrary[index].Items[i].ToString());
            }
        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This is so the setup button on the hierarchal
            //menu will bring up the set up form.
            Setup myForm = new Setup();
            myForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This is so the about button on the hierarchal
            //menu will bring up the about form.
            About myForm = new About();
            myForm.Show();
        }

        private void Ply_lst_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void Gnre_lst_bx_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Here is the lines of code which make a string from
            //whatever item is double clicked in the genre box
            //and inserts it into the playlist box.
            string playlist = Gnre_lst_bx.SelectedItem.ToString();
            Ply_lst_box.Items.Add(playlist);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //This line of code allows the user to go through the
            //genrea's using the horizontal scroll bar.
            Update_interface(hScrollBar1.Value);
        }

        private void Now_Plying_box_TextChanged(object sender, EventArgs e)
        {
            //Here I have attempted to try do task 5, however
            //I have not had any luck on figuring it out.
            Now_Plying_box.Text = "";
            string now_playing = Ply_lst_box.SelectedItem.ToString();
            
        }
    }
}

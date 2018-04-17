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

            Update_interface(2);
        }

        private void Update_interface(int index)
        {
            Gnre_lst_bx.Items.Clear();
            Genre_title.Text = "" ;

            Genre_title.Text = mediaLibrary[index].Items[0].ToString();
            for (int i = 1; i < mediaLibrary[index].Items.Count; i++)
            {
                Gnre_lst_bx.Items.Add(mediaLibrary[index].Items[i].ToString());
            }
        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setup myForm = new Setup();
            myForm.Show();
        }
    }
}

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
          StreamReader inputStream  = File.OpenText(@"C:\Users\thoma\Documents\GitHub\Assignment-2\Assignment-2\Media\Media.txt");
            NumberofGenre = Convert.ToInt32(inputStream.ReadLine());
            mediaLibrary = new ListBox[NumberofGenre];
            Gnre_lst_bx.Items.Add(mediaLibrary);


            

          
            
        }
    }
}

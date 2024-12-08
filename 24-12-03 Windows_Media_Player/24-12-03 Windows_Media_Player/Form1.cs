using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_12_03_Windows_Media_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Müzik Dosyası(*.mp3)|*.mp3|mp4 dosyası(*.mp4)|*.mp4|Flv Video (*.flv)|*.flv|Tüm Dosyalar (mp3,mp4,flv)|*.mp3;*.mp4;*.flv;";
            openFileDialog1.FilterIndex = 4; //index numarası 0dan değil 1 den başlar 
            openFileDialog1.Title = "Sürücü Listesi";
            openFileDialog1.InitialDirectory = "C:\\"; //VARSAYILAN Disk veya klasör seçmek için kullanılır
            //openFileDialog1.InitialDirectory = Application.StartupPath; //proje klasörü varsayılan seçilir            
            openFileDialog1.ShowDialog();

            listBox1.Items.Add(openFileDialog1.FileName);



        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir seçim yapınız");
            }
            else
            {
                Player.URL = listBox1.SelectedItem.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.previous();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.next();
        }
    }
}

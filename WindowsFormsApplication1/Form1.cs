using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CircularArrayTypedQueue c = new CircularArrayTypedQueue(20);
            PriorityQueue p = new PriorityQueue(20);
            CircularArrayTypedQueue priorityTers = new CircularArrayTypedQueue(20);

            int[,] beklemesureleri = new int[20, 3];
            int[,] toplambeklemesureleri = new int[20, 3];
            int[,] aradakiFark = new int[20, 1];
                
            for(int i = 0; i < 20; i++)
            {
                Kisi k = new Kisi();
                k.musteriNo = i + 1;
                k.beklemeSuresi = r.Next(60, 600);
                c.Insert(k);
                p.Insert(k);
            }

            int tempToplamBeklemeOncelik = 0, tempToplamBeklemeDairesel=0,tempBeklemeTers=0;
            Stack<Kisi> tersStack = new Stack<Kisi>(20);
            string oncelikSonucu = "",daireselSonucu="",tersSonucu="";

            for(int i = 0; i < 20; i++)
            {
                Kisi temp = c.Remove();
                beklemesureleri[temp.musteriNo-1,0] = temp.beklemeSuresi;
                tempToplamBeklemeDairesel += temp.beklemeSuresi;
                toplambeklemesureleri[temp.musteriNo-1, 0] = tempToplamBeklemeDairesel;
                daireselSonucu += temp.musteriNo + " numaralı müşterinin işlem süresi: " + temp.beklemeSuresi + ", toplam bekleme süresi: " + tempToplamBeklemeDairesel + Environment.NewLine;
                temp = p.Remove();
                beklemesureleri[temp.musteriNo-1, 1] = temp.beklemeSuresi;
                tempToplamBeklemeOncelik += temp.beklemeSuresi;
                toplambeklemesureleri[temp.musteriNo-1, 1] = tempToplamBeklemeOncelik;
                tersStack.Push(temp);
                oncelikSonucu += temp.musteriNo + " numaralı müşterinin işlem süresi: " + temp.beklemeSuresi + ", toplam bekleme süresi: " + tempToplamBeklemeOncelik + Environment.NewLine;

            }
            for(int i = 0; i <20; i++)
            {
                Kisi k = tersStack.Pop();
                priorityTers.Insert(k);
            }
            for(int i = 0; i < 20; i++)
            {
                Kisi temp = priorityTers.Remove();
                beklemesureleri[temp.musteriNo-1, 2] = temp.beklemeSuresi;
                tempBeklemeTers += temp.beklemeSuresi;
                toplambeklemesureleri[temp.musteriNo-1, 2] = tempBeklemeTers;
                tersSonucu += temp.musteriNo + " numaralı müşterinin işlem süresi: " + temp.beklemeSuresi + ", toplam bekleme süresi: " + tempBeklemeTers + Environment.NewLine;
                aradakiFark[i, 0] = (toplambeklemesureleri[i, 1] - toplambeklemesureleri[i, 0]) * -1;
            }

            txtDairesel.Text = daireselSonucu;
            txtOncelik.Text = oncelikSonucu;
            txtTers.Text = tersSonucu;

            int tempOrtDaireselToplam = 0,tempOrtOncelikToplam=0,tempOrtTersToplam=0;
            string kazanc = "";

            for(int i = 0; i < 20; i++)
            {
                tempOrtDaireselToplam += toplambeklemesureleri[i, 0];
                tempOrtOncelikToplam += toplambeklemesureleri[i, 1];
                tempOrtTersToplam += toplambeklemesureleri[i, 2];
                if (aradakiFark[i, 0] > 0)
                {
                    int musteriNo = i +1;
                    int yuzde = aradakiFark[i, 0]*100 / toplambeklemesureleri[i,0];
                    kazanc += musteriNo + " numaralı müşterinin zaman kazancı: " + aradakiFark[i, 0] + " - %" + yuzde +Environment.NewLine;
                }
            }

            txtDaireselOrt.Text = "Ort: " +(tempOrtDaireselToplam / 20).ToString();
            txtOncelikOrt.Text = "Ort: " + (tempOrtOncelikToplam / 20).ToString();
            txtTersOrt.Text = "Ort: " + (tempOrtTersToplam / 20).ToString();
            txtKazanc.Text = kazanc;
        }
    }
}

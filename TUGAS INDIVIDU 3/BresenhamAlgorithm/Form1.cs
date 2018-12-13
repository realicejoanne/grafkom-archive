using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BresenhamAlgorithm {
    public partial class Form1 : Form {
        int x1, x2, y1, y2,dx,dy;
        Graphics g;
        Brush brush = Brushes.Black;
        public Form1(){
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e){
            panel.Refresh();
            algoritmaBresenham();
        }

        private void algoritmaBresenham(){
            //Deklarasi variabel yang dibutuhkan
            int da, db, x, y, m1, m2, p;
            x1 = Convert.ToInt16(X1.Text);
            x2 = Convert.ToInt16(X2.Text);
            y1 = Convert.ToInt16(Y1.Text);
            y2 = Convert.ToInt16(X2.Text);
            x = x1;
            y = y1;
            g = panel.CreateGraphics();

            //Mencari nilai dx dan dy
            dx = x2 - x1;
            dy = y2 - y1;

            //Kondisi
            if (Math.Abs(dx) >= Math.Abs(dy)){
                da = Math.Abs(dx);
                db = Math.Abs(dy);

                if (dx >= 0){
                    m1 = 3;
                }
                else {
                    m1 = 7;
                }
            }
            else {
                da = Math.Abs(dy);
                db = Math.Abs(dx);

                if (dy >= 0){
                    m1 = 1;
                }
                else {
                    m1 = 5;
                }
            }

            if (dx >= 0){
                if (dy >= 0){
                    m2 = 2;
                }
                else {
                    m2 = 4;
                }
            }
            else {
                if (dy < 0){
                    m2 = 6;
                }
                else{
                    m2 = 8;
                }
            }
            p = 2 * db - da;

            //Menggambar menggunakan algoritma Bresenham
            richTextBox.Text = "x\ty\n";
            richTextBox.AppendText(x + "\t" + y + "\n");
            g.FillRectangle(brush, x, y, 1, 1);
            while (x != x2 || y != y2){
                if (p >= 0){
                    p = p + 2 * db - 2 * da;

                    switch (m2){
                        case 2:
                            x += 1;
                            y += 1;
                            break;
                        case 4:
                            x += 1;
                            y -= 1;
                            break;
                        case 6:
                            x -= 1;
                            y -= 1;
                            break;
                        case 8:
                            x -= 1;
                            y += 1;
                            break;
                    }
                }
                else {
                    switch (m1){
                        case 1:
                            y += 1;
                            break;
                        case 3:
                            x += 1;
                            break;
                        case 5:
                            y -= 1;
                            break;
                        case 7:
                            x -= 1;
                            break;
                    }
                    p = p + 2 * db;
                }
                richTextBox.AppendText(x + "\t" + y + "\n");
                g.FillRectangle(brush, x, y, 1, 1);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e){

        }
    }
}

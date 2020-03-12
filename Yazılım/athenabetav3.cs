using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace PROGRAMLARTABLOSU
{
   
    public partial class SATRANCOYUNU : Form
    {

        public SATRANCOYUNU()
        {
            InitializeComponent();
        }

        private void BtnA1_Click(object sender, EventArgs e)
        {
            /*A1 butonu tıklandığında yani A1 karesine tıklandığı anda txtsonuc'a gidebileceği kareleri yazdırıcak.*/
            RENK();
                TxtSonuc.Text = "B3-C2 KARELERİNE GİDEBİLİR";
            if (BtnA1.Enabled == true)
            {
                BtnB3.BackColor = Color.Blue;
                BtnC2.BackColor = Color.Blue;
            }
        }
        private void BtnB1_Click(object sender, EventArgs e)
        {
            RENK();
                TxtSonuc.Text = "A3-C3-D2 KARELERİNE GİDEBİLİR";
            if (BtnB1.Enabled == true)
            {
                BtnA3.BackColor = Color.Chocolate;
                BtnC3.BackColor = Color.Chocolate;
                BtnD2.BackColor = Color.Chocolate;
            }
        }

        private void BtnC1_Click(object sender, EventArgs e)
        {
            RENK();
                TxtSonuc.Text = "A2-B3-D3-E2 KARELERİNE GİDEBİLİR";
            if (BtnC1.Enabled == true)
            {
                BtnA2.BackColor = Color.Brown;
                BtnB3.BackColor = Color.Brown;
                BtnD3.BackColor = Color.Brown;
                BtnE2.BackColor = Color.Brown;
            }
        }

        private void BtnD1_Click(object sender, EventArgs e)
        {
            RENK();
                TxtSonuc.Text = "B2-C3-E3-F2 KARELERİNE GİDEBİLİR";
            if (BtnD1.Enabled == true)
            {
                BtnB2.BackColor = Color.CadetBlue;
                BtnC3.BackColor = Color.CadetBlue;
                BtnE3.BackColor = Color.CadetBlue;
                BtnF2.BackColor = Color.CadetBlue;
            }
        }

        private void BtnE1_Click(object sender, EventArgs e)
        {
            RENK();
                TxtSonuc.Text = "C2-D3-F3-G2 KARELERİNE GİDEBİLİR";
            if (BtnE1.Enabled == true)
                {
                BtnC2.BackColor = Color.Coral;
                BtnD3.BackColor = Color.Coral;
                BtnF3.BackColor = Color.Coral;
                BtnG2.BackColor = Color.Coral;
            }

            }

        private void BtnF1_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "D2-E3-G3-H2 KARELERİNE GİDEBİLİR";
            if (BtnF1.Enabled == true)
            {
                BtnD2.BackColor = Color.Crimson;
                BtnE3.BackColor = Color.Crimson;
                BtnG3.BackColor = Color.Crimson;
                BtnH2.BackColor = Color.Crimson;
            }
        }
        private void BtnG1_Click(object sender, EventArgs e)
        {
            RENK();
                TxtSonuc.Text = "E2-F3-H3 KARELERİNE GİDEBİLİR";
                if (BtnG1.Enabled == true)
                {
                    BtnE2.BackColor = Color.DarkOliveGreen;
                    BtnF3.BackColor = Color.DarkOliveGreen;
                    BtnH3.BackColor = Color.DarkOliveGreen;
                }
        }

        private void BtnH1_Click(object sender, EventArgs e)
        {
            RENK();
                TxtSonuc.Text = "F2-G3 KARELERİNE GİDEBİLİR";
                if (BtnH1.Enabled == true)
                {
                    BtnF2.BackColor = Color.DarkGreen;
                    BtnG3.BackColor = Color.DarkGreen;
                }
        }

        private void BtnA2_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "B4-C1-C3 KARELERİNE GİDEBİLİR";
            if (BtnA2.Enabled == true)
            {
                BtnB4.BackColor = Color.DarkMagenta;
                BtnC1.BackColor = Color.DarkMagenta;
                BtnC3.BackColor = Color.DarkMagenta;
            }
        }

        private void BtnB2_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "A4-C4-D1-D3 KARELERİNE GİDEBİLİR";
            if (BtnB2.Enabled == true)
            {
                BtnA4.BackColor = Color.DarkOrange;
                BtnC4.BackColor = Color.DarkOrange;
                BtnD1.BackColor = Color.DarkOrange;
                BtnD3.BackColor = Color.DarkOrange;
            }
        }

        private void BtnC2_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "A1-A3-B4-D4-E1-E3 KARELERİNE GİDEBİLİR";
            if (BtnC2.Enabled == true)
            {
                BtnA1.BackColor = Color.DarkOrchid;
                BtnA3.BackColor = Color.DarkOrchid;
                BtnB4.BackColor = Color.DarkOrchid;
                BtnD4.BackColor = Color.DarkOrchid;
                BtnE1.BackColor = Color.DarkOrchid;
                BtnE3.BackColor = Color.DarkOrchid;
            }
        }

        private void BtnD2_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "B1-B3-C4-E4-F1-F3 KARELERİNE GİDEBİLİR";
            if (BtnD2.Enabled == true)
            {
                BtnB1.BackColor = Color.DarkRed;
                BtnB3.BackColor = Color.DarkRed;
                BtnC4.BackColor = Color.DarkRed;
                BtnE4.BackColor = Color.DarkRed;
                BtnF1.BackColor = Color.DarkRed;
                BtnF3.BackColor = Color.DarkRed;
            }
        }

        private void BtnE2_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "C1-C3-D4-F4-G1-G3 KARELERİNE GİDEBİLİR";
            if (BtnE2.Enabled == true)
            {
                BtnC1.BackColor = Color.DarkSalmon;
                BtnC3.BackColor = Color.DarkSalmon;
                BtnD4.BackColor = Color.DarkSalmon;
                BtnF4.BackColor = Color.DarkSalmon;
                BtnG1.BackColor = Color.DarkSalmon;
                BtnG3.BackColor = Color.DarkSalmon;
            }
        }

        private void BtnF2_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "D1-D3-E4-G4-H1-H3 KARELERİNE GİDEBİLİR";
            if (BtnF2.Enabled == true)
            {
                BtnD1.BackColor = Color.DarkSeaGreen;
                BtnD3.BackColor = Color.DarkSeaGreen;
                BtnE4.BackColor = Color.DarkSeaGreen;
                BtnG4.BackColor = Color.DarkSeaGreen;
                BtnH1.BackColor = Color.DarkSeaGreen;
                BtnH3.BackColor = Color.DarkSeaGreen;

            }
        }

        private void BtnG2_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "E1-E3-F4-H4 KARELERİNE GİDEBİLİR";
            if (BtnG2.Enabled == true)
            {
                BtnE1.BackColor = Color.DarkSlateGray;
                BtnE3.BackColor = Color.DarkSlateGray;
                BtnF4.BackColor = Color.DarkSlateGray;
                BtnH4.BackColor = Color.DarkSlateGray;
            }
        }

        private void BtnH2_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "F1-F3-G4 KARELERİNE GİDEBİLİR";
            if (BtnH2.Enabled == true)
            {
                BtnF1.BackColor = Color.DarkTurquoise;
                BtnF3.BackColor = Color.DarkTurquoise;
                BtnG4.BackColor = Color.DarkTurquoise;
            }
        }

        private void BtnA3_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "B1-B5-C2-C4 KARELERİNE GİDEBİLİR";
            if (BtnA3.Enabled == true)
            {
                BtnB1.BackColor = Color.DeepPink;
                BtnB5.BackColor = Color.DeepPink;
                BtnC2.BackColor = Color.DeepPink;
                BtnC4.BackColor = Color.DeepPink;
            }
        }

        private void BtnB3_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "A1-A5-C1-C5-D2-D4 KARELERİNE GİDEBİLİR";
            if (BtnB3.Enabled == true)
            {
                BtnA1.BackColor = Color.DimGray;
                BtnA5.BackColor = Color.DimGray;
                BtnC1.BackColor = Color.DimGray;
                BtnC5.BackColor = Color.DimGray;
                BtnD2.BackColor = Color.DimGray;
                BtnD4.BackColor = Color.DimGray;
            }
        }

        private void BtnC3_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "A2-A4-B1-B5-D1-D5-E2-E4 KARELERİNE GİDEBİLİR";
            if (BtnC3.Enabled == true)
            {
                BtnA2.BackColor = Color.BurlyWood;
                BtnA4.BackColor = Color.BurlyWood;
                BtnB1.BackColor = Color.BurlyWood;
                BtnB5.BackColor = Color.BurlyWood;
                BtnD1.BackColor = Color.BurlyWood;
                BtnD5.BackColor = Color.BurlyWood;
                BtnE2.BackColor = Color.BurlyWood;
                BtnE4.BackColor = Color.BurlyWood;
            }
        }

        private void BtnD3_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "B2-B4-C1-C5-E1-E5-F2-F4 KARELERİNE GİDEBİLİR";
            if (BtnD3.Enabled == true)
            {
                BtnB2.BackColor = Color.ForestGreen;
                BtnB4.BackColor = Color.ForestGreen;
                BtnC1.BackColor = Color.ForestGreen;
                BtnC5.BackColor = Color.ForestGreen;
                BtnE1.BackColor = Color.ForestGreen;
                BtnE5.BackColor = Color.ForestGreen;
                BtnF2.BackColor = Color.ForestGreen;
                BtnF4.BackColor = Color.ForestGreen;
            }
        }

        private void BtnE3_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "C2-C4-D1-D5-F1-F5-G2-G4 KARELERİNE GİDEBİLİR";
            if (BtnE3.Enabled == true)
            {
                BtnC2.BackColor = Color.Fuchsia;
                BtnC4.BackColor = Color.Fuchsia;
                BtnD1.BackColor = Color.Fuchsia;
                BtnD5.BackColor = Color.Fuchsia;
                BtnF1.BackColor = Color.Fuchsia;
                BtnF5.BackColor = Color.Fuchsia;
                BtnG2.BackColor = Color.Fuchsia;
                BtnG4.BackColor = Color.Fuchsia;
            }
        }

        private void BtnF3_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "D2-D4-E1-E5-G1-G5-H2-H4 KARELERİNE GİDEBİLİR";
            if (BtnF3.Enabled == true)
            {
                BtnD2.BackColor = Color.Gold;
                BtnD4.BackColor = Color.Gold;
                BtnE1.BackColor = Color.Gold;
                BtnE5.BackColor = Color.Gold;
                BtnG1.BackColor = Color.Gold;
                BtnG5.BackColor = Color.Gold;
                BtnH2.BackColor = Color.Gold;
                BtnH4.BackColor = Color.Gold;
            }
        }

        private void BtnG3_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "E2-E4-F1-F5-H1-H5 KARELERİNE GİDEBİLİR";
            if (BtnG3.Enabled == true)
            {
                BtnE2.BackColor = Color.Green;
                BtnE4.BackColor = Color.Green;
                BtnF1.BackColor = Color.Green;
                BtnF5.BackColor = Color.Green;
                BtnH1.BackColor = Color.Green;
                BtnH5.BackColor = Color.Green;
            }
        }

        private void BtnH3_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "F2-F4-G1-G5 KARELERİNE GİDEBİLİR";
            if (BtnH3.Enabled == true)
            {
                BtnF2.BackColor = Color.GreenYellow;
                BtnF4.BackColor = Color.GreenYellow;
                BtnG1.BackColor = Color.GreenYellow;
                BtnG5.BackColor = Color.GreenYellow;
            }
        }

        private void BtnA4_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "B2-B6-C3-C5 KARELERİNE GİDEBİLİR";
            if (BtnA4.Enabled == true)
            {
                BtnB2.BackColor = Color.MediumAquamarine;
                BtnB6.BackColor = Color.MediumAquamarine;
                BtnC3.BackColor = Color.MediumAquamarine;
                BtnC5.BackColor = Color.MediumAquamarine;
            }
        }

        private void BtnB4_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "A2-A6-C2-C6-D3-D5 KARELERİNE GİDEBİLİR";
            if (BtnB4.Enabled == true)
            {
                BtnA2.BackColor = Color.HotPink;
                BtnA6.BackColor = Color.HotPink;
                BtnC2.BackColor = Color.HotPink;
                BtnC6.BackColor = Color.HotPink;
                BtnD3.BackColor = Color.HotPink;
                BtnD5.BackColor = Color.HotPink;
            }
        }

        private void BtnC4_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "A3-A5-B2-B6-D2-D6-E3-E5 KARELERİNE GİDEBİLİR";
            if (BtnC4.Enabled == true)
            {
                BtnA3.BackColor = Color.Indigo;
                BtnA5.BackColor = Color.Indigo;
                BtnB2.BackColor = Color.Indigo;
                BtnB6.BackColor = Color.Indigo;
                BtnD2.BackColor = Color.Indigo;
                BtnD6.BackColor = Color.Indigo;
                BtnE3.BackColor = Color.Indigo;
                BtnE5.BackColor = Color.Indigo;
            }
        }

        private void BtnD4_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "B3-B5-C2-C6-E2-E6-F3-F5 KARELERİNE GİDEBİLİR";
            if (BtnD4.Enabled == true)
            {
                BtnB3.BackColor = Color.Khaki;
                BtnB5.BackColor = Color.Khaki;
                BtnC2.BackColor = Color.Khaki;
                BtnC6.BackColor = Color.Khaki;
                BtnE2.BackColor = Color.Khaki;
                BtnE6.BackColor = Color.Khaki;
                BtnF3.BackColor = Color.Khaki;
                BtnF5.BackColor = Color.Khaki;
            }
        }

        private void BtnE4_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "C3-C5-D2-D6-F2-F6-G3-G5 KARELERİNE GİDEBİLİR";
            if (BtnE4.Enabled == true)
            {
                BtnC3.BackColor = Color.Lavender;
                BtnC5.BackColor = Color.Lavender;
                BtnD2.BackColor = Color.Lavender;
                BtnD6.BackColor = Color.Lavender;
                BtnF2.BackColor = Color.Lavender;
                BtnF6.BackColor = Color.Lavender;
                BtnG3.BackColor = Color.Lavender;
                BtnG5.BackColor = Color.Lavender;
            }
        }

        private void BtnF4_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "D3-D5-E2-E6-G2-G6-H3-H5 KARELERİNE GİDEBİLİR";
            if (BtnF4.Enabled == true)
            {
                BtnD3.BackColor = Color.LavenderBlush;
                BtnD5.BackColor = Color.LavenderBlush;
                BtnE2.BackColor = Color.LavenderBlush;
                BtnE6.BackColor = Color.LavenderBlush;
                BtnG2.BackColor = Color.LavenderBlush;
                BtnG6.BackColor = Color.LavenderBlush;
                BtnH3.BackColor = Color.LavenderBlush;
                BtnH5.BackColor = Color.LavenderBlush;
            }
        }

        private void BtnG4_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "E3-E5-F2-F6-H2-H6 KARELERİNE GİDEBİLİR";
            if (BtnG4.Enabled == true)
            {
                BtnE3.BackColor = Color.LawnGreen;
                BtnE5.BackColor = Color.LawnGreen;
                BtnF2.BackColor = Color.LawnGreen;
                BtnF6.BackColor = Color.LawnGreen;
                BtnH2.BackColor = Color.LawnGreen;
                BtnH6.BackColor = Color.LawnGreen;
            }
        }

        private void BtnH4_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "F3-F5-G2-G6 KARELERİNE GİDEBİLİR";
            if (BtnH4.Enabled == true)
            {
                BtnF3.BackColor = Color.LemonChiffon;
                BtnF5.BackColor = Color.LemonChiffon;
                BtnG2.BackColor = Color.LemonChiffon;
                BtnG6.BackColor = Color.LemonChiffon;
            }
        }

        private void BtnA5_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "B3-B7-C4-C6 KARELERİNE GİDEBİLİR";
            if (BtnA5.Enabled == true)
            {
                BtnB3.BackColor = Color.LightCoral;
                BtnB7.BackColor = Color.LightCoral;
                BtnC4.BackColor = Color.LightCoral;
                BtnC6.BackColor = Color.LightCoral;
            }
        }

        private void BtnB5_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "A3-A7-C3-C7-D4-D6 KARELERİNE GİDEBİLİR";
            if (BtnB5.Enabled == true)
            {
                BtnA3.BackColor = Color.Chartreuse;
                BtnA7.BackColor = Color.Chartreuse;
                BtnC3.BackColor = Color.Chartreuse;
                BtnC7.BackColor = Color.Chartreuse;
                BtnD4.BackColor = Color.Chartreuse;
                BtnD6.BackColor = Color.Chartreuse;
            }
        }

        private void BtnC5_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "A4-A6-B3-B7-D3-D7-E4-E6 KARELERİNE GİDEBİLİR";
            if (BtnC5.Enabled == true)
            {
                BtnA4.BackColor = Color.LightGoldenrodYellow;
                BtnA6.BackColor = Color.LightGoldenrodYellow;
                BtnB3.BackColor = Color.LightGoldenrodYellow;
                BtnB7.BackColor = Color.LightGoldenrodYellow;
                BtnD3.BackColor = Color.LightGoldenrodYellow;
                BtnD7.BackColor = Color.LightGoldenrodYellow;
                BtnE4.BackColor = Color.LightGoldenrodYellow;
                BtnE6.BackColor = Color.LightGoldenrodYellow;
            }
        }

        private void BtnD5_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "B4-B6-C3-C7-E3-E7-F4-F6 KARELERİNE GİDEBİLİR";
            if (BtnD5.Enabled == true)
            {
                BtnB4.BackColor = Color.LightSalmon;
                BtnB6.BackColor = Color.LightSalmon;
                BtnC3.BackColor = Color.LightSalmon;
                BtnC7.BackColor = Color.LightSalmon;
                BtnE3.BackColor = Color.LightSalmon;
                BtnE7.BackColor = Color.LightSalmon;
                BtnF4.BackColor = Color.LightSalmon;
                BtnF6.BackColor = Color.LightSalmon;
            }
        }

        private void BtnE5_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "C4-C6-D3-D7-F3-F7-G4-G6 KARELERİNE GİDEBİLİR";
            if (BtnE5.Enabled == true)
            {
                BtnC4.BackColor = Color.LightSkyBlue;
                BtnC6.BackColor = Color.LightSkyBlue;
                BtnD3.BackColor = Color.LightSkyBlue;
                BtnD7.BackColor = Color.LightSkyBlue;
                BtnF3.BackColor = Color.LightSkyBlue;
                BtnF7.BackColor = Color.LightSkyBlue;
                BtnG4.BackColor = Color.LightSkyBlue;
                BtnG6.BackColor = Color.LightSkyBlue;
            }
        }

        private void BtnF5_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "D4-D6-E3-E7-G3-G7-H4-H6 KARELERİNE GİDEBİLİR";
            if (BtnF5.Enabled == true)
            {
                BtnD4.BackColor = Color.LightSteelBlue;
                BtnD6.BackColor = Color.LightSteelBlue;
                BtnE3.BackColor = Color.LightSteelBlue;
                BtnE7.BackColor = Color.LightSteelBlue;
                BtnG3.BackColor = Color.LightSteelBlue;
                BtnG7.BackColor = Color.LightSteelBlue;
                BtnH4.BackColor = Color.LightSteelBlue;
                BtnH6.BackColor = Color.LightSteelBlue;
            }
        }

        private void BtnG5_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "E4-E6-F3-F7-H3-H7 KARELERİNE GİDEBİLİR";
            if (BtnG5.Enabled == true)
            {
                BtnE4.BackColor = Color.Lime;
                BtnE6.BackColor = Color.Lime;
                BtnF3.BackColor = Color.Lime;
                BtnF7.BackColor = Color.Lime;
                BtnH3.BackColor = Color.Lime;
                BtnH7.BackColor = Color.Lime;
            }
        }

        private void BtnH5_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "F4-F6-G3-G7 KARELERİNE GİDEBİLİR";
            if (BtnH5.Enabled == true)
            {
                BtnF4.BackColor = Color.Chartreuse;
                BtnF6.BackColor = Color.Chartreuse;
                BtnG3.BackColor = Color.Chartreuse;
                BtnG7.BackColor = Color.Chartreuse;
            }
        }

        private void BtnA6_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "B4-B8-C5-C7 KARELERİNE GİDEBİLİR";
            if (BtnA6.Enabled == true)
            {
                BtnB4.BackColor = Color.Magenta;
                BtnB8.BackColor = Color.Magenta;
                BtnC5.BackColor = Color.Magenta;
                BtnC7.BackColor = Color.Magenta;
            }
        }

        private void BtnB6_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "A4-A8-C4-C8-D5-D7 KARELERİNE GİDEBİLİR";
            if (BtnB6.Enabled == true)
            {
                BtnA4.BackColor = Color.Maroon;
                BtnA8.BackColor = Color.Maroon;
                BtnC4.BackColor = Color.Maroon;
                BtnC8.BackColor = Color.Maroon;
                BtnD5.BackColor = Color.Maroon;
                BtnD7.BackColor = Color.Maroon;
            }
        }

        private void BtnC6_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "A5-A7-B4-B8-D4-D8-E5-E7 KARELERİNE GİDEBİLİR";
            if (BtnC6.Enabled == true)
            {
                BtnA5.BackColor = Color.MediumBlue;
                BtnA7.BackColor = Color.MediumBlue;
                BtnB4.BackColor = Color.MediumBlue;
                BtnB8.BackColor = Color.MediumBlue;
                BtnD4.BackColor = Color.MediumBlue;
                BtnD8.BackColor = Color.MediumBlue;
                BtnE5.BackColor = Color.MediumBlue;
                BtnE7.BackColor = Color.MediumBlue;
            }
        }

        private void BtnD6_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "B5-B7-C4-C8-E4-E8-F5-F7 KARELERİNE GİDEBİLİR";
            if (BtnD6.Enabled == true)
            {
                BtnB5.BackColor = Color.MediumPurple;
                BtnB7.BackColor = Color.MediumPurple;
                BtnC4.BackColor = Color.MediumPurple;
                BtnC8.BackColor = Color.MediumPurple;
                BtnE4.BackColor = Color.MediumPurple;
                BtnE8.BackColor = Color.MediumPurple;
                BtnF5.BackColor = Color.MediumPurple;
                BtnF7.BackColor = Color.MediumPurple;
            }
        }

        private void BtnE6_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "C5-C7-D4-D8-F4-F8-G5-G7 KARELERİNE GİDEBİLİR";
            if (BtnE6.Enabled == true)
            {
                BtnC5.BackColor = Color.MediumSlateBlue;
                BtnC7.BackColor = Color.MediumSlateBlue;
                BtnD4.BackColor = Color.MediumSlateBlue;
                BtnD8.BackColor = Color.MediumSlateBlue;
                BtnF4.BackColor = Color.MediumSlateBlue;
                BtnF8.BackColor = Color.MediumSlateBlue;
                BtnG5.BackColor = Color.MediumSlateBlue;
                BtnG7.BackColor = Color.MediumSlateBlue;
            }
        }

        private void BtnF6_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "D5-D7-E4-E8-G4-G8-H5-H7 KARELERİNE GİDEBİLİR";
            if (BtnF6.Enabled == true)
            {
                BtnD5.BackColor = Color.MediumSpringGreen;
                BtnD7.BackColor = Color.MediumSpringGreen;
                BtnE4.BackColor = Color.MediumSpringGreen;
                BtnE8.BackColor = Color.MediumSpringGreen;
                BtnG4.BackColor = Color.MediumSpringGreen;
                BtnG8.BackColor = Color.MediumSpringGreen;
                BtnH5.BackColor = Color.MediumSpringGreen;
                BtnH7.BackColor = Color.MediumSpringGreen;
            }
        }

        private void BtnG6_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "E5-E7-F4-F8-H4-H8 KARELERİNE GİDEBİLİR";
            if (BtnG6.Enabled == true)
            {
                BtnE5.BackColor = Color.MediumVioletRed;
                BtnE7.BackColor = Color.MediumVioletRed;
                BtnF4.BackColor = Color.MediumVioletRed;
                BtnF8.BackColor = Color.MediumVioletRed;
                BtnH4.BackColor = Color.MediumVioletRed;
                BtnH8.BackColor = Color.MediumVioletRed;
            }
        }

        private void BtnH6_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "F5-F7-G4-G8 KARELERİNE GİDEBİLİR";
            if (BtnH6.Enabled == true)
            {
                BtnF5.BackColor = Color.MidnightBlue;
                BtnF7.BackColor = Color.MidnightBlue;
                BtnG4.BackColor = Color.MidnightBlue;
                BtnG8.BackColor = Color.MidnightBlue;
            }
        }

        private void BtnA7_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "B5-C6-C8 KARELERİNE GİDEBİLİR";
            if (BtnA7.Enabled == true)
            {
                BtnB5.BackColor = Color.MistyRose;
                BtnC6.BackColor = Color.MistyRose;
                BtnC8.BackColor = Color.MistyRose;
            }
        }

        private void BtnB7_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "A5-C5-D6-D8 KARELERİNE GİDEBİLİR";
            if (BtnB7.Enabled == true)
            {
                BtnA5.BackColor = Color.Moccasin;
                BtnC5.BackColor = Color.Moccasin;
                BtnD6.BackColor = Color.Moccasin;
                BtnD8.BackColor = Color.Moccasin;
            }
        }

        private void BtnC7_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "A6-A8-B5-D5-E6-E8 KARELERİNE GİDEBİLİR";
            if (BtnC7.Enabled == true)
            {
                BtnA6.BackColor = Color.NavajoWhite;
                BtnA8.BackColor = Color.NavajoWhite;
                BtnB5.BackColor = Color.NavajoWhite;
                BtnD5.BackColor = Color.NavajoWhite;
                BtnE6.BackColor = Color.NavajoWhite;
                BtnE8.BackColor = Color.NavajoWhite;
            }
        }

        private void BtnD7_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "B6-B8-C5-E5-F6-F8 KARELERİNE GİDEBİLİR";
            if (BtnD7.Enabled == true)
            {
                BtnB6.BackColor = Color.Aquamarine;
                BtnB8.BackColor = Color.Aquamarine;
                BtnC5.BackColor = Color.Aquamarine;
                BtnE5.BackColor = Color.Aquamarine;
                BtnF6.BackColor = Color.Aquamarine;
                BtnF8.BackColor = Color.Aquamarine;
            }
        }

        private void BtnE7_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "C6-C8-D5-F5-G6-G8 KARELERİNE GİDEBİLİR";
            if (BtnE7.Enabled == true)
            {
                BtnC6.BackColor = Color.OliveDrab;
                BtnC8.BackColor = Color.OliveDrab;
                BtnD5.BackColor = Color.OliveDrab;
                BtnF5.BackColor = Color.OliveDrab;
                BtnG6.BackColor = Color.OliveDrab;
                BtnG8.BackColor = Color.OliveDrab;
            }
        }

        private void BtnF7_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "D6-D8-E5-G5-H6-H8 KARELERİNE GİDEBİLİR";
            if (BtnF7.Enabled == true)
            {
                BtnD6.BackColor = Color.OrangeRed;
                BtnD8.BackColor = Color.OrangeRed;
                BtnE5.BackColor = Color.OrangeRed;
                BtnG5.BackColor = Color.OrangeRed;
                BtnH6.BackColor = Color.OrangeRed;
                BtnH8.BackColor = Color.OrangeRed;
            }
        }

        private void BtnG7_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "E6-E8-F5-H5 KARELERİNE GİDEBİLİR";
            if (BtnG7.Enabled == true)
            {
                BtnE6.BackColor = Color.PaleGoldenrod;
                BtnE8.BackColor = Color.PaleGoldenrod;
                BtnF5.BackColor = Color.PaleGoldenrod;
                BtnH5.BackColor = Color.PaleGoldenrod;
            }
        }

        private void BtnH7_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "F6-F8-G5 KARELERİNE GİDEBİLİR";
            if (BtnH7.Enabled == true)
            {
                BtnF6.BackColor = Color.PaleGreen;
                BtnF8.BackColor = Color.PaleGreen;
                BtnG5.BackColor = Color.PaleGreen;
            }
        }

        private void BtnA8_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "B6-C7 KARELERİNE GİDEBİLİR";
            if (BtnA8.Enabled == true)
            {
                BtnB6.BackColor = Color.PaleTurquoise;
                BtnC7.BackColor = Color.PaleTurquoise;
            }
        }

        private void BtnB8_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "A6-C6-D7 KARELERİNE GİDEBİLİR";
            if (BtnB8.Enabled == true)
            {
                BtnA6.BackColor = Color.PaleVioletRed;
                BtnC6.BackColor = Color.PaleVioletRed;
                BtnD7.BackColor = Color.PaleVioletRed;
            }
        }

        private void BtnC8_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "A7-B6-D6-E7 KARELERİNE GİDEBİLİR";
            if (BtnC8.Enabled == true)
            {
                BtnA7.BackColor = Color.PapayaWhip;
                BtnB6.BackColor = Color.PapayaWhip;
                BtnD6.BackColor = Color.PapayaWhip;
                BtnE7.BackColor = Color.PapayaWhip;
            }
        }

        private void BtnD8_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "B7-C6-E6-F7 KARELERİNE GİDEBİLİR";
            if (BtnD8.Enabled == true)
            {
                BtnB7.BackColor = Color.PeachPuff;
                BtnC6.BackColor = Color.PeachPuff;
                BtnE6.BackColor = Color.PeachPuff;
                BtnF7.BackColor = Color.PeachPuff;
            }
        }

        private void BtnE8_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "C7-D6-F6-G7 KARELERİNE GİDEBİLİR";
            if (BtnE8.Enabled == true)
            {
                BtnC7.BackColor = Color.Peru;
                BtnD6.BackColor = Color.Peru;
                BtnF6.BackColor = Color.Peru;
                BtnG7.BackColor = Color.Peru;
            }
        }

        private void BtnF8_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "D7-E6-G6-H7 KARELERİNE GİDEBİLİR";
            if (BtnF8.Enabled == true)
            {
                BtnD7.BackColor = Color.PowderBlue;
                BtnE6.BackColor = Color.PowderBlue;
                BtnG6.BackColor = Color.PowderBlue;
                BtnH7.BackColor = Color.PowderBlue;
            }
        }

        private void BtnG8_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "E7-F6-H6 KARELERİNE GİDEBİLİR";
            if (BtnG8.Enabled == true)
            {
                BtnE7.BackColor = Color.Purple;
                BtnF6.BackColor = Color.Purple;
                BtnH6.BackColor = Color.Purple;
            }
        }

        private void BtnH8_Click(object sender, EventArgs e)
        {
            RENK();
            TxtSonuc.Text = "F7-G6 KARELERİNE GİDEBİLİR";
            if (BtnH8.Enabled == true)
            {
                BtnF7.BackColor = Color.RosyBrown;
                BtnG6.BackColor = Color.RosyBrown;
            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNereyeOynar_Click(object sender, EventArgs e)
        {
            /*String olarak deger tanımlayıp txtdeger'in boş olup olmadığın kontrol ettiriyorum
             * eğer boş ise buton nereye oynar'a tıklandığında ekrana mesaj yazdırıyorum.*/
            string deger = TxtDegerGir.Text;
            if (deger == "")
            {
                MessageBox.Show("Lütfen AT'ın Bulunduğu Konum Değerini Giriniz");
            }
                /*Eğer ilk koşul sağlanmıyorsa diğer koşullarıma uygun olan işlemi gerçeklekleştirmesi için
                 * değilse eğer koşullarıyla yazılan veriye göre istenilen durumu txt.text'ime yazdırıyorum*/
            else if (deger == "A1" || deger == "a1")
            {
                RENK();/*butonun ilk rengini çağırıyorum*/
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "B3-C2 KARELERİNE GİDEBİLİR";
                BtnB3.BackColor = Color.Azure;/*gidilen karelerin renkleri değişmesi için bu kodumu yazıyorum.*/
                BtnC2.BackColor = Color.Azure;
            }
            else if (deger == "A2" || deger == "a2")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "A3-C3-D2 KARELERİNE GİDEBİLİR";
                BtnA3.BackColor = Color.AliceBlue;
                BtnC3.BackColor = Color.AliceBlue;
                BtnD2.BackColor = Color.AliceBlue;
            }
            else if (deger == "A3" || deger == "a3")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "B1-C2-C4-B5 KARELERİNE GİDEBİLİR";
                BtnB1.BackColor = Color.Aqua;
                BtnC2.BackColor = Color.Aqua;
                BtnC4.BackColor = Color.Aqua;
                BtnB5.BackColor = Color.Aqua;
            }
            else if (deger == "A4" || deger == "a4")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "B2-B6-C3-C5 KARELERİNE GİDEBİLİR";
                BtnB2.BackColor = Color.Aquamarine;
                BtnB6.BackColor = Color.Aquamarine;
                BtnC3.BackColor = Color.Aquamarine;
                BtnC5.BackColor = Color.Aquamarine;
            }
            else if (deger == "A5" || deger == "a5")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "B3-B7-C4-C6 KARELERİNE GİDEBİLİR";
                BtnB3.BackColor = Color.Beige;
                BtnB7.BackColor = Color.Beige;
                BtnC4.BackColor = Color.Beige;
                BtnC6.BackColor = Color.Beige;
            }
            else if (deger == "A6" || deger == "a6")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "B4-B8-C5-C7 KARELERİNE GİDEBİLİR";
                BtnB4.BackColor = Color.Bisque;
                BtnB8.BackColor = Color.Bisque;
                BtnC5.BackColor = Color.Bisque;
                BtnC7.BackColor = Color.Bisque;
            }
            else if (deger == "A7" || deger == "a7")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "B5-C6-C8 KARELERİNE GİDEBİLİR";
                BtnB5.BackColor = Color.BlanchedAlmond;
                BtnC6.BackColor = Color.BlanchedAlmond;
                BtnC8.BackColor = Color.BlanchedAlmond;
            }
            else if (deger == "A8" || deger == "a8")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "B6-C7 KARELERİNE GİDEBİLİR";
                BtnB6.BackColor = Color.BlueViolet;
                BtnC7.BackColor = Color.BlueViolet;
            }
            else if (deger == "B1" || deger == "B1")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "A3-C3-D2 KARELERİNE GİDEBİLİR";
                BtnA3.BackColor = Color.Brown;
                BtnC3.BackColor = Color.Brown;
                BtnD2.BackColor = Color.Brown;
            }
            else if (deger == "B2" || deger == "b2")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "A4-C4-D1-D3 KARELERİNE GİDEBİLİR";
                BtnA4.BackColor = Color.BurlyWood;
                BtnC4.BackColor = Color.BurlyWood;
                BtnD1.BackColor = Color.BurlyWood;
                BtnD3.BackColor = Color.BurlyWood;
            }
            else if (deger == "B3" || deger == "b3")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "A1-A5-C1-C5-D2-D4 KARELERİNE GİDEBİLİR";
                BtnA1.BackColor = Color.CadetBlue;
                BtnA5.BackColor = Color.CadetBlue;
                BtnC1.BackColor = Color.CadetBlue;
                BtnC5.BackColor = Color.CadetBlue;
                BtnD2.BackColor = Color.CadetBlue;
                BtnD4.BackColor = Color.CadetBlue;
            }
            else if (deger == "B4" || deger == "b4")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "A2-A6-C2-C6-D3-D5 KARELERİNE GİDEBİLİR";
                BtnA2.BackColor = Color.Chartreuse;
                BtnA6.BackColor = Color.Chartreuse;
                BtnC2.BackColor = Color.Chartreuse;
                BtnC6.BackColor = Color.Chartreuse;
                BtnD3.BackColor = Color.Chartreuse;
                BtnD5.BackColor = Color.Chartreuse;
            }
            else if (deger == "B5" || deger == "b5")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "A3-A7-C3-C7-D4-D6 KARELERİNE GİDEBİLİR";
                BtnA3.BackColor = Color.Chocolate;
                BtnA7.BackColor = Color.Chocolate;
                BtnC3.BackColor = Color.Chocolate;
                BtnC7.BackColor = Color.Chocolate;
                BtnD4.BackColor = Color.Chocolate;
                BtnD6.BackColor = Color.Chocolate;
            }
            else if (deger == "B6" || deger == "b6")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "A4-A8-C4-C8-D5-D7 KARELERİNE GİDEBİLİR";
                BtnA4.BackColor = Color.Coral;
                BtnA8.BackColor = Color.Coral;
                BtnC4.BackColor = Color.Coral;
                BtnC8.BackColor = Color.Coral;
                BtnD5.BackColor = Color.Coral;
                BtnD7.BackColor = Color.Coral;
            }
            else if (deger == "B7" || deger == "b7")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "A5-C5-D6-D8 KARELERİNE GİDEBİLİR";
                BtnA5.BackColor = Color.CornflowerBlue;
                BtnC5.BackColor = Color.CornflowerBlue;
                BtnD6.BackColor = Color.CornflowerBlue;
                BtnD8.BackColor = Color.CornflowerBlue;
            }
            else if (deger == "B8" || deger == "b8")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "A6-C6-D7 KARELERİNE GİDEBİLİR";
                BtnA6.BackColor = Color.Cornsilk;
                BtnC6.BackColor = Color.Cornsilk;
                BtnD7.BackColor = Color.Cornsilk;
            }
            else if (deger == "C1" || deger == "c1")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "A2-B3-D3-E2 KARELERİNE GİDEBİLİR";
                BtnA2.BackColor = Color.Crimson;
                BtnB3.BackColor = Color.Crimson;
                BtnD3.BackColor = Color.Crimson;
                BtnE2.BackColor = Color.Crimson;
            }
            else if (deger == "C2" || deger == "c2")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "A1-A3-B4-D4-E1-E3 KARELERİNE GİDEBİLİR";
                BtnA1.BackColor = Color.Cyan;
                BtnA3.BackColor = Color.Cyan;
                BtnB4.BackColor = Color.Cyan;
                BtnD4.BackColor = Color.Cyan;
                BtnE1.BackColor = Color.Cyan;
                BtnE3.BackColor = Color.Cyan;
            }
            else if (deger == "C3" || deger == "c3")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "A2-A4-B1-B5-D1-D5-E2-E4 KARELERİNE GİDEBİLİR";
                BtnA2.BackColor = Color.DarkBlue;
                BtnA4.BackColor = Color.DarkBlue;
                BtnB1.BackColor = Color.DarkBlue;
                BtnB5.BackColor = Color.DarkBlue;
                BtnD1.BackColor = Color.DarkBlue;
                BtnD5.BackColor = Color.DarkBlue;
                BtnE2.BackColor = Color.DarkBlue;
                BtnE4.BackColor = Color.DarkBlue;
            }
            else if (deger == "C4" || deger == "c4")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "A3-A5-B2-B6-D2-D6-E3-E5 KARELERİNE GİDEBİLİR";
                BtnA3.BackColor = Color.Gray;
                BtnA5.BackColor = Color.Gray;
                BtnB2.BackColor = Color.Gray;
                BtnB6.BackColor = Color.Gray;
                BtnD2.BackColor = Color.Gray;
                BtnD6.BackColor = Color.Gray;
                BtnE3.BackColor = Color.Gray;
                BtnE5.BackColor = Color.Gray;
            }
            else if (deger == "C5" || deger == "c5")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "A4-A6-B3-B7-D3-D7-E4-E6 KARELERİNE GİDEBİLİR";
                BtnA4.BackColor = Color.Green;
                BtnA6.BackColor = Color.Green;
                BtnB3.BackColor = Color.Green;
                BtnB7.BackColor = Color.Green;
                BtnD3.BackColor = Color.Green;
                BtnD7.BackColor = Color.Green;
                BtnE4.BackColor = Color.Green;
                BtnE6.BackColor = Color.Green;
            }
            else if (deger == "C6" || deger == "c6")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "A5-A7-B4-B8-D4-D8-E5-E7 KARELERİNE GİDEBİLİR";
                BtnA5.BackColor = Color.Honeydew;
                BtnA7.BackColor = Color.Honeydew;
                BtnB4.BackColor = Color.Honeydew;
                BtnB8.BackColor = Color.Honeydew;
                BtnD4.BackColor = Color.Honeydew;
                BtnD8.BackColor = Color.Honeydew;
                BtnE5.BackColor = Color.Honeydew;
                BtnE7.BackColor = Color.Honeydew;
            }
            else if (deger == "C7" || deger == "c7")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "A6-A8-B5-D5-E6-E8 KARELERİNE GİDEBİLİR";
                BtnA6.BackColor = Color.HotPink;
                BtnA8.BackColor = Color.HotPink;
                BtnA5.BackColor = Color.HotPink;
                BtnD5.BackColor = Color.HotPink;
                BtnE6.BackColor = Color.HotPink;
                BtnE8.BackColor = Color.HotPink;
            }
            else if (deger == "C8" || deger == "c8")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "A7-B6-D6-E7 KARELERİNE GİDEBİLİR";
                BtnA7.BackColor = Color.IndianRed;
                BtnB6.BackColor = Color.IndianRed;
                BtnD6.BackColor = Color.IndianRed;
                BtnE7.BackColor = Color.IndianRed;
            }
            else if (deger == "D1" || deger == "d1")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "B2-C3-E3-F2 KARELERİNE GİDEBİLİR";
                BtnB2.BackColor = Color.Maroon;
                BtnC3.BackColor = Color.Maroon;
                BtnE3.BackColor = Color.Maroon;
                BtnF2.BackColor = Color.Maroon;
            }
            else if (deger == "D2" || deger == "d2")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "B1-B3-C4-E4-F1-F3 KARELERİNE GİDEBİLİR";
                BtnB1.BackColor = Color.MediumAquamarine;
                BtnB3.BackColor = Color.MediumAquamarine;
                BtnC4.BackColor = Color.MediumAquamarine;
                BtnE4.BackColor = Color.MediumAquamarine;
                BtnF1.BackColor = Color.MediumAquamarine;
                BtnF3.BackColor = Color.MediumAquamarine;
            }
            else if (deger == "D3" || deger == "d3")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "B2-B4-C1-C5-E1-E5-F2-F4 KARELERİNE GİDEBİLİR";
                BtnB2.BackColor = Color.MediumBlue;
                BtnB4.BackColor = Color.MediumBlue;
                BtnC1.BackColor = Color.MediumBlue;
                BtnC5.BackColor = Color.MediumBlue;
                BtnE1.BackColor = Color.MediumBlue;
                BtnE5.BackColor = Color.MediumBlue;
                BtnF2.BackColor = Color.MediumBlue;
                BtnF4.BackColor = Color.MediumBlue;
            }
            else if (deger == "D4" || deger == "d4")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "B3-B5-C2-C6-E2-E6-F3-F5 KARELERİNE GİDEBİLİR";
                BtnB3.BackColor = Color.MediumOrchid;
                BtnB5.BackColor = Color.MediumOrchid;
                BtnC2.BackColor = Color.MediumOrchid;
                BtnC6.BackColor = Color.MediumOrchid;
                BtnE2.BackColor = Color.MediumOrchid;
                BtnE6.BackColor = Color.MediumOrchid;
                BtnF3.BackColor = Color.MediumOrchid;
                BtnF5.BackColor = Color.MediumOrchid;
            }
            else if (deger == "D5" || deger == "d5")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "B4-B6-C3-C7-E3-E7-F4-F6 KARELERİNE GİDEBİLİR";
                BtnB4.BackColor = Color.MediumSeaGreen;
                BtnB6.BackColor = Color.MediumSeaGreen;
                BtnC3.BackColor = Color.MediumSeaGreen;
                BtnC7.BackColor = Color.MediumSeaGreen;
                BtnE3.BackColor = Color.MediumSeaGreen;
                BtnE7.BackColor = Color.MediumSeaGreen;
                BtnF4.BackColor = Color.MediumSeaGreen;
                BtnF6.BackColor = Color.MediumSeaGreen;
            }
            else if (deger == "D6" || deger == "d6")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "B5-B7-C4-C8-E4-E8-F5-F7 KARELERİNE GİDEBİLİR";
                BtnB5.BackColor = Color.MediumSlateBlue;
                BtnB7.BackColor = Color.MediumSlateBlue;
                BtnC4.BackColor = Color.MediumSlateBlue;
                BtnC8.BackColor = Color.MediumSlateBlue;
                BtnE4.BackColor = Color.MediumSlateBlue;
                BtnE8.BackColor = Color.MediumSlateBlue;
                BtnF5.BackColor = Color.MediumSlateBlue;
                BtnF7.BackColor = Color.MediumSlateBlue;
            }
            else if (deger == "D7" || deger == "d7")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "B6-B8-C5-E5-F6-F8 KARELERİNE GİDEBİLİR";
                BtnB6.BackColor = Color.MidnightBlue;
                BtnB8.BackColor = Color.MidnightBlue;
                BtnC5.BackColor = Color.MidnightBlue;
                BtnE5.BackColor = Color.MidnightBlue;
                BtnF6.BackColor = Color.MidnightBlue;
                BtnF8.BackColor = Color.MidnightBlue;
            }
            else if (deger == "D8" || deger == "d8")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "B7-C6-E6-F7 KARELERİNE GİDEBİLİR";
                BtnB7.BackColor = Color.MistyRose;
                BtnC6.BackColor = Color.MistyRose;
                BtnE6.BackColor = Color.MistyRose;
                BtnF7.BackColor = Color.MistyRose;
            }
            else if (deger == "E1" || deger == "e1")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "C2-D3-F3-G2 KARELERİNE GİDEBİLİR";
                BtnC2.BackColor = Color.Magenta;
                BtnD3.BackColor = Color.Magenta;
                BtnF3.BackColor = Color.Magenta;
                BtnG2.BackColor = Color.Magenta;
            }
            else if (deger == "E2" || deger == "e2")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "C1-C3-D4-F4-G1-G3 KARELERİNE GİDEBİLİR";
                BtnC1.BackColor = Color.Linen;
                BtnC3.BackColor = Color.Linen;
                BtnD4.BackColor = Color.Linen;
                BtnF4.BackColor = Color.Linen;
                BtnG1.BackColor = Color.Linen;
                BtnG3.BackColor = Color.Linen;
            }
            else if (deger == "E3" || deger == "e3")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "C2-C4-D1-D5-F1-F5-G2-G4 KARELERİNE GİDEBİLİR";
                BtnC2.BackColor = Color.Lime;
                BtnC4.BackColor = Color.Lime;
                BtnD1.BackColor = Color.Lime;
                BtnD5.BackColor = Color.Lime;
                BtnF1.BackColor = Color.Lime;
                BtnF5.BackColor = Color.Lime;
                BtnG2.BackColor = Color.Lime;
                BtnG4.BackColor = Color.Lime;
            }
            else if (deger == "E4" || deger == "e4")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "C3-C5-D2-D6-F2-F6-G3-G5 KARELERİNE GİDEBİLİR";
                BtnC3.BackColor = Color.LemonChiffon;
                BtnC5.BackColor = Color.LemonChiffon;
                BtnD2.BackColor = Color.LemonChiffon;
                BtnD6.BackColor = Color.LemonChiffon;
                BtnF2.BackColor = Color.LemonChiffon;
                BtnF6.BackColor = Color.LemonChiffon;
                BtnG3.BackColor = Color.LemonChiffon;
                BtnG5.BackColor = Color.LemonChiffon;
            }
            else if (deger == "E5" || deger == "e5")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "C4-C6-D3-D7-F3-F7-G4-G6 KARELERİNE GİDEBİLİR";
                BtnC4.BackColor = Color.LavenderBlush;
                BtnC6.BackColor = Color.LavenderBlush;
                BtnD3.BackColor = Color.LavenderBlush;
                BtnD7.BackColor = Color.LavenderBlush;
                BtnF3.BackColor = Color.LavenderBlush;
                BtnF7.BackColor = Color.LavenderBlush;
                BtnG4.BackColor = Color.LavenderBlush;
                BtnG6.BackColor = Color.LavenderBlush;
            }
            else if (deger == "E6" || deger == "e6")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "C5-C7-D4-D8-F4-F8-G5-G7 KARELERİNE GİDEBİLİR";
                BtnC5.BackColor = Color.Lavender;
                BtnC7.BackColor = Color.Lavender;
                BtnD4.BackColor = Color.Lavender;
                BtnD8.BackColor = Color.Lavender;
                BtnF4.BackColor = Color.Lavender;
                BtnF8.BackColor = Color.Lavender;
                BtnG5.BackColor = Color.Lavender;
                BtnG7.BackColor = Color.Lavender;
            }
            else if (deger == "E7" || deger == "e7")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "C6-C8-D5-F5-G6-G8 KARELERİNE GİDEBİLİR";
                BtnC6.BackColor = Color.Ivory;
                BtnC8.BackColor = Color.Ivory;
                BtnD5.BackColor = Color.Ivory;
                BtnF5.BackColor = Color.Ivory;
                BtnG6.BackColor = Color.Ivory;
                BtnG8.BackColor = Color.Ivory;
            }
            else if (deger == "E8" || deger == "e8")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "C7-D6-F6-G7 KARELERİNE GİDEBİLİR";
                BtnC7.BackColor = Color.Indigo;
                BtnD6.BackColor = Color.Indigo;
                BtnF6.BackColor = Color.Indigo;
                BtnG7.BackColor = Color.Indigo;
            }
            else if (deger == "F1" || deger == "f1")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "D2-E3-G3-H2 KARELERİNE GİDEBİLİR";
                BtnD2.BackColor = Color.Gold;
                BtnE3.BackColor = Color.Gold;
                BtnG3.BackColor = Color.Gold;
                BtnH2.BackColor = Color.Gold;
            }
            else if (deger == "F2" || deger == "f2")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "D1-D3-E4-G4-H1-H3 KARELERİNE GİDEBİLİR";
                BtnD1.BackColor = Color.Gainsboro;
                BtnD3.BackColor = Color.Gainsboro;
                BtnE4.BackColor = Color.Gainsboro;
                BtnH1.BackColor = Color.Gainsboro;
                BtnH3.BackColor = Color.Gainsboro;
            }
            else if (deger == "F3" || deger == "f3")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "D2-D4-E1-E5-G1-G5-H2-H4 KARELERİNE GİDEBİLİR";
                BtnD2.BackColor = Color.Fuchsia;
                BtnD4.BackColor = Color.Fuchsia;
                BtnE1.BackColor = Color.Fuchsia;
                BtnE5.BackColor = Color.Fuchsia;
                BtnG1.BackColor = Color.Fuchsia;
                BtnG5.BackColor = Color.Fuchsia;
                BtnH2.BackColor = Color.Fuchsia;
                BtnH4.BackColor = Color.Fuchsia;
            }
            else if (deger == "F4" || deger == "f4")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "D3-D5-E2-E6-G2-G6-H3-H5 KARELERİNE GİDEBİLİR";
                BtnD3.BackColor = Color.ForestGreen;
                BtnD5.BackColor = Color.ForestGreen;
                BtnE2.BackColor = Color.ForestGreen;
                BtnE6.BackColor = Color.ForestGreen;
                BtnG2.BackColor = Color.ForestGreen;
                BtnG6.BackColor = Color.ForestGreen;
                BtnH3.BackColor = Color.ForestGreen;
                BtnH5.BackColor = Color.ForestGreen;
            }
            else if (deger == "F5" || deger == "f5")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "D4-D6-E3-E7-G3-G7-H4-H6 KARELERİNE GİDEBİLİR";
                BtnD4.BackColor = Color.Firebrick;
                BtnD6.BackColor = Color.Firebrick;
                BtnE3.BackColor = Color.Firebrick;
                BtnE7.BackColor = Color.Firebrick;
                BtnG3.BackColor = Color.Firebrick;
                BtnG7.BackColor = Color.Firebrick;
                BtnH4.BackColor = Color.Firebrick;
                BtnH6.BackColor = Color.Firebrick;
            }
            else if (deger == "F6" || deger == "f6")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "D5-D7-E4-E8-G4-G8-H5-H7 KARELERİNE GİDEBİLİR";
                BtnD5.BackColor = Color.DodgerBlue;
                BtnD7.BackColor = Color.DodgerBlue;
                BtnE4.BackColor = Color.DodgerBlue;
                BtnE8.BackColor = Color.DodgerBlue;
                BtnG4.BackColor = Color.DodgerBlue;
                BtnG8.BackColor = Color.DodgerBlue;
                BtnH5.BackColor = Color.DodgerBlue;
                BtnH7.BackColor = Color.DodgerBlue;
            }
            else if (deger == "F7" || deger == "f7")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "D6-D8-E5-G5-H6-H8 KARELERİNE GİDEBİLİR";
                BtnD6.BackColor = Color.DimGray;
                BtnD8.BackColor = Color.DimGray;
                BtnE5.BackColor = Color.DimGray;
                BtnG5.BackColor = Color.DimGray;
                BtnH6.BackColor = Color.DimGray;
                BtnH8.BackColor = Color.DimGray;
            }
            else if (deger == "F8" || deger == "f8")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "D7-E6-G6-H7 KARELERİNE GİDEBİLİR";
                BtnD7.BackColor = Color.DeepSkyBlue;
                BtnE6.BackColor = Color.DeepSkyBlue;
                BtnG6.BackColor = Color.DeepSkyBlue;
                BtnH7.BackColor = Color.DeepSkyBlue;
            }
            else if (deger == "G1" || deger == "g1")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "E2-F3-H3 KARELERİNE GİDEBİLİR";
                BtnE2.BackColor = Color.DeepPink;
                BtnF3.BackColor = Color.DeepPink;
                BtnH3.BackColor = Color.DeepPink;
            }
            else if (deger == "G2" || deger == "g2")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "E1-E3-F4-H4 KARELERİNE GİDEBİLİR";
                BtnE1.BackColor = Color.DarkViolet;
                BtnE3.BackColor = Color.DarkViolet;
                BtnF4.BackColor = Color.DarkViolet;
                BtnH4.BackColor = Color.DarkViolet;
            }
            else if (deger == "G3" || deger == "g3")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "E2-E4-F1-F5-H1-H5 KARELERİNE GİDEBİLİR";
                BtnE2.BackColor = Color.DarkTurquoise;
                BtnE4.BackColor = Color.DarkTurquoise;
                BtnF1.BackColor = Color.DarkTurquoise;
                BtnF5.BackColor = Color.DarkTurquoise;
                BtnH1.BackColor = Color.DarkTurquoise;
                BtnH5.BackColor = Color.DarkTurquoise;
            }
            else if (deger == "G4" || deger == "g4")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "E3-E5-F2-F6-H2-H6 KARELERİNE GİDEBİLİR";
                BtnE3.BackColor = Color.DarkSlateGray;
                BtnE5.BackColor = Color.DarkSlateGray;
                BtnF2.BackColor = Color.DarkSlateGray;
                BtnF6.BackColor = Color.DarkSlateGray;
                BtnH2.BackColor = Color.DarkSlateGray;
                BtnH6.BackColor = Color.DarkSlateGray;
            }
            else if (deger == "G5" || deger == "g5")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "E4-E6-F3-F7-H3-H7 KARELERİNE GİDEBİLİR";
                BtnE4.BackColor = Color.DarkSlateBlue;
                BtnE6.BackColor = Color.DarkSlateBlue;
                BtnF3.BackColor = Color.DarkSlateBlue;
                BtnF7.BackColor = Color.DarkSlateBlue;
                BtnH3.BackColor = Color.DarkSlateBlue;
                BtnH7.BackColor = Color.DarkSlateBlue;
            }
            else if (deger == "G6" || deger == "g6")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "E5-E7-F4-F8-H4-H8 KARELERİNE GİDEBİLİR";
                BtnE5.BackColor = Color.DarkSeaGreen;
                BtnE7.BackColor = Color.DarkSeaGreen;
                BtnF4.BackColor = Color.DarkSeaGreen;
                BtnF8.BackColor = Color.DarkSeaGreen;
                BtnH4.BackColor = Color.DarkSeaGreen;
                BtnH8.BackColor = Color.DarkSeaGreen;
            }
            else if (deger == "G7" || deger == "g7")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "E6-E8-F5-H5 KARELERİNE GİDEBİLİR";
                BtnE6.BackColor = Color.DarkSalmon;
                BtnE8.BackColor = Color.DarkSalmon;
                BtnF5.BackColor = Color.DarkSalmon;
                BtnH5.BackColor = Color.DarkSalmon;
            }
            else if (deger == "G8" || deger == "g8")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "E7-F6-H6 KARELERİNE GİDEBİLİR";
                BtnE7.BackColor = Color.DarkRed;
                BtnF6.BackColor = Color.DarkRed;
                BtnH6.BackColor = Color.DarkRed;
            }
            else if (deger == "H1" || deger == "h1")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "F2-G3 KARELERİNE GİDEBİLİR";
                BtnF2.BackColor = Color.DarkOrchid;
                BtnG3.BackColor = Color.DarkOrchid;
            }
            else if (deger == "H2" || deger == "h2")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "F1-F3-G4 KARELERİNE GİDEBİLİR";
                BtnF1.BackColor = Color.DarkOrange;
                BtnF3.BackColor = Color.DarkOrange;
                BtnG4.BackColor = Color.DarkOrange;
            }
            else if (deger == "H3" || deger == "h3")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "F2-F4-G1-G5 KARELERİNE GİDEBİLİR";
                BtnF2.BackColor = Color.DarkOliveGreen;
                BtnF4.BackColor = Color.DarkOliveGreen;
                BtnG1.BackColor = Color.DarkOliveGreen;
                BtnG5.BackColor = Color.DarkOliveGreen;
            }
            else if (deger == "H4" || deger == "h4")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "F3-F5-G2-G6 KARELERİNE GİDEBİLİR";
                BtnF3.BackColor = Color.DarkMagenta;
                BtnF5.BackColor = Color.DarkMagenta;
                BtnG2.BackColor = Color.DarkMagenta;
                BtnG6.BackColor = Color.DarkMagenta;
            }
            else if (deger == "H5" || deger == "h5")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "F4-F6-G3-G7 KARELERİNE GİDEBİLİR";
                BtnF4.BackColor = Color.DarkKhaki;
                BtnF6.BackColor = Color.DarkKhaki;
                BtnG3.BackColor = Color.DarkKhaki;
                BtnG7.BackColor = Color.DarkKhaki;
            }
            else if (deger == "H6" || deger == "h6")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "F5-F7-G4-G8 KARELERİNE GİDEBİLİR";
                BtnF5.BackColor = Color.DarkGreen;
                BtnF7.BackColor = Color.DarkGreen;
                BtnG4.BackColor = Color.DarkGreen;
                BtnG8.BackColor = Color.DarkGreen;
            }
            else if (deger == "H7" || deger == "h7")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "F6-F8-G5 KARELERİNE GİDEBİLİR";
                BtnF6.BackColor = Color.DarkGoldenrod;
                BtnF8.BackColor = Color.DarkGoldenrod;
                BtnG5.BackColor = Color.DarkGoldenrod;
            }
            else if (deger == "H8" || deger == "h8")
            {
                RENK();
                TxtNereyeOynar.Clear();
                TxtNereyeOynar.Text = "F7-G6 KARELERİNE GİDEBİLİR";
                BtnF7.BackColor = Color.DarkCyan;
                BtnG6.BackColor = Color.DarkCyan;
            }
        }
        private void RENK()
        {
            /*Kareleri ilk haline getirebilmek için karelerin renklerini 64 adet butonun kendi ilk renklerini burada tanımlıyorum*/
            BtnA1.BackColor = Color.White;
            BtnA2.BackColor = Color.Black;
            BtnA3.BackColor = Color.White;
            BtnA4.BackColor = Color.Black;
            BtnA5.BackColor = Color.White;
            BtnA6.BackColor = Color.Black;
            BtnA7.BackColor = Color.White;
            BtnA8.BackColor = Color.Black;
            BtnB1.BackColor = Color.Black;
            BtnB2.BackColor = Color.White;
            BtnB3.BackColor = Color.Black;
            BtnB4.BackColor = Color.White;
            BtnB5.BackColor = Color.Black;
            BtnB6.BackColor = Color.White;
            BtnB7.BackColor = Color.Black;
            BtnB8.BackColor = Color.White;
            BtnC1.BackColor = Color.White;
            BtnC2.BackColor = Color.Black;
            BtnC3.BackColor = Color.White;
            BtnC4.BackColor = Color.Black;
            BtnC5.BackColor = Color.White;
            BtnC6.BackColor = Color.Black;
            BtnC7.BackColor = Color.White;
            BtnC8.BackColor = Color.Black;
            BtnD1.BackColor = Color.Black;
            BtnD2.BackColor = Color.White;
            BtnD3.BackColor = Color.Black;
            BtnD4.BackColor = Color.White;
            BtnD5.BackColor = Color.Black;
            BtnD6.BackColor = Color.White;
            BtnD7.BackColor = Color.Black;
            BtnD8.BackColor = Color.White;
            BtnE1.BackColor = Color.White;
            BtnE2.BackColor = Color.Black;
            BtnE3.BackColor = Color.White;
            BtnE4.BackColor = Color.Black;
            BtnE5.BackColor = Color.White;
            BtnE6.BackColor = Color.Black;
            BtnE7.BackColor = Color.White;
            BtnE8.BackColor = Color.Black;
            BtnF1.BackColor = Color.Black;
            BtnF2.BackColor = Color.White;
            BtnF3.BackColor = Color.Black;
            BtnF4.BackColor = Color.White;
            BtnF5.BackColor = Color.Black;
            BtnF6.BackColor = Color.White;
            BtnF7.BackColor = Color.Black;
            BtnF8.BackColor = Color.White;
            BtnG1.BackColor = Color.White;
            BtnG2.BackColor = Color.Black;
            BtnG3.BackColor = Color.White;
            BtnG4.BackColor = Color.Black;
            BtnG5.BackColor = Color.White;
            BtnG6.BackColor = Color.Black;
            BtnG7.BackColor = Color.White;
            BtnG8.BackColor = Color.Black;
            BtnH1.BackColor = Color.Black;
            BtnH2.BackColor = Color.White;
            BtnH3.BackColor = Color.Black;
            BtnH4.BackColor = Color.White;
            BtnH5.BackColor = Color.Black;
            BtnH6.BackColor = Color.White;
            BtnH7.BackColor = Color.Black;
            BtnH8.BackColor = Color.White;
        }

        private void SATRANCOYUNU_Load(object sender, EventArgs e)
        {

        }
    }
}

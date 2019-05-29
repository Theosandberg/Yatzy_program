using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yatzy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //summera poäng
        private void BtnSummera_Click(object sender, EventArgs e) //Om man Kilckar på knappen BtnSummera utförs detta.
        {
            //spelare 1 summa innan bonus
            //summera poäng
            //Spelare 1
            int Spelare1kontroll = int.Parse(tbxEttorEtt.Text); //Kontroll utav spelare 1
            if (Spelare1kontroll > -0.01) //kontrollerar om spelaren är med eller inte, får ej vara mindre än 0 i Rutan.
            {
                //Ettor 
                int ettor1 = int.Parse(tbxEttorEtt.Text); //Hämtar poäng från textbox
                //Tvåor
                int tvåor1 = int.Parse(tbxTvåorEtt.Text); //Hämtar poäng från textbox
                //Treor
                int treor1 = int.Parse(tbxTreorEtt.Text); //Hämtar poäng från textbox
                //Fyror
                int fyror1 = int.Parse(tbxFyrorEtt.Text); //Hämtar poäng från textbox
                //Femmor
                int femmor1 = int.Parse(tbxFemmorEtt.Text); //Hämtar poäng från textbox
                //Femmor
                int sexor1 = int.Parse(tbxSexorEtt.Text); //Hämtar poäng från textbox

                int svarSpelare1 = ettor1 + tvåor1 + treor1 + fyror1 + femmor1 + sexor1; //Plussar ihop alla summor

                lblSumma11.Text = svarSpelare1.ToString(); //Printar summan i label

                if (svarSpelare1 > 63) //Om spelaren har mer än 63 poäng ska bonus ges (50 poäng).
                {
                    int bonus1 = 50; //Lägger till 50 poäng i label
                    lblBonus1.Text = bonus1.ToString(); //Printar bonus i label

                }
            }

            //spelare 2 summa innan bonus
            //summera poäng
            //Spelare 2
            int Spelare2kontroll = int.Parse(tbxEttorTvå.Text); //Kontroll utav spelare 2
            if (Spelare2kontroll > -0.01) //kontrollerar om spelaren är med eller inte, får ej vara mindre än 0 i Rutan.
            {
                //Ettor 
                int ettor2 = int.Parse(tbxEttorTvå.Text); //Hämtar poäng från textbox
                //Tvåor
                int tvåor2 = int.Parse(tbxTvåorTvå.Text); //Hämtar poäng från textbox
                //Treor
                int treor2 = int.Parse(tbxTreorTvå.Text); //Hämtar poäng från textbox
                //Fyror
                int fyror2 = int.Parse(tbxFyrorTvå.Text); //Hämtar poäng från textbox
                //Femmor
                int femmor2 = int.Parse(tbxFemmorTvå.Text); //Hämtar poäng från textbox
                //Sexor
                int sexor2 = int.Parse(tbxSexorTvå.Text); //Hämtar poäng från textbox

                int svarSpelare2 = ettor2 + tvåor2 + treor2 + fyror2 + femmor2 + sexor2; //Plussar ihop alla summor

                lblSumma12.Text = svarSpelare2.ToString(); //Printar summan i label

                if (svarSpelare2 > 63) //Om spelaren har mer än 63 poäng ska bonus ges (50 poäng).
                {
                    int bonus2 = 50; //Lägger till 50 poäng i label
                    lblBonus2.Text = bonus2.ToString(); //Printar bonus i label
                }

                //spelare 3 summa innan bonus
                //summera poäng
                //Spelare 3
                int Spelare3kontroll = int.Parse(tbxEttorTre.Text); //Kontroll utav spelare 3
                if (Spelare3kontroll > -0.01) //kontrollerar om spelaren är med eller inte, får ej vara mindre än 0 i Rutan.
                {
                    //Ettor 
                    int ettor3 = int.Parse(tbxEttorTre.Text); //Hämtar poäng från textbox
                    //Tvåor
                    int tvåor3 = int.Parse(tbxTvåorTre.Text); //Hämtar poäng från textbox
                    //Treor
                    int treor3 = int.Parse(tbxTreorTre.Text); //Hämtar poäng från textbox
                    //Fyror
                    int fyror3 = int.Parse(tbxFyrorTre.Text); //Hämtar poäng från textbox
                    //Femmor
                    int femmor3 = int.Parse(tbxFemmorTre.Text); //Hämtar poäng från textbox
                    //Sexor
                    int sexor3 = int.Parse(tbxSexorTre.Text); //Hämtar poäng från textbox

                    int svarSpelare3 = ettor3 + tvåor3 + treor3 + fyror3 + femmor3 + sexor3; //Plussar ihop alla summor

                    lblSumma13.Text = svarSpelare3.ToString(); //Printar summan i label

                    if (svarSpelare3 > 63) //Om spelaren har mer än 63 poäng ska bonus ges (50 poäng).
                    {
                        int bonus3 = 50; //Lägger till 50 poäng i label
                        lblBonus3.Text = bonus3.ToString(); //Printar bonus i label
                    }
                }
                //spelare 4 summa innan bonus
                //summera poäng   
                //Spelare 4
                int Spelare4kontroll = int.Parse(tbxEttorFyra.Text); //Kontroll utav spelare 4
                if (Spelare4kontroll > -0.01) //kontrollerar om spelaren är med eller inte, får ej vara mindre än 0 i Rutan.
                {
                    //Ettor 
                    int ettor4 = int.Parse(tbxEttorFyra.Text); //Hämtar poäng från textbox
                    //Tvåor
                    int tvåor4 = int.Parse(tbxTvåorFyra.Text); //Hämtar poäng från textbox
                    //Treor
                    int treor4 = int.Parse(tbxTreorFyra.Text); //Hämtar poäng från textbox
                    //Fyror
                    int fyror4 = int.Parse(tbxFyrorFyra.Text); //Hämtar poäng från textbox
                    //Femmor
                    int femmor4 = int.Parse(tbxFemmorFyra.Text); //Hämtar poäng från textbox
                    //Sexor
                    int sexor4 = int.Parse(tbxSexorFyra.Text); //Hämtar poäng från textbox

                    int svarSpelare4 = ettor4 + tvåor4 + treor4 + fyror4 + femmor4 + sexor4;//Plussar ihop alla summor

                    lblSumma14.Text = svarSpelare4.ToString(); //Printar summan i label

                    if (svarSpelare4 > 63) //Om spelaren har mer än 63 poäng ska bonus ges (50 poäng).
                    {
                        int bonus4 = 50; //Lägger till 50 poäng i label
                        lblBonus4.Text = bonus4.ToString(); //Printar bonus i label
                    }
                }


            }

        }

        private void BtnSummeraAllt_Click(object sender, EventArgs e) //Om man klickar på knappen BtnSummeraAllt utförs detta.
        {
            //summera poäng efter bonus och räknar ihop allt till en slutsumma.
            //Spelare 1
            int Spelare1kontroll = int.Parse(tbxEttorEtt.Text); //Kontroll utav spelare 1
            if (Spelare1kontroll > -0.01) //kontrollerar om spelaren är med eller inte, får ej vara mindre än 0 i Rutan.
            {
                //Ett Par
                int EttPar1 = int.Parse(tbx1Par1.Text); //Hämtar poäng från textbox
                //Två Par
                int TvåPar1 = int.Parse(tbx2Par1.Text); //Hämtar poäng från textbox
                //Tretal
                int Tretal1 = int.Parse(tbx3Tal1.Text); //Hämtar poäng från textbox
                //Fyrtal
                int Fyrtal1 = int.Parse(tbx4Tal1.Text); //Hämtar poäng från textbox
                //Kåk
                int Kak1 = int.Parse(tbxKak1.Text); //Hämtar poäng från textbox
                //Liten Stege
                int LS1 = int.Parse(tbxLS1.Text); //Hämtar poäng från textbox
                //Stor Stege
                int SS1 = int.Parse(tbxLS1.Text); //Hämtar poäng från textbox
                //Chans
                int Chans1 = int.Parse(tbxChans1.Text); //Hämtar poäng från textbox
                //Yatzy
                int Yatzy1 = int.Parse(tbxYatzy1.Text); //Hämtar poäng från textbox


                //Steg1
                int SummaDel1 = int.Parse(lblSumma11.Text); //Hämtar summan från label i steg 1
                int Bonus11 = int.Parse(lblBonus1.Text); //Hämtar bonusen om spelaren har fått bonus ifrån steg 1, hämtas ifrån bonus label
                int svarSpelare11 = EttPar1 + TvåPar1 + Tretal1 + Fyrtal1 + Kak1 + LS1 + SS1 + Chans1 + Yatzy1 + SummaDel1 + Bonus11;//Plussar ihop alla summor

                lblSummaA1.Text = svarSpelare11.ToString(); //Printar summan i lblSummaA1


            }
            //summera poäng efter bonus
            //Spelare 2
            int Spelare2kontroll = int.Parse(tbxEttorTvå.Text); //Kontroll utav spelare 2
            if (Spelare2kontroll > -0.01) //kontrollerar om spelaren är med eller inte, får ej vara mindre än 0 i Rutan.
            {
                //Ett Par
                int EttPar2 = int.Parse(tbx1Par2.Text); //Hämtar poäng från textbox
                //Två Par
                int TvåPar2 = int.Parse(tbx2Par2.Text); //Hämtar poäng från textbox
                //Tretal
                int Tretal2 = int.Parse(tbx3Tal2.Text); //Hämtar poäng från textbox
                //Fyrtal
                int Fyrtal2 = int.Parse(tbx4Tal2.Text); //Hämtar poäng från textbox
                //Kåk
                int Kak2 = int.Parse(tbxkak2.Text); //Hämtar poäng från textbox
                //Liten Stege
                int LS2 = int.Parse(tbxLS2.Text); //Hämtar poäng från textbox 
                //Stor Stege
                int SS2 = int.Parse(tbxLS2.Text); //Hämtar poäng från textbox
                //Chans
                int Chans2 = int.Parse(tbxChans2.Text); //Hämtar poäng från textbox
                //Yatzy
                int Yatzy2 = int.Parse(tbxYatzy2.Text); //Hämtar poäng från textbox

                //steg1
                int SummaDel2 = int.Parse(lblSumma12.Text); //Hämtar summan från label i steg 1
                int Bonus22 = int.Parse(lblBonus2.Text); //Hämtar bonusen om spelaren har fått bonus ifrån steg 1, hämtas ifrån bonus label
                int svarSpelare22 = EttPar2 + TvåPar2 + Tretal2 + Fyrtal2 + Kak2 + LS2 + SS2 + Chans2 + Yatzy2 + SummaDel2 + Bonus22;//Plussar ihop alla summor

                lblSummaA2.Text = svarSpelare22.ToString(); //Printar summan i lblSummaA2

               
            }
            //summera poäng efter bonus
            //Spelare 3
            int Spelare1kontro33 = int.Parse(tbxEttorTre.Text); //Kontroll utav spelare 3
            if (Spelare1kontro33 > -0.01) //kontrollerar om spelaren är med eller inte, får ej vara mindre än 0 i Rutan.
            {
                //Ett Par
                int EttPar3 = int.Parse(tbx1Par3.Text); //Hämtar poäng från textbox
                //Två Par
                int TvåPar3 = int.Parse(tbx2Par3.Text); //Hämtar poäng från textbox
                //Tretal
                int Tretal3 = int.Parse(tbx3Tal3.Text); //Hämtar poäng från textbox
                //Fyrtal
                int Fyrtal3 = int.Parse(tbx4Tal3.Text); //Hämtar poäng från textbox
                //Kåk
                int Kak3 = int.Parse(tbxKak3.Text); //Hämtar poäng från textbox
                //Liten Stege
                int LS3 = int.Parse(tbxLS3.Text); //Hämtar poäng från textbox
                //Stor Stege
                int SS3 = int.Parse(tbxLS3.Text); //Hämtar poäng från textbox
                //Chans
                int Chans3 = int.Parse(tbxChans3.Text); //Hämtar poäng från textbox
                //Yatzy
                int Yatzy3 = int.Parse(tbxYatzy3.Text); //Hämtar poäng från textbox

                //steg1
                int SummaDel3 = int.Parse(lblSumma13.Text); //Hämtar summan från label i steg 1
                int Bonus33 = int.Parse(lblBonus3.Text); //Hämtar bonusen om spelaren har fått bonus ifrån steg 1, hämtas ifrån bonus label
                int svarSpelare33 = EttPar3 + TvåPar3 + Tretal3 + Fyrtal3 + Kak3 + LS3 + SS3 + Chans3 + Yatzy3 + SummaDel3 + Bonus33;//Plussar ihop alla summor

                lblSummaA3.Text = svarSpelare33.ToString(); //Printar summan i lblSummaA3


            }
            //summera poäng efter bonus
            //Spelare 4
            int Spelare4kontroll = int.Parse(tbxEttorFyra.Text); //Kontroll utav spelare 4
            if (Spelare4kontroll > -0.01) //kontrollerar om spelaren är med eller inte, får ej vara mindre än 0 i Rutan.
            {
                //Ett Par
                int EttPar4 = int.Parse(tbx1Par4.Text); //Hämtar poäng från textbox
                //Två Par
                int TvåPar4 = int.Parse(tbx2Par4.Text); //Hämtar poäng från textbox
                //Tretal
                int Tretal4 = int.Parse(tbx3Tal4.Text); //Hämtar poäng från textbox
                //Fyrtal
                int Fyrtal4 = int.Parse(tbx4Tal4.Text); //Hämtar poäng från textbox
                //Kåk
                int Kak4 = int.Parse(tbxKak4.Text); //Hämtar poäng från textbox
                //Liten Stege
                int LS4 = int.Parse(tbxLS4.Text); //Hämtar poäng från textbox
                //Stor Stege
                int SS4 = int.Parse(tbxLS4.Text); //Hämtar poäng från textbox
                //Chans
                int Chans4 = int.Parse(tbxChans4.Text); //Hämtar poäng från textbox
                //Yatzy
                int Yatzy4 = int.Parse(tbxYatzy4.Text); //Hämtar poäng från textbox

                //steg1
                int SummaDel4 = int.Parse(lblSumma14.Text); //Hämtar summan från label i steg 1
                int Bonus44 = int.Parse(lblBonus4.Text); //Hämtar bonusen om spelaren har fått bonus ifrån steg 1, hämtas ifrån bonus label
                int svarSpelare44 = EttPar4 + TvåPar4 + Tretal4 + Fyrtal4 + Kak4 + LS4 + SS4 + Chans4 + Yatzy4 + SummaDel4 + Bonus44;//Plussar ihop alla summor

                lblSummaA4.Text = svarSpelare44.ToString(); //Printar Summan i lblSummaA4


            }












        }
        //Tärningskod
        private void BtnSlå_Click(object sender, EventArgs e) //Vid klick på knappen BtnSlå utförs detta
        {




            Random r = new Random(); //Random

            int iRnd = new int(); //definerar iRnd
            if (cB1.Checked)  //Låser tärningen
            {
                //Tom efterssom att tärningen inte ska rullas då cB1 är ikryssad.
            }
            else //Om tärningen inte är ikryssad utförs detta
            {
                //Tärning 1

                iRnd = r.Next(0, 6); //Slumpar tärningen mellan numrena 1 till 6.
                //pB#Dold innehåller bilder på alla sidor i tärningen, är dold och används för att hämta bilder in i tärningsrutorna.
                if (iRnd == 0)
                    pB1.Image = pB1Dold.Image; //Byter till bilden pB1Dold i ruta 1 om iRnd = 0
                else if (iRnd == 1)
                    pB1.Image = pB2Dold.Image; //Byter till bilden pB2Dold i ruta 1 om iRnd = 1
                else if (iRnd == 2)
                    pB1.Image = pB3Dold.Image; //Byter till bilden pB3Dold i ruta 1 om iRnd = 2
                else if (iRnd == 3)
                    pB1.Image = pB4Dold.Image; //Byter till bilden pB4Dold i ruta 1 om iRnd = 3
                else if (iRnd == 4)
                    pB1.Image = pB5Dold.Image; //Byter till bilden pB5Dold i ruta 1 om iRnd = 4
                else
                    pB1.Image = pB6Dold.Image; //Byter till bilden pB1Dold i ruta 1 om iRnd är något annat.
            }


            if (cB2.Checked)  //Låser tärningen
            {
                //Tom efterssom att tärningen inte ska rullas då cB2 är ikryssad.
            }
            else //Om tärningen inte är ikryssad utförs detta
            {
                //Tärning 2
                iRnd = r.Next(0, 6); //Slumpar tärningen mellan numrena 1 till 6.
                //pB#Dold innehåller bilder på alla sidor i tärningen, är dold och används för att hämta bilder in i tärningsrutorna.
                if (iRnd == 0)
                    pB2.Image = pB1Dold.Image; //Byter till bilden pB1Dold i ruta 2 om iRnd = 0
                else if (iRnd == 1)
                    pB2.Image = pB2Dold.Image; //Byter till bilden pB2Dold i ruta 2 om iRnd = 1
                else if (iRnd == 2)
                    pB2.Image = pB3Dold.Image; //Byter till bilden pB3Dold i ruta 2 om iRnd = 2
                else if (iRnd == 3)
                    pB2.Image = pB4Dold.Image; //Byter till bilden pB4Dold i ruta 2 om iRnd = 3
                else if (iRnd == 4)
                    pB2.Image = pB5Dold.Image; //Byter till bilden pB5Dold i ruta 2 om iRnd = 4
                else
                    pB2.Image = pB6Dold.Image; //Byter till bilden pB6Dold i ruta 2 om iRnd är något annat.

            }


            if (cB3.Checked)  //Låser tärningen
            {
                //Tom efterssom att tärningen inte ska rullas då cB3 är ikryssad.
            }
            else //Om tärningen inte är ikryssad utförs detta
            {
                //Tärning 3
                iRnd = r.Next(0, 6); //Slumpar tärningen mellan numrena 1 till 6.
                //pB#Dold innehåller bilder på alla sidor i tärningen, är dold och används för att hämta bilder in i tärningsrutorna.
                if (iRnd == 0)
                    pB3.Image = pB1Dold.Image; //Byter till bilden pB1Dold i ruta 3 om iRnd = 0
                else if (iRnd == 1)
                    pB3.Image = pB2Dold.Image; //Byter till bilden pB2Dold i ruta 3 om iRnd = 1
                else if (iRnd == 2)
                    pB3.Image = pB3Dold.Image; //Byter till bilden pB3Dold i ruta 3 om iRnd = 2
                else if (iRnd == 3)
                    pB3.Image = pB4Dold.Image; //Byter till bilden pB4Dold i ruta 3 om iRnd = 3
                else if (iRnd == 4)
                    pB3.Image = pB5Dold.Image; //Byter till bilden pB5Dold i ruta 3 om iRnd = 4
                else
                    pB3.Image = pB6Dold.Image; //Byter till bilden pB6Dold i ruta 3 om iRnd är något annat.
            }


            if (cB4.Checked) //Låser tärningen
            {
                //Tom efterssom att tärningen inte ska rullas då cB4 är ikryssad.
            }
            else //Om tärningen inte är ikryssad utförs detta
            {
                //Tärning 4
                iRnd = r.Next(0, 6); //Slumpar tärningen mellan numrena 1 till 6.
                //pB#Dold innehåller bilder på alla sidor i tärningen, är dold och används för att hämta bilder in i tärningsrutorna.
                if (iRnd == 0)
                    pB4.Image = pB1Dold.Image; //Byter till bilden pB1Dold i ruta 4 om iRnd = 0
                else if (iRnd == 1)
                    pB4.Image = pB2Dold.Image; //Byter till bilden pB2Dold i ruta 4 om iRnd = 1
                else if (iRnd == 2)
                    pB4.Image = pB3Dold.Image; //Byter till bilden pB3Dold i ruta 4 om iRnd = 2
                else if (iRnd == 3)
                    pB4.Image = pB4Dold.Image; //Byter till bilden pB4Dold i ruta 4 om iRnd = 3
                else if (iRnd == 4)
                    pB4.Image = pB5Dold.Image; //Byter till bilden pB5Dold i ruta 4 om iRnd = 4
                else
                    pB4.Image = pB6Dold.Image; //Byter till bilden pB6Dold i ruta 4 om iRnd är något annat.
            }


            if (cB5.Checked)  //Låser tärningen
            {
                //Tom efterssom att tärningen inte ska rullas då cB5 är ikryssad.
            }
            else //Om tärningen inte är ikryssad utförs detta
            {
                //Tärning 5
                iRnd = r.Next(0, 6); //Slumpar tärningen mellan numrena 1 till 6.
                //pB#Dold innehåller bilder på alla sidor i tärningen, är dold och används för att hämta bilder in i tärningsrutorna.
                if (iRnd == 0)
                    pB5.Image = pB1Dold.Image; //Byter till bilden pB1Dold i ruta 5 om iRnd = 0
                else if (iRnd == 1)
                    pB5.Image = pB2Dold.Image; //Byter till bilden pB2Dold i ruta 5 om iRnd = 1
                else if (iRnd == 2)
                    pB5.Image = pB3Dold.Image; //Byter till bilden pB3Dold i ruta 5 om iRnd = 2
                else if (iRnd == 3)
                    pB5.Image = pB4Dold.Image; //Byter till bilden pB4Dold i ruta 5 om iRnd = 3
                else if (iRnd == 4)
                    pB5.Image = pB5Dold.Image; //Byter till bilden pB5Dold i ruta 5 om iRnd = 4
                else
                    pB5.Image = pB6Dold.Image; //Byter till bilden pB6Dold i ruta 5 om iRnd är något annat.
            }


        }
        //Omknapp
        private void OmToolStripMenuItem_Click(object sender, EventArgs e) //Vid klick på knappen Om utförs detta
        {
            //Talar om vilka som har utvecklat spelet och vilket år, i formen utav en messagebox.
            MessageBox.Show("Programmet har gjorts utav Theo Sandberg och JohanAugust Nordangård, TE17B, år 2019", "Om", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //HjälpKnapp
        private void HjälpToolStripMenuItem_Click(object sender, EventArgs e) //Vid klick på knappen Hjälp utförs detta
        {
            //Regler kring yatzy och hur det fungerar, i formen utav en messagebox.
            MessageBox.Show("Spelreglerna i Yatzy är väligt enkla och för den som aldrig spelat tar det sällan mer än ett par minuter att förstå sig på spelet. Låt oss gå igenom Yatzys spelregler: För att spela Yatzy behövs 5 tärningar. Innan man börjar spela skall man kasta samtliga fem tärningar en gång. Den spelare som får flest poäng börjar. Skulle två spelare hamna på samma antal poäng, kastar dessa två en gång till.I Yatzy får varje spelare kasta tärningarna tre gånger per runda.Skulle man nöja sig efter en eller två rundor går detta också bra.Antalet tärningar som kastas om bestämmer spelaren själv.Exempel: Spelaren får, två sexor, två treor och en etta, vid första tärningskastet.Spelaren väljer att spara sexor och treor, och kastar om ettan i hopp om att den skall landa på en sexa eller trea, vilket skulle ge kåk.Skulle spelaren misslyckas med detta kan han eller hon trösta sig med att ha två par.", "Hjälp", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Räknare - Slag
        
        




    }
}

using DiceRoll.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace DiceRoll
{
    public partial class Game : Form
    {
        private readonly Random random = new Random();
        private int faze = 3;
        private SoundPlayer kostkaHod = new SoundPlayer(Resources.sRoll);
        private bool povolTimer = false;
        private static int skorePuvodni = 149;
        private int skore = 149;
        private int predchoziKostka = 0;
        private int aktualniKostka = 0;
        private bool typVic = false;
        private bool typStejne = false;
        private bool typMin = false;
        private int cisloKostka = 0;
        private static Random nahoda = new Random();
        private static List<string> osobyList = new List<string>
                    {
                        "sestru",
                        "bratra",
                        "babičku",
                        "dědu",
                        "maminku",
                        "tatínka",
                        "strýce",
                        "tetu",
                        "přítele",
                        "přítelkyni",
                        "manžela",
                        "manželku",
                        "syna",
                        "dceru",
                        "kamaráda",
                        "kamarádku",
                        "souseda",
                        "sousedku",
                        "šéfa",
                        "kolegu",
                        "bratrance",
                        "neteř",
                        "švagrovou",
                        "švagra",
                        "kmotra",
                        "kmotru",
                        "tchána",
                        "tchýni",
                        "zeťě",
                        "snachu",
                        "staršího bratra",
                        "nevlasntí sestru",
                        "zubaře",
                        "kadeřníka",
                        "třídního učitele",
                        "třídní učitleku",
                        "spolubydlícího",
                        "spolubydlící",
                        "prodavače",
                        "prodavačku",
                        "policistu",
                        "policistku"
                    };
        private static List<string> cenyList = new List<string>
        {
            "kafe",
            "4 litry benzínu",
            "4,65 litrů nafty",
            "8 láhvy Dobrých vod (1,5 litru)",
            "2 másla (250 g)",
            "plyšový medvídek",
            "2 bochníky chleba",
            "hrníček s nápisem 'Ráno jsem lidská bytost až po první šálku kávy'",
            "pivní sprchový gel",
            "dvě antistresová prsa",
            "dva páry ponožek s kočičkou",
            "dva páry ponožek s pejskem",
        };

        private static string[] osobyPole = osobyList.ToArray();
        private static string[] cenyPole = cenyList.ToArray();
        private static SoundPlayer gameOverSound = new SoundPlayer(Properties.Resources.game_over);
        private static SoundPlayer victorySound = new SoundPlayer(Properties.Resources.victory);

        private int RandomNumber(int min, int max)
        {
            return random.Next(min, max + 1);
        }

        private Image DiceImage(int i)
        {
            Image[] images = new Image[]
            {
                null,
                Resources._1,
                Resources._2,
                Resources._3,
                Resources._4,
                Resources._5,
                Resources._6
            };

            if (i >= 1 && i <= 6)
            {
                return images[i];
            } else
            {
                return null;
            }
        }

        public Game()
        {
            InitializeComponent();
            povolTimer = false;
            btnVic.Visible = false;
            btnMin.Visible = false;
            btnStejne.Visible = false;
            lblPenize.Text = $"{skorePuvodni} Kč";
        }

        private void btnAppClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAppClose_MouseHover(object sender, EventArgs e)
        {
            tooltip.SetToolTip(btnAppClose, "Close");
        }

        private void btnHazej_Click(object sender, EventArgs e)
        {
            if(!timerHod.Enabled && !povolTimer)
            {
                faze = 4; // Reset faze na 4
                povolTimer = true; // Povolení timeru pro další házení
                timerHod.Enabled = true;
            }
        }

        private GameOver GetGameOver(bool konec)
        {
            if (!konec)
            {
                GameOver gameOver = new GameOver("¨Vyhrál jsi", $"Za vyhraných {skore} Kč jsi jako dárek pro {osobyPole[(nahoda.Next(0, osobyPole.Length))]} koupil {cenyPole[(nahoda.Next(0, cenyPole.Length))]}", Resources.win, "Hrát znovu", victorySound);
                return gameOver;
            }
            else
            {
                GameOver gameOver = new GameOver("Konec hry", $"Prohrál jsi svých {skorePuvodni} Kč, které jsi měl původně na dárek pro {osobyPole[(nahoda.Next(0, osobyPole.Length))]}", Resources.dead, "Hrát znovu", gameOverSound);
                return gameOver;
            }
        }

        private void timerHod_Tick(object sender, EventArgs e)
        {
            if (faze > 0 || (faze == 0 && (cisloKostka == predchoziKostka)))
            {
                cisloKostka = RandomNumber(1, 6);
            }

            if (faze > 0)
            {
                kostkaHod.Play();
                faze--;
                picboxKostka.BackgroundImage = DiceImage(cisloKostka);
                timerHod.Interval = 1000;
            }
            else
            {
                timerHod.Enabled = false; // Zastavení timeru
                povolTimer = false; // Vypnutí povolení timeru pro další házení
                btnMin.Visible = true;
                btnVic.Visible = true;
                btnStejne.Visible = true;
                btnMin.Enabled = true;
                btnVic.Enabled = true;
                btnStejne.Enabled = true;
                btnHazej.Visible = false;

                predchoziKostka = aktualniKostka; // Přepsání předchozí hodnoty na aktuální hodnotu
                aktualniKostka = cisloKostka; // Uložení aktuální hodnoty kostky

                if (predchoziKostka != 0) // Pokud je předchozí hodnota nastavena
                {
                    if ((aktualniKostka > predchoziKostka && typVic) || (aktualniKostka < predchoziKostka && typMin))
                    {
                        skore += 10; // Přičtení 10 bodů
                    }
                    else if ((aktualniKostka == predchoziKostka) && typStejne)
                    {
                        skore += 5; // Přičtení 5 bodů
                    }
                    else
                    {
                        skore -= 5; // Odečtení 5 bodů
                    }

                    if (skore <= 0)
                    {
                        DialogResult dialogResult = GetGameOver(true).ShowDialog();

                        if(dialogResult == DialogResult.Abort)
                        {
                            Close();
                        }
                        else if(dialogResult == DialogResult.Retry)
                        {
                            skore = skorePuvodni;
                            povolTimer = false;
                            btnVic.Visible = false;
                            btnMin.Visible = false;
                            btnStejne.Visible = false;
                            btnHazej.Visible = true;
                            predchoziKostka = 0;
                            aktualniKostka = 0;
                            lblPenize.Text = $"{skorePuvodni} Kč";
                        }

                        // MessageBox.Show($"Porhrál jsi všech svých {skorePuvodni} Kč, které jsi měl původně na dárek pro {osobyPole[(random.Next(0, osobyPole.Length))]}");
                    }

                    if (skore >= 150)
                    {
                        DialogResult dialogResult = GetGameOver(false).ShowDialog();

                        if (dialogResult == DialogResult.Abort)
                        {
                            Close();
                        }
                        else if (dialogResult == DialogResult.Retry)
                        {
                            skore = skorePuvodni;
                            povolTimer = false;
                            btnVic.Visible = false;
                            btnMin.Visible = false;
                            btnStejne.Visible = false;
                            btnHazej.Visible = true;
                            predchoziKostka = 0;
                            aktualniKostka = 0;
                            lblPenize.Text = $"{skorePuvodni} Kč";
                        }
                    }
                }

                lblPredchozi.Text = $"Aktuální hozená hodnota: {aktualniKostka}\nPředchozí hozená hodnota: {predchoziKostka}";
                lblPenize.Text = $"{skore} Kč";
            }
        }

        private void btnVic_Click(object sender, EventArgs e)
        {
            if (btnVic.Visible)
            {
                btnVic.Enabled = false;
                typVic = true;
                typStejne = false;
                typMin = false;
                btnVic.Visible = true; // Zobrazit pouze tlačítko "VÍC"
                btnStejne.Visible = false; // Schovat tlačítko "STEJNĚ"
                btnMin.Visible = false; // Schovat tlačítko "MÍŇ"
                btnHazej.Visible = true;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (btnMin.Visible)
            {
                btnMin.Enabled = false;
                typVic = false;
                typStejne = false;
                typMin = true;
                btnVic.Visible = false; // Schovat tlačítko "VÍC"
                btnStejne.Visible = false; // Schovat tlačítko "STEJNĚ"
                btnMin.Visible = true; // Zobrazit pouze tlačítko "MÍŇ"
                btnHazej.Visible = true;
            }
        }

        private void btnStejne_Click(object sender, EventArgs e)
        {
            if (btnStejne.Visible)
            {
                btnStejne.Enabled = false;
                typVic = false;
                typStejne = true;
                typMin = false;
                btnVic.Visible = false; // Schovat tlačítko "VÍC"
                btnStejne.Visible = true; // Zobrazit pouze tlačítko "STEJNĚ"
                btnMin.Visible = false; // Schovat tlačítko "MÍŇ"
                btnHazej.Visible = true;
            }
        }
    }
}

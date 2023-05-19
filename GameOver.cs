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
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Globalization;

namespace DiceRoll
{
    public partial class GameOver : Form
    {
        public static string _title, _description, _buttontext;
        public static Image _icon;
        private static SoundPlayer _soundPlayer;

        public GameOver(string title, string description, Image icon, string buttontext, SoundPlayer soundPlayer)
        {
            InitializeComponent();

            _title = title;
            _description = description;
            _icon = icon;
            _buttontext = buttontext;

            lblTitle.Text = _title;
            lblText.Text = _description;
            picboxIkona.BackgroundImage = _icon;
            btnPlayAgain.Text = _buttontext;
            _soundPlayer = soundPlayer;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
            _soundPlayer.Stop();
            Close();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            _soundPlayer.Play();
        }

        /// <summary>
        /// Zobrazí dialogové okno s informací o konci hry s daným názvem, popisem, ikonou a textem na tlačítku.
        /// </summary>
        /// <param name="title">Název dialogového okna informujícího o konci hry.</param>
        /// <param name="description">Text popisu zobrazený v dialogovém okně.</param>
        /// <param name="icon">Ikona zobrazená v dialogovém okně.</param>
        /// <param name="buttontext">Text zobrazený na tlačítku v dialogovém okně.</param>
        /// <returns>Výsledek dialogu, který označuje interakci uživatele s dialogovým oknem.</returns>
        /// <exception cref="ArgumentException">Vyhazuje se, když je název, popis nebo text na tlačítku null nebo prázdný.</exception>
        /// <exception cref="ArgumentNullException">Vyhazuje se, když ikona je null.</exception>
        public static DialogResult ShowAlert()
        {
            if (string.IsNullOrEmpty(_title))
            {
                throw new ArgumentException($"Hodnota {nameof(_title)} nemůže být nulová a toto pole nemůže být prázdné.", nameof(_title));
            }

            if (string.IsNullOrEmpty(_description))
            {
                throw new ArgumentException($"Hodnota {nameof(_description)} nemůže být nulová a toto pole nemůže být prázdné.", nameof(_description));
            }

            if (_icon is null)
            {
                throw new ArgumentNullException(nameof(_icon));
            }

            if (string.IsNullOrEmpty(_buttontext))
            {
                throw new ArgumentException($"Hodnota {nameof(_buttontext)} nemůže být nulová a toto pole nemůže být prázdné.", nameof(_buttontext));
            }

            GameOver gameOver = new GameOver(_title, _description, _icon, _buttontext, _soundPlayer);

            return gameOver.ShowDialog();
        }

        private void btnDialogClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            _soundPlayer.Stop();
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Domain;

namespace WindowsGame
{
    public partial class BattleField : Form, IPlayerInteraction
    {
        private int _numberOfPlayers;
        private int _currentPlayerIndex;
        private Player _currentPlayer;
        private List<Player> _players;
        private Card _selectedCard;

        private readonly Dictionary<Player, FlowLayoutPanel> _playerBattleFields = new Dictionary<Player, FlowLayoutPanel>();

        public BattleField()
        {
            InitializeComponent();
        }

        private void BattleField_Load(object sender, EventArgs e)
        {
        }


        public int PromptPlayerForTurnChoice()
        {
            return 1;
        }

        public Card PromptPlayerForCardToPlay(List<Card> hand)
        {
            DisplayCards(CardCollection, hand, false, "Hand: Choose a Card to Play");
            CardCollection.Visible = true;

            _selectedCard = null;

            while (_selectedCard == null)
            {
                Application.DoEvents();
                Thread.Sleep(100);
            }
            return _selectedCard;
        }

        public void DisplayMessage(string message)
        {
            throw new NotImplementedException();
        }

        public int PromptPlayerForBuyChoice()
        {
            throw new NotImplementedException();
        }

        public void DisplayHand(List<Card> hand)
        {
            DisplayCards(CardCollection, hand, true, "Hand");
            CardCollection.Visible = true;
        }

        public void DisplayBattleField(List<Card> battlefield)
        {
            DisplayCards(_playerBattleFields[_currentPlayer], battlefield, true);
        }

        void DisplayCards(FlowLayoutPanel panel, List<Card> cards, bool readOnly, string cardCollectionName = "")
        {
            if (!string.IsNullOrEmpty(cardCollectionName))
            {
                CardCollectionLabel.Text = cardCollectionName;
            }
            panel.Controls.Clear();

            foreach (var card in cards)
            {
                Control controlToAdd;
                if (readOnly)
                {
                    var cardToAdd = new Panel { Width = 120, Height = 135};
                    cardToAdd.Controls.Add(new Label { Text = card.CardType.ToString() });
                    controlToAdd = cardToAdd;
                }
                else
                {
                    var button = new Button { Text = card.CardType.ToString(), Width = 120, Height = 135 };
                    button.Click += (sender, args) => _selectedCard = card;
                    controlToAdd = button;
                }
                panel.Controls.Add(controlToAdd);
            }
        }

        private void InitializePlayers()
        {
            _players = GetPlayers();

            _currentPlayerIndex = 0;
            _currentPlayer = _players[0];
        }

        private List<Player> GetPlayers()
        {
            List<string> playerNames = GetPlayerNames();
            List<Player> players = playerNames.Select(x => new Player { Name = x }).ToList();

            players.Shuffle();

            return players;
        }

        private List<string> GetPlayerNames()
        {
            List<string> playerNames = new List<string>();
            for (int index = 0; index < _numberOfPlayers; index++ )
            {
                string playerName = "";
                DialogResult result = Dialog.InputBox(string.Format("Player {0} Name", index + 1),
                                                      string.Format("Enter the Name for Player {0}", index + 1), ref playerName);
                playerNames.Add(playerName);
            }
            return playerNames;
        }

        private void TwoPlayersButton_Click(object sender, EventArgs e)
        {
            ChoosePlayersPanel.Hide();
            BattleField2.Hide();
            BattleField4.Hide();

            _numberOfPlayers = 2;
            
            InitializePlayers();
            _playerBattleFields.Add(_players[0], BattleField1);
            _playerBattleFields.Add(_players[1], BattleField3);
            StartGame();
        }

        private void ThreePlayersButton_Click(object sender, EventArgs e)
        {
            ChoosePlayersPanel.Hide();
            BattleField4.Hide();

            _numberOfPlayers = 3;
            InitializePlayers();

            _playerBattleFields.Add(_players[0], BattleField1);
            _playerBattleFields.Add(_players[1], BattleField2);
            _playerBattleFields.Add(_players[2], BattleField3);
            StartGame();

        }

        private void FourPlayersButton_Click(object sender, EventArgs e)
        {
            ChoosePlayersPanel.Hide();
            _numberOfPlayers = 4;
            InitializePlayers();

            _playerBattleFields.Add(_players[0], BattleField1);
            _playerBattleFields.Add(_players[1], BattleField2);
            _playerBattleFields.Add(_players[2], BattleField3);
            _playerBattleFields.Add(_players[3], BattleField4);
            StartGame();

        }

        private void StartGame()
        {
            _currentPlayerIndex = 0;
            _currentPlayer = _players[0];
            _currentPlayer.TakeTurn(this);
        }

        private void HandButton_Click(object sender, EventArgs e)
        {
            DisplayCards(CardCollection, _currentPlayer.Hand, true, "Hand");
        }

        private void DiscardButton_Click(object sender, EventArgs e)
        {
            DisplayCards(CardCollection, _currentPlayer.DiscardPile, true, "Discard Pile");
        }

        private void EndTurnButton_Click(object sender, EventArgs e)
        {
            SetCurrentPlayerToNextPlayer();
            _currentPlayer.TakeTurn(this);
        }

        private void SetCurrentPlayerToNextPlayer()
        {
            if (_currentPlayerIndex == _players.Count - 1)
            {
                _currentPlayerIndex = 0;
            }
            else
            {
                _currentPlayerIndex++;
            }
            _currentPlayer = _players[_currentPlayerIndex];
        }
    }
}

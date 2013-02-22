using System.Collections.Generic;

namespace Domain
{
    public interface IPlayerInteraction
    {
        int PromptPlayerForTurnChoice();
        Card PromptPlayerForCardToPlay(List<Card> hand);
        void DisplayMessage(string message);
        int PromptPlayerForBuyChoice();
        void DisplayHand(List<Card> hand);
        void DisplayBattleField(List<Card> battlefield);
    }
}
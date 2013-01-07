using System.Collections.Generic;

namespace MyGame
{
    public interface IPlayerInteraction
    {
        int PromptPlayerForTurnChoice();
        int PromptPlayerForCardToPlay();
        void DisplayMessage(string message);
        int PromptPlayerForBuyChoice();
        List<string> GetPlayerNames();
    }
}
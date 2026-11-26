
using System;

namespace GreatATUTreasureHunt
{
    public class Clue
    {
        // The answer is private to protect it.
        private string answer;

        public string Question { get; set; }
        public string Hint { get; set; }

        public Clue(string question, string answer, string hint)
        {
            Question = question;
            this.answer = answer;
            Hint = hint;
        }

        // Checks whether the player's answer is correct.
        public bool CheckAnswer(string playerAnswer)
        {
            return playerAnswer.Trim().Equals(
                answer,
                StringComparison.OrdinalIgnoreCase);
        }
    }
}

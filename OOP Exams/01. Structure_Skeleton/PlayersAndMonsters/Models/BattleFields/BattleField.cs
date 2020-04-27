using PlayersAndMonsters.Models.BattleFields.Contracts;
using PlayersAndMonsters.Models.Cards;
using PlayersAndMonsters.Models.Players;
using PlayersAndMonsters.Models.Players.Contracts;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Models.BattleFields
{
    public class BattleField : IBattleField
    {
        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if (attackPlayer.IsDead || enemyPlayer.IsDead)
            {
                throw new ArgumentException(
                    "Player is dead!");
            }

            ModyfyPlayerPoints(attackPlayer);

            ModyfyPlayerPoints(enemyPlayer);

            BoostPlayerPoints(attackPlayer);

            BoostPlayerPoints(enemyPlayer);

            while (!attackPlayer.IsDead && !enemyPlayer.IsDead)
            {

                int attackerAttackPoints = calculateDamagePoints(attackPlayer);

                int enemyAttackPoints = calculateDamagePoints(enemyPlayer);

                enemyPlayer.TakeDamage(attackerAttackPoints);

                if (enemyPlayer.IsDead)
                {
                    break;
                }

                attackPlayer.TakeDamage(enemyAttackPoints);

            }
        }

        private static int calculateDamagePoints(IPlayer currentPlayer)
        {
            return currentPlayer
                .CardRepository
                .Cards
                .Select(c => c.DamagePoints)
                .Sum();
        }

        private static void BoostPlayerPoints(IPlayer currentPlayer)
        {
            currentPlayer.Health += currentPlayer.CardRepository
                .Cards
                .Select(c => c.HealthPoints)
                .Sum();
        }

        private static void ModyfyPlayerPoints(IPlayer currentPlayer)
        {
            if (currentPlayer is Beginner)
            {
                currentPlayer.Health += 40;

                foreach (var card in currentPlayer.CardRepository.Cards)
                {
                    card.DamagePoints += 30;
                }
            }
        }
    }
}

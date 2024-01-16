using DiskCardGame;
using InscryptionAPI.Encounters;
using System;
using System.Collections.Generic;
using System.Text;
using InscryptionAPI.Regions;

namespace NevernamedsInscryptionMod
{
    public static class EncounterHelper
    {
        public static EncounterBlueprintData Create(string name, Tribe dominantTribe, List<string> randomReplacementCards, List<List<EncounterBlueprintData.CardBlueprint>> turns)
        {
            EncounterBlueprintData data = EncounterManager.New(name);
            data.SetDifficulty(1, 15);
            data.AddDominantTribes(dominantTribe);
            data.AddRandomReplacementCards(randomReplacementCards.ToArray());
            data.AddTurnMods(new[] { new EncounterBlueprintData.TurnModBlueprint() { turn = 1, applyAtDifficulty = 1, } });

            foreach (List<EncounterBlueprintData.CardBlueprint> turn in turns)
            {
                data.AddTurn(turn.ToArray());
            }

            

            return data;
        }
    }
}

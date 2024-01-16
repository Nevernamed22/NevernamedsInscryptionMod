using DiskCardGame;
using InscryptionAPI.Encounters;
using System;
using System.Collections.Generic;
using System.Text;

namespace NevernamedsInscryptionMod
{
    public static class MayflyEncounter
    {
        public static void Init()
        {
           EncounterHelper.Create("MayflySwarm", Tribe.Insect, 
               new List<string>() { "Bee", "BeastNevernamed KillerBee" },
               new List<List<EncounterBlueprintData.CardBlueprint>>()
               {
                 new List<EncounterBlueprintData.CardBlueprint>() //Turn 1
                 {
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed Mayfly"), minDifficulty = 0, maxDifficulty = 15 },
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed Mayfly"), minDifficulty = 6, maxDifficulty = 15 }
                 },
                 new List<EncounterBlueprintData.CardBlueprint>() //Turn 2
                 {
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed Mayfly"), minDifficulty = 2, maxDifficulty = 15 },
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed Mayfly"), minDifficulty = 0, maxDifficulty = 15 }
                 },
                 new List<EncounterBlueprintData.CardBlueprint>() //Turn 3
                 {
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed Mayfly"), minDifficulty = 2, maxDifficulty = 15 },
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed Mayfly"), minDifficulty = 0, maxDifficulty = 15, randomReplaceChance = 25 },
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed Mayfly"), minDifficulty = 6, maxDifficulty = 15 }
                 },
                 new List<EncounterBlueprintData.CardBlueprint>() //Turn 4
                 {
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed Mayfly"), minDifficulty = 2, maxDifficulty = 15 },
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed Mayfly"), minDifficulty = 0, maxDifficulty = 15, randomReplaceChance = 25 },
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed Mayfly"), minDifficulty = 0, maxDifficulty = 15 }
                 },
                 new List<EncounterBlueprintData.CardBlueprint>() //Turn 5
                 {
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed Mayfly"), minDifficulty = 6, maxDifficulty = 15 },
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed Mayfly"), minDifficulty = 2, maxDifficulty = 15, randomReplaceChance = 50 },
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed Mayfly"), minDifficulty = 0, maxDifficulty = 15 },
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed Mayfly"), minDifficulty = 0, maxDifficulty = 15, difficultyReplace = true, difficultyReq = 7, replacement = CardLoader.GetCardByName("BeastNevernamed MayflySwarm") }
                 },
                 new List<EncounterBlueprintData.CardBlueprint>() //Turn 6
                 {
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed Mayfly"), minDifficulty = 2, maxDifficulty = 15 },
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed Mayfly"), minDifficulty = 3, maxDifficulty = 15, randomReplaceChance = 65 },
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed Mayfly"), minDifficulty = 0, maxDifficulty = 15 },
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed Mayfly"), minDifficulty = 0, maxDifficulty = 15, difficultyReplace = true, difficultyReq = 7, replacement = CardLoader.GetCardByName("BeastNevernamed MayflySwarm") }
                 }

               });
        }
    }
}

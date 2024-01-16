using DiskCardGame;
using InscryptionAPI.Encounters;
using System;
using System.Collections.Generic;
using System.Text;

namespace NevernamedsInscryptionMod
{
    public static class ThickLizardEncounter
    {
        public static void Init()
        {
            EncounterHelper.Create("ThickLizardEncounter", Tribe.Reptile,
                new List<string>() { "Skink", "Bullfrog", "BeastNevernamed PoppingToad" },
                new List<List<EncounterBlueprintData.CardBlueprint>>()
                {
                 new List<EncounterBlueprintData.CardBlueprint>() //Turn 1
                 {
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed ThickLizard"), minDifficulty = 0, maxDifficulty = 15 },
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed ThickLizard"), minDifficulty = 0, maxDifficulty = 15, randomReplaceChance = 100 },
                 },
                 new List<EncounterBlueprintData.CardBlueprint>() //Turn 2
                 {
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed ThickLizard"), minDifficulty = 4, maxDifficulty = 15, randomReplaceChance = 100 },
                 },
                 new List<EncounterBlueprintData.CardBlueprint>() //Turn 3
                 {
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed ThickLizard"), minDifficulty = 0, maxDifficulty = 15 },
                 },
                 new List<EncounterBlueprintData.CardBlueprint>() //Turn 4
                 {
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed Mugwump"), minDifficulty = 7, maxDifficulty = 15 },
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("Skink"), minDifficulty = 0, maxDifficulty = 15 },
                 },
                 new List<EncounterBlueprintData.CardBlueprint>() //Turn 5
                 {
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed ThickLizard"), minDifficulty = 0, maxDifficulty = 15 },
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed ThickLizard"), minDifficulty = 0, maxDifficulty = 15, difficultyReplace = true, difficultyReq = 8, replacement = CardLoader.GetCardByName("BeastNevernamed ThornyDevil") },
                 },
                 new List<EncounterBlueprintData.CardBlueprint>() //Turn 6
                 {                 
                 },
                 new List<EncounterBlueprintData.CardBlueprint>() //Turn 7
                 {
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed Vodyanoy"), minDifficulty = 9, maxDifficulty = 15 },
                 },
                });
        }
    }
}
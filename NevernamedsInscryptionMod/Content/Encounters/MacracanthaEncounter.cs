using DiskCardGame;
using InscryptionAPI.Encounters;
using System;
using System.Collections.Generic;
using System.Text;

using NevernamedsSigils;

namespace NevernamedsInscryptionMod
{
    public static class MacracanthaEncounter
    {
        public static void Init()
        {
            EncounterHelper.Create("MacracanthaEncounter", NevernamedsTribes.Arachnid,
                new List<string>() { "Skink", "Bullfrog", "BeastNevernamed PoppingToad" },
                new List<List<EncounterBlueprintData.CardBlueprint>>()
                {
                 new List<EncounterBlueprintData.CardBlueprint>() //Turn 1
                 {
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed Macracantha"), minDifficulty = 0, maxDifficulty = 15, difficultyReplace = true, difficultyReq = 7, replacement =   CardLoader.GetCardByName("BeastNevernamed MacracanthaBi")},
                    new EncounterBlueprintData.CardBlueprint(){ card = CardLoader.GetCardByName("BeastNevernamed Macracantha"), minDifficulty = 0, maxDifficulty = 15, difficultyReplace = true, difficultyReq = 7, replacement =   CardLoader.GetCardByName("BeastNevernamed MacracanthaBi")},
                 },             
                });
        }
    }
}
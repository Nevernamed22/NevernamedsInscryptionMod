/*using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.Text;
using NevernamedsSigils;
using UnityEngine;
using InscryptionAPI.Encounters;

namespace NevernamedsInscryptionMod
{
    class EncounterUtil
    {
        public static List<CardInfo> AddRandomCards(string turn1 = "none", string turn2 = "none", string turn3 = "none", string turn4 = "none", string turn5 = "none", string turn6 = "none", string turn7 = "none", string turn8 = "none", string turn9 = "none")
        {

            List<CardInfo> randomReplacements = new List<CardInfo>();
            if (turn1 != "none")
            {
                randomReplacements.Add(CardLoader.GetCardByName(turn1));
            }
            else
            {
                return randomReplacements;
            }
            if (turn2 != "none")
            {
                randomReplacements.Add(CardLoader.GetCardByName(turn2));
            }
            else
            {
                return randomReplacements;
            }
            if (turn3 != "none")
            {
                randomReplacements.Add(CardLoader.GetCardByName(turn3));
            }
            else
            {
                return randomReplacements;
            }
            if (turn4 != "none")
            {
                randomReplacements.Add(CardLoader.GetCardByName(turn4));
            }
            else
            {
                return randomReplacements;
            }
            if (turn5 != "none")
            {
                randomReplacements.Add(CardLoader.GetCardByName(turn5));
            }
            else
            {
                return randomReplacements;
            }
            if (turn6 != "none")
            {
                randomReplacements.Add(CardLoader.GetCardByName(turn6));
            }
            else
            {
                return randomReplacements;
            }
            if (turn7 != "none")
            {
                randomReplacements.Add(CardLoader.GetCardByName(turn7));
            }
            else
            {
                return randomReplacements;
            }
            if (turn8 != "none")
            {
                randomReplacements.Add(CardLoader.GetCardByName(turn8));
            }
            else
            {
                return randomReplacements;
            }
            if (turn9 != "none")
            {
                randomReplacements.Add(CardLoader.GetCardByName(turn9));
            }
            else
            {
                return randomReplacements;
            }
            return randomReplacements;
        }
    }

    public static void MakeAndAddBlueprint()
    {
        var blueprint = ScriptableObject.CreateInstance<EncounterBlueprintData>();
        blueprint.turns = new List<List<EncounterBlueprintData.CardBlueprint>>
        {
            new() { },
            new() { bp_Zombie },
            new() { bp_Draugr },
            new() { bp_Skeleton },
            new() { },
            new() { bp_Skeleton },
            new() { },
            new() { bp_Revenant },
            new() { bp_Skeleton },
            new() { bp_Skeleton, bp_Draugr },
            new() { },
            new() { bp_Skeleton },
            new() { bp_Skeleton },
            new() { bp_Skeleton },
            new() { bp_Skeleton },
            new() { },
            new() { bp_DrownedSoul }
        };
            EncounterManager.Add(blueprint);
    }
    class SetupCustomEncounters
    {
        public static void Init()
        {


              /*    NewEncounter.Add(
                             "GoneToTheDogs", //Name
                             "Forest", //Either Forest, Wetlands, or Alpine
                             new List<EncounterBlueprintData.TurnModBlueprint>(),
                             new List<Tribe>() { Tribe.Canine }, //A list of the most dominant tribe/tribes
                             new List<Ability>(), //A list of any sigils that are redundant in the battle
                             unlockedCardPrerequisites: null,
                             false, //If it's locked to an area
                             minDifficulty: 1,
                             maxDifficulty: 30,
                             EncounterUtil.AddRandomCards("Wolf", "WolfCub"), //Cards that can randomly replace other cards each turn
                             new List<List<EncounterBlueprintData.CardBlueprint>>() //A full list of turns
                             {
                                 //----------------------------------------------- TURN 1
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("WolfCub")
                                     },
                                 },
                                 //----------------------------------------------- TURN 2
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed LoneWolf")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("WolfCub")
                                     },
                                 },
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                 },
                                 //----------------------------------------------- TURN 3
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Wolf")
                                     },
                                 },
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                 },
                                 //----------------------------------------------- TURN 4
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed RabidDog")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed RabidDog")
                                     },
                                 },
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                 },
                                 //----------------------------------------------- TURN 5
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Wolf")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Bloodhound")
                                     },
                                 },
                                 //----------------------------------------------- TURN 6
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed LoneWolf")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("WolfCub")
                                     },
                                 },
                             },
                             regular: true,
                             bossPrep: false,
                             oldPreviewDifficulty: 0);


                  NewEncounter.Add(
                             "SnakePit", //Name
                             "Wetlands", //Either Forest, Wetlands, or Alpine
                             new List<EncounterBlueprintData.TurnModBlueprint>(),
                             new List<Tribe>() { Tribe.Reptile }, //A list of the most dominant tribe/tribes
                             new List<Ability>(), //A list of any sigils that are redundant in the battle
                             unlockedCardPrerequisites: null,
                             true, //If it's locked to an area
                             minDifficulty: 1,
                             maxDifficulty: 30,
                            null, //Cards that can randomly replace other cards each turn
                             new List<List<EncounterBlueprintData.CardBlueprint>>() //A full list of turns
                             {
                                 //----------------------------------------------- TURN 1
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Bee")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Bee")
                                     },
                                 },
                                 //----------------------------------------------- TURN 2
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed Cobra")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Bee")
                                     },
                                 },
                                 //----------------------------------------------- TURN 3
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed Cobra")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Bee")
                                     },
                                 },
                                 //----------------------------------------------- TURN 4
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed KingCobra")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Adder")
                                     },
                                 },
                                 //----------------------------------------------- TURN 5
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Adder")
                                     },
                                 },
                                 //----------------------------------------------- TURN 6
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Rattler")
                                     },
                                 },
                                 //----------------------------------------------- TURN 7
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Rattler")
                                     },
                                      new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Rattler")
                                     },
                                 },
                             },
                             regular: true,
                             bossPrep: false,
                             oldPreviewDifficulty: 0);

                  NewEncounter.Add(
                             "MayflySpawningSeason", //Name
                             "Wetlands", //Either Forest, Wetlands, or Alpine
                             new List<EncounterBlueprintData.TurnModBlueprint>(),
                             new List<Tribe>() { Tribe.Insect }, //A list of the most dominant tribe/tribes
                             new List<Ability>() { Ability.Flying }, //A list of any sigils that are redundant in the battle
                             unlockedCardPrerequisites: null,
                             true, //If it's locked to an area
                             minDifficulty: 1,
                             maxDifficulty: 30,
                             null, //Cards that can randomly replace other cards each turn
                             new List<List<EncounterBlueprintData.CardBlueprint>>() //A full list of turns
                             {
                                 //----------------------------------------------- TURN 1
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed_Mayfly")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed_Mayfly")
                                     },
                                 },
                                 //----------------------------------------------- TURN 2
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed_Mayfly")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed_Mayfly")
                                     },
                                 },
                                 //----------------------------------------------- TURN 3
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed_Mayfly")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed_Mayfly")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed_Mayfly")
                                     },
                                 },
                                 //----------------------------------------------- TURN 4
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed_Mayfly")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed_Mayfly")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed_Mayfly")
                                     },
                                 },
                                 //----------------------------------------------- TURN 5
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed_Mayfly")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed_Mayfly")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed_Mayfly")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed_Mayfly")
                                     },
                                 },
                                 //----------------------------------------------- TURN 6
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed_Mayfly")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed_Mayfly")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed_Mayfly")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed_Mayfly")
                                     },
                                 },
                                 //----------------------------------------------- TURN 7
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed_Mayfly")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed_Mayfly")
                                     },
                                 },
                             },
                             regular: true,
                             bossPrep: false,
                             oldPreviewDifficulty: 0);

                  NewEncounter.Add(
                 "StallForAsLongAsYouCan", //Name
                 "Forest", //Either Forest, Wetlands, or Alpine
                 new List<EncounterBlueprintData.TurnModBlueprint>(),
                 new List<Tribe>() { Tribe.Hooved }, //A list of the most dominant tribe/tribes
                 new List<Ability>() { }, //A list of any sigils that are redundant in the battle
                 unlockedCardPrerequisites: null,
                 false, //If it's locked to an area
                 minDifficulty: 1,
                 maxDifficulty: 30,
                 null, //Cards that can randomly replace other cards each turn
                 new List<List<EncounterBlueprintData.CardBlueprint>>() //A full list of turns
                 {
                                 //----------------------------------------------- TURN 1
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Rabbit")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Mole")
                                     },
                                 },
                                 //----------------------------------------------- TURN 2
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                 },
                                  new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                 },
                                 //----------------------------------------------- TURN 3
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Grizzly")
                                     },
                                 },
                                 //----------------------------------------------- TURN 4
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Rabbit")
                                     },
                                 },
                                 //----------------------------------------------- TURN 5
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Grizzly")
                                     },
                                 },
                                 //----------------------------------------------- TURN 6
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Rabbit")
                                     },

                                 },
                 },
                 regular: true,
                 bossPrep: false,
                 oldPreviewDifficulty: 0);

                  NewEncounter.Add(
                  "BullShit", //Name
                  "Forest", //Either Forest, Wetlands, or Alpine
                  new List<EncounterBlueprintData.TurnModBlueprint>(),
                  new List<Tribe>() { Tribe.Insect }, //A list of the most dominant tribe/tribes
                  new List<Ability>() { }, //A list of any sigils that are redundant in the battle
                  unlockedCardPrerequisites: null,
                  true, //If it's locked to an area
                  minDifficulty: 1,
                  maxDifficulty: 30,
                  null, //Cards that can randomly replace other cards each turn
                  new List<List<EncounterBlueprintData.CardBlueprint>>() //A full list of turns
                  {
                                 //----------------------------------------------- TURN 1
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Bull")
                                     },
                                 },
                                 //----------------------------------------------- TURN 2
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Rabbit")
                                     },
                                 },
                                 //----------------------------------------------- TURN 3
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed Finch")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed Finch")
                                     },
                                 },
                                 //----------------------------------------------- TURN 4
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed Gnat")
                                     },
                                 },
                                 //----------------------------------------------- TURN 5
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed Gnat")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed Gnat")
                                     },
                                 },
                                 //----------------------------------------------- TURN 6
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Bull")
                                     },
                                 },
                  },
                  regular: true,
                  bossPrep: false,
                  oldPreviewDifficulty: 0);


                  NewEncounter.Add(
                 "BisonStampede", //Name
                 "Forest", //Either Forest, Wetlands, or Alpine
                 new List<EncounterBlueprintData.TurnModBlueprint>(),
                 new List<Tribe>() { Tribe.Hooved }, //A list of the most dominant tribe/tribes
                 new List<Ability>() { Trampler.ability }, //A list of any sigils that are redundant in the battle
                 unlockedCardPrerequisites: null,
                 true, //If it's locked to an area
                 minDifficulty: 1,
                 maxDifficulty: 30,
                 null, //Cards that can randomly replace other cards each turn
                 new List<List<EncounterBlueprintData.CardBlueprint>>() //A full list of turns
                 {
                                 //----------------------------------------------- TURN 1
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed Bison")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Geck")
                                     },
                                 },
                                 //----------------------------------------------- TURN 2
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Geck")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Geck")
                                     },
                                 },
                                 //----------------------------------------------- TURN 3
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed Bison")
                                     },
                                 },
                                 //----------------------------------------------- TURN 4
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Geck")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Geck")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Geck")
                                     },
                                 },
                                 //----------------------------------------------- TURN 5
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed Bison")
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed Bison")
                                     },
                                 },
                 },
                 regular: true,
                 bossPrep: false,
                 oldPreviewDifficulty: 0);

                  NewEncounter.Add(
                             "LittleMissMuffet", //Name
                             "Forest", //Either Forest, Wetlands, or Alpine
                             new List<EncounterBlueprintData.TurnModBlueprint>(),
                             new List<Tribe>() { Tribe.Insect }, //A list of the most dominant tribe/tribes
                             new List<Ability>() { }, //A list of any sigils that are redundant in the battle
                             unlockedCardPrerequisites: null,
                             false, //If it's locked to an area
                             minDifficulty: 1,
                             maxDifficulty: 30,
                             null, //Cards that can randomly replace other cards each turn
                             new List<List<EncounterBlueprintData.CardBlueprint>>() //A full list of turns
                             {
                                 //----------------------------------------------- TURN 1
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed OrbWeaver")
                                     },
                                 },
                                 //----------------------------------------------- TURN 2
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                 new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed JumpingSpider"),

                                     },
                                 new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed JumpingSpider"),
                                     },
                                 },
                                 //----------------------------------------------- TURN 3
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {

                                 },
                                 //----------------------------------------------- TURN 4
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed OrbWeaver")
                                     },
                                 },
                                 //----------------------------------------------- TURN 5
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed JumpingSpider"),
                                     },
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed JumpingSpider"),
                                     },
                                 },
                                 //----------------------------------------------- TURN 6
                                 new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed Huntsman")
                                     },
                                 },
                                  new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed Huntsman")
                                     },
                                 },
                                  new List<EncounterBlueprintData.CardBlueprint>()
                                 {
                                     new EncounterBlueprintData.CardBlueprint()
                                     {
                                           card = CardLoader.GetCardByName("Nevernamed Huntsman")
                                     },
                                 },
                             },
                             regular: true,
                             bossPrep: false,
                             oldPreviewDifficulty: 0);

              }
        }
    }
}*/


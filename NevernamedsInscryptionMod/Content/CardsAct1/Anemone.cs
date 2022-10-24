using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;

namespace NevernamedsInscryptionMod
{
    static class Anemone
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Anemone",
                "Anemone",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The soft, unassuming anemone- it seems to have remarkable potential for propagation, but no means as of yet...",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/anemone.png"),
                abilities: new List<Ability>() { Gooey.ability },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/anemone_emission.png"),
                defaultEvolutionName: "Ananenome",
               overrideAntSpawnerSpawn: "BeastNevernamed Anemone",
               overrideBeesWithinID: "BeastNevernamed Anemone",
               overrideBellistID: "BeastNevernamed Anemone",
               overrideDamID: "BeastNevernamed Anemone",
               overrideLeftClaw: "BeastNevernamed Anemone",
               overrideRightClaw: "BeastNevernamed Anemone",
               overrideFactoryConduitSpawn: "BeastNevernamed Anemone",
               overrideRabbitHoleSpawn: "BeastNevernamed Anemone",
               overrideSkeletonCrewID: "BeastNevernamed Anemone",
               overrideSquirrelShedderId: "BeastNevernamed Anemone"
                );
        }
    }
}
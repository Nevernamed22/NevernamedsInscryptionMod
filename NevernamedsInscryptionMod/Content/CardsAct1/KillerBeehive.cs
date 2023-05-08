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
    static class KillerBeehive
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed KillerBee",
               "Killer Bee",
               2,
               1,
               new List<CardMetaCategory> {  },
               CardTemple.Nature,
               description: "",
               bloodCost: 0,
               bonesCost: 0,
               defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/killerbee.png"),
               abilities: new List<Ability>() { Ability.Flying },
               tribes: new List<Tribe>() { Tribe.Insect },
               emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/killerbee_emission.png")
               );

            CardSetupUtility.NewCard("Nevernamed KillerBeehive",
                "Killer Beehive",
                0,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "Full of vicious defenders...",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/killerbeehive.png"),
                abilities: new List<Ability>() { Ability.BeesOnHit },
                tribes: new List<Tribe>() { Tribe.Insect },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/killerbeehive_emission.png"),
                overrideBeesWithinID: "BeastNevernamed KillerBee"
                );
        }
    }
}

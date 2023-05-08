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
    static class Archerfish
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Archerfish",
                "Archerfish",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The archerfish is quick to retaliate to any confrontation with a precise jet of water.",
                bloodCost: 0,
                bonesCost: 5,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/archerfish.png"),
                abilities: new List<Ability>() { Lurk.ability },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/archerfish_emission.png")
                );
        }
    }
}

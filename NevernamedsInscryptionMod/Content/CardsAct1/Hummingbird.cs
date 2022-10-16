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
    static class Hummingbird
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Hummingbird",
                "Hummingbird",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "Small and fast, it's sharp beak is ideal for a swift first strike.",
                bloodCost: 0,
                bonesCost: 2,
               // energyCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hummingbird.png"),
                abilities: new List<Ability>() { Ability.Sentry },
                tribes: new List<Tribe>() { Tribe.Bird },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hummingbird_emission.png")
                );
        }
    }
}

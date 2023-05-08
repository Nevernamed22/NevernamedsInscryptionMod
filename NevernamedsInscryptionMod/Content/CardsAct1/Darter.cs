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
    static class Darter
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Darter",
                "Darter",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "Mind the splash.",
                bonesCost: 5,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/darter.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/darter_emission.png"),
                abilities: new List<Ability>() { Ability.Flying, CoastGuard.ability },
                tribes: new List<Tribe>() { Tribe.Bird }
                );
        }
    }
}
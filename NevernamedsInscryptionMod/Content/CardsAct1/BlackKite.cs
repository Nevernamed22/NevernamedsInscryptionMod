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
    static class BlackKite
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed BlackKite",
                "Black Kite",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "It carries the flames of a previous inferno to drive prey from cover...",
                bonesCost: 4,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/blackkite.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/blackkite_emission.png"),
                abilities: new List<Ability>() { Ability.Flying, BurningLatch.ability },
                tribes: new List<Tribe>() { Tribe.Bird }
                );
        }
    }
}
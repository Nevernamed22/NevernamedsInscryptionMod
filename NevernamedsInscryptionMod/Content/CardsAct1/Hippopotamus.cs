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
    static class Hippopotamus
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Hippopotamus",
                "Hippopotamus",
                3,
                6,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The fat, looming hippopotamus. Anything nearby is shunted out of the way.",
                bloodCost: 3,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hippopotamus.png"),
                abilities: new List<Ability>() { Ability.StrafePush, Stalwart.ability },
                tribes: new List<Tribe>() { Tribe.Hooved },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hippopotamus_emission.png")
                );
        }
    }
}

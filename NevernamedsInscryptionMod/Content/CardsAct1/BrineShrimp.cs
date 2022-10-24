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
    static class BrineShrimp
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed BrineShrimp",
                "Brine Shrimp",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The tiny, fleeting brine shrimp, so small it's as if it's not even there...",
                bloodCost: 0,
                bonesCost: 3,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/brineshrimp.png"),
                abilities: new List<Ability>() { Immaterial.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Crustacean },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/brineshrimp_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}

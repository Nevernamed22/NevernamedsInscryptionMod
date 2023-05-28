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
    static class WhiteWhale
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed WhiteWhale",
                "White Whale",
                1,
                7,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "...Not Jove did surpass the glorified White Whale as he so divinely swam...",
                bloodCost: 3,
                bonesCost: 0,
                abilities: new List<Ability>() { Ability.TripleBlood, Disembowel.ability, Enraged.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/whitewhale.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/whitewhale_emission.png")
                );
        }
    }
}
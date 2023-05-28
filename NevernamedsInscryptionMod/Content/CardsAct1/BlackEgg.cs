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
    static class BlackEgg
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed BlackEgg",
                "Black Egg",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Rare, },
                CardTemple.Nature,
                description: "Something pulses dimly, below the surface...",
                bloodCost: 0,
                bonesCost: 1,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/blackegg.png"),
                abilities: new List<Ability>() { NatureOfTheBeast.ability },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CardAppearanceBehaviour.Appearance.RareCardBackground},
                tribes: new List<Tribe>() {  }
                );
        }
    }
}

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
    static class MotherMatryoshka
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed DaughterMatryoshka",
                "Daughter Matryoshka",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bonesCost: 3,
                abilities: new List<Ability>() {  },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/daughtermatryoshka_pixel.png")
                );
            CardSetupUtility.NewCard("Nevernamed SisterMatryoshka",
                "Sister Matryoshka",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bonesCost: 6,
                abilities: new List<Ability>() { GraveyardShift.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/sistermatryoshka_pixel.png"),
                defaultFrozenCard: "DeadNevernamed DaughterMatryoshka"
                );
            CardSetupUtility.NewCard("Nevernamed MotherMatryoshka",
                "Mother Matryoshka",
                3,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bonesCost: 9,
                abilities: new List<Ability>() { GraveyardShift.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/mothermatryoshka_pixel.png"),
                defaultFrozenCard: "DeadNevernamed SisterMatryoshka"
                );
        }
    }
}
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
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                abilities: new List<Ability>() {  },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/daughtermatryoshka.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/daughtermatryoshka_emission.png"),
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
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                abilities: new List<Ability>() { GraveyardShift.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/sistermatryoshka.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/sistermatryoshka_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/sistermatryoshka_pixel.png"),
                defaultFrozenCard: "DeadNevernamed DaughterMatryoshka"
                );
            CardSetupUtility.NewCard("Nevernamed MotherMatryoshka",
                "Mother Matryoshka",
                3,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "A haunted little trinket, it contains more than just its own soul inside it.",
                bonesCost: 9,
                abilities: new List<Ability>() { GraveyardShift.ability },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/mothermatryoshka.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/mothermatryoshka_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/mothermatryoshka_pixel.png"),
                defaultFrozenCard: "DeadNevernamed SisterMatryoshka"
                );
        }
    }
}
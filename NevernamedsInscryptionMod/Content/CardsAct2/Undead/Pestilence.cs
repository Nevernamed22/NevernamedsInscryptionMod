using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;
using InscryptionAPI.Card;

namespace NevernamedsInscryptionMod
{
    static class Pestilence
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Pestilence",
                "Pestilence",
                3,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "\"At his back swung the brass quiver filled with poisoned arrows, containing the germs of all diseases.\"",
                bonesCost: 13,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                abilities: new List<Ability>() { Dripping.ability, Ability.DebuffEnemy },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/pestilence.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/pestilence_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/pestilence_pixel.png")
                ).SetExtendedProperty("DrippingLeaveBehind", "DeadNevernamed Boil");
        }
    }
}
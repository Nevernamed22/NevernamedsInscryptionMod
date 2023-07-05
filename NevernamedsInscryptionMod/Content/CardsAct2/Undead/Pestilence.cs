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
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bonesCost: 13,
                abilities: new List<Ability>() { Dripping.ability, Ability.DebuffEnemy },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/pestilence_pixel.png")
                ).SetExtendedProperty("DrippingLeaveBehind", "DeadNevernamed Boil");
        }
    }
}
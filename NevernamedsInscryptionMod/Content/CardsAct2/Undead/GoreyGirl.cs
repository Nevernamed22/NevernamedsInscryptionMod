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
    static class GoreyGirl
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed GoreyGirl",
                "Gorey Girl",
                2,
                4,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 8,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { GutSpewer.ability, ExplodingCorpseCustom.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/goreygirl_pixel.png")
                );
        }
    }
}
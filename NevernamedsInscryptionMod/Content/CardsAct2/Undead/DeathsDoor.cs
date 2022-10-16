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
    static class DeathsDoor
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed DeathsDoor",
                "Death's Door",
                0,
                4,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 5,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { OtherSide.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/deathsdoor_pixel.png")
                );
        }
    }
}
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
    static class Necrophidius
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Necrophidius",
                "Necrophidius",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 4,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.CreateDams },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/necrophidius_pixel.png"),
                overrideDamID: "BeastNevernamed BoneClutter"
                );
        }
    }
}
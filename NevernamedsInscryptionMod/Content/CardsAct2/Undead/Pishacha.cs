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
    static class Pishacha
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Pishacha",
                "Pishacha",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 3,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Carnivore.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/pishacha_pixel.png")
                );
        }
    }
}
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
    static class Speyeral
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Speyeral",
                "Speyeral",
               2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bonesCost: 8,
                abilities: new List<Ability>() { Ability.Tutor, Revolve.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/speyeral_pixel.png")
                );
        }
    }
}
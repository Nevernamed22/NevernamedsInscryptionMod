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
    static class Bloodstopper
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Bloodstopper",
                "Bloodstopper",
               0,
               3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Wizard,
                description: "",
                gemsCost: new List<GemType>() { GemType.Green },
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { BloodMagic.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/bloodstopper_pixel.png")
                );
        }
    }
}
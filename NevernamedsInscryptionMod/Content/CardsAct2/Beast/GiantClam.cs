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
    static class GiantClam
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed GiantClam",
                "Giant Clam",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "",
                bloodCost: 1,
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/giantclam_pixel.png"),
                abilities: new List<Ability>() { Ability.DeathShield, Ability.GainGemBlue },
                tribes: new List<Tribe>() { }
                );
        }
    }
}
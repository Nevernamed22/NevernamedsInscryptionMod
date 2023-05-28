using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NevernamedsSigils;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class GhostTrain
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed GhostTrain",
                "Ghost Train",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 6,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Trampler.ability  },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/ghosttrain_pixel.png"),
                flipPortraitWhenStrafing: true
                );
        }
    }
}
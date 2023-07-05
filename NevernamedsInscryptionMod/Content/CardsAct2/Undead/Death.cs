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
    static class Death
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Death",
                "Death",
                2,
                6,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bonesCost: 13,
                abilities: new List<Ability>() { Ability.Deathtouch, RunningStrike.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/death_pixel.png")
                );
        }
    }
}
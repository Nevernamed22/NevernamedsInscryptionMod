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
    static class War
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed War",
                "War",
                2,
                5,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bonesCost: 13,
                abilities: new List<Ability>() { Ability.GainAttackOnKill, DoubleTap.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/war_pixel.png")
                );
        }
    }
}
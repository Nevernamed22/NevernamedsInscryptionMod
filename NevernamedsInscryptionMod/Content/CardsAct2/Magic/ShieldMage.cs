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
    static class ShieldMage
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed ShieldMage",
                 "Shield Mage",
                 1,
                 1,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { GemType.Orange },
                 abilities: new List<Ability>() { Ability.DeathShield },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/shieldmage_pixel.png")
                 );
        }
    }
}
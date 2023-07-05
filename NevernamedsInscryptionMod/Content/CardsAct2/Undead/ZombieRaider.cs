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
    static class ZombieRaider
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed ZombieRaider",
                "Zombie Raider",
               2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bonesCost: 3,
                abilities: new List<Ability>() { Ability.Loot, Ability.Brittle },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/zombieraider_pixel.png")
                );
        }
    }
}
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
    static class ChickenBones
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed ChickenBones",
                "Chicken Bones",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 2,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.Sharp, Ability.DrawCopyOnDeath },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/chickenbones_pixel.png")
                );
        }
    }
}
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
    static class Jumpscare
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Jumpscare",
                "Jumpscare",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "Boo!",
                bonesCost: 3,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.Reach },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/jumpscare.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/jumpscare_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/jumpscare_pixel.png")
                );
        }
    }
}
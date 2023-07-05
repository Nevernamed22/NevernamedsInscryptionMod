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
    static class TinMan
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed TinMan",
                "Tin Man",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 5, //5
                tribes: new List<Tribe>() { },
                specialAbilities: new List<SpecialTriggeredAbility>() { WizardOfOz.ability },
                abilities: new List<Ability>() { Cleaving.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/tinman_pixel.png")
                );
        }
    }
}
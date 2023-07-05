using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using NevernamedsSigils;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class ViridescentDroid
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed ViridescentDroid",
                "Viridescent Droid",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Part3Random, CardMetaCategory.ChoiceNode, Plugin.P03KayceesWizardRegion, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                energyCost: 2,
                abilities: new List<Ability>() {  },
                specialAbilities: new List<SpecialTriggeredAbility>() { SpecialTriggeredAbility.GreenMage },
                variableStat: SpecialStatIcon.GreenGems,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/viridescentdroid.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/viridescentdroid_pixel.png")
                //decals: new List<Texture>() { Tools.LoadTex("NevernamedsInscryptionMod/Resources/Other/viridescentdroid_decal.png") }
                );
        }
    }
}
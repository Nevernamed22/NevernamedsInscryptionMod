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
    static class ScaleTick
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed ScaleTick",
                "Scale Tick",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The unnerving scale tick. It burrows into other creatures to hide when fatally wounded.",
                bloodCost: 0,
                bonesCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/scaletick.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/scaletick_pixel.png"),
                abilities: new List<Ability>() { Ability.LatchDeathShield },
                tribes: new List<Tribe>() {  NevernamedsTribes.Arachnid },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/scaletick_emission.png")
                );
        }
    }
}
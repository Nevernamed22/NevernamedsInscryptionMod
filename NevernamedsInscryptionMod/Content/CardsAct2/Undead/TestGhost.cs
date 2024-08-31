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
    static class TestGhost
    {
        public static void Init()
        {
            // Add the card
            CardInfo inf = CardSetupUtility.NewCard("Nevernamed TestGhost",
                "Test Ghost",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 0,//7,
                energyCost: 0,
                gemsCost: new List<GemType>() { },
                tribes: new List<Tribe>() {  },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/testsquare.png"),
                abilities: new List<Ability>() {  Ability.Brittle, DataBreach.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/testghost_pixel.png"),
                  appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
            //inf.mods.Add(new CardModificationInfo() { gemify = true });
        }
    }
}
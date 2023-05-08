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
            CardSetupUtility.NewCard("Nevernamed TestGhost",
                "Test Ghost",
                1,
                1,
                new List<CardMetaCategory> {  },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 0,//7,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/testsquare.png"),
                abilities: new List<Ability>() { /*HaunterCustom.ability, Immaterial.ability*/ Gorge.ability, Traitor.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/testghost_pixel.png"),
                  appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> {  }
                );
        }
    }
}
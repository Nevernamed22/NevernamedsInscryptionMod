using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class NightmareFuel
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/nightmarefuel.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed NightmareFuel",
                "Nightmare Fuel",
                0,
                1,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                defaultTex: tex,
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/nightmarefuel_pixel.png"),
                abilities: new List<Ability>() { },
                tribes: new List<Tribe>() {  },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}

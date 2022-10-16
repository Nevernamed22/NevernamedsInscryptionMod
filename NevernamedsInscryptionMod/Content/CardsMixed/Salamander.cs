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
    static class Salamander
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/salamander.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Salamander",
                "Salamander",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, CardMetaCategory.GBCPlayable, CardMetaCategory.GBCPack },
                CardTemple.Nature,
                description: "The firey salamander, it's dancing flames linger long after it's death.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Burning.ability, FireResistant.ability },
                tribes: new List<Tribe>() { Tribe.Reptile },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/salamander_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                pixelTex : Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/salamander_pixel.png")
                );
        }
    }
}

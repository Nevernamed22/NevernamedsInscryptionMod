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
    static class Fennec
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Fennec",
                "Fennec",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The diminutive Fennec Fox. A weak, if agile canine.",
                bonesCost: 2,
                //energyCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/fennec.png"),
                abilities: new List<Ability>() {  },
                tribes: new List<Tribe>() { Tribe.Canine },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/fennec_pixel.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/fennec_emission.png")
                );
        }
    }
}
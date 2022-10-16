using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class BloatedLeech
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bloatedleech.png");
            // Add the card
           CardSetupUtility.NewCard("Nevernamed BloatedLeech",
                "Bloated Leech",
                0,
                3,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "The disquieting leech. It has reached full maturity.",
                bloodCost: 0,
                bonesCost: 4,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.TripleBlood },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bloatedleech_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/bloatedleech_pixel.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}

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
    static class StarnosedMole
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/starnosedmole.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed StarnosedMole",
                "Star-Nosed Mole",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, CardMetaCategory.GBCPlayable, CardMetaCategory.GBCPack },
                CardTemple.Nature,
                description: "The... disquieting star-nosed mole... it slashes blindly at whatever wounds it's sensitive feelers.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.WhackAMole, ReturnStrike.ability },
                tribes: new List<Tribe>() { },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/starnosedmole_pixel.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/starnosedmole_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}

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
    static class Parrot
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/parrot.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Parrot",
                "Parrot",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer,  CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable},
                CardTemple.Nature,
                description: "The playful parrot. It can copy the power of other creatures using it's talent for mimicry.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Mockery.ability, Ability.Flying },
                tribes: new List<Tribe>() { Tribe.Bird },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/parrot_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/parrot_pixel.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }

                );
        }
    }
}

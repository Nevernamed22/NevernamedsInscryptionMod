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
    static class Dingo
    {
        public static void Init()
        {
            // Load the image into a Texture2D object
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/dingo.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed Dingo",
                "Dingo",
                2,
                0,
                new List<CardMetaCategory>{CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, CardMetaCategory.GBCPlayable, CardMetaCategory.GBCPack},
                CardTemple.Nature,
                description: "The wild dingo, scavenging nuisance of the land down under.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/dingo_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/dingo_pixel.png"),
                tribes: new List<Tribe>() { Tribe.Canine },
                specialAbilities: new List<SpecialTriggeredAbility>() { Boned.ability },
                variableStat: Boned.specialStatIcon
                );
        }
    }
}

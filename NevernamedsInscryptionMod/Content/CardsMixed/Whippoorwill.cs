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
    static class Whippoorwill
    {
        public static void Init()
        {
            // metaCategories determine the card pools
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>
            {
                CardMetaCategory.ChoiceNode,
                CardMetaCategory.TraderOffer,
                CardMetaCategory.GBCPlayable,
                CardMetaCategory.GBCPack,
            };


            // Load the image into a Texture2D object
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/whippoorwill.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed Whippoorwill",
                "Whippoorwill",
                1,
                3,
                metaCategories,
                CardTemple.Nature,
                description: "The Whippoorwill, a harbinger of things to come...",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Harbinger.ability, Ability.Flying },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/whippoorwill_emission.png"),
                pixelTex : Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/whippoorwill_pixel.png"),
                tribes: new List<Tribe>() { Tribe.Bird }
                );
        }
    }
}


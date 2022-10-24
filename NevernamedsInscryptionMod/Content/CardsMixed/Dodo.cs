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
    static class Dodo
    {
        public static void Init()
        {
            // metaCategories determine the card pools
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>
            {
                CardMetaCategory.ChoiceNode,
                CardMetaCategory.TraderOffer,
                CardMetaCategory.GBCPack,
                CardMetaCategory.GBCPlayable,
            };



            // Load the image into a Texture2D object
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/dodo.png");

            // Add the card
            CardSetupUtility.NewCard("Dodo",
                "Dodo",
                1,
                2,
                metaCategories,
                CardTemple.Nature,
                description: "The Dodo... it adds teeth directly to the scale, but is not long for this world regardless...",
                bloodCost: 0,
                bonesCost: 4,
                defaultTex: tex,
                abilities: new List<Ability>() { Endangered.ability, ToothPuller.ability },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/dodo_emission.png"),
                pixelTex : Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/dodo_pixel.png"),
                tribes: new List<Tribe>() { Tribe.Bird }
                );
        }
    }
}

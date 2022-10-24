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
    static class Copycat
    {
        public static void Init()
        {
            // metaCategories determine the card pools
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>
            {
                CardMetaCategory.Rare,
                CardMetaCategory.GBCPlayable,
                CardMetaCategory.GBCPack
                //CardMetaCategory.TraderOffer,
            };
            List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance> 
            {
                CardAppearanceBehaviour.Appearance.RareCardBackground,
            };

            

            // Load the image into a Texture2D object
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/copycat.png");

            // Add the card
            CardSetupUtility.NewCard("Copycat",
                "Copycat",
                1,
                2,
                metaCategories,
                CardTemple.Nature,
                description: "The mysterious copycat. When it perishes, it... warps, to mimic it's murderer.",
                bloodCost: 1,
                bonesCost: 0,
                appearanceBehaviour: appearanceBehaviour,
                defaultTex: tex,
                abilities: new List<Ability>() { Copier.ability },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/copycat_emission.png"),
                decals: new List<Texture>() { Plugin.raresignaturetex },
                pixelTex : Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/copycat_pixel.png")
                );
        }
    }
}

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
    static class CursedChild
    {
        public static void Init()
        {
            // metaCategories determine the card pools
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>
            {
                CardMetaCategory.Rare, CardMetaCategory.GBCPlayable, CardMetaCategory.GBCPack
            };

            // Load the image into a Texture2D object
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/cursedchild.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed CursedChild",
                "Cursed Child",
                0,
                5,
                metaCategories,
                CardTemple.Nature,
                description: "That... should not be in my deck...",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/cursedchild_pixel.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/cursedchild_emission.png"),
                tribes: new List<Tribe>() { },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                decals: new List<Texture>() { Plugin.raresignaturetex },
                specialAbilities: new List<SpecialTriggeredAbility>() { SinEater.ability },
                variableStat: SinEater.specialStatIcon
                );
        }
    }
}


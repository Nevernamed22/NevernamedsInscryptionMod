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
    static class Impossibeast
    {
        public static void Init()
        {
            // metaCategories determine the card pools
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>
            {
                CardMetaCategory.Rare,
            };
            List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>
            {
                CardAppearanceBehaviour.Appearance.RareCardBackground,
            };



            // Load the image into a Texture2D object
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/impossibeast.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed_Impossibeast",
                "Impossibeast",
                4,
                1,
                metaCategories,
                CardTemple.Nature,
                description: "I have no words. It is repugnant. Nothing dares to strike it.",
                bloodCost: 3,
                bonesCost: 0,
                appearanceBehaviour: appearanceBehaviour,
                defaultTex: tex,
                abilities: new List<Ability>() { },
                
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/impossibeast_emission.png"),
                decals: new List<Texture>() { Plugin.raresignaturetex },
                tribes: new List<Tribe>() { },
                traits: new List<Trait>() { NevernamedsTraits.InherentRepulsive },
                defaultEvolutionName: "Impractabeast"
                );
        }
    }
}
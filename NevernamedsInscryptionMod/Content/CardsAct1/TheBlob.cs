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
    static class TheBlob
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/theblob.png");
            
            // Add the card
            CardSetupUtility.NewCard("Nevernamed TheBlob",
                "The Blob",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "That terrifying sludge, it never ceases to expand. Beware of the blob.",
                bloodCost: 0,
                bonesCost: 4,
                defaultTex: tex,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/theblob_emission.png"),
                decals: new List<Texture>() { Plugin.raresignaturetex },
                specialAbilities: new List<SpecialTriggeredAbility>() { ContinualEvolution.ability }
                ); 
        }
    }
}

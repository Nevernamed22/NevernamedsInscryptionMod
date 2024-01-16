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
    static class Frid
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/frid.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Frid",
                "Frid",
                1,
                5,
                new List<CardMetaCategory> { CardMetaCategory.Rare, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "The mythical Frid, hidden away inside of it's stony shell. Becomes inert when killed. Never steal it's milk...",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.MadeOfStone, GraveyardShift.ability },
                tribes: new List<Tribe>() {  },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/frid_pixel.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/frid_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground },
                decals: new List<Texture>() { Plugin.raresignaturetex },
                defaultFrozenCard: "Boulder",
                defaultTailCard: "Boulder",
                overrideDamID: "Boulder"
                );
        }
    }
}

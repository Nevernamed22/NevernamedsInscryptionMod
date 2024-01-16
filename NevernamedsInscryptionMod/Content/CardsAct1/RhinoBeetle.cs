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
    static class RhinoBeetle
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/rhinobeetle.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed RhinoBeetle",
                "Rhino Beetle",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, CardMetaCategory.GBCPlayable, CardMetaCategory.GBCPack },
                CardTemple.Nature,
                description: "The proud Rhino Beetle. Pieces of it's exoskeleton break away as it is wounded.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { BoneSpurs.ability },
                tribes: new List<Tribe>() { Tribe.Insect },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/rhinobeetle_pixel.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/rhinobeetle_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}

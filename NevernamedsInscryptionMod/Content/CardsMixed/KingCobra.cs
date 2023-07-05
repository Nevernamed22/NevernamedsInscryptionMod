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
    static class KingCobra
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/kingcobra.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed KingCobra",
                "King Cobra",
                3,
                5,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "Far deadlier than it's common counterpart, the King Cobra inspires allegiance in nearby beasts...",
                bloodCost: 3,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Commander.ability },
                tribes: new List<Tribe>() { Tribe.Reptile },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/kingcobra_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/kingcobra_pixel.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }

                );
        }
    }
}
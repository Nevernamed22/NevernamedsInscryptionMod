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
    static class WildBoar
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/wildboar.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed WildBoar",
                "Wild Boar",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, CardMetaCategory.GBCPlayable, CardMetaCategory.GBCPack },
                CardTemple.Nature,
                description: "The fierce wild boar. When betrayed, it lashes out one final time in impotent rage.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.TripleBlood, SavageRitual.ability },
                tribes: new List<Tribe>() { Tribe.Hooved },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/wildboar_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/wildboar_pixel.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }

                );
        }
    }
}

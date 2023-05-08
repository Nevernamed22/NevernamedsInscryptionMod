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
    static class StarvedRat
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/starvedrat.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed StarvedRat",
                "Starved Rat",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A poor, starving rat. Fights ferociously for any scrap of food, but is pitifully frail.",
                bloodCost: 0,
                bonesCost: 1,
                defaultTex: tex,
                abilities: new List<Ability>() { Frail.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Rodent },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/starvedrat_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/starvedrat_pixel.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}

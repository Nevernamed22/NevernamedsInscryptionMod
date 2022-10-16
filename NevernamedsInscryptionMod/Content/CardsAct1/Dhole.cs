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
    static class Dhole
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/dhole.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Dhole",
                "Dhole",
                3,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The wild Dhole. Though it's hunting techniques are unconventional, they are nonetheless powerful.",
                bloodCost: 0,
                bonesCost: 6,
                defaultTex: tex,
                abilities: new List<Ability>() { CrookedStrikeLeft.ability },
                tribes: new List<Tribe>() { Tribe.Canine },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/dhole_emission.png"),

                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}

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
    static class BrownRecluse
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/brownrecluse.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed BrownRecluse",
                "Brown Recluse",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The unassuming Brown Recluse. It attacks when threatened.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { ReturnStrike.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },

                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/brownrecluse_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}

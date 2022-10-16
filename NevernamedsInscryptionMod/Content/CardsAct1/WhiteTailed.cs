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
    static class WhiteTailed
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/whitetailed.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed WhiteTailed",
                "White-Tailed",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The white-tailed spider. It's bite corrodes it's victim's flesh.",
                bloodCost: 0,
                bonesCost: 5,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.WhackAMole, Caustic.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/whitetailed_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}

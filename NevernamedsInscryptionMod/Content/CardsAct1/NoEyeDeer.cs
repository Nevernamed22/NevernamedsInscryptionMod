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
    static class NoEyeDeer
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/noeyedeer.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed NoEyeDeer",
                "No Eye Deer",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The No Eye Deer... its behaviour is little more than a series of perturbing spasms.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Flighty.ability, UnfocusedStrike.ability },
                tribes: new List<Tribe>() { Tribe.Hooved },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/noeyedeer_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}

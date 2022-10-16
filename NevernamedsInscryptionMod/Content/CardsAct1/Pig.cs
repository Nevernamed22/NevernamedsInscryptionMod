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
    static class Pig
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/pig.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Pig",
                "Pig",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A bloated hog. While it is somewhat useful to any deck, it is the centerpiece of none.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { TriflingSacrifice.ability, Crossbones.ability },
                tribes: new List<Tribe>() { Tribe.Hooved },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/pig_emission.png"),
                traits:new List<Trait>() { Trait.Goat },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}

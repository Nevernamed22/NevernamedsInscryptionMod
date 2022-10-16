using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NevernamedsSigils;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class BobbitWorm
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed BobbitWorm",
                "Bobbit Worm",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, CardMetaCategory.GBCPlayable, CardMetaCategory.GBCPack },
                CardTemple.Nature,
                description: "The terrifying bobbit worm. It leaps from it's aquatic burrow to attack with it's razor sharp jaws.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bobbitworm.png"),
                abilities: new List<Ability>() { Ability.Submerge, Trapjaw.ability },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bobbitworm_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                pixelTex : Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/bobbitworm_pixel.png")
                );
        }
    }
}

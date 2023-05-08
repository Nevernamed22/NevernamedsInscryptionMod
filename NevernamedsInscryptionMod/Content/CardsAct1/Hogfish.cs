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
    static class Hogfish
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Hogfish",
                "Hogfish",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "Beauty is in the eye of the beholder, and the eye beholds not this fish...",
                bonesCost: 3,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hogfish.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hogfish_emission.png"),
                abilities: new List<Ability>() { Ability.Submerge },
                tribes: new List<Tribe>() {  }
                );
        }
    }
}
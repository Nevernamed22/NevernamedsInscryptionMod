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
    static class Theow
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Theow",
                "Theow",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A strange creature. It snarls like a dog, but walks upon cloven hooves.",
                bonesCost: 4,
                //energyCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/theow.png"),
                abilities: new List<Ability>() { Ability.StrafeSwap },
                tribes: new List<Tribe>() {  Tribe.Canine, Tribe.Hooved },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/theow_emission.png")
                );
        }
    }
}
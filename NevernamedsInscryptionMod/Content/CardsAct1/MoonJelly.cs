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
    static class MoonJelly
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed MoonJelly",
                "Moon Jelly",
                0,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "Do not discount it, despite it's size.",
                bloodCost: 0,
                bonesCost: 5,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/moonjelly.png"),
                abilities: new List<Ability>() { Ability.WhackAMole, Gooey.ability },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/moonjelly_emission.png")
                );
        }
    }
}

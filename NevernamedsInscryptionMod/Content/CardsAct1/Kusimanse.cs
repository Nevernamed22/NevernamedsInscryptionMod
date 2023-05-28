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
    static class Kusimanse
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Kusimanse",
                "Kusimanse",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The bumbling kusimanse... easy to send to a fight, but impossible to control.",
                bloodCost: 0,
                bonesCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/kusimanse.png"),
                abilities: new List<Ability>() { UnfocusedStrike.ability },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/kusimanse_emission.png")
                );
        }
    }
}

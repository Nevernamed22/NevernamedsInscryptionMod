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
    static class Gorilla
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Gorilla",
                "Gorilla",
                2,
                6,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The true master of the jungle. It swings with club-like fists, particularly when provoked...",
                bloodCost: 3,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/gorilla.png"),
                abilities: new List<Ability>() { ReturnStrike.ability, UnfocusedStrike.ability },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/gorilla_emission.png")
                );
        }
    }
}

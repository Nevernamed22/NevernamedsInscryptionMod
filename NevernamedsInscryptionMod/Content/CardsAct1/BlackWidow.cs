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
    static class BlackWidow
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed BlackWidow",
                "Black Widow",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The black widow spider. It's infamous bite kills swiftly.",
                bloodCost: 0,
                bonesCost: 5,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/blackwidow.png"),
                abilities: new List<Ability>() { Ability.Deathtouch },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/blackwidow_emission.png")
                );
        }
    }
}

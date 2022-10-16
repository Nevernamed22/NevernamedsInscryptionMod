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
    static class Bowerbird
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Bowerbird",
                "Bowerbird",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The crafty bowerbird, master of manipulating materials around itself.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bowerbird.png"),
                abilities: new List<Ability>() { ArtisticLicense.ability },
                tribes: new List<Tribe>() { Tribe.Bird},
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bowerbird_emission.png")
                );
        }
    }
}

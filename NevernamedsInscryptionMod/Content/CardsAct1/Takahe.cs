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
    static class Takahe
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Takahe",
                "Takahe",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "Always scrounging for a tussle...",
                bonesCost: 4,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/takahe.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/takahe_emission.png"),
                abilities: new List<Ability>() {  },
                tribes: new List<Tribe>() { Tribe.Bird }
                );
        }
    }
}
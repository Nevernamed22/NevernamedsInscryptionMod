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
    static class Antingaw
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Antingaw",
                "Antingaw",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A peculiar mollusk. It gathers sustenance from burrowing into barren rock...",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/antingaw.png"),
                abilities: new List<Ability>() { BloodFromStone.ability },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/antingaw_emission.png")
                );
        }
    }
}

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
    static class Powelliphanta
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Powelliphanta",
                "Powelliphanta",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "The great snail, that oozing devourer. It can permanently taint the board...",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/powelliphanta.png"),
                abilities: new List<Ability>() { Slimeball.ability },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/powelliphanta_emission.png")
                );
        }
    }
}
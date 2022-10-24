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
    static class Hyena
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Hyena",
                "Hyena",
                3,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The cackling Hyena, it hoardes the bones of it's prey along with it...",
                bloodCost: 0,
                bonesCost: 6,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hyena.png"),
                abilities: new List<Ability>() { Ability.CreateDams },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hyena_emission.png"),
                overrideDamID: "BeastNevernamed BoneClutter"
                );
        }
    }
}
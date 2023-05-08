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
    static class Sandhopper
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Sandhopper",
                "Sandhopper",
               1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "Erratic seaside scavengers- perfectly adapted to the harshness of life at the shore.",
                bloodCost: 0,
                bonesCost: 4,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/sandhopper.png"),
                abilities: new List<Ability>() { WaveringStrike.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Crustacean },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/sandhopper_emission.png")
                );
        }
    }
}
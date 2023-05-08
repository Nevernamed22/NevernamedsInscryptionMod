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
    static class MoleCrab
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed MoleCrab",
                "Mole Crab",
                0,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "The stalwart Mole Crab, it draws opponents into it's suffocating burrow.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/molecrab.png"),
                abilities: new List<Ability>() { Ability.WhackAMole, Snare.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Crustacean },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/molecrab_emission.png")
                );
        }
    }
}

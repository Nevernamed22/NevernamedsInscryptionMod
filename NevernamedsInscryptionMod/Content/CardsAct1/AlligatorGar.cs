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
    static class AlligatorGar
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed GarRoe",
                "Gar Roe",
                0,
                1,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "Toxic gar roe, will kill anything that swallows it.",
                bloodCost: 0,
                bonesCost: 3,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/garroe.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/garroe_emission.png"),
                abilities: new List<Ability>() {Caustic.ability, Ability.Evolve },
                tribes: new List<Tribe>() {  },
                defaultEvolutionCard: "BeastNevernamed AlligatorGar"
                );

            CardSetupUtility.NewCard("Nevernamed AlligatorGar",
                "Alligator Gar",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "The ferocious Alligator Gar. It squirts out it's toxic eggs when frightened.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/alligatorgar.png"),
                abilities: new List<Ability>() { Ability.TailOnHit, },
                tribes: new List<Tribe>() {  },
                defaultTailCard: "BeastNevernamed GarRoe",
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/alligatorgar_emission.png")
                );
        }
    }
}

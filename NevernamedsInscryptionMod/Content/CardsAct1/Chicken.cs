using APIPlugin;
using DiskCardGame;
using NevernamedsSigils;
using System;
using System.Collections.Generic;
using System.IO;
using InscryptionAPI.Card;
using System.Text;
using UnityEngine;


namespace NevernamedsInscryptionMod
{
    static class Chicken
    {
        public static void Init()
        {

            CardSetupUtility.NewCard("Nevernamed Chicken",
                "Chicken",
                1,
                4,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A vindictive, nasty little bird.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/chicken.png"),
                abilities: new List<Ability>() { Twister.ability },
                tribes: new List<Tribe>() { Tribe.Bird },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/chicken_emission.png"),
                twisterForm: "BeastNevernamed ChickenSwarm"
                );

         CardInfo swarm =   CardSetupUtility.NewCard("Nevernamed ChickenSwarm",
                "Chicken Swarm",
                1,
                4,
                new List<CardMetaCategory> {  },
                CardTemple.Nature,
                description: "A vindictive, nasty little bird.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/chickenswarm.png"),
                abilities: new List<Ability>() { TransformerCustom.ability, Ability.TriStrike },
                tribes: new List<Tribe>() { Tribe.Bird },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/chickenswarm_emission.png"),
                transformerForm: "BeastNevernamed Chicken"
                );
            swarm.SetExtendedProperty("WaitsForOneTurnOnCustomTransform", "Yes");
        }
    }
}
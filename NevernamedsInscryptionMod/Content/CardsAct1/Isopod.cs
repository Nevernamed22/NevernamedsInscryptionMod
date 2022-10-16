using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Isopod
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/isopod.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Isopod",
                "Isopod",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A weak, yet armored isopod from deep beneath the waves...",
                bloodCost: 0,
                bonesCost: 3,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.DeathShield },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/isopod_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                defaultEvolutionCard: "Nevernamed TitanicIsopod"
                );
        }
    }
}
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
    static class Budgerigar
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Budgerigar",
                "Budgerigar",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A friendly bird of domesticated breed, the Budgerigar will follow your command...",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/budgerigar.png"),
                abilities: new List<Ability>() { TrainedFlier.ability },
                tribes: new List<Tribe>() {  Tribe.Bird },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/budgerigar_emission.png")
                );
        }
    }
}

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
    static class EggSac
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed EggSac",
                "Egg Sac",
                0,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The wriggling silken egg sac. What could be inside?",
                bonesCost: 2,
                //energyCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/eggsac.png"),
                abilities: new List<Ability>() { KinBearer.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/eggsac_emission.png")
                );
        }
    }
}
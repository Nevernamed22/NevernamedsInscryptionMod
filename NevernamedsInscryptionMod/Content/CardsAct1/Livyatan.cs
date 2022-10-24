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
    static class Livyatan
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Livyatan",
                "Livyatan",
                3,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The ancient Livyatan- a monstrous whale whose physical magnitude is only surpassed by the vastness of it's bloodlust...",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/livyatan.png"),
                abilities: new List<Ability>() { Lurk.ability },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/livyatan_emission.png")
                );
        }
    }
}

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
    static class Mongoose
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Mongoose",
                "Mongoose",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The mongoose. Already particularly nasty, it is animated by extreme fury at the sight of it's mortal enemies...",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/mongoose.png"),
                abilities: new List<Ability>() { Snakebite.ability },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/mongoose_emission.png")
                );
        }
    }
}

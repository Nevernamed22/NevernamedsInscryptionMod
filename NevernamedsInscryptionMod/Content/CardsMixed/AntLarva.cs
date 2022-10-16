using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class AntLarva
    {
        public static void Init()
        {
            // metaCategories determine the card pools
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>
            {
                
                CardMetaCategory.ChoiceNode,
                CardMetaCategory.TraderOffer,
                CardMetaCategory.GBCPack,
                CardMetaCategory.GBCPlayable
            };
            List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance> { };

            // Load the image into a Texture2D object
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/antlarva.png");

            // Add the card
           CardSetupUtility.NewCard("Nevernamed AntLarva",
                "Ant Larva",
                0,
                1,
                metaCategories,
                CardTemple.Nature,
                description: "So small... so fragile...",
                bloodCost: 0,
                bonesCost: 2,
                appearanceBehaviour: appearanceBehaviour,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.Evolve },
                tribes: new List<Tribe>() { Tribe.Insect },
                traits: new List<Trait>() { Trait.Ant },
                pixelTex : Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/antlarva_pixel.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/antlarva_emission.png"),
               defaultEvolutionCard: "Ant"
                );
        }
    }
}

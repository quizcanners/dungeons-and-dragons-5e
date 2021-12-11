using QuizCanners.Inspect;
using UnityEngine;

namespace Dungeons_and_Dragons.Tables
{
    [CreateAssetMenu(fileName = FILE_NAME, menuName = SO_CREATE_PATH + SO_MENU_NAME_CONCEPT + FILE_NAME)]
    public class RollTable_CreatureType_Concept : RollTable_ForEnum_Generic<CreatureType>
    {
        public const string FILE_NAME = "Random "+nameof(CreatureType);
    }

    [PEGI_Inspector_Override(typeof(RollTable_CreatureType_Concept))] internal class RollTable_CreatureType_ConceptDrawer : PEGI_Inspector_Override { }
}
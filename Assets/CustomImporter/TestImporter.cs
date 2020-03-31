using UnityEngine;

namespace CustomImporting
{
    /// <summary>
    /// Renames all transforms to be "Test"
    /// </summary>
    [CreateAssetMenu(fileName = "NAME.asset", menuName ="ASG/CustomImporter/TestImporter", order = 0)]
    public class TestImporter : CustomImporter
    {
        public override void OnImport(GameObject g)
        {
            g.name = "Test";
        }
    }
}
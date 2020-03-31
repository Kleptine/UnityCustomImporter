using System.IO;
using UnityEditor;
using UnityEngine;

namespace CustomImporting
{
    /// <summary>Checks to see if we have a custom importer set for the imported model asset, and runs it.</summary>
    internal class CustomImporterProcessor : AssetPostprocessor
    {
        private void OnPostprocessModel(GameObject g)
        {
            var path = assetImporter.assetPath;
            var importerPath = Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path)) + "_Importer.asset";
            Debug.Log("Looking for importer at: " + importerPath);

            var customImporter = AssetDatabase.LoadAssetAtPath<CustomImporter>(importerPath);

            if (customImporter != null) customImporter.OnImport(g);
        }
    }
}
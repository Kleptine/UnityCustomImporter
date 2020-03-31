using UnityEngine;

namespace CustomImporting
{
    /// <summary>
    ///     A list of assets and their associated <see cref="CustomImporter" /> that should run when the asset is
    ///     imported.
    /// </summary>
    public abstract class CustomImporter : ScriptableObject
    {
        public abstract void OnImport(GameObject g);
    }
}
using UnityEngine;

// ScriptableObject est une classe qui permet de cr�er des "data assets"
[CreateAssetMenu(fileName = "ItemData", menuName = "ScriptableObjects/ItemData", order = 1)]
public class ItemData : ScriptableObject
{
    public enum ERarity
    {
        Common,
        Rare,
        Epic,
        Legendary
    }

    // Variables publiques avec leurs valeurs par d�faut
    public int ItemID = -1;
    public float ItemPrice = 0.0f; // Mettre un f � la fin pour les float
    public string ItemName = "Default ItemName"; // Mettre des guillemets pour les chaines de caract�res alias strings
    public bool IsDestroyable = false;
    public ERarity Rarity = ERarity.Common; // ici on utilise l'enum d�fini plus haut pour d�finir la raret� de l'objet par d�faut
    public Vector3 ItemPosition = new Vector3(0.0f, 0.0f, 0.0f); // d�crit la position par defaut l'objet dans la sc�ne (ici au centre du monde)
    public Sprite ItemSprite; // Un sprite 2D pour l'icone de l'objet
    //public Mesh ItemMeshFilter; // Un mesh 3D pour l'objet
}

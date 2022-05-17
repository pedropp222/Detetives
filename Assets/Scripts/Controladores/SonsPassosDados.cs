using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dados", menuName = "ScriptableObjects/Sons Passos Dados", order = 1)]
public class SonsPassosDados : ScriptableObject
{
    [SerializeField]
    List<SomDados> listaDeSons;

    public SomDados GetSomDados(string tag)
    {
        foreach(var s in listaDeSons)
        {
            if (s.tagNome == tag)
            {
                return s;
            }
        }

        return null;
    }
}

[System.Serializable]
public class SomDados
{
    public string tagNome;
    public List<AudioClip> sons;
}
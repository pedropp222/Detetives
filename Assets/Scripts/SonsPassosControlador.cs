using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controladores
{
    /// <summary>
    /// Classe que controla os sons dos passos do jogador.
    /// Utiliza um sistema em que usa a tag da superficie para assim tocar um som aleatorio de uma lista.
    /// Essa lista dos tags e dos sons existe num objeto Scriptable Object do tipo SonsPassosDados.
    /// </summary>
    [RequireComponent(typeof(AudioSource))]
    public class SonsPassosControlador : MonoBehaviour
    {
        
        private AudioSource m_AudioSource;

        private RaycastHit hit;

        [Tooltip("O objeto que contem os dados dos passos nas diferentes superficies")]
        public SonsPassosDados objetoDados;

        private void Start()
        {
            //buscar o audio source que tem obrigatoriamente que existir
            m_AudioSource = GetComponent<AudioSource>();
        }

        public void ReceberPasso()
        {
            //fazer um raycast para baixo para detetar a superficie
            if (Physics.Raycast(transform.position, -transform.up, out hit, 5f))
            {
                //ver se a tag que a superficie em que esta o jogador contem sons
                SomDados s = objetoDados.GetSomDados(hit.collider.tag);
                if (s != null)
                {
                    //tocar um som aleatorio
                    m_AudioSource.PlayOneShot(s.sons[Random.Range(0,s.sons.Count)]);
                }
            }
        }
    }
}

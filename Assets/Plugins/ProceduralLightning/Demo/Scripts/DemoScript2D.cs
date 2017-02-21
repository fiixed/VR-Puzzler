using UnityEngine;
using System.Collections;

namespace DigitalRuby.ThunderAndLightning
{
    public class DemoScript2D : MonoBehaviour
    {
        public GameObject spriteToRotate;

        private void Start()
        {
        }

        private void Update()
        {
            spriteToRotate.transform.Rotate(0.0f, 0.0f, Time.deltaTime * 10.0f);
        }
    }
}
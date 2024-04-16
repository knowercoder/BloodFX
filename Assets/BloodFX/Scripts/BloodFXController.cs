using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is a sample script for controlling the particle effect and the decal on button click, just to demo the effect
namespace KnowerCoder.BloodFX
{
    public class BloodFXController : MonoBehaviour
    {
        [SerializeField] ParticleSystem[] particleSystems;
        [SerializeField] Material DecalMaterial;
        [SerializeField] GameObject DecalObject;

        [SerializeField] float decalSpreadSpeed = 1.0f;

        bool onShoot;
        float darkMaskStartSize = 4;
        float LightMaskStartSize = 4;

        private void Update()
        {
            //Set the material properties when the 'Shoot' button is clicked after 'Reset' button click
            if (onShoot && DecalMaterial.GetFloat("_DarkMaskStartSize") >= 1.5f)
            {
                DecalMaterial.SetFloat("_DarkMaskStartSize", darkMaskStartSize -= (Time.deltaTime * decalSpreadSpeed));
                DecalMaterial.SetFloat("_LightMaskStartSize", LightMaskStartSize -= (Time.deltaTime * decalSpreadSpeed));
            }
        }

        //Trigger te particle systems
        public void Shoot()
        {
            foreach (var particle in particleSystems)
            {
                if(particle != null)
                    particle.Play();
            }

            onShoot = true;

            Invoke("EnableDecal", 0.3f);

        }

        //Reset the Decal parameters and disable it
        public void ShootReset()
        {
            DecalObject.SetActive(false);
            onShoot = false;
            darkMaskStartSize = 4;
            LightMaskStartSize = 4;
            DecalMaterial.SetFloat("_DarkMaskStartSize", darkMaskStartSize);
            DecalMaterial.SetFloat("_LightMaskStartSize", LightMaskStartSize);

        }

        void EnableDecal()
        {
            DecalObject.SetActive(true);
        }


    }
}




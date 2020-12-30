using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using TMPro;



namespace Tests

{

    public class TestSuite
    {
        public TextMeshProUGUI isPaused;
        public Transform playerBody;
        [UnityTest]
        public IEnumerator TestPause()
        {
         

            Input.GetKeyDown(KeyCode.Escape);
            Time.timeScale = 1;

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (Time.timeScale == 0)
                {
                    Time.timeScale = 1;
                    isPaused.enabled = false;
                }
                else
                {
                    Time.timeScale = 0;
                    isPaused.enabled = true;
                }
                Assert.AreEqual(true, isPaused.enabled);
            }
            yield return null;
        }

        [UnityTest]
        public IEnumerator TestMouse()
        {
            float xRotation = 0f;
            float mouseSens = 100f;
            float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;
            xRotation -= 10;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);
            Assert.Greater(0, xRotation);
            yield return null;
        }

        [UnityTest]
        public IEnumerator TestJump() { 

            yield return null;


        }
    }
}

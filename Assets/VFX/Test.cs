using System.Collections;
using System.Collections.Generic;
using Bonjour.Vision;
using UnityEngine;
using UnityEngine.VFX;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update

    public VisualEffect VisualEffect;

    public OpticalFlow OpticalFlow;

    public OFTrailSystemUpdater update;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (VisualEffect != null)
        {


            //if (update.GetOFTrail() != null)
            // VisualEffect.SetTexture("HeadCamTexture", update.GetOFTrail());

            if (OpticalFlow.GetOpticalFlowMap() != null)
                VisualEffect.SetTexture("HeadCamTexture", OpticalFlow.GetOpticalFlowMap());
        }

        //if (VisualEffect != null)
        //{
        //    if (opticalFlow.flowBuffer != null)
        //        VisualEffect.SetTexture("HeadCamTexture", opticalFlow.flowBuffer);
        //}
    }
}

using System.Collections;
using System.Collections.Generic;
using Bonjour.Vision;
using com.rfilkov.kinect;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update

    public VisualEffect VisualEffect;

    public OpticalFlow OpticalFlow;

    public OFTrailSystemUpdater update;

    public RawImage bodyRawImage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (KinectManager.Instance != null && KinectManager.Instance.sensorDatas.Count > 0 && bodyRawImage.texture == null)
        {
            KinectInterop.SensorData sensorData = KinectManager.Instance.sensorDatas[0];
            Vector3 imageScale = sensorData.depthImageScale;
            //RenderTexture imageTex = sensorData.colorImageTexture;
            bodyRawImage.texture = sensorData.colorImageTexture;
            //bodyRawImage.texture = sensorData.bodyImageTexture;


        }

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

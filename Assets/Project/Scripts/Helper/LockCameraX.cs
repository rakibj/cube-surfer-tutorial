using UnityEngine;
using Cinemachine;

namespace Rakib
{
    [ExecuteInEditMode]
    [SaveDuringPlay]
    [AddComponentMenu("")] // Hide in menu
    public class LockCameraX : CinemachineExtension
    {
        [Tooltip("Lock the camera's X position to this value")]
        public float m_XPosition = 0f;

        protected override void PostPipelineStageCallback(
            CinemachineVirtualCameraBase vcam,
            CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
        {
            if (enabled && stage == CinemachineCore.Stage.Body)
            {
                var pos = state.RawPosition;
                pos.x = m_XPosition;
                state.RawPosition = pos;
            }
        }
    }
}
using UnityEngine;

namespace Lycoris
{
    [RequireComponent(typeof(Camera))]
    public abstract class CameraController : MonoBehaviour
    {
        private new Camera _camera;
        private Transform _transform;

        public new Transform transform
        {
            get
            {
                if (_transform == null)
                    _transform = transform;
                return _transform;
            }
        }

        public new Camera camera
        {
            get
            {
                if (_camera == null)
                    _camera = GetComponent<Camera>();
                return _camera;
            }
        }

        public void OnUpdate()
        {

        }
    }
}

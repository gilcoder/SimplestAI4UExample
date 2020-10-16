using UnityEngine;
using ai4u;
public class CubeAgent : Agent {
    private Vector3 translation;
    private float[] mPosition;
    void Start() {
        translation = Vector3.zero;
        mPosition = new float[3];
    }
    public override void ApplyAction() {
        string action = GetActionName();
        if (action == "tx") {
            float tx = GetActionArgAsFloat();
            translation.Set(tx, 0, 0);
        } else if (action == "translation") {
            float[] t = GetActionArgAsFloatArray();
            translation.Set(t[0], t[1], t[2]);
        }
    }
    public override void UpdatePhysics() {
        transform.Translate(translation);
        mPosition[0] = transform.position.x;
        mPosition[1] = transform.position.y;
        mPosition[2] = transform.position.z;
    }
    public override void UpdateState() {
        SetStateAsFloatArray(0, "position", mPosition);
    }
}

using UnityEngine;
using System.Collections;
using VoxelBusters.RuntimeSerialization;

public class CheckPointRSExtension :  ComponentRSExtension {
    #region Constants


   
    private     const       string          kCheckPointIdKey       = "checkPointId";
    private     const       string          kLightOnKey            = "LightOn";
    private     const       string          kLightOffKey           = "LightOff";
    #endregion
    #region Serialization Methods
    public override void WriteSerializationData (object _object, RuntimeSerializationInfo _info){
        CheckPoint   _checkPoint  = _object as CheckPoint;

        if (_checkPoint == null)
            return;

        UIDSystem   _UIDSystem  = _checkPoint.GetComponent<UIDSystem>();

        if (_UIDSystem == null)
        {
            Debug.LogError(string.Format("[RS] UIDSystem not found in GameObject with name {0}. Please add UIDSystem component to serializing object.", _checkPoint.name), _checkPoint);
            return;
        }

        // Serialize base properties
        base.WriteSerializationData(_object, _info);

//        // Serializing properties
        _info.AddValue<int>(kCheckPointIdKey,     _checkPoint.checkPointId);
        _info.AddValue<Sprite>(kLightOnKey,   _checkPoint.LightOn);
        _info.AddValue<Sprite>(kLightOffKey,         _checkPoint.LightOff);

        // Serialize immediate childrens
       
    }

    public override object ReadSerializationData (object _object, RuntimeSerializationInfo _info){
        CheckPoint _checkPoint        = base.ReadSerializationData(_object, _info) as CheckPoint;

        if (_checkPoint == null)
            return null;
        _checkPoint.checkPointId=_info.GetValue<int>(kCheckPointIdKey);
        _checkPoint.LightOn=_info.GetValue<Sprite>(kLightOnKey);
        _checkPoint.LightOff=_info.GetValue<Sprite>(kLightOffKey);
        return _checkPoint;
    }
    #endregion
}
